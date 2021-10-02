using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioCita : IRepositorioCita
  {

    private readonly AppContext appContext;
    public RepositorioCita(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Cita AgregarCita(Cita cita)
    {
      var citaAdicionado = this.appContext.Citas.Add(cita);
      this.appContext.SaveChanges();
      return citaAdicionado.Entity;
    }
    public Cita EditarCita(Cita cita)
    {
      return null;
    }
    public void EliminarCita(int idCita)
    {
      var citaEncontrado = this.appContext.Citas.FirstOrDefault(v => v.Id == idCita);

      if (citaEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Citas.Remove(citaEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Cita GetCita(int idCita)
    {
      return this.appContext.Citas.FirstOrDefault(v => v.Id == idCita);
    }
    public IEnumerable<Cita> GetCitas()
    {
      return null;
    }

  }
}