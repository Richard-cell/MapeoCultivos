using System;
using System.IO;

namespace CapaInfrastructure
{
    public class DataFileTxt : DataFile
    {
        private bool isFileExist(string path)
        {
            if (File.Exists(path))
            {
                reader = File.OpenText(path);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override double[,] ReadFileToMatriz(string path)
        {
            double[,] matriz=null;
            matriz = new double[GetNPatterns(path), GetNInputs(path)+GetNOuputs(path)];
            if (isFileExist(path))
            {
                int nRow = 0;
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        var fila = line.Split(',',';');
                        //Console.WriteLine(fila.Length);
                        for (int i = 0; i < fila.Length; i++)
                        {
                            matriz[nRow, i] = double.Parse(fila[i].Replace('.',','));
                        }
                    }
                    nRow++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return matriz;
        }

        public override double[,] ReadFileToMatrizPesos(string path)
        {
            int nRow = 0;
            int nColumns = 0;
            double[,] matriz=new double[0,0];
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        nColumns=line.Split(';').Length;
                        nRow++;
                    }

                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            if (isFileExist(path))
            {
                //Console.WriteLine("Numeropooo de columnas:"+nColumns);
                matriz = new double[nRow, nColumns];
                string line;
                int row = 0;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        for (int j = 0; j < line.Split(';').Length; j++)
                        {
                            matriz[row, j] = double.Parse(line.Split(';')[j]);
                        }
                    }
                    row++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return matriz;
        }

        public override string WriteFileToMatriz(string path, double[,] matriz, int nRows, int nColumns)
        {
            try
            {
                File.Delete(path);
                writer = File.CreateText(path);
                for (int i = 0; i < nRows; i++)
                {
                    string line = "";
                    for (int j = 0; j < nColumns; j++)
                    {
                        if (j == nColumns - 1)
                        {
                            line += matriz[i, j].ToString();
                        }
                        else
                        {
                            line += matriz[i, j].ToString() + ";";
                        }
                    }
                    writer.WriteLine(line);
                }
                writer.Close();
                return "Archivo almacenado correctamente";
            }
            catch (Exception e)
            {

                return $"{e},Error al crear el archivo";
            }           
        }

        public override string WriteFileToVector(string path, double[] vector, int nColumns)
        {
            try
            {
                File.Delete(path);
                writer = File.CreateText(path);
                string line = "";
                for (int j = 0; j < nColumns; j++)
                {
                    if (j == nColumns - 1)
                    {
                        line += vector[j].ToString();
                    }
                    else
                    {
                        line += vector[j].ToString() + ";";
                    }
                }
                writer.WriteLine(line);
                writer.Close();
                return "Archivo almacenado correctamente";
            }
            catch (Exception e)
            {

                return $"{e},Error al crear el archivo";
            }
        }
        public override string WriteFileConfiguration(string path,int nSalidas,int nEntradas, int nCapas, int[] nNeuronasCapa, string[] FACapas, string FASalida)
        {
            try
            {
                File.Delete(path);
                writer = File.CreateText(path);
                for (int i = 0; i < 6; i++)
                {
                    string line = "";
                    if (i==0)
                    {
                        writer.WriteLine(nEntradas.ToString());
                    }else if (i==1)
                    {
                        writer.WriteLine(nSalidas.ToString());
                    }else if (i==2)
                    {
                        writer.WriteLine(nCapas.ToString());
                    }
                    else if(i==3)
                    {
                        for (int j = 0; j < nCapas; j++)
                        {
                            if (j==nCapas-1)
                            {
                                line += nNeuronasCapa[j].ToString();
                            }
                            else
                            {
                                line += nNeuronasCapa[j].ToString()+";";
                            }
                        }
                        writer.WriteLine(line);
                    }else if (i==4)
                    {
                        for (int j = 0; j < nCapas; j++)
                        {
                            if (j == nCapas - 1)
                            {
                                line += FACapas[j];
                            }
                            else
                            {
                                line += FACapas[j] + ";";
                            }
                        }
                        writer.WriteLine(line);
                    }
                    else
                    {
                        writer.WriteLine(FASalida);
                    }
                    Console.WriteLine($"Recorri el for:{i}");
                }
                writer.Close();
                return "Archivo de configuracion almacenado correctamente";
            }
            catch (Exception e)
            {

                return $"{e},Error al crear el archivo";
            }
        }

        public override int GetNInputs(string path)
        {
            int nInputs = 0;
            if (isFileExist(path))
            {
                string line;
                line = reader.ReadLine();
                if (line != null)
                {
                    nInputs = line.Split(',').Length;
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return nInputs;
        }

        public override int GetNOuputs(string path)
        {
            int nOutputs = 0;
            if (isFileExist(path))
            {
                string line;
                line = reader.ReadLine();
                if (line != null)
                {
                    nOutputs = line.Split(';').Length-1;
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return nOutputs;
        }

        public override int GetNPatterns(string path)
        {
            int nPatterns = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        nPatterns++;
                    }
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return nPatterns;
        }

        public override int GetNInputsConfiguration(string path)
        {
            int inputs = 0;
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (nRows==0)
                        {
                            inputs = int.Parse(line);
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return inputs;
        }

        public override int GetOutputsConfiguration(string path)
        {
            int Outputs = 0;
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (nRows == 1)
                        {
                            Outputs = int.Parse(line);
                            break;
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return Outputs;
        }

        public override int GetNLayersConfiguration(string path)
        {
            int layers = 0;
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (nRows == 2)
                        {
                            layers = int.Parse(line);
                            break;
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return layers;
        }

        public override int[] GetNNeruonsLayerConfiguration(string path)
        {
            int[] neuronsLayers= new int[GetNLayersConfiguration(path)];
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {   
                        if (nRows == 3)
                        {
                            for (int i = 0; i < line.Split(';').Length; i++)
                            {
                                neuronsLayers[i] = int.Parse(line.Split(';')[i]);
                            }
                            break;
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return neuronsLayers;
        }

        public override string[] GetFActivationLayers(string path)
        {
            string[] fActivationLayers = new string[GetNLayersConfiguration(path)];
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (nRows == 4)
                        {
                            for (int i = 0; i < line.Split(';').Length; i++)
                            {
                                fActivationLayers[i] = line.Split(';')[i];
                            }
                            break;
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return fActivationLayers;
        }

        public override string GetFActivationOutput(string path)
        {
            string fActivationOutput = "";
            int nRows = 0;
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (nRows == 5)
                        {
                            fActivationOutput = line;
                            break;
                        }
                    }
                    nRows++;
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return fActivationOutput;
        }

        public override double[] ReadFileToVectorUmbral(string path)
        {
            int nElements = 0;
            double[] vector = new double[0];
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        for (int i = 0; i < line.Split(';').Length; i++)
                        {
                            nElements++;
                        }
                    }
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            if (isFileExist(path))
            {
                vector = new double[nElements];
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        for (int j = 0; j < line.Split(';').Length; j++)
                        {
                            vector[j] = double.Parse(line.Split(';')[j]);
                        }
                    }
                } while (line != null);
                reader.Close();
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada");
            }
            return vector;
        }
        public override double[] ReadFileToVector(string path)
        {
            double[] vector = new double[0];
            if (isFileExist(path))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        vector = new double[line.Split(',').Length];
                        for (int i = 0; i < vector.Length; i++)
                        {
                            vector[i] = double.Parse(line.Split(',')[i].Replace('.', ','));
                        }
                    }
                } while (line != null);
                reader.Close();
            }
            return vector;
        }
    }
}
