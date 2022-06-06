using HamsterWars.Shared.Entity;
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


    public async Task<Hamster> CreateNewHamster(Hamster hamster)
    {
        var hamsterJson = new StringContent(JsonSerializer.Serialize(hamster), Encoding.UTF8, "application/json");
        var response = await _http.PostAsync("matches", hamsterJson);
        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<Hamster>(await response.Content.ReadAsStreamAsync());
        }
        return null;
    }

    public async Task DeleteHamster(int id)
    {
        await _http.DeleteAsync($"matches/{id}");
    }

    public async Task<Hamster> GetSingleHamster(int id)
    {
        var result = await _http.GetFromJsonAsync<Hamster>($"matches/{id}");
        if (result != null)
            return result;
        throw new Exception("No hamster found");

    }   
    public async Task<Hamster> GetRandomHamster()
    {
        var result = await _http.GetFromJsonAsync<Hamster>($"matches/random");
        if (result != null)
            return result;
        throw new Exception("No hamster found");
    }

    public async Task GetHamsters()
    {
        var results = await _http.GetFromJsonAsync<List<Hamster>>("matches");
        if (results != null)
        {
            Hamsters = results;
        }
    }

    public async Task UpdateHamster(Hamster hamster)
    {
        var result = await _http.PutAsJsonAsync($"matches/{hamster.Id}", hamster);
        var response = await result.Content.ReadFromJsonAsync<List<Hamster>>();
        Hamsters = response;
        
    }

    public async Task<List<Hamster>> GetTop5Winners()
    {
        var topWinners = await _http.GetFromJsonAsync<List<Hamster>>("matches/winners");
        if(topWinners != null)
        {
            return topWinners;
        }
        return null;
    }

    public async Task<List<Hamster>> GetTop5Losers()
    {
        var topLosers = await _http.GetFromJsonAsync<List<Hamster>>("matches/losers");
        if (topLosers != null)
        {
            return topLosers;
        }
        return null;
    }
}