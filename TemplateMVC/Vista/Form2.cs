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
        public Form2()
        {
            InitializeComponent();
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
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
        }
    }
}
