using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
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
