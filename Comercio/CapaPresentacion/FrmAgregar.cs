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
    public partial class FrmAgregar : Form
    {

        Producto auxProducto;
        public FrmAgregar()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id;
            double precio;
            int stock;
            Producto auxproducto = (Producto)cmbTIPO.SelectedItem;

            if (double.TryParse(this.txtPrecio.Text, out precio) && int.TryParse(this.txtCantidad.Text, out stock)
                && !Validaciones.ValidarString(this.txtdecripcion.Text) && int.TryParse(this.txtcodigo.Text, out id))
            {
                if (!Validaciones.CerosYnegativos(precio) && !Validaciones.CerosYnegativos(stock) && !Validaciones.CerosYnegativos(id))
                {
                    auxProducto = new Producto(Convert.ToInt32(this.txtcodigo.Text),auxproducto.Marca,Convert.ToDouble(this.txtPrecio.Text),this.txtdecripcion.Text,
                    Convert.ToInt32(this.txtCantidad.Text));

                    Comercio.ListaProductos.Add(auxProducto);
                    
                    MessageBox.Show("Producto cargado con exitos", Comercio.NombreComercio);
                    MessageBox.Show(auxProducto.ToString(), Comercio.NombreComercio);
                  
                    this.Limpiar();
                }
                else
                {
                    MessageBox.Show("Verificar campo numericos", Comercio.NombreComercio);
                }
            }
            else
            {
                MessageBox.Show("Verificar datos ingresados", Comercio.NombreComercio);
            }



        }

        private void Limpiar()
        {
            this.txtcodigo.Text = "";
            this.txtCantidad.Text = "";
            this.txtPrecio.Text = "";
            this.txtdecripcion.Text = "";
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.cmbTIPO.DataSource = Comercio.ListaProductos;
            this.cmbTIPO.DisplayMember = "Marca";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
