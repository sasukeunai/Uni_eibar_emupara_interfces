using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Emuparadise.Models;

namespace Emuparadise.Data
{
    public class EmuparadiseDbContext : IdentityDbContext<ApplicationUser>
    {
        public EmuparadiseDbContext(DbContextOptions<EmuparadiseDbContext> options)
            : base(options)
        {
        }
        public DbSet<Consola> Consola
        {
            get; set;
        }
        public DbSet<CE> CE
        {
            get; set;
        }
        public DbSet<Emulador> Emualador
        {
            get; set;
        }
        public DbSet<Plataforma> Plataforma
        {
            get; set;
        }
        public DbSet<Videojuego> Videojuego
        {
            get; set;
        }
      

    }
}
