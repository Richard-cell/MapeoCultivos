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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void multilayerBtn_Click(object sender, EventArgs e)
        {
            /*MulticapaUI form = new MulticapaUI(this);
            form.Visible = true;
            this.Visible = false;]*/
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Entrenamiento form = new Entrenamiento(this);
            form.Visible = true;
            this.Visible = false;
        }
    }
}
