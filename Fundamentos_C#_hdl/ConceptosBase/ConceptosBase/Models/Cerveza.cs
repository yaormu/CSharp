using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosBase.Models
{
    // Hereda atributos y metodos publicos, protegidos de la Clase Bebida
    internal class Cerveza : Bebida
    {
        // Como no construir el constructor con los parametros por defecto
        public Cerveza() : base("Cerveza", 500) // De esta forma se envia al Padre directamente
        {

        }

        // Constructor obliga como minimo implementar el parametro Cantidad
        // Los parametro con valores por defecto va al final, siempre
        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            : base(Nombre, Cantidad)
        {

        }
    }
}
