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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string user;
            string pass;
            user = txtUsuario.Text;
            pass = txtContraseña.Text;
            if(user == "Wilson" && pass == "123456")
            {
                //instanciamos formulario
                FrmMenu opcion1 = new FrmMenu();
                opcion1.Show(); // me va mostrar el formulario qu estoy abriendo.
                this.Hide();//minimisa y cierra la ventana de mi logi
            }
            else
            {
                MessageBox.Show("Usuario no existe",Comercio.NombreComercio);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
