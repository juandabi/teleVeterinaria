using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioCuidador : IRepositorioCuidador
  {

    private readonly AppContext appContext;
    public RepositorioCuidador(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Cuidador AgregarCuidador(Cuidador cuidador)
    {
      var cuidadorAdicionado = this.appContext.Cuidadores.Add(cuidador);
      this.appContext.SaveChanges();
      return cuidadorAdicionado.Entity;
    }
    public Cuidador EditarCuidador(Cuidador cuidador)
    {
      return null;
    }
    public void EliminarCuidador(int idCuidador)
    {
      var cuidadorEncontrado = this.appContext.Cuidadores.FirstOrDefault(v => v.Id == idCuidador);

      if (cuidadorEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Cuidadores.Remove(cuidadorEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Cuidador GetCuidador(int idCuidador)
    {
      return this.appContext.Cuidadores.FirstOrDefault(v => v.Id == idCuidador);
    }
    public IEnumerable<Cuidador> GetCuidadores()
    {
      return null;
    }

  }
}