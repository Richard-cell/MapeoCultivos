
using CapaInfrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfrastructureTest
{
    [TestClass]
    public class DataFileTest
    {
        DataFileTxt dataFile = new DataFileTxt();
        string pathOne = @"C:\Users\Richard\Desktop\richardv2\IA\Ejercicio.txt";
        string pathTwo = @"C:\Users\Richard\Desktop\richardv2\IA\PruebaTest.txt";
        string pathTree = @"C:\Users\Richard\Desktop\richardv2\IA\PruebaTestDos.txt";
        string pathConfiguration = @"C:\Users\Richard\Desktop\richardv2\IA\Configuration.txt";

        [TestMethod]
        public void GetPatternsTest()
        {
            Assert.AreEqual(6, dataFile.GetNPatterns(pathOne));
        }
        [TestMethod]
        public void GetInputsTest()
        {
            Assert.AreEqual(2, dataFile.GetNInputs(pathOne));
        }
        [TestMethod]
        public void GetOutputTest()
        {
            Assert.AreEqual(1, dataFile.GetNOuputs(pathOne));
        }
        [TestMethod]
        public void WriteFileToMatrizTest()
        {
            float[,] matriz = new float[2,2] { { 2,2},{ 1,0} };
            Assert.AreEqual("Archivo almacenado correctamente", dataFile.WriteFileToMatriz(pathTwo,matriz,2,2));
        }
        [TestMethod]
        public void WriteFileToVectorTest()
        {
            float[] vector = new float[2] {  1,0 };
            Assert.AreEqual("Archivo almacenado correctamente", dataFile.WriteFileToVector(pathTree, vector, 2));
        }
        [TestMethod]
        public void WriteFileConfigurationTest()
        {
            int[] vector = new int[2] { 1, 2 };
            string[] FACapas = new string[2] { "Sigmoide", "Sigmoide" };
            Assert.AreEqual("Archivo de configuracion almacenado correctamente", dataFile.WriteFileConfiguration(pathConfiguration,2,vector,FACapas,"Lineal"));
        }
        [TestMethod]
        public void ReadFileToMatrizTest()
        {
            Assert.AreEqual(-1, dataFile.ReadFileToMatriz(pathOne)[5, 2]);
        }
    }
}
