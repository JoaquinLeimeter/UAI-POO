using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios _instancia;

        private ControladoraUsuarios() { }

        public static ControladoraUsuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraUsuarios();
            }
            return _instancia;
        }

        public void Agregar_Usuarios(Usuario usuario)
        {
            Singleton.obtener_instancia().Contexto.Usuarios.Add(usuario);
            Singleton.obtener_instancia().Contexto.SaveChanges();
        }
        public List<Usuario> Listar_Usuarios()
        {
            return Singleton.obtener_instancia().Contexto.Usuarios.ToList();
        }
    }
}
