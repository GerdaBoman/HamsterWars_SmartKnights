using Microsoft.AspNetCore.Components;

namespace HamsterWars.Client.Pages;

public partial class Gallery
{
    protected override async Task OnInitializedAsync()
    {
        await hamsterService.GetHamsters();
    }

    void CreateHamster()
    {
        navigationManager.NavigateTo($"hamster");
    }

    protected async Task DeleteHamster(int id)
    {
        await DeleteImage(id);
        await hamsterService.DeleteHamster(id);
        await hamsterService.GetHamsters();
    }

    async Task DeleteImage(int id)
    {
        var hamster = await hamsterService.GetSingleHamster(id);
        string imgName = hamster.ImgName.ToString();
        string filePath = "~\\Client\\wwwroot\\images\\hamsterImg\\" + imgName;
        FileInfo file = new(filePath);
        if (file.Exists)
        {
            file.Delete();
        }
    }
}