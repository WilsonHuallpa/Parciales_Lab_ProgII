using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Comercio
    {
        //tiene que contener una lista de toda la clases.
        //manejador principal del programa.
        //lista de producto. validar que el producto no exita haganla sobre el operador ==,
        //si tienen un producto esta en 0 no removemos el producto. 
        //lista de clientes.
        static List<Producto> listaProductos;
        static List<Cliente> listaClientes;
        static List<Empleado> listaEmpleados;
        static List<venta> listaventas;
        static string nombreComercio;
        
        static Comercio() {

            nombreComercio = "Kwik E Mart";

            ListaProductos= new List<Producto>();

            listaClientes = new List<Cliente>();

            listaEmpleados = new List<Empleado>();

            listaventas = new List<venta>();
        }
        

        public static List<venta> Listaventas { get => listaventas; }
        public static string NombreComercio { get => nombreComercio; }

        public static List<Cliente> ListaClientes { get => listaClientes; }
        public static List<Empleado> ListaEmpleados { get => listaEmpleados; }
        public static List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }

        public static int StockDeProducto()
        {
            int cantidad = 0;

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                cantidad += ListaProductos[i].Stock;
            }

            return cantidad;
        }

        public static List<venta> GetListaVentas(int idEmpleado)
        {
            List<venta> auxListaventas = new List<venta>();

            foreach (venta v in listaventas)
            {
                if (v.id == idEmpleado)
                {
                    auxListaventas.Add(v);
                }
            }
            return auxListaventas;
        }

       

        public static List<Producto> StockMenorde10()
        {
            List<Producto> auxproductos = new List<Producto>();

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if(ListaProductos[i].Stock < 10)
                    auxproductos.Add(ListaProductos[i]);
            }

            return auxproductos;
        }


        public static bool DescuentoASimpson (Cliente auxClient)
        {
            if(auxClient.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }


        //hardcodeo de usuario

        public static bool ValidarCantidad(int idProducto, int auxCantidad)
        {
            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if(ListaProductos[i].Codigo == idProducto && ListaProductos[i].Stock >= auxCantidad)
                {
                    return true;
                }
            }
            return false;
        }


        public static void HarcodeoProducto()
        {
            ListaProductos.Add(new Producto(1001, "marca1", 100, "Descripcion1",5));
            ListaProductos.Add(new Producto(1002, "marca2", 100, "Descripcion2",6));
            ListaProductos.Add(new Producto(1003, "marca3", 100, "Descripcion3",7));
            ListaProductos.Add(new Producto(1004, "marca4", 100, "Descripcion4",34));
            ListaProductos.Add(new Producto(1005, "marca5", 100, "Descripcion5",55));
            ListaProductos.Add(new Producto(1006, "marca6", 100, "Descripcion6",2));
            ListaProductos.Add(new Producto(1007, "marca7", 100, "Descripcion7",5));
            ListaProductos.Add(new Producto(1008, "marca8", 100, "Descripcion8",55));
            ListaProductos.Add(new Producto(1009, "marca9", 100, "Descripcion9",77));
            ListaProductos.Add(new Producto(1010, "marca10", 100, "Descripcion10",55));
 
        }

        public static void HarcodeoCliente()
        {
            listaClientes.Add(new Cliente("wilson", "Simpson",111111,"22222","@gmail"));
            listaClientes.Add(new Cliente("Ariel", "Simpson",111111,"22222","@gmail"));
            listaClientes.Add(new Cliente("yona", "Huallpa",111111,"22222","@gmail"));
            listaClientes.Add(new Cliente("Maxi", "Huallpa", 111111,"22222","@gmail"));
            listaClientes.Add(new Cliente("Tavo", "Huallpa", 111111,"22222","@gmail"));
            listaClientes.Add(new Cliente("Nestor", "Huallpa", 111111,"22222","@gmail"));
        }

       public static void HarcodeoEmpleado()
        {
            listaEmpleados.Add(new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"));
            listaEmpleados.Add(new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"));
        }

        public static void HardcodeoCompras()
        {
            //string nombre, string apellido, double dni, string telefono, int id, string usuario
            Empleado[] auxEmpleado = new Empleado[50] {new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"), new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),new Empleado("Empleado1", "Apellido1", 222222, "11111111", 2222,"usuario1"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"), new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),
            new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2"),new Empleado("Empleado2", "Apellido2", 222222, "22222222", 2222,"usuario2")};

            Cliente[] auxCliente = new Cliente[50] {new Cliente("Ned","Flanders",333333,"22222","@gmail"), new Cliente("Ned","Flanders",333333,"22222","@gmail"),
            new Cliente("Ned","Flanders",333333,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Ned","Flanders",333333,"22222","@gmail"),
            new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Ned","Flanders",333333,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),
            new Cliente("Homero","Simpson",123456,"22222","@gmail"), new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),
            new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Ned","Flanders",333333,"22222","@gmail"),new Cliente("Ned","Flanders",333333,"22222","@gmail"),
            new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),new Cliente("Homero","Simpson",123456,"22222","@gmail"),
            new Cliente("Ned","Flanders",333333,"22222","@gmail"),new Cliente("Ned","Flanders",333333,"22222","@gmail"), new Cliente("Barney","Gomez",7891011,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Waylon","Smithers",4444,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Waylon","Smithers",4444,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),
            new Cliente("Waylon","Smithers",4444,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),new Cliente("Barney","Gomez",7891011,"22222","@gmail"),
            new Cliente("Montgomery","Burns",2222222,"22222","@gmail"), new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),
            new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),
            new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),new Cliente("Montgomery","Burns",2222222,"22222","@gmail"),
            new Cliente("Montgomery","Burns",2222222,"22222","@gmail"), new Cliente("Montgomery","Burns",2222222,"22222","@gmail")};

            string[] descripcion = new string[50] { "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te", "Arroz", "Jabon en polvo", "Mate cocido", "Salsa de tomate",
            "Arvejas", "Choclo", "Atun", "Jugo de naranja", "Jugo de manzana", "Caldo",  "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te" };

            double[] precio = new double[50] { 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51, 63, 177, 48, 55, 68, 88, 91, 145, 141, 30, 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51 };

            int[] idProducto = new int[50] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23, 24, 25, 26, 27, 28, 29, 30, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < 50; i++)
            {
                List<CarritodeCompras> auxLista = new List<CarritodeCompras>();
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                auxLista.Add(new CarritodeCompras(descripcion[i], precio[i], idProducto[i]));
                listaventas.Add(new venta(auxEmpleado[i], auxCliente[i], auxLista, (precio[i] * 3)));
            }
        }


    }
}
