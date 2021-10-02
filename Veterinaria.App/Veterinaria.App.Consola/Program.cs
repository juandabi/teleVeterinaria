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
      //AgregarVeterinario();
      //eliminarVeterinario(3);
      //getVeterinario(3);
      //EditarVeterinario(2);
    }
    private static void EditarVeterinario(int IdVeterinario)
    {
      Veterinario veterinario = new Veterinario
      {
        Id = IdVeterinario,
        Nombre = "Carlos",
        Apellido = "Cardona",
        Telefono = "43423",
        DireccionResidencia = "calle 40 carrera 30",
        CorreoElectronico = "nolose@gmail.com",
        Sexo = "Masculino",
        FechaNacimiento = new DateTime(1993, 10, 13),
        FechaRegistro = new DateTime(2021, 09, 26),
        TarjetaProfesional = 12321,
        Especializacion = "Felinos",
        Password = "3432nuf43",

      };
      repositorioVeterinario.EditarVeterinario(veterinario);

    }
    private static void EliminarVeterinario(int idVeterinario)
    {
      repositorioVeterinario.EliminarVeterinario(idVeterinario);

    }
  }
}
