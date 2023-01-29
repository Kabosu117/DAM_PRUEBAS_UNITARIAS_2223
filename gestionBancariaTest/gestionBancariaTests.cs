namespace gestionBancariaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        public void validarMetodoIngreso()
        {
            // preparaci�n del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // M�todo a probar

            cuenta.realizarIngreso(ingreso);

            // afirmaci�n de la prueba (valor esperado Vs. Valor obtenido)

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}