using HamsterWars.Shared.Models;

namespace HamsterWars.Client.Services.HamsterService;

public interface IHamsterService
{
    List<Hamster> Hamsters { get; set; }

    Task GetHamsters();
    Task CreateHamster(Hamster hamster);
    Task DeleteHamster(int id); 
    
}
