using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Cliente : Persona
    {
        /*string usuaria;
        string password;*/
        string email;

        public Cliente(string nombre, string apellido,double dni, string telefono,
                       string email): base(nombre,apellido,dni,telefono)
        {
            this.email = email;
        }

        public string Email
        {
            get { return this.email; }
        }

        public static bool operator == (List<Cliente> listaClientes, Cliente auxCliente)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if(listaClientes[i].dni == auxCliente.dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator != (List<Cliente> listaCliente, Cliente auxCliente)
        {
            return !(listaCliente == auxCliente);
        }
    }
}
