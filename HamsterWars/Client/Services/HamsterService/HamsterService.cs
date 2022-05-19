using HamsterWars.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace HamsterWars.Client.Services.HamsterService;

public class HamsterService : IHamsterService
{
    private readonly HttpClient _http;
    private readonly NavigationManager _navigationManager;

    public HamsterService(HttpClient http, NavigationManager navigationManager)
    {
        _http = http;
        _navigationManager = navigationManager;
    }
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public Task CreateHamster(Hamster hamster)
    {
        throw new NotImplementedException();
    }

    public Task DeleteHamster(int id)
    {
        throw new NotImplementedException();
    }

    public async Task GetHamsters()
    {
        var results = await _http.GetFromJsonAsync<List<Hamster>>("api/Hamsters");
        if(results!= null)
        {
            Hamsters = results;
        }
    }
}
