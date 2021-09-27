using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioVeterinario
  {
    Veterinario AgregarVeterinario(Veterinario veterinario);
    Veterinario EditarVeterinario(Veterinario veterinario);
    void EliminarVeterinario(int idVeterinario);
    Veterinario GetVeterinario(int idVeterinario);
    IEnumerable<Veterinario> GetVeterinarios();
  }
}