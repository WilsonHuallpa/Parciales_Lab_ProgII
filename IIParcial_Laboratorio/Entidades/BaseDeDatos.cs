using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Exception1;

namespace Entidades
{
    public static class BaseDeDatos
    {

        static SqlConnection conexion;

        static BaseDeDatos()
        {
            conexion = new SqlConnection("data source=DESKTOP-3J3IBDL\\SQLEXPRESS01;initial catalog=Parcial;integrated security=true ");
        }

        #region metodo

        public static void insertar (Turno auxturno)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Insert into parcial(Ticket, Cliente, Tipo, Precio, Domicilio) " +
                 "values(@auxticket, @auxcliente, @auxtipo, @auxprecio, @auxdomicilio)";

                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando.Parameters.Add(new SqlParameter("@auxticket", auxturno.ticke));
                comando.Parameters.Add(new SqlParameter("@auxcliente", auxturno.cliente));
                comando.Parameters.Add(new SqlParameter("@auxtipo", auxturno.tipo.ToString()));
                comando.Parameters.Add(new SqlParameter("@auxprecio", auxturno.precio));
                comando.Parameters.Add(new SqlParameter("@auxdomicilio", auxturno.domicilio));

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new BDException("ERROR al insertar datos :" + e.Message);
            }
            finally
            {
                conexion.Close();
            }

        }
        #endregion
    }
}
