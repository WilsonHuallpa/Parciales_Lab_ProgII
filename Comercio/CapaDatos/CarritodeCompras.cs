using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CarritodeCompras
    {
        string descripcion;
        double precio;
        int idCompra;
        //int cantidad;
        //Producto miproducto;

        public CarritodeCompras()
        {
            this.descripcion = "Sin decripcion";
            this.precio = -1;
            this.idCompra = -1;
        }

        public CarritodeCompras(string decripcion, double precio, int idCompra) : this()
        {
            this.descripcion = decripcion;
            this.precio = precio;
            this.idCompra = idCompra;
        }

        public double IdCompra
        {
            get { return this.idCompra; }
        }
        
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }



        //calcular subtotal
    }
}
