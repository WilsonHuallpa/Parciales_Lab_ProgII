using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensores
    {
        /// <summary>
        /// Motodo de extencion, Genera un Diseño de ticke con todo la imformacion corespondiente. 
        /// </summary>
        /// <param name="auxproducto"></param>
        /// <returns></returns>
        public static string GenerarDiseñoTicke(this Turno auxproducto)
        {
            StringBuilder sb = new StringBuilder();
            DateTime dateTime = DateTime.Now;
            string titulo = "****************" + "FACTURA: " + auxproducto.ticke.ToString() + "****************";
            string asterisquitos = string.Empty;
            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "*"; 
            }
            sb.AppendLine(asterisquitos);
            sb.AppendLine(titulo);
            sb.AppendLine(asterisquitos);
            sb.AppendLine($"Enpresa::{MacDonald.nombre}");
            sb.AppendLine($"Fecha:: {dateTime.ToString("MM/dd/yyy")} Hora:: {dateTime.ToString("HH:mm")}");
            sb.AppendLine($"Nombre Cliente:: {auxproducto.cliente} ");
            sb.AppendLine($"Producto comprado:: {auxproducto.tipo.ToString()} ");
            sb.AppendLine(String.Format("Precio:: ${0: #,###.00}", auxproducto.precio));
            sb.AppendLine($"Domicilio:: {auxproducto.domicilio} ");
            sb.AppendLine(asterisquitos);
            return sb.ToString();
        }
    }
}
