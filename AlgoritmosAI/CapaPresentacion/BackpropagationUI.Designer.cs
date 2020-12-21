namespace CapaPresentacion
{
    partial class Entrenamiento
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.iteracionLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.entrenarBtn = new System.Windows.Forms.Button();
            this.graficaErrorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vectorIteracionesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nIteracionesInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorMaximoInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rataInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MatrizInicialDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fActivacionCapSalida = new System.Windows.Forms.ComboBox();
            this.fActivacionCap3 = new System.Windows.Forms.ComboBox();
            this.fActivacionCap2 = new System.Windows.Forms.ComboBox();
            this.fActivacionCap1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nNeuronasCap3 = new System.Windows.Forms.TextBox();
            this.nNeuronasCap2 = new System.Windows.Forms.TextBox();
            this.nNeuronasCap1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nCapasComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restablecerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.nSalidasInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nPatronesInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nEntradasInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulaciónGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerGraficaError = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaErrorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorIteracionesDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrizInicialDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.errorLabel);
            this.groupBox5.Controls.Add(this.iteracionLabel);
            this.groupBox5.Controls.Add(this.stopBtn);
            this.groupBox5.Controls.Add(this.entrenarBtn);
            this.groupBox5.Controls.Add(this.graficaErrorChart);
            this.groupBox5.Controls.Add(this.vectorIteracionesDataGridView);
            this.groupBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 290);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(913, 252);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Entrenamiento.";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(605, 38);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(60, 20);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "Error:";
            // 
            // iteracionLabel
            // 
            this.iteracionLabel.AutoSize = true;
            this.iteracionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteracionLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.iteracionLabel.Location = new System.Drawing.Point(420, 38);
            this.iteracionLabel.Name = "iteracionLabel";
            this.iteracionLabel.Size = new System.Drawing.Size(99, 20);
            this.iteracionLabel.TabIndex = 12;
            this.iteracionLabel.Text = "Iteracion:";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.stopBtn.Location = new System.Drawing.Point(232, 20);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(80, 50);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // entrenarBtn
            // 
            this.entrenarBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.entrenarBtn.FlatAppearance.BorderSize = 0;
            this.entrenarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrenarBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrenarBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.entrenarBtn.Location = new System.Drawing.Point(11, 20);
            this.entrenarBtn.Name = "entrenarBtn";
            this.entrenarBtn.Size = new System.Drawing.Size(215, 50);
            this.entrenarBtn.TabIndex = 7;
            this.entrenarBtn.Text = "Entrenar";
            this.entrenarBtn.UseVisualStyleBackColor = false;
            this.entrenarBtn.Click += new System.EventHandler(this.entrenarBtn_Click);
            // 
            // graficaErrorChart
            // 
            chartArea1.Name = "ChartArea1";
            this.graficaErrorChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficaErrorChart.Legends.Add(legend1);
            this.graficaErrorChart.Location = new System.Drawing.Point(318, 76);
            this.graficaErrorChart.Name = "graficaErrorChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficaErrorChart.Series.Add(series1);
            this.graficaErrorChart.Size = new System.Drawing.Size(589, 167);
            this.graficaErrorChart.TabIndex = 1;
            this.graficaErrorChart.Text = "chart1";
            // 
            // vectorIteracionesDataGridView
            // 
            this.vectorIteracionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorIteracionesDataGridView.Location = new System.Drawing.Point(11, 76);
            this.vectorIteracionesDataGridView.Name = "vectorIteracionesDataGridView";
            this.vectorIteracionesDataGridView.Size = new System.Drawing.Size(301, 167);
            this.vectorIteracionesDataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nIteracionesInput);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.errorMaximoInput);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.rataInput);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 58);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de entrenamiento.";
            // 
            // nIteracionesInput
            // 
            this.nIteracionesInput.Location = new System.Drawing.Point(742, 21);
            this.nIteracionesInput.Name = "nIteracionesInput";
            this.nIteracionesInput.Size = new System.Drawing.Size(76, 21);
            this.nIteracionesInput.TabIndex = 11;
            this.nIteracionesInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nIteracionesInput_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "N° Iteraciones:";
            // 
            // errorMaximoInput
            // 
            this.errorMaximoInput.Location = new System.Drawing.Point(442, 24);
            this.errorMaximoInput.Name = "errorMaximoInput";
            this.errorMaximoInput.Size = new System.Drawing.Size(76, 21);
            this.errorMaximoInput.TabIndex = 9;
            this.errorMaximoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.errorMaximoInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Error maximo:";
            // 
            // rataInput
            // 
            this.rataInput.Location = new System.Drawing.Point(137, 26);
            this.rataInput.Name = "rataInput";
            this.rataInput.Size = new System.Drawing.Size(76, 21);
            this.rataInput.TabIndex = 7;
            this.rataInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rataInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rata aprendizaje:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MatrizInicialDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(216, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 202);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matriz Inicial.";
            // 
            // MatrizInicialDataGridView
            // 
            this.MatrizInicialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrizInicialDataGridView.Location = new System.Drawing.Point(6, 20);
            this.MatrizInicialDataGridView.Name = "MatrizInicialDataGridView";
            this.MatrizInicialDataGridView.Size = new System.Drawing.Size(239, 176);
            this.MatrizInicialDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fActivacionCapSalida);
            this.groupBox2.Controls.Add(this.fActivacionCap3);
            this.groupBox2.Controls.Add(this.fActivacionCap2);
            this.groupBox2.Controls.Add(this.fActivacionCap1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nNeuronasCap3);
            this.groupBox2.Controls.Add(this.nNeuronasCap2);
            this.groupBox2.Controls.Add(this.nNeuronasCap1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nCapasComboBox);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(473, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 202);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración.";
            // 
            // fActivacionCapSalida
            // 
            this.fActivacionCapSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fActivacionCapSalida.FormattingEnabled = true;
            this.fActivacionCapSalida.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Sinusoidal",
            "Tangente",
            "Lineal"});
            this.fActivacionCapSalida.Location = new System.Drawing.Point(214, 157);
            this.fActivacionCapSalida.Name = "fActivacionCapSalida";
            this.fActivacionCapSalida.Size = new System.Drawing.Size(125, 23);
            this.fActivacionCapSalida.TabIndex = 22;
            // 
            // fActivacionCap3
            // 
            this.fActivacionCap3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fActivacionCap3.Enabled = false;
            this.fActivacionCap3.FormattingEnabled = true;
            this.fActivacionCap3.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Sinusoidal",
            "Tangente"});
            this.fActivacionCap3.Location = new System.Drawing.Point(325, 110);
            this.fActivacionCap3.Name = "fActivacionCap3";
            this.fActivacionCap3.Size = new System.Drawing.Size(125, 23);
            this.fActivacionCap3.TabIndex = 21;
            // 
            // fActivacionCap2
            // 
            this.fActivacionCap2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fActivacionCap2.Enabled = false;
            this.fActivacionCap2.FormattingEnabled = true;
            this.fActivacionCap2.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Sinusoidal",
            "Tangente"});
            this.fActivacionCap2.Location = new System.Drawing.Point(325, 84);
            this.fActivacionCap2.Name = "fActivacionCap2";
            this.fActivacionCap2.Size = new System.Drawing.Size(125, 23);
            this.fActivacionCap2.TabIndex = 20;
            // 
            // fActivacionCap1
            // 
            this.fActivacionCap1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fActivacionCap1.Enabled = false;
            this.fActivacionCap1.FormattingEnabled = true;
            this.fActivacionCap1.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Sinusoidal",
            "Tangente"});
            this.fActivacionCap1.Location = new System.Drawing.Point(325, 57);
            this.fActivacionCap1.Name = "fActivacionCap1";
            this.fActivacionCap1.Size = new System.Drawing.Size(125, 23);
            this.fActivacionCap1.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "F.Activacion capa salida:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(223, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "F.Activacion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "F.Activacion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "F.Activacion:";
            // 
            // nNeuronasCap3
            // 
            this.nNeuronasCap3.Enabled = false;
            this.nNeuronasCap3.Location = new System.Drawing.Point(159, 110);
            this.nNeuronasCap3.Name = "nNeuronasCap3";
            this.nNeuronasCap3.Size = new System.Drawing.Size(58, 21);
            this.nNeuronasCap3.TabIndex = 14;
            this.nNeuronasCap3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nNeuronasCap3_KeyPress);
            // 
            // nNeuronasCap2
            // 
            this.nNeuronasCap2.Enabled = false;
            this.nNeuronasCap2.Location = new System.Drawing.Point(159, 84);
            this.nNeuronasCap2.Name = "nNeuronasCap2";
            this.nNeuronasCap2.Size = new System.Drawing.Size(58, 21);
            this.nNeuronasCap2.TabIndex = 13;
            this.nNeuronasCap2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nNeuronasCap2_KeyPress);
            // 
            // nNeuronasCap1
            // 
            this.nNeuronasCap1.Enabled = false;
            this.nNeuronasCap1.Location = new System.Drawing.Point(159, 57);
            this.nNeuronasCap1.Name = "nNeuronasCap1";
            this.nNeuronasCap1.Size = new System.Drawing.Size(58, 21);
            this.nNeuronasCap1.TabIndex = 12;
            this.nNeuronasCap1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nNeuronasCap1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "N° Neuronas Capa 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "N° Neuronas Capa 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "N° Neuronas Capa 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingrese nCapas:";
            // 
            // nCapasComboBox
            // 
            this.nCapasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nCapasComboBox.FormattingEnabled = true;
            this.nCapasComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.nCapasComboBox.Location = new System.Drawing.Point(214, 23);
            this.nCapasComboBox.Name = "nCapasComboBox";
            this.nCapasComboBox.Size = new System.Drawing.Size(125, 23);
            this.nCapasComboBox.TabIndex = 0;
            this.nCapasComboBox.Tag = "";
            this.nCapasComboBox.SelectedIndexChanged += new System.EventHandler(this.nCapasComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restablecerBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCargarArchivo);
            this.groupBox1.Controls.Add(this.nSalidasInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nPatronesInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nEntradasInput);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar datos.";
            // 
            // restablecerBtn
            // 
            this.restablecerBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.restablecerBtn.FlatAppearance.BorderSize = 0;
            this.restablecerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restablecerBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.restablecerBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.restablecerBtn.Location = new System.Drawing.Point(10, 160);
            this.restablecerBtn.Name = "restablecerBtn";
            this.restablecerBtn.Size = new System.Drawing.Size(179, 27);
            this.restablecerBtn.TabIndex = 7;
            this.restablecerBtn.Text = "Restablecer";
            this.restablecerBtn.UseVisualStyleBackColor = false;
            this.restablecerBtn.Click += new System.EventHandler(this.restablecerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "nEntradas:";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCargarArchivo.Location = new System.Drawing.Point(11, 104);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(179, 50);
            this.btnCargarArchivo.TabIndex = 3;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // nSalidasInput
            // 
            this.nSalidasInput.Location = new System.Drawing.Point(113, 78);
            this.nSalidasInput.Name = "nSalidasInput";
            this.nSalidasInput.ReadOnly = true;
            this.nSalidasInput.Size = new System.Drawing.Size(76, 21);
            this.nSalidasInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nPatrones:";
            // 
            // nPatronesInput
            // 
            this.nPatronesInput.Location = new System.Drawing.Point(113, 52);
            this.nPatronesInput.Name = "nPatronesInput";
            this.nPatronesInput.ReadOnly = true;
            this.nPatronesInput.Size = new System.Drawing.Size(76, 21);
            this.nPatronesInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nSalidas:";
            // 
            // nEntradasInput
            // 
            this.nEntradasInput.Location = new System.Drawing.Point(113, 26);
            this.nEntradasInput.Name = "nEntradasInput";
            this.nEntradasInput.ReadOnly = true;
            this.nEntradasInput.Size = new System.Drawing.Size(76, 21);
            this.nEntradasInput.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulaciónGeneralToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulaciónGeneralToolStripMenuItem
            // 
            this.simulaciónGeneralToolStripMenuItem.Name = "simulaciónGeneralToolStripMenuItem";
            this.simulaciónGeneralToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.simulaciónGeneralToolStripMenuItem.Text = "Simulación General";
            this.simulaciónGeneralToolStripMenuItem.Click += new System.EventHandler(this.simulaciónGeneralToolStripMenuItem_Click);
            // 
            // timerGraficaError
            // 
            this.timerGraficaError.Tick += new System.EventHandler(this.timerGraficaError_Tick);
            // 
            // Entrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Entrenamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenamiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackpropagationUI_FormClosed);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficaErrorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorIteracionesDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrizInicialDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button entrenarBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaErrorChart;
        private System.Windows.Forms.DataGridView vectorIteracionesDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox nIteracionesInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox errorMaximoInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rataInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView MatrizInicialDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox fActivacionCapSalida;
        private System.Windows.Forms.ComboBox fActivacionCap3;
        private System.Windows.Forms.ComboBox fActivacionCap2;
        private System.Windows.Forms.ComboBox fActivacionCap1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nNeuronasCap3;
        private System.Windows.Forms.TextBox nNeuronasCap2;
        private System.Windows.Forms.TextBox nNeuronasCap1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nCapasComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button restablecerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.TextBox nSalidasInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nPatronesInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nEntradasInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulaciónGeneralToolStripMenuItem;
        private System.Windows.Forms.Timer timerGraficaError;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label iteracionLabel;
    }
}