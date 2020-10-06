using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        bool login = false;
        SoundPlayer auxSonido;
        //string directorio = Directory.GetCurrentDirectory();
        public FrmMenu()
        {
            InitializeComponent();
            auxSonido = new SoundPlayer();

        }

        private void OpcionControl_Click(object sender, EventArgs e)
        {
            Control_de_Usuario opcion2 = new Control_de_Usuario();
            opcion2.Show();
            this.Hide();
        }

        private void OpcionVentas_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();

            if(frmVenta.ShowDialog()== DialogResult.OK)
            {
                Comercio.Listaventas.Add(frmVenta.Miventa);

                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }

        }

        private void opcionInventario_Click(object sender, EventArgs e)
        {
            FrmStockDeArticulo listaProducto = new FrmStockDeArticulo();

            if (listaProducto.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            Comercio.HarcodeoCliente();
            Comercio.HarcodeoEmpleado();
            Comercio.HarcodeoProducto();
            Comercio.HardcodeoCompras();
        }

        private void listaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaCompras listaCompra = new FrmListaCompras();

            if(listaCompra.ShowDialog() == DialogResult.OK)
            {
                auxSonido.Play();
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login milogin = new Login();


            milogin.Show();
            this.Close();
        }

        private void opcionAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agregarProducto = new FrmAgregar();

            if (agregarProducto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!! Vuelva prontosss", Comercio.NombreComercio);
            }
            else
            {
                MessageBox.Show("Nos veremos en el Infiernosss!!", Comercio.NombreComercio);
            }
        }
    }
}
