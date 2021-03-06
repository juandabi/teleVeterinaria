using System;

namespace Veterinaria.App.Dominio
{
  public class Persona
  {
    public int Id { get; set; }
    public String Nombre { get; set; }
    public String Apellido { get; set; }
    public String Telefono { get; set; }
    public String DireccionResidencia { get; set; }
    public String CorreoElectronico { get; set; }
    public String Sexo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public DateTime FechaRegistro { get; set; }
    public String Password { get; set; }

  }
}
