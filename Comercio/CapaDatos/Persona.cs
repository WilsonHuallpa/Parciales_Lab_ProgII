using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected double dni;
        protected string telefono;

        private Persona()
        {
            this.nombre = "Sin Nombre";
            this.apellido = "Sin Apellido";
            this.dni = 00000000 ;
            this.telefono = "121212";
        }


        public Persona(string nombre_Persona, string apellido_Persona,double dni_Persona, string telefono):this()
        {
            this.nombre = nombre_Persona;
            this.apellido = apellido_Persona;
            this.dni = dni_Persona;
            this.telefono = telefono;
        }

        public string Nombre 
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get{ return apellido; }
        }

        public double Dni
        {
            get{ return dni; }
        }

        public string Telefono
        {
            get{return telefono; }
        }
      
    }
}
