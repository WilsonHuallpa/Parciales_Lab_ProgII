using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado : Persona
    {
        int idEmpleado;
        string usuario;

        public Empleado(string nombre, string apellido, double dni, string telefono, int id, string usuario) : base( nombre, apellido, dni, telefono)
        {
            this.idEmpleado = id;
            this.usuario = usuario;
        }

        public int IdEmpleado
        {
            get { return this.idEmpleado; }
        }

        public string Usuario
        {
            get { return this.usuario; }
        }

    }
}
