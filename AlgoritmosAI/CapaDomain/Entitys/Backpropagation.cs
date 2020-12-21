

using System;
using System.Collections.Generic;

namespace CapaDomain.Entitys
{
    public class Backpropagation
    {
        public int nEntradas { get; set; }
        public int nSalidas { get; set; }
        public int nPatrones { get; set; }
        public int nCapas { get; set; }
        public double[,] matrizPatrones { get; set; }
        public int[] nNeuronasCapa { get; set; }
        public string[] funcionActivacionCapa { get; set; }
        public string[] DerivadafuncionActivacionCapa { get; set; }
        public string funcionActivacionSalida { get; set; }
        public List<double[,]> listaMatricesPeso;
        public List<double[]> listaUmbrales;
        public List<double[]> H;
        public List<double[]> EN;
        public double[] YD { get; set; }
        public double[] YR { get; set; }
        public double[] errorLineal { get; set; }
        public double[] errorPatron { get; set; }
        public double[] errorIteracion { get; set; }
        public int nIteraciones { get; set; }
        public double rataAprendizaje { get; set; }
        public double errorMaximoPermitido { get; set; }
        public Backpropagation() { }
        public Backpropagation(int entradas, int salidas, int patrones, double[,] mPatrones)
        {
            nEntradas = entradas;
            nSalidas = salidas;
            nPatrones = patrones;
            matrizPatrones = mPatrones;
            errorLineal = new double[nSalidas];
            errorPatron = new double[nPatrones];
            YD = new double[nSalidas];
        }

