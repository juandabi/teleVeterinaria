using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioVeterinario : IRepositorioVeterinario
  {

    private readonly AppContext appContext;
    public RepositorioVeterinario(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Veterinario AgregarVeterinario(Veterinario veterinario)
    {
      var veterinarioAdicionado = this.appContext.Veterinarios.Add(veterinario);
      this.appContext.SaveChanges();
      return veterinarioAdicionado.Entity;
    }
    public Veterinario EditarVeterinario(Veterinario veterinario)
    {
      return null;
    }
    public void EliminarVeterinario(int idVeterinario)
    {
      var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

      if (veterinarioEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Veterinarios.Remove(veterinarioEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Veterinario GetVeterinario(int idVeterinario)
    {
      return this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
    }
    public IEnumerable<Veterinario> GetVeterinarios()
    {
      return null;
    }

  }
}