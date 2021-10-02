using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioAdministrador
  {
    Administrador AgregarAdministrador(Administrador administrador);
    Administrador EditarAdministrador(Administrador administrador);
    void EliminarAdministrador(int idAdministrador);
    Administrador GetAdministrador(int idAdministrador);
    IEnumerable<Administrador> GetAdministradores();
  }
}