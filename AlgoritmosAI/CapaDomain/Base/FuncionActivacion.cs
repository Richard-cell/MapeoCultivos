using System;


namespace CapaDomain
{
    public static class FuncionActivacion
    {
        public static double Sigmoide(double valor)
        {
            return (1 / (1 + Math.Exp(-(valor))));
        }
        public static double Gausiana(double valor)
        {
            return (Math.Exp(-((Math.Pow(valor,2)))));
        }
        public static double Escalon(double valor)
        {
            if (valor<0) {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static double Tangente(double valor)
        {
            return (2 / (1 + Math.Exp(-2 * valor))) - 1;
        }
        public static double Lineal(double valor)
        {
            return valor;
        }
        public static double Sinusoidal(double valor)
        {
            return Math.Sin(valor);
        }
        public static double DevSinusoidal(double valor)
        {
            return Math.Cos(valor);
        }
        public static double DevSigmoide(double valor)
        {
            return (1 - Math.Tanh(Math.Pow(valor, 2)));
        }
        public static double DevGausiana(double valor)
        {
            return (Math.Exp(-2 * valor * (Math.Exp(Math.Pow(-valor, 2)))));
        }
    }
}
