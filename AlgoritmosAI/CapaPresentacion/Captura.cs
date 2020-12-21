using AForge.Video;
using AForge.Video.DirectShow;
using CapaApplication;
using CapaInfrastructure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Captura : Form
    {
        private string Paht = @"C:\Users\CJCALVO\Desktop\MapeoCultivos\AlgoritmosAI\CapaPresentacion\imagenes\";
        private string _paht1 = @"C:\Users\usuario\Desktop\richardv3\IA\MAPEO CULTIVOS\Mapeo\";
        private bool _isDispositivo;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        private MainUI mainForm;
        ProcessImageService pis = new ProcessImageService(new DataImage(), new DataFileTxt());

        public Captura(MainUI form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Captura_Load(object sender, EventArgs e)
        {
            CargaDispositivos();
        }

        public void CargaDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(MisDispositivos.Count > 0)
            {
                _isDispositivo = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                    comboBox1.Text = MisDispositivos[0].Name.ToString();                
            }
            else
            {
                _isDispositivo = false;
            }
        }

        private void CerrarWebcam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarWebcam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();

        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            fotoPicture.Image = Imagen;
        }

        private void Captura_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebcam();
            mainForm.Enabled = true;
        }

        public static Bitmap RedimensionarImagen(Image imagenOriginal, int width, int height)
        {
            var Radio = Math.Max((double)width / imagenOriginal.Width, (double)height / imagenOriginal.Height);
            var NuevoAncho = (int)(imagenOriginal.Width * Radio);
            var NuevoAlto = (int)(imagenOriginal.Height * Radio);
            var ImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            Graphics.FromImage(ImagenRedimencionada).DrawImage(imagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            Bitmap ImagenFinal = new Bitmap(ImagenRedimencionada);

            return ImagenFinal;

        }

        private void procesarBtn_Click(object sender, EventArgs e)
        {
            if (tomadaPicture.Image!=null)
            {
                CerrarWebcam();
                mainForm.SetOriginalImage((Bitmap)tomadaPicture.Image, (Bitmap)pictureBox1.Image, _paht1);
                mainForm.Enabled = true;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("¡TOME UNA FOTO!");
            }
            
        }

        private void tomarFotoBtn_Click(object sender, EventArgs e)
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                tomadaPicture.Image = fotoPicture.Image;
                pictureBox1.Image = fotoPicture.Image;
                Bitmap bmp = new Bitmap(RedimensionarImagen(fotoPicture.Image, 200, 200));
                Bitmap bmp2 = new Bitmap(RedimensionarImagen(fotoPicture.Image, 200, 200));
                tomadaPicture.Image = bmp;
                pictureBox1.Image = bmp2;
            }
            else
            {
                MessageBox.Show("¡ENCIENDA LA CAMARA!");
            }
        }
    }
}
