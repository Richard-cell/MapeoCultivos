using CapaApplication;
using CapaInfrastructure;
using CapaPresentacion.Base;
using System;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Entrenamiento : Form
    {
        private BackpropagationService _backService;
        private DataGridViewControl _dataViewControl = new DataGridViewControl();
        private ChartControl _chartControl = new ChartControl();
        private Form _mainForm;
        string path = "";
        int index = 0;
        public Entrenamiento(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            LoadFile();
            if (path.Length > 0)
            {
                _backService = new BackpropagationService(new DataFileTxt(), path);
                _backService.InitMultilayerPerceptron();
                LoadInitData();
            }
        }

        private void nCapasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivateInputsLayers(int.Parse(nCapasComboBox.Text));
        }

        private void entrenarBtn_Click(object sender, EventArgs e)
        {
            if (nEntradasInput.Text.Length == 0)
            {
                ShowDialog("Debe cargar la matriz inicial");
            }
            else if (IsCorrectConfiguration())
            {
                if (IsCorrectDataTrain())
                {
                    var nCapas = int.Parse(nCapasComboBox.Text);
                    var nNeuronasCapa = new int[nCapas + 1];
                    var fActivacionCapa = new string[nCapas];
                    var fActivacionSalida = fActivacionCapSalida.Text;
                    var rata = double.Parse(rataInput.Text);
                    var errorMaximo = double.Parse(errorMaximoInput.Text);
                    var nIteraciones = int.Parse(nIteracionesInput.Text);

                    if (nCapas == 1)
                    {
                        nNeuronasCapa[0] = int.Parse(nNeuronasCap1.Text);
                        nNeuronasCapa[1] = int.Parse(nSalidasInput.Text);
                        fActivacionCapa[0] = fActivacionCap1.Text;
                    }
                    else if (nCapas == 2)
                    {
                        nNeuronasCapa[0] = int.Parse(nNeuronasCap1.Text);
                        nNeuronasCapa[1] = int.Parse(nNeuronasCap2.Text);
                        nNeuronasCapa[2] = int.Parse(nSalidasInput.Text);
                        fActivacionCapa[0] = fActivacionCap1.Text;
                        fActivacionCapa[1] = fActivacionCap2.Text;
                    }
                    else
                    {
                        nNeuronasCapa[0] = int.Parse(nNeuronasCap1.Text);
                        nNeuronasCapa[1] = int.Parse(nNeuronasCap2.Text);
                        nNeuronasCapa[2] = int.Parse(nNeuronasCap3.Text);
                        nNeuronasCapa[3] = int.Parse(nSalidasInput.Text);
                        fActivacionCapa[0] = fActivacionCap1.Text;
                        fActivacionCapa[1] = fActivacionCap2.Text;
                        fActivacionCapa[2] = fActivacionCap3.Text;
                    }

                    _backService.Train(nCapas, nNeuronasCapa, fActivacionCapa, fActivacionSalida, rata, errorMaximo, nIteraciones);
                    _dataViewControl.VectorToDataGridViewError(_backService.GetErrorVector(), vectorIteracionesDataGridView, "Error");
                    _chartControl.InitChartError(graficaErrorChart, "ERROR VS N°ITERACIONES");
                    index = 0;
                    timerGraficaError.Enabled = true;
                }
            }
        }
        public static void ShowDialog(string message)
        {
            var cuadro = MessageBox.Show(message);
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
                    path = openFileDialog.FileName;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private void LoadInitData()
        {
            nEntradasInput.Text = _backService.GetNInputs().ToString();
            nSalidasInput.Text = _backService.GetNOutputs().ToString();
            nPatronesInput.Text = _backService.GetNPatterns().ToString();
            _dataViewControl.MatrizToDataGridView(_backService.InitMatriz(), _backService.GetNInputs(), MatrizInicialDataGridView, "X");
        }
        private void ActivateInputsLayers(int nCapas)
        {
            switch (nCapas)
            {
                case 1:
                    nNeuronasCap2.Enabled = false;
                    fActivacionCap2.Enabled = false;
                    nNeuronasCap3.Enabled = false;
                    fActivacionCap3.Enabled = false;

                    nNeuronasCap1.Enabled = true;
                    fActivacionCap1.Enabled = true;
                    break;
                case 2:
                    nNeuronasCap3.Enabled = false;
                    fActivacionCap3.Enabled = false;

                    nNeuronasCap1.Enabled = true;
                    fActivacionCap1.Enabled = true;
                    nNeuronasCap2.Enabled = true;
                    fActivacionCap2.Enabled = true;
                    break;
                case 3:
                    nNeuronasCap1.Enabled = true;
                    fActivacionCap1.Enabled = true;
                    nNeuronasCap2.Enabled = true;
                    fActivacionCap2.Enabled = true;
                    nNeuronasCap3.Enabled = true;
                    fActivacionCap3.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private bool IsCorrectConfiguration()
        {
            bool var = true;
            if (nCapasComboBox.Text == "")
            {
                ShowDialog("Faltan datos por ingresar, verifique");
                var = false;
            }
            else if (nCapasComboBox.Text == "1")
            {
                if (nNeuronasCap1.Text.Length == 0 || fActivacionCap1.Text == "" || fActivacionCapSalida.Text == "")
                {
                    ShowDialog("Faltan datos por ingresar, verifique");
                    var = false;
                }
            }
            else if (nCapasComboBox.Text == "2")
            {
                if (nNeuronasCap1.Text.Length == 0 || fActivacionCap1.Text == "" || nNeuronasCap2.Text.Length == 0 || fActivacionCap2.Text == "" || fActivacionCapSalida.Text == "")
                {
                    ShowDialog("Faltan datos por ingresar, verifique");
                    var = false;
                }
            }
            else if (nCapasComboBox.Text == "3")
            {
                if (nNeuronasCap1.Text.Length == 0 || fActivacionCap1.Text == "" || nNeuronasCap2.Text.Length == 0 || fActivacionCap2.Text == "" || nNeuronasCap3.Text.Length == 0 || fActivacionCap3.Text == "" || fActivacionCapSalida.Text == "")
                {
                    ShowDialog("Faltan datos por ingresar, verifique");
                    var = false;
                }
            }
            return var;
        }
        private bool IsCorrectDataTrain()
        {
            bool var = true;
            if (rataInput.Text == "" || errorMaximoInput.Text == "" || nIteracionesInput.Text == "")
            {
                ShowDialog("Faltan datos para realizar el entrenamiento");
                var = false;
            }
            return var;
        }

        private void timerGraficaError_Tick(object sender, EventArgs e)
        {
            double errorMaximo = double.Parse(errorMaximoInput.Text);
            string result = _chartControl.VectorToChart(_backService.GetErrorVector(), graficaErrorChart, index, errorMaximo);
            if (result.Equals("Error")) {
                timerGraficaError.Stop();
                timerGraficaError.Enabled = false;
                ShowDialog("El valor del error es demasiado grande, Ajuste la configuracion");
            }
            if (index == int.Parse(nIteracionesInput.Text) - 1 || _backService.GetErrorVector()[index] <= errorMaximo)
            {
                timerGraficaError.Stop();
                timerGraficaError.Enabled = false;
                if (_backService.GetErrorVector()[index] <= errorMaximo)
                {
                    SaveData();
                }
            }
            iteracionLabel.Text = $"Iteracion: {index}";
            errorLabel.Text = $"Error: {_backService.GetErrorVector()[index]}";
            index++;
        }

        private void SaveData()
        {
            try
            {
                _backService.SaveConfiguration(RecalculatePath());
                _backService.SaveMatrizPesos(RecalculatePath());
                _backService.SaveVectorUmbrales(RecalculatePath());
                ShowDialog("SE HAN GUARDADO PESOS Y UMBRALES OPTIMOS");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private string RecalculatePath()
        {
            var line = path.Split(Path.DirectorySeparatorChar);
            var pathNew = "";
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (i == line.Length - 2)
                {
                    pathNew += line[i];
                }
                else
                {
                    pathNew += line[i] + Path.DirectorySeparatorChar;
                }


            }
            return pathNew;
        }

        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nNeuronasCap1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputIntKeyPress(sender, e);
        }

        private void nNeuronasCap2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputIntKeyPress(sender, e);
        }

        private void nNeuronasCap3_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputIntKeyPress(sender, e);
        }

        private void rataInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputDecimalKeyPress(sender, e);
        }

        private void errorMaximoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputDecimalKeyPress(sender, e);
        }

        private void nIteracionesInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControl.InputIntKeyPress(sender, e);
        }

        private void simulacionLetraTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simulaciónSensoresRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simulaciónCircuitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simulaciónResfriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restablecerBtn_Click(object sender, EventArgs e)
        {
            nEntradasInput.Text = "";
            nSalidasInput.Text = "";
            nPatronesInput.Text = "";
            _dataViewControl.RestartDataGridView(MatrizInicialDataGridView);
            _dataViewControl.RestartDataGridView(vectorIteracionesDataGridView);
            nNeuronasCap1.Text = "";
            nNeuronasCap2.Text = "";
            nNeuronasCap3.Text = "";
            rataInput.Text = "";
            errorMaximoInput.Text = "";
            nIteracionesInput.Text = "";
            _chartControl.RestartChart(graficaErrorChart);
        }

        private void simulaciónGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimulacionGeneralForm simulacionForm = new SimulacionGeneralForm(this, new MultilayerPerceptronService(new DataFileTxt()));
            simulacionForm.Visible = true;
            this.Enabled = false;
        }

        private void BackpropagationUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Visible = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (timerGraficaError.Enabled)
            {
                timerGraficaError.Stop();
                timerGraficaError.Enabled = false;
            }
        }
    }
}
