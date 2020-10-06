using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Validaciones
    {

        //Que el campo de datos no se vacio.
        //1. no se puede cargar un campo de formulario que me rompa el codigo de producto.
        //2. no puedo dar de alta algo vacio.
        //3. no puedo editar un comobox.
        //4. no cierre un formulario y me agregar un empleado/ producto / cliente null.
        //5. comverciones de texto.


        /// <summary>
        /// Verifica si el numero ingresado es menor o igual a 0
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns>true si es menor a 0, false si no lo es</returns>
        public static bool CerosYnegativos(double auxNumero)
        {
            if (auxNumero <= 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica si el elemento ingresado es un string null, vacio o menor a 2 caracteres
        /// </summary>
        /// <param name="auxString"></param>
        /// <returns>true si cumple los requisitos, false si no los cumple</returns>
        public static bool ValidarString(string auxString)
        {
            if (String.IsNullOrEmpty(auxString) || auxString.Length < 2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }



        //public static bool ValidarEntero(int min, int max)
        //{

        //    return false;
        //}


        //que el string tenga mas de dos letras. poner el samari
    }
}
