
using Microsoft.EntityFrameworkCore;
using HamsterWars.Shared.Entity;

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
