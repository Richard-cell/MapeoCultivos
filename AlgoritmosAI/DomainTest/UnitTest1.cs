using System;
using CapaDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTest
{
    [TestClass]
    public class UnitTest1
    {
        PerceptronMulticapa perceptron;
        [TestMethod]
        public void PerceptronMulticapaTest()
        {
            perceptron = new PerceptronMulticapa(
                3,
                1,
                3,
                2,
                new int[3] { 2, 3,1 },
                new string[2] { "Sigmoide", "Tangente" },
                "Lineal",
                new int[3, 4] { { 0, 1, 0,1 }, { 1, 0, 1,0 }, { 1, 1, 1,1 } },
                0.1f,
                0.1f,
                5
                );
            Assert.AreEqual(3, perceptron.listaMatricesPeso.Count);
        }
        [TestMethod]
        public void PerceptronMulticapaTestV2()
        {
            perceptron = new PerceptronMulticapa(
                3,
                1,
                3,
                2,
                new int[3] { 2, 3, 1 },
                new string[2] { "Sigmoide", "Tangente" },
                "Lineal",
                new int[3, 4] { { 0, 1, 0, 1 }, { 1, 0, 1, 0 }, { 1, 1, 1, 1 } },
                0.1f,
                0.1f,
                5
                );
            Assert.AreEqual(3, perceptron.listaUmbrales.Count);
        }

        [TestMethod]
        public void EntrenamientoTest()
        {
            int nEntradas = 2;
            int nSalidas = 1;
            int nPatrones = 4;
            int nCapas = 3;
            int[] neuronasCapa = new int[4] { 5,5,30, nSalidas };
            string[] FAcapasOcultas = new string[3] { "Sigmoide","Sinuidal","Sigmoide" };
            string FACapaSalida = "Tangente";
            var matrizPatrones = new int[4, 3] { { 0,0,0},{ 0,1,1},{ 1,0,1},{ 1,1,0} };
            var rata = 0.01f;
            var errorMaximo = 0.1f;
            var nIteraciones = 1000;

            perceptron = new PerceptronMulticapa(
                nEntradas,
                nSalidas,
                nPatrones,
                nCapas,
                neuronasCapa,
                FAcapasOcultas,
                FACapaSalida,
                matrizPatrones,
                rata,
                errorMaximo,
                nIteraciones
                );
            perceptron.Entrenar();
            Assert.AreEqual(1, perceptron.errorIteracion[0]);
        }
    }
}
