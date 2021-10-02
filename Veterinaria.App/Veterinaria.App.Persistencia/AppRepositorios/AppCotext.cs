using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;
using System;

namespace Veterinaria.App.Persistencia
{
  public class AppContext : DbContext
  {
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    public DbSet<Administrador> Administradores { get; set; }
    public DbSet<Cuidador> Cuidadores { get; set; }
    public DbSet<Diagnostico> Diagnosticos { get; set; }
    public DbSet<Animal> Animales { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<PlanVacunas> PlanesVacunas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("data source = (Localdb)\\MSSQLLocalDB; Initial Catalog = Veterianaria");
      }
    }
  }
}
