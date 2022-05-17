using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Singleton
    {
        private static Singleton _instancia;
        private static ContextoContainer _contexto;

        private Singleton() { }

        public static Singleton obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Singleton();
                _contexto = new ContextoContainer();
            }
            return _instancia;
        }

        public ContextoContainer Contexto
        {
            get { return _contexto; }
        }
    }
}