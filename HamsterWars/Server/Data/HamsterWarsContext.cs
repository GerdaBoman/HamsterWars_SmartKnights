using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HamsterWars.Shared.Models;

namespace HamsterWars.Server.Data
{
    public class HamsterWarsContext : DbContext
    {
        public HamsterWarsContext(DbContextOptions<HamsterWarsContext> options)
            : base(options)
        {
        }

        public DbSet<Hamster>? Hamster { get; set; }

        public DbSet<History>? History { get; set; }
    }
}
