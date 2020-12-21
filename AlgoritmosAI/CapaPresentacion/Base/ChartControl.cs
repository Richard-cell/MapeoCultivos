
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Base
{
    public class ChartControl
    {

        public string VectorToChart(double[] vector, Chart chart, int index, double errorMax)
        {
            if (vector[index]<int.MaxValue)
            {
                chart.Series["ErrorIteracion"].Points.AddXY(index + 1, vector[index]);
                chart.Series["ErrorMaximo"].Points.AddXY(index + 1, errorMax);
                return "Ok";
            }
            else
            {
                return "Error";
            }
        }

        public void RestartChart(Chart chart)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Update();
        }
        public void InitChartError(Chart chart, string chartTitle)
        {
            RestartChart(chart);
            chart.Titles.Add(chartTitle);
            chart.Series.Add("ErrorIteracion");
            chart.Series.Add("ErrorMaximo");
            chart.ChartAreas.Add("Area");

            chart.ChartAreas[0].AxisX.Title = "N° Iteraciones";
            chart.ChartAreas[0].AxisY.Title = "Error Iteración";
            chart.ChartAreas[0].AxisY.Interval = 0.1;
            chart.ChartAreas[0].AxisX.Minimum = 1;

            chart.Series["ErrorIteracion"].ChartType = SeriesChartType.Spline;
            chart.Series["ErrorIteracion"].BorderWidth = 3;
            chart.Series["ErrorMaximo"].ChartType = SeriesChartType.Spline;
            chart.Series["ErrorMaximo"].BorderWidth = 3;
            chart.Series["ErrorIteracion"].Color = Color.Red;
            chart.Series["ErrorMaximo"].Color = Color.Blue;
        }
        public void InitChartImage(Chart chart, string chartTitle)
        {
            RestartChart(chart);
            chart.Titles.Add(chartTitle);
            chart.ChartAreas.Add("Area");
            chart.Series.Add("1").Color = HexToColor("006400");
            chart.Series.Add("0.9").Color = HexToColor("008000");
            chart.Series.Add("0.8").Color = HexToColor("6B8E23");
            chart.Series.Add("0.7").Color = HexToColor("9ACD32");
            chart.Series.Add("0.6").Color = HexToColor("32CD32");
            chart.Series.Add("0.5").Color = HexToColor("00FF00");
            chart.Series.Add("0.4").Color = HexToColor("7CFC00");
            chart.Series.Add("0.3").Color = HexToColor("7FFF00");
            chart.Series.Add("0.2").Color = HexToColor("ADFF2F");
            chart.Series.Add("0.1").Color = HexToColor("F0E68C");
            chart.Series.Add("0.0").Color = HexToColor("FFFF00");
            chart.Series.Add("-0.1").Color = HexToColor("FFD700");
            chart.Series.Add("-0.2").Color = HexToColor("FFA500");
            chart.Series.Add("-0.3").Color = HexToColor("FF8C00");
            chart.Series.Add("-0.4").Color = HexToColor("FF7F50");
            chart.Series.Add("-0.5").Color = HexToColor("FF6347");
            chart.Series.Add("-0.6").Color = HexToColor("FF4500");
            chart.Series.Add("-0.7").Color = HexToColor("FF0000");
            chart.Series.Add("-0.8").Color = HexToColor("DC143C");
            chart.Series.Add("-0.9").Color = HexToColor("B22222");
            chart.Series.Add("-1").Color = HexToColor("800000");

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.Title = "Porcentaje";
            chart.ChartAreas[0].AxisX.Minimum = -1;
            chart.ChartAreas[0].AxisX.Maximum = 1;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 3;
            chart.ChartAreas[0].AlignmentOrientation = AreaAlignmentOrientations.Vertical;
            chart.BackColor = SystemColors.ButtonFace;
        }

        public void VectorChartImage(double[] porcentajeVector, Chart chart, int numberPixels)
        {
            chart.Series["1"].Points.AddXY(1,(porcentajeVector[0]/numberPixels)*100);
            chart.Series["1"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.9"].Points.AddXY(0.9,(porcentajeVector[1]/numberPixels)*100);
            chart.Series["0.9"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.8"].Points.AddXY(0.8, (porcentajeVector[2]/numberPixels)*100);
            chart.Series["0.8"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.7"].Points.AddXY(0.7, (porcentajeVector[3]/numberPixels)*100);
            chart.Series["0.7"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.6"].Points.AddXY(0.6, (porcentajeVector[4]/numberPixels)*100);
            chart.Series["0.6"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.5"].Points.AddXY(0.5, (porcentajeVector[5]/numberPixels)*100);
            chart.Series["0.5"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.4"].Points.AddXY(0.4, (porcentajeVector[6]/numberPixels)*100);
            chart.Series["0.4"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.3"].Points.AddXY(0.3, (porcentajeVector[7]/numberPixels)*100);
            chart.Series["0.3"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.2"].Points.AddXY(0.2, (porcentajeVector[8]/numberPixels)*100);
            chart.Series["0.2"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.1"].Points.AddXY(0.1, (porcentajeVector[9]/numberPixels)*100);
            chart.Series["0.1"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["0.0"].Points.AddXY(0.0, (porcentajeVector[10]/numberPixels)*100);
            chart.Series["0.0"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.1"].Points.AddXY(-0.1, (porcentajeVector[11]/numberPixels)*100);
            chart.Series["-0.1"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.2"].Points.AddXY(-0.2, (porcentajeVector[12]/numberPixels)*100);
            chart.Series["-0.2"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.3"].Points.AddXY(-0.3, (porcentajeVector[13]/numberPixels)*100);
            chart.Series["-0.3"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.4"].Points.AddXY(-0.4, (porcentajeVector[14]/numberPixels)*100);
            chart.Series["-0.4"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.5"].Points.AddXY(-0.5, (porcentajeVector[15]/numberPixels)*100);
            chart.Series["-0.5"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.6"].Points.AddXY(-0.6, (porcentajeVector[16]/numberPixels)*100);
            chart.Series["-0.6"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.7"].Points.AddXY(-0.7, (porcentajeVector[17]/numberPixels)*100);
            chart.Series["-0.7"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.8"].Points.AddXY(-0.8, (porcentajeVector[18]/numberPixels)*100);
            chart.Series["-0.8"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-0.9"].Points.AddXY(-0.9, (porcentajeVector[19]/numberPixels)*100);
            chart.Series["-0.9"].ToolTip = "Valor: #VAL{0.0} %";
            chart.Series["-1"].Points.AddXY(-1, (porcentajeVector[20]/numberPixels)*100);
            chart.Series["-1"].ToolTip = "Valor: #VAL{0.0} %";

            
        }
        public static Color HexToColor(string hexString)
        {
            //replace # occurences
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
