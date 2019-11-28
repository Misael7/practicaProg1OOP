using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrquestaMúsico
{
 class Persona
  {
   public String nombre;
   public String apellido;
   private int edad;

    public Persona() //Constructor sin parámetros
    {
    }

    public Persona(String nombre, String apellido, int edad) //Constructor con parámetros
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
    }

    public void setEdad(int edad)
    {
      this.edad = edad;
    }
    public int getEdad()
    {
      return this.edad;
    }
    public void cumplirAnios()
    {
      this.edad++;
    }
  }
}
