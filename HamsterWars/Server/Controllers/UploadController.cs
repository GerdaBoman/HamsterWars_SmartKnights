using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using HamsterWars.Shared.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamsterWars.Server.Controllers
{
    [Route("upload")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _azureConnectionString;

        public UploadController (IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _azureConnectionString = configuration.GetConnectionString("AzureConnectionString");
        }

        [HttpPost]
        public async Task Post([FromBody] ImageFile[] files)
        {
            foreach( var file in files)
            {
                var buf = Convert.FromBase64String(file.base64data);
                await System.IO.File.WriteAllBytesAsync(_webHostEnvironment.ContentRootPath.Replace("\\Server", "\\Client\\wwwroot\\images\\hamsterImg") +  $@"\{ file.FileName}", buf);
            }
        }

        [HttpPost("azure")]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                if (file.Length > 0)
                {
                    var container = new BlobContainerClient(_azureConnectionString, "upload-container");
                    var createResponse = await container.CreateIfNotExistsAsync();
                    if (createResponse != null && createResponse.GetRawResponse().Status == 201)
                        await container.SetAccessPolicyAsync(Azure.Storage.Blobs.Models.PublicAccessType.Blob);
                    var blob = container.GetBlobClient(file.FileName);
                    await blob.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);
                    using (var fileStream = file.OpenReadStream())
                    {
                        await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = file.ContentType });
                    }
                    return Ok(blob.Uri.ToString());
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


    }
}
