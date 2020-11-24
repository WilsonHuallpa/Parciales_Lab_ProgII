using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using Exception1;
namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// testea que se lance la excepcion de erro de datos ingresado
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ErrorDatosException))]
        public void Test_CrearunPedido()
        {
            Turno nuevo = new Turno("w", Turno.Etipos.Hambuerguesa);

            //Turno nuevo2 = new Turno("wilson", Turno.Etipos.Helados, "3");

        }
        /// <summary>
        /// testea que se lance la excepcion de erro al insertar base de datos.
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(BDException))]
        public void Test_BasedeDatos()
        {
            Turno turno = null;

            BaseDeDatos.insertar(turno);
        }
        /// <summary>
        /// testea que se lance true al imprimir el ticke de los pedidos. 
        /// </summary>
        [TestMethod]
        public void test_ImprimirTick()
        {
            Turno auxPedido = new Turno("wilson",Turno.Etipos.Papas,"costa rica 1730");

            Assert.IsTrue(MacDonald.PrintTicket(auxPedido));
        }


    }
}
