using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{

  public class RepositorioPlanVacunas : IRepositorioPlanVacunas
  {

    private readonly AppContext appContext;
    public RepositorioPlanVacunas(AppContext appContextParam)
    {
      this.appContext = appContextParam;
    }

    public PlanVacunas AgregarPlanVacunas(PlanVacunas planVacunas)
    {
      var planVacunasAdicionado = this.appContext.PlanesVacunas.Add(planVacunas);
      this.appContext.SaveChanges();
      return planVacunasAdicionado.Entity;
    }
    public PlanVacunas EditarPlanVacunas(PlanVacunas planVacunas)
    {
      return null;
    }
    public void EliminarPlanVacunas(int idPlanVacunas)
    {
      var planVacunasEncontrado = this.appContext.PlanesVacunas.FirstOrDefault(v => v.Id == idPlanVacunas);

      if (planVacunasEncontrado == null)
      {
        return;

      }
      else
      {
        this.appContext.PlanesVacunas.Remove(planVacunasEncontrado);
        this.appContext.SaveChanges();
      }
    }
    public PlanVacunas GetPlanVacunas(int idPlanVacunas)
    {
      return this.appContext.PlanesVacunas.FirstOrDefault(v => v.Id == idPlanVacunas);
    }
    public IEnumerable<PlanVacunas> GetPlanesVacunas()
    {
      return null;
    }

  }
}