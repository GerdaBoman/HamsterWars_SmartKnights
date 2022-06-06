using HamsterWars.Shared.Entity;

namespace HamsterWars.Client.Services.HamsterService;

public interface IHamsterService
{
    List<Hamster> Hamsters { get; set; }
    Task<List<Hamster>> GetTop5Winners();
    Task<List<Hamster>> GetTop5Losers();
    Task<Hamster> CreateNewHamster(Hamster hamster);
    Task UpdateHamster(Hamster hamster);
    Task DeleteHamster(int id);
    Task<Hamster> GetSingleHamster(int id); 
    Task<Hamster> GetRandomHamster();
    Task GetHamsters();




}
