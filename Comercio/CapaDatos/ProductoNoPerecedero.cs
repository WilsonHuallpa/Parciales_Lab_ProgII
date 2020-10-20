﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoNoPerecedero : Producto
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoProducto"></param>
        public ProductoNoPerecedero(string descripcion, int idProducto, double precio, int stock, ETipo tipoProducto) : base(descripcion, idProducto, precio, stock, tipoProducto)
        {

        }

        #endregion

        #region Metodos
        /// <summary>
        /// override del metodo Mostrar
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTO NO PERECEDERO");
            sb.AppendLine("---------------------------------------------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------------------------------------------");
            sb.AppendLine("Este producto puede ser conservado a temperatura ambiente");

            return sb.ToString();
        }
        #endregion
    }
}
