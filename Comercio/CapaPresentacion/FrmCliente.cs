using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCliente : Form
    {


        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(dtgvCliente);
            fila.Cells[0].Value = txtidCliente.Text;
            fila.Cells[1].Value = txtNombre.Text;
            fila.Cells[2].Value = txtApellido.Text;
            fila.Cells[3].Value = txtTelefono.Text;
            fila.Cells[4].Value = txtEmail.Text;

            dtgvCliente.Rows.Add(fila);

            Limpiar();

        }

        private void Limpiar()
        {

            txtidCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
         
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            
        }

    }
}
