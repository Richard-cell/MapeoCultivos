using System;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace CapaDomain.Base
{
    public static class Conversiones
    {
        //De binario a hexademcimal
        public static string BinaryStringToHexString(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        //De Hexadecimal a Binario
        public static double[] HexaToBinary(string numberHexa)
        {
            string aBinario = "";
            aBinario = Convert.ToString(Convert.ToInt32(numberHexa, 16), 2);
            var number = new double[24];
            if (aBinario.Length<24)
            {
                var faltantes = 24 - aBinario.Length;
                for (int i = 0; i < faltantes; i++)
                {
                    number[i] = 0;
                }
                int index = 0;
                for (int j = faltantes; j < 24; j++)
                {
                    number[j] = Double.Parse(aBinario[index].ToString());
                    index++;
                }
            }
            else
            {
                for (int i = 0; i < aBinario.Length; i++)
                {
                    number[i] = Double.Parse(aBinario[i].ToString());
                }
            }
            return number;
        }
        //Convertir de vector a string
        public static string VectorToString(double[] vector)
        {
            var line = "";
            for (int i = 0; i < vector.Length; i++)
            {
                line += vector[i].ToString();
            }
            return line;
        }
        public static Color HexToColor(string hexString)
        {
            //replace # occurences
            //Console.WriteLine(hexString+" :COLOR");
            if (hexString.IndexOf('#') != -1)
                hexString = hexString.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(hexString.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            g = int.Parse(hexString.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            b = int.Parse(hexString.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return Color.FromArgb(r, g, b);
        }
    }
}
