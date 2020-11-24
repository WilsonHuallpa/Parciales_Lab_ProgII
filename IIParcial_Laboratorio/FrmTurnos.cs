using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace IIParcial_Laboratorio
{

    public partial class FrmTurnos : Form
    {
        Thread p1;
        Random random;

        public FrmTurnos()
        {
           
            InitializeComponent();
            p1 = new Thread(iniciarCiclo);
            random = new Random();

        }

      
        private void FrmTurnos_Load(object sender, EventArgs e)
        {
            try
            {
                MacDonald.TraerDatoXML();
                CargardeListaEntregados();
                CargardeListaEnpreparacion();

                if (!p1.IsAlive)
                {
                    p1.Start();
                }
                else
                {
                    p1.Abort();
                    p1.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        /// <summary>
        /// Metodo que mueve los pedidos de un listbox en preparacion a otro listbox en entregado.
        /// </summary>
        public void iniciarCiclo()
        {
            try
            {
                while (true)
                {
                   

                    if (MacDonald.EnPreparacion.Count > 0)
                    {

                        Thread.Sleep(random.Next(4000, 6000));

                        Turno auxturno = MacDonald.EnPreparacion.Dequeue();
                        BaseDeDatos.insertar(auxturno);
                        MacDonald.Entregados.Enqueue(auxturno);

                        ActualizarEnPreparacion();

                        ActualizarEntregados();

                        this.ActualizarLabel("Hay pedidos en preparacion");

                    }
                    else
                    {
                        this.ActualizarLabel("No hay Nigun pedido");
                    }
                }
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Gracias, vuelva prontross!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        }


        private void ActualizarLabel(string texto)
        {
            if (this.lbPedidosActuales.InvokeRequired)
            {
                this.lbPedidosActuales.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lbPedidosActuales.Text = texto;

                });
            }
            else
            {
                this.lbPedidosActuales.Text = texto;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agregar = new FrmAgregar();

            agregar.Show();
        }

        /// <summary>
        /// Verifica si es necesario llamar a un metodo de invocacion para actualizar los datos de pantalla
        /// </summary>
        private void ActualizarEnPreparacion()
        {
            if (this.list_Preparacion.InvokeRequired)
            {
                this.list_Preparacion.BeginInvoke((MethodInvoker)delegate ()
                {
                    CargardeListaEnpreparacion();

                });
            }
            else
            {
                CargardeListaEnpreparacion();
            }
        }

        /// <summary>
        /// Verifica si es necesario llamar a un metodo de invocacion para actualizar los datos de pantalla
        /// </summary>
        private void ActualizarEntregados()
        {
            if (this.list_Entregados.InvokeRequired)
            {
                this.list_Entregados.BeginInvoke((MethodInvoker)delegate ()
                {
                    CargardeListaEntregados();
                });
            }
            else
            {
                CargardeListaEntregados();
            }
        }
        /// <summary>
        /// Carga los pedidos entregados en el listbox 
        /// </summary>
        private void CargardeListaEntregados()
        {
            this.list_Entregados.DataSource = null;
            this.list_Entregados.DataSource = MacDonald.Entregados.ToArray();
        }
        /// <summary>
        /// Carga los pedidos en preparacion en el listbox 
        /// </summary>
        public void CargardeListaEnpreparacion()
        {
            this.list_Preparacion.DataSource = null;
            this.list_Preparacion.DataSource = MacDonald.EnPreparacion.ToArray();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTurnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MacDonald.Guardar())
            {
                MessageBox.Show("Se Guardaron los pedido pendiente en MacDonald.xml",MacDonald.nombre);
            }

            if (p1.IsAlive)
                p1.Abort();
        }

     
        
    }
}
