using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquestas
{
  class Orquesta
  {
    String nombre;
    String lugar;
    String tipo;
    
    public Orquesta()
    {

    }
    public Orquesta(String nombre, String lugar, String tipo)
    {
      this.nombre=nombre;
      this.lugar=lugar;
      this.tipo=tipo;
     
    }
    public void setNombre(String nombre)
    {
      this.nombre = nombre;
    }
    public void setLugar(String lugar)
    {
      this.lugar = lugar;
    }
    public void setTipo(String tipo)
    {
      this.tipo = tipo;
    }

    public String getNombre()
    {
      return this.nombre;
    }
    public String getLugar()
    {
      return this.lugar;
    }
    public String getTipo()
    {
      return this.tipo;
    }
  }
  
}
