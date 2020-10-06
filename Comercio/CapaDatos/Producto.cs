using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Producto
    {

        int codigo;
        string marca;
        double precio;
        string descripcion;
        int stock;

        /// <summary>
        /// Inicializacion del producto
        /// </summary>
        /// <param name="codigoBarra"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        public Producto(int codigoBarra, string marca, double precio, string descripcion, int stock)
        {
            this.codigo = codigoBarra;
            this.marca = marca;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;
        }

      
        /// <summary>
        ///  Propiedad Getter del campo codigo de barra.
        /// </summary>
        public int Codigo
        {
            get { return this.codigo; }
        }
        /// <summary>
        ///  Propiedad Getter del campo Marca.
        /// </summary>
        public string Marca
        {
            get{ return this.marca; }
        }
        /// <summary>
        ///  Propiedad Getter del campo Precio.
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }

        /// <summary>
        ///  Propiedad Getter del campo descripcion.
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public int Stock
        {
            get { return this.stock; }

            set
            {
                this.stock = value;

                if(this.stock < 0)
                {
                    this.stock = 0;
                }

            }
        }

        public static bool operator ==(List<Producto> listaProductos, Producto auxProducto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].codigo == auxProducto.codigo)
                {
                    return true;
                }
            }

            return false;
        }


        public static bool operator !=(List<Producto> listaProductos, Producto auxProducto)
        {
            return !(listaProductos == auxProducto);
        }

        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            bool retorno = false;

            if(listaProductos != auxProducto)
            {
                listaProductos.Add(auxProducto);
                retorno = true;
            }
            else
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].codigo == auxProducto.codigo)
                    {
                        listaProductos[i].Stock = auxProducto.Stock;
                    }

                }
            }
            return retorno;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Descripcion: {this.descripcion}");
            sb.AppendLine($"Stock: {this.stock.ToString()}");
            sb.AppendLine($"ID Producto: {this.codigo.ToString()}");
            sb.AppendLine(String.Format("Precio: ${0: #,###.00}", this.precio));

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
