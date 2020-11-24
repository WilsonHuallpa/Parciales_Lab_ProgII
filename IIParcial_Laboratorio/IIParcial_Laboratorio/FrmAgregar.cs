using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Exception1;

namespace IIParcial_Laboratorio
{
    public delegate void Carga(Turno nombre);
    public partial class FrmAgregar : Form
    {
        Turno AuxTurno;
        public Carga delegado;
        public FrmAgregar()
        {
            InitializeComponent();
            delegado += ejemplodedelegados;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Agregar();
                delegado(AuxTurno);
            }
            catch (Exception miErrorDatos)
            {
                MessageBox.Show(miErrorDatos.Message, MacDonald.nombre);
            }
            finally
            {
                
                Limpiar();
            }
        }

        private void Agregar()
        {
            if (this.checkBox1.Checked)
            {
                AuxTurno = new Turno(this.txtNombre.Text, (Turno.Etipos)this.cmbTipos.SelectedValue, this.txtDomicilio.Text);
                MacDonald.EnPreparacion.Enqueue(AuxTurno);
                MessageBox.Show("Cargado con exitos", MacDonald.nombre);
                MacDonald.PrintTicket(AuxTurno);
            }
            else
            {
                AuxTurno = new Turno(this.txtNombre.Text, (Turno.Etipos)this.cmbTipos.SelectedValue);
                MacDonald.EnPreparacion.Enqueue(AuxTurno);
                MessageBox.Show("Cargado con exitos", MacDonald.nombre);
            }
        }
        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            cmbTipos.DataSource = Enum.GetValues(typeof(Turno.Etipos));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                this.txtDomicilio.Enabled = true;
            }
            else
            {
                this.txtDomicilio.Enabled = false;
            }
        }

        /// <summary>
        /// Limpia los Textbox
        /// </summary>
        private void Limpiar()
        {
            this.txtNombre.Clear();
            this.txtDomicilio.Clear();
        }

        public void ejemplodedelegados(Turno Nombre)
        {

            MessageBox.Show($"gracias por su compra {Nombre.cliente}",MacDonald.nombre);
        }
    }
}
