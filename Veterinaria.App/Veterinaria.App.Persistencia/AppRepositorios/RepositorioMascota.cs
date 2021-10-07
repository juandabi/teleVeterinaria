using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioMascota : IRepositorioMascota
  {

    private readonly AppContext appContext;
    public RepositorioMascota(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Mascota AgregarMascota(Mascota mascota)
    {
      var mascotaAdicionado = this.appContext.Mascotas.Add(mascota);
      this.appContext.SaveChanges();
      return mascotaAdicionado.Entity;
    }
    public Mascota EditarMascota(Mascota mascotaNuevo)
    {

      var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault(v => v.Id == mascotaNuevo.Id);
      if (mascotaEncontrado != null)
      {
        mascotaEncontrado.Especie = mascotaNuevo.Especie;
        mascotaEncontrado.Raza = mascotaNuevo.Raza;
        mascotaEncontrado.Sexo = mascotaNuevo.Sexo;
        mascotaEncontrado.Nombre = mascotaNuevo.Nombre;
        mascotaEncontrado.FechaNacimiento = mascotaNuevo.FechaNacimiento;
        this.appContext.SaveChanges();
      }
      return mascotaNuevo;
    }
    public void EliminarMascota(int idMascota)
    {
      var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault(v => v.Id == idMascota);

      if (mascotaEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Mascotas.Remove(mascotaEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Mascota GetMascota(int idMascota)
    {
      return this.appContext.Mascotas.FirstOrDefault(v => v.Id == idMascota);
    }
    public IEnumerable<Mascota> GetMascotas()
    {
      return null;
    }

  }
}