        private void InstanciarMatricesPeso()
        {
            //Console.WriteLine(nNeuronasCapa.Length);
            listaMatricesPeso = new List<double[,]>();
            for (int i = 0; i < ((2 + nCapas) - 1); i++)
            {
                if (listaMatricesPeso.Count == 0)
                {
                    listaMatricesPeso.Add(new double[nEntradas, nNeuronasCapa[i]]);
                }
                else
                {
                    listaMatricesPeso.Add(new double[nNeuronasCapa[i - 1], nNeuronasCapa[i]]);
                }
            }
        }
        private void InstanciarUmbrales()
        {
            listaUmbrales = new List<double[]>();
            for (int i = 0; i < nCapas + 1; i++)
            {
                if (i == (nCapas + 1) - 1)
                {
                    listaUmbrales.Add(new double[nSalidas]);
                    break;
                }
                listaUmbrales.Add(new double[nNeuronasCapa[i]]);
            }
        }
        private void InstanciarSalidasCapa(int nCapas)
        {
            H = new List<double[]>();
            for (int i = 0; i < nCapas; i++)
            {
                H.Add(new double[nNeuronasCapa[i]]);
            }
        }
        private void InstanciarErroresNoLinealesPorCapa()
        {
            EN = new List<double[]>();
            for (int i = 0; i < nCapas; i++)
            {
                EN.Add(new double[nNeuronasCapa[i]]);
            }
        }
        private void LlenarMatricesPeso()
        {
            var valor = new Random();
            var r = new int[2] { 1, -1 };
            for (int w = 0; w < listaMatricesPeso.Count; w++)
            {
                if (w == 0)
                {
                    for (int i = 0; i < nEntradas; i++)
                    {
                        for (int j = 0; j < nNeuronasCapa[w]; j++)
                        {
                            listaMatricesPeso[w][i, j] = Math.Truncate(10 * (valor.NextDouble() * r[valor.Next(0, 2)])) / 10;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < nNeuronasCapa[w - 1]; i++)
                    {
                        for (int j = 0; j < nNeuronasCapa[w]; j++)
                        {
                            listaMatricesPeso[w][i, j] = Math.Truncate(10 * (valor.NextDouble() * r[valor.Next(0, 2)])) / 10;
                        }
                    }
                }
            }
        }
        private void LlenarUmbrales()
        {
            var valor = new Random();
            var r = new int[2] { 1, -1 };
            for (int u = 0; u < listaUmbrales.Count; u++)
            {
                for (int i = 0; i < nNeuronasCapa[u]; i++)
                {
                    listaUmbrales[u][i] = Math.Truncate(10 * (valor.NextDouble() * r[valor.Next(0, 2)])) / 10;
                }
            }
        }

        private string[] ObtenerDerivada(string[] VectorFA, int ncapas)
        {

            var vector = new string[ncapas];
            for (int i = 0; i < ncapas; i++)
            {
                switch (VectorFA[i])
                {
                    case "Sigmoide":
                        vector[i] = "DevSigmoide";
                        break;
                    case "Gausiana":
                        vector[i] = "DevGausiana";
                        break;
                    case "Sinusoidal":
                        vector[i] = "DevSinusoidal";
                        break;
                }
            }
            return vector;
        }

        public void Entrenar(int capas, int[] neuronasCapa, string[] FACapa, string FASalida, double rata, double errorMaximo, int Niteraciones)
        {
            nNeuronasCapa = neuronasCapa;
            funcionActivacionCapa = FACapa;
            funcionActivacionSalida = FASalida;
            rataAprendizaje = rata;
            errorMaximoPermitido = errorMaximo;
            nIteraciones = Niteraciones;
            errorIteracion = new double[nIteraciones];
            nCapas = capas;

            InstanciarMatricesPeso();
            InstanciarErroresNoLinealesPorCapa();
            InstanciarUmbrales();
            LlenarMatricesPeso();
            LlenarUmbrales();
            DerivadafuncionActivacionCapa = ObtenerDerivada(FACapa, capas);

            int iteraciones = 0;
            bool isParada = false;
            do
            {
                //For para presentar los patrones
                for (int p = 0; p < nPatrones; p++)
                {
                    InstanciarSalidasCapa(nCapas);
                    YR = new double[nSalidas];
                    var fila = ObtenerFila(matrizPatrones, p);
                    var x = new double[nEntradas];
                    for (int i = 0; i < nEntradas; i++)
                    {
                        x[i] = fila[i];
                    }
                    //for para recorrer las capas
                    for (int c = 0; c < nCapas + 1; c++)
                    {
                        if (c != (nCapas + 1) - 1)
                        {
                            //For para la capas Ocultas, numeros de neurona por capa
                            if (c == 0)
                            {
                                for (int i = 0; i < nNeuronasCapa[c]; i++)
                                {
                                    for (int j = 0; j < x.Length; j++)
                                    {
                                        H[c][i] += x[j] * listaMatricesPeso[c][j, i];
                                    }
                                    H[c][i] = H[c][i] - listaUmbrales[c][i];
                                    H[c][i] = AplicarFuncionActivacion(H[c][i], funcionActivacionCapa[c]);

                                }
                            }
                            else
                            {
                                for (int l = 0; l < nNeuronasCapa[c]; l++)
                                {
                                    for (int i = 0; i < nNeuronasCapa[c - 1]; i++)
                                    {
                                        H[c][l] += H[c - 1][i] * listaMatricesPeso[c][i, l];
                                    }
                                    H[c][l] = H[c][l] - listaUmbrales[c][l];
                                    H[c][l] = AplicarFuncionActivacion(H[c][l], funcionActivacionCapa[c]);
                                }
                            }
                        }
                        else
                        {
                            //For para la capa de salida, numero de neuronas 
                            for (int k = 0; k < nSalidas; k++)
                            {
                                for (int i = 0; i < nNeuronasCapa[c - 1]; i++)
                                {
                                    YR[k] += H[c - 1][i] * listaMatricesPeso[c][i, k];
                                }
                                YR[k] = YR[k] - listaUmbrales[c][k];
                                YR[k] = AplicarFuncionActivacion(YR[k], funcionActivacionSalida);
                                YD[k] = fila[nEntradas + k];
                                errorLineal[k] = CalcularErrorLineal(YD[k], YR[k]);
                            }
                        }
                    }
                    CalculoErrorNoLinealPorCapas();
                    errorPatron[p] = CalcularErrorPatron();
                    AjustarPesos(x, p);
                    AjustarUmbrales(p);
                }
                CalcularErrorIteracion(iteraciones);
                //Console.WriteLine(errorIteracion[iteraciones]);
                isParada = errorIteracion[iteraciones] <= errorMaximoPermitido;
                iteraciones++;
            } while ((isParada == false) && iteraciones < nIteraciones);
        }
        public double[] Simular(int salidas, double[] vectorEntrada, List<double[,]> matricesPeso, List<double[]> vectorUmbrales, int capas, int[] neuronasCapa, string[] FACapa, string FASalida)
        {
            nSalidas = salidas;
            listaMatricesPeso = matricesPeso;
            listaUmbrales = vectorUmbrales;
            nNeuronasCapa = neuronasCapa;
            funcionActivacionCapa = FACapa;
            funcionActivacionSalida = FASalida;
            nCapas = capas;

            InstanciarSalidasCapa(nCapas);
            YR = new double[nSalidas];
            var x = vectorEntrada;
            var salida = new double[nSalidas];
            //for para recorrer las capas
            for (int c = 0; c < nCapas + 1; c++)
            {
                if (c != (nCapas + 1) - 1)
                {
                    //For para la capas Ocultas, numeros de neurona por capa
                    if (c == 0)
                    {
                        for (int i = 0; i < nNeuronasCapa[c]; i++)
                        {
                            for (int j = 0; j < x.Length; j++)
                            {
                                H[c][i] += x[j] * listaMatricesPeso[c][j, i];
                            }
                            H[c][i] = H[c][i] - listaUmbrales[c][i];
                            H[c][i] = AplicarFuncionActivacion(H[c][i], funcionActivacionCapa[c]);
                        }
                    }
                    else
                    {
                        for (int l = 0; l < nNeuronasCapa[c]; l++)
                        {
                            for (int i = 0; i < nNeuronasCapa[c - 1]; i++)
                            {
                                H[c][l] += H[c - 1][i] * listaMatricesPeso[c][i, l];
                            }
                            H[c][l] = H[c][l] - listaUmbrales[c][l];
                            H[c][l] = AplicarFuncionActivacion(H[c][l], funcionActivacionCapa[c]);
                        }
                    }
                }
                else
                {
                    //For para la capa de salida, numero de neuronas 
                    for (int k = 0; k < nSalidas; k++)
                    {
                        for (int i = 0; i < nNeuronasCapa[c - 1]; i++)
                        {
                            salida[k] += H[c - 1][i] * listaMatricesPeso[c][i, k];
                        }
                        salida[k] = salida[k] - listaUmbrales[c][k];
                        salida[k] = AplicarFuncionActivacion(salida[k], funcionActivacionSalida);
                        salida[k] = Math.Round(salida[k]);
                    }
                }
            }
            return salida;
        }
        private double[] ObtenerFila(double[,] matriz, int filaIndex)
        {
            var vector = new double[nEntradas + nSalidas];
            for (int i = 0; i < nEntradas + nSalidas; i++)
            {
                vector[i] = matriz[filaIndex, i];
            }
            return vector;
        }
        private double AplicarFuncionActivacion(double valor, string tipoFuncion)
        {
            double valorFinal = 0;
            switch (tipoFuncion)
            {
                case "Sigmoide":
                    valorFinal = FuncionActivacion.Sigmoide(valor);
                    break;
                case "Gausiana":
                    valorFinal = FuncionActivacion.Gausiana(valor);
                    break;
                case "DevSigmoide":
                    valorFinal = FuncionActivacion.DevSigmoide(valor);
                    break;
                case "DevSinusoidal":
                    valorFinal = FuncionActivacion.DevSinusoidal(valor);
                    break;
                case "DevGausiana":
                    valorFinal = FuncionActivacion.DevGausiana(valor);
                    break;
                case "Lineal":
                    valorFinal = FuncionActivacion.Lineal(valor);
                    break;
                case "Sinusoidal":
                    valorFinal = FuncionActivacion.Sinusoidal(valor);
                    break;
            }
            return valorFinal;

        }
        private double CalcularErrorLineal(double YD, double YR)
        {
            //console.WriteLine($"YD: {YD} - YR: {YR}");
            return YD - YR;
        }
        private double CalcularErrorPatron()
        {
            double error = 0;
            for (int k = 0; k < nSalidas; k++)
            {
                error += Math.Abs(errorLineal[k]);
            }

            return (error = error / nSalidas);
        }
        private void CalculoErrorNoLinealPorCapas()
        {

            for (int i = EN.Count - 1; i == 0; i--)
            {

                for (int j = 0; j < EN[i].Length; j++)
                {
                    if (i == EN.Count - 1)
                    {
                        for (int e = 0; e < nSalidas; e++)
                        {
                            for (int o = 0; o < nNeuronasCapa[nNeuronasCapa.Length - 1]; o++)
                            {
                                EN[i][j] += errorLineal[e] * listaMatricesPeso[nNeuronasCapa.Length - 1][o, e];
                            }
                        }
                    }
                    else if (i != EN.Count - 1)
                    {

                        for (int e = 0; e < nNeuronasCapa[i + 1]; e++)
                        {
                            for (int o = 0; o < nNeuronasCapa[i]; o++)
                            {
                                EN[i][j] += EN[i + 1][o] * listaMatricesPeso[i][o, e];
                            }
                        }
                    }
                    else
                    {
                        for (int e = 0; e < nNeuronasCapa[0]; e++)
                        {
                            for (int o = 0; o < nNeuronasCapa[1]; o++)
                            {
                                EN[i][j] += EN[i - 1][o] * listaMatricesPeso[1][o, e];
                            }
                        }
                    }
                }

            }
        }
        private void AjustarPesos(double[] x, int patronIndex)
        {
            for (int w = 0; w < listaMatricesPeso.Count; w++)
            {
                if (w == 0)
                {
                    for (int j = 0; j < nNeuronasCapa[w]; j++)
                    {
                        for (int i = 0; i < nEntradas; i++)
                        {
                            listaMatricesPeso[w][i, j] = listaMatricesPeso[w][i, j] + 2 * rataAprendizaje * EN[w][j] * AplicarFuncionActivacion(H[w][j], DerivadafuncionActivacionCapa[w]) * x[i];
                        }
                    }
                }
                else if (w != listaMatricesPeso.Count - 1)
                {
                    for (int i = 0; i < nNeuronasCapa[w]; i++)
                    {
                        for (int l = 0; l < nNeuronasCapa[w - 1]; l++)
                        {
                            listaMatricesPeso[w][l, i] = listaMatricesPeso[w][l, i] + 2 * rataAprendizaje * EN[w][i] * AplicarFuncionActivacion(H[w][i], DerivadafuncionActivacionCapa[w]);
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < nSalidas; k++)
                    {

                        for (int o = 0; o < nNeuronasCapa[w - 1]; o++)
                        {
                            listaMatricesPeso[w][o, k] = listaMatricesPeso[w][o, k] + 2 * rataAprendizaje * errorLineal[k] * H[w - 1][o];
                        }
                    }
                }
            }
        }
        private void AjustarUmbrales(int patronIndex)
        {
            for (int u = 0; u < listaUmbrales.Count; u++)
            {
                if (u != listaUmbrales.Count - 1)
                {
                    for (int l = 0; l < nNeuronasCapa[u]; l++)
                    {
                        listaUmbrales[u][l] = listaUmbrales[u][l] + 2 * rataAprendizaje * EN[u][l] * 1;
                    }
                }
                else
                {
                    for (int k = 0; k < nNeuronasCapa[u]; k++)
                    {
                        listaUmbrales[u][k] = listaUmbrales[u][k] + rataAprendizaje * errorLineal[k] * 1;
                    }
                }
            }
        }
        private void CalcularErrorIteracion(int iteracionIndex)
        {
            for (int p = 0; p < nPatrones; p++)
            {
                errorIteracion[iteracionIndex] += errorPatron[p];
            }
            errorIteracion[iteracionIndex] = Math.Truncate(100 * (errorIteracion[iteracionIndex] / nPatrones)) / 100;
        } 
    }
}
