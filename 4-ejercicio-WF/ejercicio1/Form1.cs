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

        //obtenemos la instancia de Empleados.
        List<Empleado> Empleados = Empresa.getEmpresa().getEmpleados();
        //guardamos aquí sobre que índice nos encontramos.
        //para poder clickear una Row y luego borrarla.
        private int rowIndex = 0;

        public Form1()
        {
            InitializeComponent();
            index.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int edadComoEntero;
            //validar que haya algo en los inputs
            //Valido tambien que
            if
                (
                    !String.IsNullOrWhiteSpace(txtNombre.Text) &&
                    !String.IsNullOrWhiteSpace(txtApellido.Text) &&
                    !String.IsNullOrWhiteSpace(txtEdad.Text) &&
                    int.TryParse(txtEdad.Text, out edadComoEntero)
                )
            {
                //agregamos una row
                //agregamos el empleado a la lista de empleados de la empresa
                Empleados.Add(new Empleado(txtNombre.Text, txtApellido.Text, edadComoEntero));
                //llenar dgv con los empleados de la lista.
                FillGrid();

                //clear inputs
                //esto podría ser una función definida en otro lado. En caso de que quisieramos limpiar los inputs en otro momento.
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                return;
            }
            errorMessage.Text = "Incorrect Input";
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //esto es solo para mostrar en que row me encuentro.
            rowIndex = e.RowIndex;
            index.Text = (rowIndex + 1).ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Tambien podr{iamos deshabilitar el boton siempre que no haya empleados en la lista
            if (Empleados.Count() > 0 && rowIndex < Empleados.Count())
            {
                Empleados.RemoveAt(rowIndex);
                FillGrid();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //esto no funciona ya que cada vez que corremos el programa
            //perdemos la data que pusimos en la lista
            //luego veremos como persistir la información.
            FillGrid();
        }

        private void FillGrid()
        {
            //clear dataGridView if there is something
            if (dgvEmpleados.RowCount > 1)
            {
                
                    dgvEmpleados.Rows.Clear();
                
            }

            //buscamos la data desde la instancia. 
            //Podríamos buscar esta data de "otro lado" donde guardaríamos la data
            //usamos el índice para llenar tantas Rows como empleados tengamos en la lista
            int i = 0;
            //por cada emp (de tipo Empleados) en empleados.
            foreach (Empleado emp in Empleados)
            {
                //agregamos una row
                dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[i].Cells[0].Value = emp.Nombre;
                dgvEmpleados.Rows[i].Cells[1].Value = emp.Apellido;
                dgvEmpleados.Rows[i].Cells[2].Value = emp.Edad;
                Console.WriteLine(emp.Nombre);
                i++;
            }
            Console.WriteLine($"aomnt of loops on fillGrid {i}");
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }

    }
}
