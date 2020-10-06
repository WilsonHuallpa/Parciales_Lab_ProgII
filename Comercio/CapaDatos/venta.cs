using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class venta
    {
        Empleado vendedor;
        Cliente comprador;
        List<CarritodeCompras> listaComprar;
        double montoTotal;
        static int numeroFactura = 100;
      
       public venta()
        {
            listaComprar = new List<CarritodeCompras>();
            numeroFactura = 1 + numeroFactura;
        }
        
        public venta(Empleado vendedor, Cliente comprador, List<CarritodeCompras> listaCompra, double montoTotal): this()
        {
            this.vendedor = vendedor;
            this.comprador = comprador;
            this.listaComprar = listaCompra;
            this.montoTotal = montoTotal;

        }

        public string ApellidoVendedor
        {
            get { return vendedor.Apellido; }
        }
        
        public int id
        {
            get { return vendedor.IdEmpleado; }
        }

        public string ApellidoCliente
        {
            get { return comprador.Apellido; }
        }

        public string NombreCliente
        {
            get { return comprador.Nombre; }
        }

        public int CantArt
        {
            get { return listaComprar.Count; }
        }

        public double Total
        {
            get { return montoTotal; }
        }
    }
}
