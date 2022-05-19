using HamsterWars.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace HamsterWars.Client.Services.HamsterService;

public class HamsterService : IHamsterService
{
    private readonly HttpClient _http;
   
    public HamsterService(HttpClient http)
    {
        _http = http;
       
    }
    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public Task CreateHamster(Hamster hamster)
    {
        throw new NotImplementedException();
    }

    public async Task<Hamster> CreateNewHamster(Hamster hamster)
    {
        var hamsterJson = new StringContent(JsonSerializer.Serialize(hamster), Encoding.UTF8, "application/json");
        var response = await _http.PostAsync( "api/Hamsters", hamsterJson);
        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<Hamster>(await response.Content.ReadAsStreamAsync());
        }
        return null;
    }

    public async Task DeleteHamster(int id)
    {
            await _http.DeleteAsync( $"api/Hamsters/{id}");
        
    }


    public async Task GetHamsters()
    {
        var results = await _http.GetFromJsonAsync<List<Hamster>>("api/Hamsters");
        if(results!= null)
        {
            Hamsters = results;
        }
    }

    public Task UpdateHamster(Hamster hamster)
    {
        throw new NotImplementedException();
    }
}
