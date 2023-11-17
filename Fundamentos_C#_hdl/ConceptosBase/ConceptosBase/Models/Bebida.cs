using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBase.Models
{
    class Bebida
    {
        // Modificadores
        // public
        // private (solo accedido en la misma clase)
        // protected (clases derivada de estas)
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        // Constructor, no tiene tipo, no regresa tipo
        // Sirve para cuando construye la Clase
        // Que es lo que necesita esa clase, ese objeto para existir
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int cuantoBebio)
        {
            this.Cantidad -= cuantoBebio;
        }
    }
}
