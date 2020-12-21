

using System.Collections.Generic;

namespace CapaInfrastructure
{
    public interface IDataFile
    {
        int GetNInputs(string path);
        int GetNOuputs(string path);
        int GetNPatterns(string path);
        int GetNInputsConfiguration(string path);
        int GetOutputsConfiguration(string path);
        int GetNLayersConfiguration(string path);
        int[] GetNNeruonsLayerConfiguration(string path);
        string[] GetFActivationLayers(string path);
        string GetFActivationOutput(string path);
        double[,] ReadFileToMatriz(string path);
        double[,] ReadFileToMatrizPesos(string path);
        double[] ReadFileToVectorUmbral(string path);
        double[] ReadFileToVector(string path);
        string WriteFileToMatriz(string path, double[,] matriz, int nRows, int nColumns);
        string WriteFileToVector(string path, double[] vector, int nColumns);
        string WriteFileConfiguration(string path, int nSalidas, int nEntradas, int nCapas, int[] nNeuronasCapa, string[] FACapas, string FASalida);
        
    }
}
