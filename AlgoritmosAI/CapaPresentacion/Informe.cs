using CapaPresentacion.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Informe : Form
    {
        private ChartControl _chartControl;
        private DataGridViewControl _dataGrid;
        private Form _mainForm;
        private int _numberPixel;
        private double[] porcentaje;
        public Informe(double[] vector, Form main, int pixels)
        {
            InitializeComponent();
            porcentaje = vector;
            _numberPixel = pixels;
            _mainForm = main;
            _chartControl = new ChartControl();
            _dataGrid = new DataGridViewControl();
            _dataGrid.VectorToDataGridViewV2(vector,informeDataGrid,"VARI",pixels);
            RealizarSugerencias();
        }

        private void Informe_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Enabled = true;
            this.Dispose();
        }
        private void RealizarSugerencias()
        {
            double densidadVegetacionSaludable=0;
            for (int i = 0; i < 8; i++)
            {
                densidadVegetacionSaludable += porcentaje[i];
            }
            double densidadVegetacionEnferma = ((_numberPixel - densidadVegetacionSaludable) / _numberPixel) * 100;
            densidadVegetacionSaludable = (densidadVegetacionSaludable / _numberPixel) * 100;
            densidadVegetacionEnferma = Math.Truncate(10*(densidadVegetacionEnferma))/10;
            densidadVegetacionSaludable = Math.Truncate(10*(densidadVegetacionSaludable)) / 10;
            if (densidadVegetacionSaludable>densidadVegetacionEnferma)
            {
                infoLabel.Text = $"-La densidad promedio de la vegetación saludable es del {densidadVegetacionSaludable} % \r\n" +
                    $"-La densidad promedio de la vegetación enferma o de zonas sin vegetación es del {densidadVegetacionEnferma} % \r\n" +
                    $"-Momentaneamente posee una gran densidad de vegtación.";
            }
            else
            {
                infoLabel.Text = $"-La densidad promedio de la vegetación saludable es del {densidadVegetacionSaludable} % \r\n" +
                    $"-La densidad promedio de la vegetación enferma o de zonas sin vegetación es del {densidadVegetacionEnferma} % \r\n" +
                    $"-Considere plantar un mayor numero de plantas en las zonas que no poseen vegetación. \r\n" +
                    $"-Aumente el numero de horas que se le dedica al riego del cultivo.";
            }
        }
    }
}
