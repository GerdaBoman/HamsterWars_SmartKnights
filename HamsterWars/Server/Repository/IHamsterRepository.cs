using HamsterWars.Shared.Models;

namespace HamsterWars.Server.Repository;

public interface IHamsterRepository
{
    Task<IEnumerable<Hamster>> GetHamsters();
    Task<Hamster> GetSingleHamster(int id);
    Task<Hamster> CreateNewHamster(Hamster hamster);
    Task<Hamster> UpdateHamster(Hamster hamster);
    Task<Hamster> GetRandomHamster();
    Task<Hamster> DelelteHamster(int id);
}
