using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioAdministrador : IRepositorioAdministrador
  {

    private readonly AppContext appContext;
    public RepositorioAdministrador(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Administrador AgregarAdministrador(Administrador administrador)
    {
      var administradorAdicionado = this.appContext.Administradores.Add(administrador);
      this.appContext.SaveChanges();
      return administradorAdicionado.Entity;
    }
    public Administrador EditarAdministrador(Administrador administrador)
    {
      return null;
    }
    public void EliminarAdministrador(int idAdministrador)
    {
      var administradorEncontrado = this.appContext.Administradores.FirstOrDefault(v => v.Id == idAdministrador);

      if (administradorEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Administradores.Remove(administradorEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Administrador GetAdministrador(int idAdministrador)
    {
      return this.appContext.Administradores.FirstOrDefault(v => v.Id == idAdministrador);
    }
    public IEnumerable<Administrador> GetAdministradores()
    {
      return null;
    }

  }
}