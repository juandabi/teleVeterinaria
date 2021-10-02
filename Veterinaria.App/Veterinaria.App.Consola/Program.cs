using System;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Consola
{
  class Program
  {
    private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      AgregarVeterinario();
    }
    private static void AgregarVeterinario() {
        Veterinario veterinario = new Veterinario{
            Nombre = "Juan",
            Apellido ="Cardona",
            Telefono = "323232",
            DireccionResidencia ="calle 40 carrera 30",
            CorreoElectronico = "juan@gmail.com",
            Sexo ="Masculino",
            FechaNacimiento = new DateTime (1993, 10 , 13),
            FechaRegistro = new DateTime (2021, 09 , 26),
            TarjetaProfesional = 12321,
            Especializacion = "Felinos",
            Password ="contrasena",

        };
        repositorioVeterinario.AgregarVeterinario(veterinario);

     }
  }
}
