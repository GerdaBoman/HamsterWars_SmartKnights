using HamsterWars.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace HamsterWars.Client.Services.HamsterService;

public class HamsterService : IHamsterService
{
    private readonly HttpClient _http;
    private NavigationManager _navigationManager;

    public HamsterService(HttpClient http, NavigationManager navManager)
    {
        _http = http;
        _navigationManager = navManager;

    }
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();



    public async Task<Hamster> CreateNewHamster(Hamster hamster)
    {
        var hamsterJson = new StringContent(JsonSerializer.Serialize(hamster), Encoding.UTF8, "application/json");
        var response = await _http.PostAsync("api/Hamsters", hamsterJson);
        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<Hamster>(await response.Content.ReadAsStreamAsync());
        }
        return null;
    }

    public async Task DeleteHamster(int id)
    {
        await _http.DeleteAsync($"api/Hamsters/{id}");

    }

    public async Task<Hamster> GetSingleHamster(int id)
    {
        return await _http.GetFromJsonAsync<Hamster>($"api/Hamsters/{id}");

    }   
    public async Task<Hamster> GetRandomHamster()
    {
        return await _http.GetFromJsonAsync<Hamster>($"api/Hamsters/random");

    }

    public async Task<IEnumerable<Hamster>> GetHamsters()
    {
       return await _http.GetFromJsonAsync<Hamster[]>("api/Hamsters");
    }

    public async Task UpdateHamster(Hamster hamster)
    {
        var result = await _http.PutAsJsonAsync($"api/Hamsters/{hamster.Id}", hamster);
        var response = await result.Content.ReadFromJsonAsync<List<Hamster>>();
        Hamsters = response;
        
    }
}