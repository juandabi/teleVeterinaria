using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioMascota
  {
    Mascota AgregarMascota(Mascota mascota);
    Mascota EditarMascota(Mascota mascota);
    void EliminarMascota(int idMascota);
    Mascota GetMascota(int idMascota);
    IEnumerable<Mascota> GetMascotas();
  }
}