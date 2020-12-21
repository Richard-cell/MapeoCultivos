
using CapaDomain.Entitys;
using CapaInfrastructure;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaApplication
{
    public class ProcessImageService
    {
        private ProcessImage _processImage;
        private IDataImage _dataImage;
        private IDataFile _dataFile;
        public ProcessImageService(IDataImage dataImage, IDataFile dataFile)
        {
            _dataImage = dataImage;
            _dataFile = dataFile;
        }
        public Bitmap OpenImage(string path)
        {
            return _dataImage.OpenImage(path);
        }
        public bool SaveImage(string path, string name, Bitmap image)
        {
            return _dataImage.SaveImage(path,name,image);
        }
        public void ApplyIndicator(ProgressBar bar,Bitmap originalImage, string pathFilesTrain)
        {
            var nSalidas = _dataFile.GetOutputsConfiguration(pathFilesTrain + "\\Configuracion.txt");
            var nEntradas = _dataFile.GetNInputsConfiguration(pathFilesTrain + "\\Configuracion.txt");
            var nCapas = _dataFile.GetNLayersConfiguration(pathFilesTrain + "\\Configuracion.txt");
            var nNeuronasCapa = _dataFile.GetNNeruonsLayerConfiguration(pathFilesTrain + "\\Configuracion.txt");
            var fActivacionCapas = _dataFile.GetFActivationLayers(pathFilesTrain + "\\Configuracion.txt");
            var fActivacionSalida = _dataFile.GetFActivationOutput(pathFilesTrain + "\\Configuracion.txt");
            var listaMatrices = new List<double[,]>();
            var listaUmbrales = new List<double[]>();
            for (int i = 0; i < ((2 + nCapas) - 1); i++)
            {
                listaMatrices.Add(_dataFile.ReadFileToMatrizPesos(pathFilesTrain + "\\W" + i + ".txt"));
            }
            for (int i = 0; i < nCapas + 1; i++)
            {
                listaUmbrales.Add(_dataFile.ReadFileToVectorUmbral(pathFilesTrain + "\\U" + i + ".txt"));
            }
            _processImage = new ProcessImage(originalImage,bar);
            _processImage.ApplyIndicator(nSalidas,listaMatrices,listaUmbrales,nCapas,nNeuronasCapa,fActivacionCapas,fActivacionSalida);
        }
        public Bitmap GetFinalImage()
        {
            return _processImage.GetImage();
        }
        public double[] GetPercentageByColor()
        {
            return _processImage.porcentajeVector;
        }
        public int GetNumberPixels()
        {
            return _processImage.NumberPixels();
        }
    }
}
