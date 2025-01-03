using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000; 
            double ingreso = 500;
            double saldoActual = 0; 
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        public void validarMetodoIngreso1()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoEsperado = 1000;
            double saldoActual = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        public void validarMetodoIngreso2()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double ingreso = 1;
            double saldoEsperado = 1001;
            double saldoActual = 0;


            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoIngreso3()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        public void validarMetodoReintegro()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegro1()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double reintegro = 0;
            double saldoEsperado = 1000;
            double saldoActual = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        public void validarMetodoReintegro2()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double reintegro = 1;
            double saldoEsperado = 999;
            double saldoActual = 0;


            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegro3()
        {
            // preparación del caso de prueba 
            double saldoInicial = 1000;
            double reintegro = 1500;
            double saldoEsperado = 0;
            double saldoActual = 0;


            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar 
            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido) 
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
    }
}
