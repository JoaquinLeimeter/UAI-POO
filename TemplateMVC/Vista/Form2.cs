using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form2 : Form
    {
        Usuario selectedUser = new Usuario();

        public Form2()
        {
            InitializeComponent();

            //trae los usuarios apenas inicia el programa
            ARMA_GRILLA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            ControladoraUsuarios.obtener_instancia().Agregar_Usuarios(user);
            //MessageBox.Show("");
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ubo un error al ejecutar el programa" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                ControladoraUsuarios.obtener_instancia().Eliminar_Usuarios(selectedUser);
            }
            ARMA_GRILLA();
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = ControladoraUsuarios.obtener_instancia().Listar_Usuarios().ElementAt(e.RowIndex);
            Console.WriteLine("selected User", selectedUser.Id);
        }
    }
}
