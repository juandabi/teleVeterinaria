using System;

namespace Veterinaria.App.Dominio
{
    public class Diagnostico { 
      public int CodigoDiagnostico {get;set;}
      public int CodigoMascota {get;set;}
      public int TarjetaProfesional {get;set;}
      public DateTime FechaDiagnostico {get;set;}
      public String EstadoSalud {get;set;}
      public String DiagnosticoActual {get;set;}
      public String Cuidados {get;set;}

    }
}
