using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioPlanVacunas
  {
    PlanVacunas AgregarPlanVacunas(PlanVacunas planVacunas);
    PlanVacunas EditarPlanVacunas(PlanVacunas planVacunas);
    void EliminarPlanVacunas(int idPlanVacunas);
    PlanVacunas GetPlanVacunas(int idPlanVacunas);
    IEnumerable<PlanVacunas> GetPlanesVacunas();
  }
}