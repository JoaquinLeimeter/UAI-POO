using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Empresa
    {

        private static readonly Empresa instance = new Empresa();
        private List<Empleado> Empleados = new List<Empleado>();

        private Empresa() { }

        public static Empresa getEmpresa()
        {
            return instance;
        }

    }
}
