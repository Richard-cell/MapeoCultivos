

using CapaDomain;
using CapaDomain.Entitys;
using CapaInfrastructure;
using System.Collections.Generic;

namespace CapaApplication
{
    public class BackpropagationService: IService
    {
        private string _path;
        private IDataFile _dataFile;
        private Backpropagation _backpropagation;
        public BackpropagationService(IDataFile dataFile)
        {
            _dataFile = dataFile;
        }
        public BackpropagationService(IDataFile dataFile, string path)
        {
            _dataFile = dataFile;
            _path = path;
        }
        public void InitMultilayerPerceptron()
        {
            int entradas = _dataFile.GetNInputs(_path);
            int salidas = _dataFile.GetNOuputs(_path);
            int patrones = _dataFile.GetNPatterns(_path);
            double[,] mPatrones = _dataFile.ReadFileToMatriz(_path);

            _backpropagation = new Backpropagation(entradas, salidas, patrones, mPatrones);
        }
        public void Train(int capas, int[] neuronasCapa, string[] FACapa, string FASalida, double rata, double errorMaximo, int Niteraciones)
        {
            _backpropagation.Entrenar(capas, neuronasCapa, FACapa, FASalida, rata, errorMaximo, Niteraciones);
        }
        public double[] GetErrorVector()
        {
            return _backpropagation.errorIteracion;
        }
        public Backpropagation GetPerceptronMulticapa()
        {
            return _backpropagation;
        }
        public int GetNInputs()
        {
            return _backpropagation.nEntradas;
        }
        public int GetNOutputs()
        {
            return _backpropagation.nSalidas;
        }
        public int GetNPatterns()
        {
            return _backpropagation.nPatrones;
        }
        public double[,] InitMatriz()
        {
            return _backpropagation.matrizPatrones;
        }
        public void SaveConfiguration(string path)
        {
            var nSalidas = _backpropagation.nSalidas;
            var nEntradas = _backpropagation.nEntradas;
            var nCapas = _backpropagation.nCapas;
            var nNeuronasCapa = _backpropagation.nNeuronasCapa;
            var fActivacionCapas = _backpropagation.funcionActivacionCapa;
            var fActivacionSalida = _backpropagation.funcionActivacionSalida;
            _dataFile.WriteFileConfiguration(path + @"\Configuracion.txt", nSalidas, nEntradas, nCapas, nNeuronasCapa, fActivacionCapas, fActivacionSalida);
        }
        public void SaveMatrizPesos(string path)
        {
            for (int i = 0; i < _backpropagation.listaMatricesPeso.Count; i++)
            {
                var matriz = _backpropagation.listaMatricesPeso[i];
                var nRows = matriz.GetLength(0);
                var nColumns = matriz.GetLength(1);
                var repo = _dataFile.WriteFileToMatriz(path + "\\W" + i + ".txt", matriz, nRows, nColumns);
            }
        }
        public void SaveVectorUmbrales(string path)
        {
            for (int i = 0; i < _backpropagation.listaUmbrales.Count; i++)
            {
                var vector = _backpropagation.listaUmbrales[i];
                var nElements = vector.Length;
                var repo = _dataFile.WriteFileToVector(path + "\\U" + i + ".txt", vector, nElements);
            }
        }
        public double[] Simulate(double[] vector, string path)
        {
            Backpropagation perceptronMulticapa = new Backpropagation();
            var nSalidas = _dataFile.GetOutputsConfiguration(path + "\\Configuracion.txt");
            var nEntradas = _dataFile.GetNInputsConfiguration(path + "\\Configuracion.txt");
            var nCapas = _dataFile.GetNLayersConfiguration(path + "\\Configuracion.txt");
            var nNeuronasCapa = _dataFile.GetNNeruonsLayerConfiguration(path + "\\Configuracion.txt");
            var fActivacionCapas = _dataFile.GetFActivationLayers(path + "\\Configuracion.txt");
            var fActivacionSalida = _dataFile.GetFActivationOutput(path + "\\Configuracion.txt");
            var listaMatrices = new List<double[,]>();
            var listaUmbrales = new List<double[]>();
            for (int i = 0; i < ((2 + nCapas) - 1); i++)
            {
                listaMatrices.Add(_dataFile.ReadFileToMatrizPesos(path + "\\W" + i + ".txt"));
            }
            for (int i = 0; i < nCapas + 1; i++)
            {
                listaUmbrales.Add(_dataFile.ReadFileToVectorUmbral(path + "\\U" + i + ".txt"));
            }

            return perceptronMulticapa.Simular(nSalidas, vector, listaMatrices, listaUmbrales, nCapas, nNeuronasCapa, fActivacionCapas, fActivacionSalida);
        }

        public double[] GetVector(string path)
        {
            return _dataFile.ReadFileToVector(path);
        }
        public int GetNOutputFile(string path)
        {
            return _dataFile.GetOutputsConfiguration(path);
        }
    }
}

