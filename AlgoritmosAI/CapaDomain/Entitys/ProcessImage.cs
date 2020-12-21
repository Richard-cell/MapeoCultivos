using CapaDomain.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDomain.Entitys
{
    public class ProcessImage
    {
        private Bitmap _originalImage;
        private ProgressBar _progresBar;
        private Backpropagation _backpropagation;
        public int _nRows;
        public int _nColumns;
        public double[] porcentajeVector;
        public ProcessImage(Bitmap originalImage, ProgressBar bar)
        {
            _originalImage = originalImage;
            _progresBar = bar;
            _backpropagation = new Backpropagation();
            _nRows = _originalImage.Width;
            _nColumns = _originalImage.Height;
            porcentajeVector = new double[21];
        }
        public void ApplyIndicator(int salidas, List<double[,]> matricesPeso, List<double[]> vectorUmbrales, int capas, int[] neuronasCapa, string[] FACapa, string FASalida)
        {
            for (int i = 0; i < _nRows; i++)
            {
                for (int j = 0; j < _nColumns; j++)
                {
                    Color colorPixel = _originalImage.GetPixel(i, j);
                    var red = (double)colorPixel.R;
                    var green = (double)colorPixel.G;
                    var blue = (double)colorPixel.B;
                    var varIndex = new double[1] { (green - red) / (green + red - blue) };
                    var varTruncate = new double[1] { (Math.Truncate(10 * varIndex[0]) / 10) };
                    GetPercentageByColor(varTruncate[0]);
                    if (varTruncate[0] > 1)
                    {
                        varTruncate[0] = 1;
                    }
                    else if(varTruncate[0]<-1)
                    {
                        varTruncate[0] = -1;
                    }else if (double.IsNaN(varTruncate[0]))
                    {
                        varTruncate[0] = -1;
                    }
                    double[] finalColor = _backpropagation.Simular(salidas, varTruncate, matricesPeso, vectorUmbrales, capas, neuronasCapa, FACapa, FASalida);
                    string binary = "";
                    for (int k = 0; k < finalColor.Length; k++)
                    {
                        binary += finalColor[k].ToString();
                    }
                    string hexFinalColor = Conversiones.BinaryStringToHexString(binary);
                    _originalImage.SetPixel(i, j, Conversiones.HexToColor(hexFinalColor));
                    _progresBar.Value = (100 * i + 1) / (_nRows);
                }         
            }
            
        }
        public int NumberPixels()
        {
            return _nColumns * _nRows;
        }
        public void GetPercentageByColor(double variResult)
        {
            switch (variResult)
            {
                case 1.0:
                    porcentajeVector[0]++;
                    break;
                case 0.9:
                    porcentajeVector[1]++;
                    break;
                case 0.8:
                    porcentajeVector[2]++;
                    break;
                case 0.7:
                    porcentajeVector[3]++;
                    break;
                case 0.6:
                    porcentajeVector[4]++;
                    break;
                case 0.5:
                    porcentajeVector[5]++;
                    break;
                case 0.4:
                    porcentajeVector[6]++;
                    break;
                case 0.3:
                    porcentajeVector[7]++;
                    break;
                case 0.2:
                    porcentajeVector[8]++;
                    break;
                case 0.1:
                    porcentajeVector[9]++;
                    break;
                case 0.0:
                    porcentajeVector[10]++;
                    break;
                case -0.1:
                    porcentajeVector[11]++;
                    break;
                case -0.2:
                    porcentajeVector[12]++;
                    break;
                case -0.3:
                    porcentajeVector[13]++;
                    break;
                case -0.4:
                    porcentajeVector[14]++;
                    break;
                case -0.5:
                    porcentajeVector[15]++;
                    break;
                case -0.6:
                    porcentajeVector[16]++;
                    break;
                case -0.7:
                    porcentajeVector[17]++;
                    break;
                case -0.8:
                    porcentajeVector[18]++;
                    break;
                case -0.9:
                    porcentajeVector[19]++;
                    break;
                case -1.0:
                    porcentajeVector[20]++;
                    break;
                default:
                    break;
            }
        }

        public Bitmap GetImage()
        {
            return _originalImage;
        }
    }
}
