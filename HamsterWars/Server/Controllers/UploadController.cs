using HamsterWars.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        public UploadController (IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpPost]
        public async Task Post([FromBody] ImageFile[] files)
        {
            foreach( var file in files)
            {
                var buf = Convert.FromBase64String(file.base64data);
                await System.IO.File.WriteAllBytesAsync(_webHostEnvironment.ContentRootPath.Replace("\\Server", "\\Client\\wwwroot") + "images" + $@"\{ file.FileName}", buf);
            }
        }


    }
}
