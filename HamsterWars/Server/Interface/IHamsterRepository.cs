using HamsterWars.Shared.Entity;

namespace HamsterWars.Server.Interface;

public interface IHamsterRepository
{
    Task<IEnumerable<Hamster>> GetHamsters();
    Task<IEnumerable<Hamster>> GetTop5Winners(); 
    Task<IEnumerable<Hamster>> GetTop5Losers();
    Task<Hamster> GetSingleHamster(int id);
    Task<Hamster> CreateNewHamster(Hamster hamster);
    Task<Hamster> UpdateHamster(Hamster hamster);
    Task<Hamster> GetRandomHamster();
    Task<Hamster> DelelteHamster(int id);
}
