using System;
using System.Windows.Forms;

namespace CapaPresentacion.Base
{
    public class DataGridViewControl
    {
        public void MatrizToDataGridView(double[,] matriz,int nInputs, DataGridView table, string title)
        {
            RestartDataGridView(table);
            table.ColumnCount = matriz.GetLength(1);
            table.RowCount = matriz.GetLength(0);
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j<nInputs)
                    {
                        table.Columns[j].HeaderCell.Value = $"{title}{j + 1}";
                    }
                    else
                    {
                        table.Columns[j].HeaderCell.Value = $"YD{j - (nInputs-1)}";
                    }
                    table.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }
        public void VectorToDataGridViewError(double[] vector, DataGridView table, string title)
        {
            RestartDataGridView(table);
            table.Columns.Add("N°","N° Iteracion");
            table.Columns.Add("Error", "Error");
            table.RowCount = vector.Length;
            for (int i = 0; i < vector.Length; i++)
            {
                table.Rows[i].Cells[0].Value = i + 1;
                table.Rows[i].Cells[1].Value = vector[i];
            }
        }
        public void VectorToDataGridView(double[] vector, DataGridView table, string title)
        {
            RestartDataGridView(table);
            table.ColumnCount = vector.Length;
            table.RowCount = vector.Length;
            for (int i = 0; i < vector.Length; i++)
            {
                table.Columns[i].HeaderCell.Value = $"{title}{i+1}";
                table.Rows[0].Cells[i].Value = vector[i];
            }
        }
        public void VectorToDataGridViewV2(double[] vector, DataGridView table, string title, int pixels)
        {
            double vari= 1;
            RestartDataGridView(table);
            table.ColumnCount = 3;
            table.Columns[0].HeaderCell.Value = $"Valor indice";
            table.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[1].HeaderCell.Value = $"Color";
            table.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[2].HeaderCell.Value = $"Porcentaje";
            table.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.RowCount = vector.Length;
            for (int i = 0; i < vector.Length; i++)
            {
                table.Rows[i].Cells[0].Value = Math.Truncate(10 * (vari)) / 10; 
                table.Rows[i].Cells[2].Value = (Math.Truncate(10 * (((vector[i] / pixels) * 100))) / 10) +" %";
                vari = Math.Truncate(10 * (Math.Truncate(10 * (vari)) / 10) - 0.1) / 10;
            }
            table.Rows[20].Cells[0].Value = -1;
            table.Rows[20].Cells[1].Style.BackColor = ChartControl.HexToColor("#800000");
            table.Rows[19].Cells[0].Value = -0.9;
            table.Rows[19].Cells[1].Style.BackColor = ChartControl.HexToColor("#B22222");
            table.Rows[18].Cells[0].Value = -0.8;
            table.Rows[18].Cells[1].Style.BackColor = ChartControl.HexToColor("#DC143C");
            table.Rows[17].Cells[0].Value = -0.7;
            table.Rows[17].Cells[1].Style.BackColor = ChartControl.HexToColor("#FF0000");
            table.Rows[16].Cells[0].Value = -0.6;
            table.Rows[16].Cells[1].Style.BackColor = ChartControl.HexToColor("#FF4500");
            table.Rows[15].Cells[0].Value = -0.5;
            table.Rows[15].Cells[1].Style.BackColor = ChartControl.HexToColor("#FF6347");
            table.Rows[14].Cells[0].Value = -0.4;
            table.Rows[14].Cells[1].Style.BackColor = ChartControl.HexToColor("#FF7F50");
            table.Rows[13].Cells[0].Value = -0.3;
            table.Rows[13].Cells[1].Style.BackColor = ChartControl.HexToColor("#FF8C00");
            table.Rows[12].Cells[0].Value = -0.2;
            table.Rows[12].Cells[1].Style.BackColor = ChartControl.HexToColor("#FFA500");
            table.Rows[11].Cells[0].Value = -0.1;
            table.Rows[11].Cells[1].Style.BackColor = ChartControl.HexToColor("#FFD700");
            table.Rows[10].Cells[1].Style.BackColor = ChartControl.HexToColor("#FFFF00");
            table.Rows[9].Cells[1].Style.BackColor = ChartControl.HexToColor("#F0E68C");
            table.Rows[8].Cells[1].Style.BackColor = ChartControl.HexToColor("#ADFF2F");
            table.Rows[7].Cells[1].Style.BackColor = ChartControl.HexToColor("#7FFF00");
            table.Rows[6].Cells[1].Style.BackColor = ChartControl.HexToColor("#7CFC00");
            table.Rows[5].Cells[1].Style.BackColor = ChartControl.HexToColor("#00FF00");
            table.Rows[4].Cells[1].Style.BackColor = ChartControl.HexToColor("#32CD32");
            table.Rows[3].Cells[1].Style.BackColor = ChartControl.HexToColor("#9ACD32");
            table.Rows[2].Cells[1].Style.BackColor = ChartControl.HexToColor("#6B8E23");
            table.Rows[1].Cells[1].Style.BackColor = ChartControl.HexToColor("#008000");
            table.Rows[0].Cells[1].Style.BackColor = ChartControl.HexToColor("#006400");
        }
        public double[,] DataGridViewToMatriz(DataGridView table)
        {
            double[,] matriz = new double[0,0];
            if (table.RowCount!=0)
            {
                matriz = new double[table.RowCount, table.ColumnCount];
                for (int i = 0; i < table.RowCount; i++)
                {
                    for (int j = 0; j < table.ColumnCount; j++)
                    {
                        matriz[i, j] = float.Parse(table.Rows[i].Cells[j].Value.ToString());
                    }
                }
                return matriz;
            }
            else
            {
                Console.WriteLine($"No Hay registros en la tabla {table.Name}");
                return matriz;
            }
        }
        public double[] DataGridViewToVector(DataGridView table, int columIndex)
        {
            double[] vector = new double[0];
            if (table.RowCount != 0)
            {
                vector = new double[table.RowCount];
                for (int i = 0; i < table.RowCount; i++)
                {
                   vector[i] = float.Parse(table.Rows[i].Cells[columIndex].Value.ToString());
                }
                return vector;
            }
            else
            {
                Console.WriteLine($"No Hay registros en la tabla {table.Name}");
                return vector;
            }
        }
        public void RestartDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Update();
        }
    }
}
