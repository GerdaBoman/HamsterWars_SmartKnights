using HamsterWars.Shared.Models;

namespace HamsterWars.Client.Services.HamsterService;

public interface IHamsterService
{
    List<Hamster> Hamsters { get; set; }
    Task<Hamster> CreateNewHamster(Hamster hamster);
    Task<Hamster> GetHamsterDetails(int id);
    Task UpdateHamster(Hamster hamster);    
    Task DeleteHamster(int id);
    Task GetHamsters();
    Task CreateHamster(Hamster hamster);
     
    
}
