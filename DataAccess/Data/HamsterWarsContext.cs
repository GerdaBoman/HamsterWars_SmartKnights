
using Microsoft.EntityFrameworkCore;
using HamsterWars.Shared.Models;

namespace DataAccess.Data
{
    public class HamsterWarsContext : DbContext
    {
        public HamsterWarsContext(DbContextOptions<HamsterWarsContext> options)
            : base(options)
        {
        }

        public DbSet<Hamster>? Hamster { get; set; }


    }
}
