using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Emuparadise.Models
{
    public partial class EmuparadiseContext : DbContext
    {
        public virtual DbSet<CE> CE { get; set; }
        public virtual DbSet<Consola> Consola { get; set; }
        public virtual DbSet<Emulador> Emulador { get; set; }
        public virtual DbSet<Plataforma> Plataforma { get; set; }
        public virtual DbSet<Videojuego> Videojuego { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Emuparadise;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CE>(entity =>
            {
                entity.HasKey(e => new { e.IdConsola, e.IdEmulador })
                    .HasName("PK_C_E");

                entity.ToTable("C_E");

                entity.Property(e => e.IdConsola).HasColumnName("Id_Consola");

                entity.Property(e => e.IdEmulador).HasColumnName("Id_Emulador");

                entity.HasOne(d => d.IdConsolaNavigation)
                    .WithMany(p => p.CE)
                    .HasForeignKey(d => d.IdConsola)
                    .HasConstraintName("FK_C_E_Consola");

                entity.HasOne(d => d.IdEmuladorNavigation)
                    .WithMany(p => p.CE)
                    .HasForeignKey(d => d.IdEmulador)
                    .HasConstraintName("FK_C_E_Emulador");
            });

            modelBuilder.Entity<Consola>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.PlataformaId).HasColumnName("Plataforma_id");

                entity.HasOne(d => d.Plataforma)
                    .WithMany(p => p.Consola)
                    .HasForeignKey(d => d.PlataformaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Consola_Plataforma");
            });

            modelBuilder.Entity<Emulador>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasColumnType("nchar(10)");

                entity.Property(e => e.Plataforma).HasMaxLength(50);
            });

            modelBuilder.Entity<Plataforma>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<Videojuego>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Genero).HasMaxLength(50);

                entity.Property(e => e.IdConsola).HasColumnName("Id_Consola");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.HasOne(d => d.IdConsolaNavigation)
                    .WithMany(p => p.Videojuego)
                    .HasForeignKey(d => d.IdConsola)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Videojuego_Consola");
            });
        }
    }
}