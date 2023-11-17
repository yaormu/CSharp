using System;
using System.ComponentModel;
using ConceptosBase.Models;

namespace ConceptosBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 tipos de datos para números enteros
            byte numero = 255; // 0 a 255
            sbyte numero2 = -128; // -128 a 127, nemesis que permite tener números negativos

            int numeroInt = 0; // # - & + 
            uint numeroInt2 = 3321470000; // solo positivos

            long numeroInt3 = -20; // # - & +
            ulong numeroInt4 = 20; // # + 

            // Esto tanto para los números enteros
            // byte
            // short
            // int
            // long

            // Tipos de datos flotantes, que permiten decimal
            float numeroF = 189.1f; // 4 bytes
            double numeroDou = 189.9d; // 8 bytes
            decimal numeroDec = 190.4m; // 16 bytes

            // Cadena de caracter
            char caracter = 'A';

            // Dato cadenas compuesta
            string cadena = "Varios datos";

            // Dato booleano
            bool siOno = false;

            // Clase objeto
            DateTime date = DateTime.Now; // fecha actual

            Console.WriteLine(date);

            // C# los elementos nativos, tienen datos por defecto
            int num = new int(); // 0

            // Deseamos que no tenga ningun valor por defecto, debemos usar ?
            int? num2 = null;
            float? num3 = null;
            char? caract = null;

            Console.WriteLine(num.ToString());

            // var uso asignación tipo de dato por el C#
            // var no puede ser un atributo, pero si permitido en metodo local
            // solo funciona dentro de local osea dentro de los métodos
            var nombre = "Leon";

            // Object base de todos los elementos de C#
            // Creación objeto anonimo, sin necesidad de una clase
            /*object*/
            var persona = new { nombre = "apolo", apellido = "lozada", edad = 50 }; // object con valor anonimo

            Console.WriteLine(persona.apellido);

            // Uso de clase, cuando no tenia parametro
            //Bebida cerveza = new Bebida();
            //cerveza.Nombre = "Aguila";

            // Clase al tener parametro
            Bebida gaseosa = new Bebida("Coca Cola", 1000);
            gaseosa.Beberse(500);
            Console.WriteLine(gaseosa.Cantidad);

            // Clase heredada
            Cerveza clubColombia = new Cerveza();
            clubColombia.Beberse(10);
            Console.WriteLine(clubColombia.Cantidad.ToString());
        }
        //var hola; //No permitido
    }
}