

using System.Collections.Generic;
using System.IO;

namespace CapaInfrastructure
{
    public abstract class DataFile : IDataFile
    {
        protected StreamWriter writer;
        protected StreamReader reader;

        public abstract int GetNInputs(string path);
        public abstract int GetNOuputs(string path);
        public abstract int GetNPatterns(string path);
        public abstract double[] ReadFileToVector(string path);
        public abstract double[,] ReadFileToMatriz(string path);
        public abstract double[,] ReadFileToMatrizPesos(string path);
        public abstract string WriteFileConfiguration(string path, int nSalidas, int nEntradas, int nCapas, int[] nNeuronasCapa, string[] FACapas, string FASalida);
        public abstract string WriteFileToMatriz(string path, double[,] matriz, int nRows, int nColumns);
        public abstract string WriteFileToVector(string path, double[] vector, int nColumns);
        public abstract int GetNInputsConfiguration(string path);
        public abstract int GetOutputsConfiguration(string path);
        public abstract int GetNLayersConfiguration(string path);
        public abstract int[] GetNNeruonsLayerConfiguration(string path);
        public abstract string[] GetFActivationLayers(string path);
        public abstract string GetFActivationOutput(string path);
        public abstract double[] ReadFileToVectorUmbral(string path);
    }
}
