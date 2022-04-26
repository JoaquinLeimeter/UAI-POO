using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        private int rowIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            //validar que haya algo en los inputs
            if(1 < 0)
            {
               
            }
            //agregamos columna, nos devuelve el indice de esa columna.
            int n = dgvEmpleados.Rows.Add();
            //usando el indice agregamos informacion
            dgvEmpleados.Rows[n].Cells[0].Value = txtNombre.Text;
            dgvEmpleados.Rows[n].Cells[1].Value = txtApellido.Text;
            dgvEmpleados.Rows[n].Cells[2].Value = txtEdad.Text;
            
            //clear inputs
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            index.Text = (rowIndex + 1).ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.RemoveAt(rowIndex);
        }
    }
}
