using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /* 
        EJERCICIO   
        1. Agregar validaciones para que no nos deje ingresar una edad que no sea un número
        2. utilizar la lista que se encuentra en Empresa para llenar dgvEmpleados
        3. Agregar un Label que muestre un mensage de error cuando queremos agregar un empleado de forma erronea
            y que se desaparezca cuando ingresamos a algun textBox.

        Pueden encontrar una resolución en la rama res-clase-4-ejercicio-1.
    */
    class Empresa
    {
        private List<Empleado> Empleados = new List<Empleado>();

        //singleton.
        //La instancia se genera una sola vez.
        private static Empresa instance;
        //al hacer privado el contructor no dejamos que se instancie fuera con "new"
        private Empresa() { }
        //este método controla el acceso a la instancia.
        public static Empresa getEmpresa()
        {
            //si no hay instancia la creo y la devuelvo
            if (instance == null)
            {
                instance = new Empresa();
            }
            //si hay instancia devuelvo ESA instancia.
            return instance;
        }

        //Método publico para obtener la lista de empleados
        //noten que al no ser estática, se obtiene del objeto, no de la clase.
        public List<Empleado> getEmpleados()
        {
            return Empleados;
        }
    }
}

