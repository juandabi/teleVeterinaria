using System;

namespace Veterinaria.App.Dominio
{
    public class PlanVacunas { 
      public int Id {get;set;}
      public int CodigoMascota {get;set;}
      public int TarjetaProfesional {get;set;}
      public DateTime FechaVacunas {get;set;}
      public String VacunasAplicadas {get;set;}

    }
}
