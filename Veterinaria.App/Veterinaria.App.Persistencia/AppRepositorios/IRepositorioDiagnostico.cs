using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioDiagnostico
  {
    Diagnostico AgregarDiagnostico(Diagnostico diagnostico);
    Diagnostico EditarDiagnostico(Diagnostico diagnostico);
    void EliminarDiagnostico(int idDiagnostico);
    Diagnostico GetDiagnostico(int idDiagnostico);
    IEnumerable<Diagnostico> GetDiagnosticos();
  }
}