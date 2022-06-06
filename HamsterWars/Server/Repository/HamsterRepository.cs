using DataAccess.Data;
using HamsterWars.Server.Interface;
using HamsterWars.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace HamsterWars.Server.Repository;

public class HamsterRepository : IHamsterRepository
{
    private readonly HamsterWarsContext _context;

    public HamsterRepository(HamsterWarsContext context)
    {
        _context = context;
    }

    public async Task<Hamster> CreateNewHamster(Hamster hamster)
    {
        var result = await _context.Hamster.AddAsync(hamster);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Hamster> DelelteHamster(int id)
    {
        var result = await _context.Hamster
                       .FirstOrDefaultAsync(h=>h.Id == id);

        if (result != null)
        {
            _context.Hamster.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }

        return null;
   
    }

    public async Task<IEnumerable<Hamster>> GetHamsters()
    {
        return await _context.Hamster.ToListAsync();
    }

    public async Task<Hamster> GetRandomHamster()
    {
        Hamster randomHamster = new();
        var random = new Random();
        var avialableHamster = await _context.Hamster.ToListAsync();
        int index = random.Next(avialableHamster.Count);
        randomHamster = avialableHamster[index];

        return randomHamster;
    }

    public async Task<Hamster> GetSingleHamster(int id)
    {
        return await _context.Hamster.FirstAsync(h => h.Id == id);
    }

    public async Task<Hamster> UpdateHamster(Hamster hamster)
    {
        var result = await _context.Hamster
            .FirstOrDefaultAsync(h => h.Id == hamster.Id);

        if(result != null)
        {
            result.Name = hamster.Name;
            result.Age = hamster.Age;
            result.FavFood = hamster.FavFood;
            result.Loves = hamster.Loves;
            result.ImgName = hamster.ImgName;
            result.Wins = hamster.Wins;
            result.Losses = hamster.Losses;
            result.Games = hamster.Games;

            await _context.SaveChangesAsync();
            return result;
        }
        return null;
    }

    public async Task<IEnumerable<Hamster>> GetTop5Losers()
    {
        var hamsterList = await _context.Hamster.ToListAsync();
        var losers = hamsterList.OrderByDescending(h => h.Losses)
                                               .Take(5).ToList();
        return losers;
    }

   
    public async Task<IEnumerable<Hamster>> GetTop5Winners()
    {
        var hamsterList = await _context.Hamster.ToListAsync();
        var winners = hamsterList.OrderByDescending(h => h.Wins)
                                               .Take(5).ToList();
        return winners;
    }
}

