using System;

namespace Veterinaria.App.Dominio
{
    public class Cita { 
      public int Id {get;set;}
      public int TarjetaProfesional {get;set;}
      public int Identificacion {get;set;}
      public int CodigoMascota {get;set;}
      public DateTime FechaSolicitud {get;set;}
      public DateTime FechaAsignacion {get;set;}

    }
}
