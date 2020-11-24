using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Archivos;
namespace Entidades
{
    public static class MacDonald
    {
        public static Queue<Turno> EnPreparacion { get; set; }
        public static Queue<Turno> Entregados { get; set; }
        public static string nombre { get; }

        static MacDonald()
        {
            nombre = "MacDonald";
            EnPreparacion = new Queue<Turno>();
            Entregados = new Queue<Turno>();
        }

        /// <summary>
        /// Trae datos desde archivo y los agrega a la cola
        /// </summary>
        public static void TraerDatoXML()
        {
            List<Turno> pedidos = Leer();

            foreach (Turno pedido in pedidos)
            {
                EnPreparacion.Enqueue(pedido);
            }
        }

        /// <summary>
        /// Deserializa un listado de pedidos
        /// </summary>
        /// <returns>una List<> de tipo Pedido</returns>
        public static List<Turno> Leer()
        {
            List<Turno> datos = new List<Turno>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "MacDonald.xml");
            Xml<List<Turno>> auxPedidos = new Xml<List<Turno>>();

            auxPedidos.Leer(path, out datos);

            return datos;

        }

        /// <summary>
        /// Serializa una lista de pedidos
        /// </summary>
        /// <returns>true si se guardo, false caso contrario</returns>
        public static bool Guardar()
        {

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "MacDonald.xml");
            Xml<List<Turno>> auxPedidos = new Xml<List<Turno>>();

            List<Turno> pedidos = new List<Turno>();

            foreach (Turno item in EnPreparacion)
            {
                pedidos.Add(item);
            }

            return auxPedidos.Guardar(path, pedidos);
        }

        /// <summary>
        /// Impime ticket con los datos del pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>true si se imprimio, false caso contrario</returns>
        public static bool PrintTicket(Turno delivery)
        {
            bool retorno = false;
            string path;

            if (delivery != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, delivery.ticke.ToString());

                Texto texto = new Texto();

                texto.Guardar(path, delivery.GenerarDiseñoTicke());
                retorno = true;
            }

            return retorno;
        }
    }
}
