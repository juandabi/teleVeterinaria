using System;

namespace Veterinaria.App.Dominio
{
  public class Veterinario : Persona
  {
    public int TarjetaProfesional { get; set; }
    public String Especializacion { get; set; }
  }
}