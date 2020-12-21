using CapaApplication;
using CapaInfrastructure;
using CapaPresentacion.Base;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MainUI : Form
    {
        private ProcessImageService _processImageService;
        private ChartControl _chartControl;
        Bitmap finalImageBtm;
        Bitmap originalImageCaptured;
        string path = "";

        int index = 0;
        int nRows = 0;
        int nColumns = 0;

        bool isCaptured = false;
        public MainUI()
        {
            InitializeComponent();
            _chartControl = new ChartControl();
            _processImageService = new ProcessImageService(new DataImage(), new DataFileTxt());
            estadoVegetacionGroup.BackColor = Color.FromArgb(243,253,249);
        }

        private void cargarImagenBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
            if (path.Length > 0)
            {
                isCaptured = false;
                originalImage.Image = _processImageService.OpenImage(path);
                finalImage.Image = null;
                finalImageBtm = (Bitmap)originalImage.Image;
                _chartControl.RestartChart(estadisticaChart);
                progressBar.Value = 0;
            }
        }
        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
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
        private void procesarBtn_Click(object sender, EventArgs e)
        {
            if (originalImage.Image!=null)
            {
                _chartControl.InitChartImage(estadisticaChart, "Porcentaje Indice VARI");
                _processImageService.ApplyIndicator(progressBar,(Bitmap)originalImage.Image, Path.GetDirectoryName(path));
                finalImage.Image = _processImageService.GetFinalImage();
                if (isCaptured==false)
                {
                    originalImage.Image = _processImageService.OpenImage(path);
                }
                else
                {
                    originalImage.Image = originalImageCaptured;
                }
                timerMain.Enabled = true;
                _chartControl.VectorChartImage(_processImageService.GetPercentageByColor(), estadisticaChart, _processImageService.GetNumberPixels());
            }
            else
            {
                MessageBox.Show("CARGUE LA IMAGEN A PROCESAR");
            } 
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            /*if (index < _processImageService.GetNumberPixels())
            {
                finalImageBtm.SetPixel(0, 0, _processImageService.GetFinalImage().GetPixel(0, 0));
                finalImage.Image = finalImageBtm;
                //finalImage.Update();
            }
            else
            {
                timerMain.Stop();
                timerMain.Enabled = false;
            }
            index++;
            nRows++;
            nColumns++;*/
        }
        public void SetOriginalImage(Bitmap image,Bitmap image2, string rute)
        {
            isCaptured = true;
            path = rute;
            originalImageCaptured = image2;
            originalImage.Image = image;
        }
        private void restablecerBtn_Click(object sender, EventArgs e)
        {
            Restablecer();
        }
        public void Restablecer()
        {
            if (originalImage.Image!=null)
            {
                originalImage.Image.Dispose();
                originalImage.Image = null;
                _chartControl.RestartChart(estadisticaChart);
                if (finalImage.Image!=null)
                {
                    finalImage.Image.Dispose();
                    finalImage.Image = null;
                }
                progressBar.Value = 0;
            }
            
        }
        private void guardarImagenBtn_Click(object sender, EventArgs e)
        {
            if (originalImage.Image != null && finalImage.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveFileDialog.Title = "Guardar imagen";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    finalImage.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("SE HA GUARDADO LA IMAGEN CORRECTAMENTE");
                }
            } else if (originalImage.Image == null)
            {
                MessageBox.Show("CARGUE LA IMAGEN A PROCESAR");
            } else if (finalImage.Image == null) 
            {
                MessageBox.Show("DEBE PROCESAR LA IMAGEN");
            }
            
        }

        private void entrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrenamiento backForm = new Entrenamiento(this);
            backForm.Visible = true;
            this.Visible = false;
        }

        private void medioOpticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Captura capturaForm = new Captura(this);
            capturaForm.Visible = true;
            this.Enabled = false;
        }

        private void informeBtn_Click(object sender, EventArgs e)
        {
            if (finalImage.Image!=null)
            {
                Informe informeForm = new Informe(_processImageService.GetPercentageByColor(), this, _processImageService.GetNumberPixels());
                informeForm.Visible = true;
                this.Enabled = false;
            }
        }
    }
}
