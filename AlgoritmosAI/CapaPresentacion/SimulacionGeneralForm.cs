using CapaApplication;
using CapaPresentacion.Base;
using System;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SimulacionGeneralForm : Form
    {
        private IService _service;
        private Form _form;
        private DataGridViewControl gridControl = new DataGridViewControl();
        private int nSalidas=0;
        private double[] vector;

        string path = "";
        string filePath = "";
        public SimulacionGeneralForm(Form form, IService service)
        {
            InitializeComponent();
            _service = service;
            _form = form;
        }

        private void simularBtn_Click(object sender, EventArgs e)
        {
            salidaTxt.Text = "";
            if (nSalidas!=0)
            {
                if (isDecimal())
                {
                    for (int i = 0; i < nSalidas; i++)
                    {
                        if (i != nSalidas - 1)
                        {
                            salidaTxt.Text += ((Math.Truncate(100 * (_service.Simulate(vector, path)[i])))/100).ToString()+"...";
                        }
                        else
                        {
                            salidaTxt.Text += ((Math.Truncate(100 * (_service.Simulate(vector, path)[i]))) / 100).ToString();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < nSalidas; i++)
                    {
                        if (i != nSalidas - 1)
                        {
                            salidaTxt.Text += Math.Round(_service.Simulate(vector, path)[i]).ToString()+";";
                        }
                        else
                        {
                            salidaTxt.Text += Math.Round(_service.Simulate(vector, path)[i]).ToString();
                        }

                    }
                }
            }
        }
        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = Path.GetDirectoryName(openFileDialog.FileName);
                    filePath = openFileDialog.FileName;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private void SimulacionGeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Enabled = true;
        }

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            salidaTxt.Text = "";
            LoadFile();
            if (path.Length > 0)
            {
                vector = _service.GetVector(filePath);
                gridControl.VectorToDataGridView(vector, patronDataGrid, "X");
                nSalidas = _service.GetNOutputFile(path + "\\Configuracion.txt");
            }
            else
            {
                Entrenamiento.ShowDialog("No Se encuentra el archivo de configuración");
            }
        }
        private bool isDecimal()
        {
            bool response = false;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i].ToString().Contains(","))
                {
                    response = true;
                    break;
                }
            }
            return response;
        }
    }
}
