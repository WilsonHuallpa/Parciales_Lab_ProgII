using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Exception1;
namespace Entidades
{
    public class Turno
    {
        public Etipos tipo { get; set; }

        public string cliente { get; set; }

        public int precio { get; set; }

        static int nroTicket = 0;

        public int ticke { get; set; }
        
        public string domicilio { get; set; }

        private Turno()
        {
            this.domicilio = "Sin Delivery";
            nroTicket++;
        }

        public Turno(string cliente,Etipos tipos):this()
        {
            this.ticke = nroTicket;
            this.cliente = ValidarDatos(cliente);
            this.tipo = tipos;
            this.precio = (int)tipos;
        }

        public Turno(string cliente, Etipos tipos, string domicilio ):this(cliente,tipos)
        {
            this.domicilio = ValidarDatos(domicilio);
        }

        public enum Etipos{

            Hambuerguesa = 300,
            Helados = 100 ,
            Jugo = 150,
            Papas = 120,
        }

        /// <summary>
        /// Genera un stringbuilder  de algunos datos del pedido.
        /// </summary>
        /// <returns></returns>
        public virtual string MostrarTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"N°: {this.ticke} ");
            sb.AppendLine($"Nombre: {this.cliente} ");
            sb.AppendLine($"Tipo: {this.tipo.ToString()} ");
            sb.AppendLine($"Lugar: {this.domicilio}");
            return sb.ToString();
        }

        /// <summary>
        /// override del metodo mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarTicket();
        }


        private string ValidarDatos(string texto)
        {
            if (String.IsNullOrEmpty(texto) || texto.Length < 2)
            {
                throw new ErrorDatosException("Error...Verificar Datos ingresado.");
            }
            return texto;
        }


    }
}
