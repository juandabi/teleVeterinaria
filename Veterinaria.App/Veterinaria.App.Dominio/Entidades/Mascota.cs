using System;

namespace Veterinaria.App.Dominio
{
    public class Mascota : Animal{ 
      public int IdMascota {get;set;}
      public String Nombre {get;set;}
      public String Sexo {get;set;}
      public DateTime FechaNacimiento {get;set;}
    }
}