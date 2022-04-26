using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Empleado
    {
        public string Nombre { get; set;}
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Empleado(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public void ShowName()
        {
            Console.WriteLine("");
        }
    }
}
