
namespace CapaPresentacion
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finalImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cargarImagenBtn = new System.Windows.Forms.Button();
            this.restablecerBtn = new System.Windows.Forms.Button();
            this.procesarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.informeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardarImagenBtn = new System.Windows.Forms.Button();
            this.barraImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estadisticaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.estadoVegetacionGroup = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medioOpticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaChart)).BeginInit();
            this.estadoVegetacionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImage.Location = new System.Drawing.Point(25, 37);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(314, 319);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imagen original.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(466, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imagen final.";
            // 
            // finalImage
            // 
            this.finalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalImage.Location = new System.Drawing.Point(345, 37);
            this.finalImage.Name = "finalImage";
            this.finalImage.Size = new System.Drawing.Size(314, 279);
            this.finalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalImage.TabIndex = 2;
            this.finalImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(474, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAPEO DE CULTIVOS";
            // 
            // cargarImagenBtn
            // 
            this.cargarImagenBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.cargarImagenBtn.FlatAppearance.BorderSize = 0;
            this.cargarImagenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarImagenBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarImagenBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cargarImagenBtn.Location = new System.Drawing.Point(665, 36);
            this.cargarImagenBtn.Name = "cargarImagenBtn";
            this.cargarImagenBtn.Size = new System.Drawing.Size(212, 81);
            this.cargarImagenBtn.TabIndex = 6;
            this.cargarImagenBtn.Text = "Cargar imagen";
            this.cargarImagenBtn.UseVisualStyleBackColor = false;
            this.cargarImagenBtn.Click += new System.EventHandler(this.cargarImagenBtn_Click);
            // 
            // restablecerBtn
            // 
            this.restablecerBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.restablecerBtn.FlatAppearance.BorderSize = 0;
            this.restablecerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restablecerBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restablecerBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.restablecerBtn.Location = new System.Drawing.Point(665, 123);
            this.restablecerBtn.Name = "restablecerBtn";
            this.restablecerBtn.Size = new System.Drawing.Size(212, 50);
            this.restablecerBtn.TabIndex = 7;
            this.restablecerBtn.Text = "Restablecer";
            this.restablecerBtn.UseVisualStyleBackColor = false;
            this.restablecerBtn.Click += new System.EventHandler(this.restablecerBtn_Click);
            // 
            // procesarBtn
            // 
            this.procesarBtn.BackColor = System.Drawing.Color.LightGreen;
            this.procesarBtn.FlatAppearance.BorderSize = 0;
            this.procesarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procesarBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesarBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.procesarBtn.Location = new System.Drawing.Point(665, 179);
            this.procesarBtn.Name = "procesarBtn";
            this.procesarBtn.Size = new System.Drawing.Size(212, 48);
            this.procesarBtn.TabIndex = 8;
            this.procesarBtn.Text = "Procesar imagen";
            this.procesarBtn.UseVisualStyleBackColor = false;
            this.procesarBtn.Click += new System.EventHandler(this.procesarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.informeBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.procesarBtn);
            this.groupBox1.Controls.Add(this.guardarImagenBtn);
            this.groupBox1.Controls.Add(this.barraImage);
            this.groupBox1.Controls.Add(this.cargarImagenBtn);
            this.groupBox1.Controls.Add(this.originalImage);
            this.groupBox1.Controls.Add(this.restablecerBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.finalImage);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 370);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesamiento.";
            // 
            // informeBtn
            // 
            this.informeBtn.BackColor = System.Drawing.Color.LightGreen;
            this.informeBtn.FlatAppearance.BorderSize = 0;
            this.informeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informeBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informeBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.informeBtn.Location = new System.Drawing.Point(665, 322);
            this.informeBtn.Name = "informeBtn";
            this.informeBtn.Size = new System.Drawing.Size(212, 34);
            this.informeBtn.TabIndex = 14;
            this.informeBtn.Text = "Informe detallado";
            this.informeBtn.UseVisualStyleBackColor = false;
            this.informeBtn.Click += new System.EventHandler(this.informeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(490, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "VARI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(606, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(393, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "1";
            // 
            // guardarImagenBtn
            // 
            this.guardarImagenBtn.BackColor = System.Drawing.Color.LightGreen;
            this.guardarImagenBtn.FlatAppearance.BorderSize = 0;
            this.guardarImagenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarImagenBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarImagenBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.guardarImagenBtn.Location = new System.Drawing.Point(665, 266);
            this.guardarImagenBtn.Name = "guardarImagenBtn";
            this.guardarImagenBtn.Size = new System.Drawing.Size(212, 50);
            this.guardarImagenBtn.TabIndex = 9;
            this.guardarImagenBtn.Text = "Guardar Imagen";
            this.guardarImagenBtn.UseVisualStyleBackColor = false;
            this.guardarImagenBtn.Click += new System.EventHandler(this.guardarImagenBtn_Click);
            // 
            // barraImage
            // 
            this.barraImage.Image = ((System.Drawing.Image)(resources.GetObject("barraImage.Image")));
            this.barraImage.InitialImage = null;
            this.barraImage.Location = new System.Drawing.Point(414, 322);
            this.barraImage.Name = "barraImage";
            this.barraImage.Size = new System.Drawing.Size(186, 34);
            this.barraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barraImage.TabIndex = 10;
            this.barraImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.estadisticaChart);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1331, 269);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafica de barras.";
            // 
            // estadisticaChart
            // 
            this.estadisticaChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea3.Name = "ChartArea1";
            this.estadisticaChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.estadisticaChart.Legends.Add(legend3);
            this.estadisticaChart.Location = new System.Drawing.Point(6, 19);
            this.estadisticaChart.Name = "estadisticaChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.estadisticaChart.Series.Add(series3);
            this.estadisticaChart.Size = new System.Drawing.Size(1307, 243);
            this.estadisticaChart.TabIndex = 0;
            this.estadisticaChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Indice VARI";
            this.estadisticaChart.Titles.Add(title3);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // estadoVegetacionGroup
            // 
            this.estadoVegetacionGroup.Controls.Add(this.pictureBox2);
            this.estadoVegetacionGroup.Controls.Add(this.pictureBox1);
            this.estadoVegetacionGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.estadoVegetacionGroup.Location = new System.Drawing.Point(922, 46);
            this.estadoVegetacionGroup.Name = "estadoVegetacionGroup";
            this.estadoVegetacionGroup.Size = new System.Drawing.Size(421, 370);
            this.estadoVegetacionGroup.TabIndex = 11;
            this.estadoVegetacionGroup.TabStop = false;
            this.estadoVegetacionGroup.Text = "Estado de la vegetación.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medioOpticoToolStripMenuItem,
            this.entrenamientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medioOpticoToolStripMenuItem
            // 
            this.medioOpticoToolStripMenuItem.Name = "medioOpticoToolStripMenuItem";
            this.medioOpticoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.medioOpticoToolStripMenuItem.Text = "Medio optico";
            this.medioOpticoToolStripMenuItem.Click += new System.EventHandler(this.medioOpticoToolStripMenuItem_Click);
            // 
            // entrenamientoToolStripMenuItem
            // 
            this.entrenamientoToolStripMenuItem.Name = "entrenamientoToolStripMenuItem";
            this.entrenamientoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.entrenamientoToolStripMenuItem.Text = "Entrenamiento";
            this.entrenamientoToolStripMenuItem.Click += new System.EventHandler(this.entrenamientoToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(436, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(666, 234);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(211, 23);
            this.progressBar.TabIndex = 15;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1355, 720);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.estadoVegetacionGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapeo de cultivos v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barraImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaChart)).EndInit();
            this.estadoVegetacionGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox finalImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cargarImagenBtn;
        private System.Windows.Forms.Button restablecerBtn;
        private System.Windows.Forms.Button procesarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button guardarImagenBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart estadisticaChart;
        private System.Windows.Forms.PictureBox barraImage;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox estadoVegetacionGroup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button informeBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medioOpticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenamientoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}