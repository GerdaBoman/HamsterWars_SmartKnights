using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using HamsterWars.Shared.Entity;

namespace HamsterWars.Client.Pages;

public partial class HamsterForm
{
    Hamster hamster = new();

    List<ImageFile> image = new List<ImageFile>();

    bool success = false;
    bool failure = true;

    async Task HandleValidSubmit()
    {
        success = true;
        failure = false;
        await Upload();
        await HamsterService.CreateNewHamster(hamster);
    }

    async Task HandleInvalidSubmit()
    {
        failure = true;
        success = false;


    }

  

    async Task OnChange(InputFileChangeEventArgs e)
    {
        var file = e.File; 
        var resizedFile = await file.RequestImageFileAsync(file.ContentType, 640, 480);
        var buf = new byte[resizedFile.Size]; 

        using (var stream = resizedFile.OpenReadStream())
        {
            await stream.ReadAsync(buf); 
        }

        image.Add(new ImageFile{base64data = Convert.ToBase64String(buf), contentType = file.ContentType, FileName = file.Name}); 
        hamster.ImgName = file.Name;
    }

    async Task Upload()
    {
        await http.PostAsJsonAsync<List<ImageFile>>("/api/upload", image, System.Threading.CancellationToken.None);
    }
}