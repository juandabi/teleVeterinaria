using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;
using System;

namespace Veterinaria.App.Persistencia
{
  public class AppContext : DbContext
  {
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Data Sourse = (Localdb)\\MSSQLLocalDB; Initial Catalog =Veterianaria");
      }
    }
  }
}
