using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioDiagnostico : IRepositorioDiagnostico
  {

    private readonly AppContext appContext;
    public RepositorioDiagnostico(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public Diagnostico AgregarDiagnostico(Diagnostico diagnostico)
    {
      var diagnosticoAdicionado = this.appContext.Diagnosticos.Add(diagnostico);
      this.appContext.SaveChanges();
      return diagnosticoAdicionado.Entity;
    }
    public Diagnostico EditarDiagnostico(Diagnostico diagnostico)
    {
      return null;
    }
    public void EliminarDiagnostico(int idDiagnostico)
    {
      var diagnosticoEncontrado = this.appContext.Diagnosticos.FirstOrDefault(v => v.Id == idDiagnostico);

      if (diagnosticoEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.Diagnosticos.Remove(diagnosticoEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public Diagnostico GetDiagnostico(int idDiagnostico)
    {
      return this.appContext.Diagnosticos.FirstOrDefault(v => v.Id == idDiagnostico);
    }
    public IEnumerable<Diagnostico> GetDiagnosticos()
    {
      return null;
    }

  }
}