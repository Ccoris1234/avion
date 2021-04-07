using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class mesajcontext : DbContext
    {
        public mesajcontext(DbContextOptions<mesajcontext> options) 
            : base (options) 
        {
        }
        public DbSet<avion> hotels { get; set; }

        public DbSet<mesaj> mesaje { get; set; }

        public DbSet<rezervare> rezervari { get; set; }

        public DbSet<cariera> cariera { get; set; }

        public DbSet<beneficii> beneficiis { get; set; }

        public DbSet<job> joburi { get; set; }

    }
}
