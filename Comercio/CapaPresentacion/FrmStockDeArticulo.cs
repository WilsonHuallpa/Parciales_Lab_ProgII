using CapaDatos;
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
    public partial class FrmStockDeArticulo : Form
    {

        
        public FrmStockDeArticulo()
        {
            InitializeComponent();
        }

        private void btnListaProducto_Click(object sender, EventArgs e)
        {
           CargaDatagrid();

        }


        private void CargaDatagrid()
        {
            this.dgvListaProducto.DataSource = null;
            this.dgvListaProducto.DataSource = Comercio.ListaProductos;
        }

        private void btnMenorde10_Click(object sender, EventArgs e)
        {
            this.dgvListaProducto.DataSource = null;
            this.dgvListaProducto.DataSource = Comercio.StockMenorde10();

        }

        private void lbVolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
