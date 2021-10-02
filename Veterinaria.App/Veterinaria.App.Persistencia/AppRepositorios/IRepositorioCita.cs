using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
  public interface IRepositorioCita
  {
    Cita AgregarCita(Cita cita);
    Cita EditarCita(Cita cita);
    void EliminarCita(int idCita);
    Cita GetCita(int idCita);
    IEnumerable<Cita> GetCitas();
  }
}