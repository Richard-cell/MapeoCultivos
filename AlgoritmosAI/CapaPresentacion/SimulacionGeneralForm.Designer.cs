namespace CapaPresentacion
{
    partial class SimulacionGeneralForm
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
            this.patronDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.simularBtn = new System.Windows.Forms.Button();
            this.salidaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cargarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patronDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // patronDataGrid
            // 
            this.patronDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronDataGrid.Location = new System.Drawing.Point(92, 67);
            this.patronDataGrid.Name = "patronDataGrid";
            this.patronDataGrid.Size = new System.Drawing.Size(392, 65);
            this.patronDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Simulacion: General";
            // 
            // simularBtn
            // 
            this.simularBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.simularBtn.Location = new System.Drawing.Point(141, 241);
            this.simularBtn.Name = "simularBtn";
            this.simularBtn.Size = new System.Drawing.Size(267, 56);
            this.simularBtn.TabIndex = 40;
            this.simularBtn.Text = "Simular";
            this.simularBtn.UseVisualStyleBackColor = true;
            this.simularBtn.Click += new System.EventHandler(this.simularBtn_Click);
            // 
            // salidaTxt
            // 
            this.salidaTxt.Enabled = false;
            this.salidaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaTxt.Location = new System.Drawing.Point(84, 154);
            this.salidaTxt.Name = "salidaTxt";
            this.salidaTxt.Size = new System.Drawing.Size(505, 26);
            this.salidaTxt.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Salida/s:";
            // 
            // cargarBtn
            // 
            this.cargarBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.cargarBtn.Location = new System.Drawing.Point(143, 186);
            this.cargarBtn.Name = "cargarBtn";
            this.cargarBtn.Size = new System.Drawing.Size(267, 49);
            this.cargarBtn.TabIndex = 47;
            this.cargarBtn.Text = "Cargar Archivo";
            this.cargarBtn.UseVisualStyleBackColor = true;
            this.cargarBtn.Click += new System.EventHandler(this.cargarBtn_Click);
            // 
            // SimulacionGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 331);
            this.Controls.Add(this.cargarBtn);
            this.Controls.Add(this.salidaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simularBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patronDataGrid);
            this.Name = "SimulacionGeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulacionGeneralForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulacionGeneralForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.patronDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patronDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simularBtn;
        private System.Windows.Forms.TextBox salidaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cargarBtn;
    }
}