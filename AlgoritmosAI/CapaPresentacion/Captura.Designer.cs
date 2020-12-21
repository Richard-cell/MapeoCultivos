namespace CapaPresentacion
{
    partial class Captura
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
            this.encenderBtn = new System.Windows.Forms.Button();
            this.tomarFotoBtn = new System.Windows.Forms.Button();
            this.fotoPicture = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.procesarBtn = new System.Windows.Forms.Button();
            this.tomadaPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // encenderBtn
            // 
            this.encenderBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.encenderBtn.FlatAppearance.BorderSize = 0;
            this.encenderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encenderBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encenderBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.encenderBtn.Location = new System.Drawing.Point(400, 26);
            this.encenderBtn.Name = "encenderBtn";
            this.encenderBtn.Size = new System.Drawing.Size(163, 23);
            this.encenderBtn.TabIndex = 0;
            this.encenderBtn.Text = "Encender camara";
            this.encenderBtn.UseVisualStyleBackColor = false;
            this.encenderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tomarFotoBtn
            // 
            this.tomarFotoBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.tomarFotoBtn.FlatAppearance.BorderSize = 0;
            this.tomarFotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomarFotoBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.tomarFotoBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tomarFotoBtn.Location = new System.Drawing.Point(191, 359);
            this.tomarFotoBtn.Name = "tomarFotoBtn";
            this.tomarFotoBtn.Size = new System.Drawing.Size(170, 52);
            this.tomarFotoBtn.TabIndex = 1;
            this.tomarFotoBtn.Text = "Tomar foto";
            this.tomarFotoBtn.UseVisualStyleBackColor = false;
            this.tomarFotoBtn.Click += new System.EventHandler(this.tomarFotoBtn_Click);
            // 
            // fotoPicture
            // 
            this.fotoPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPicture.Location = new System.Drawing.Point(15, 55);
            this.fotoPicture.Name = "fotoPicture";
            this.fotoPicture.Size = new System.Drawing.Size(346, 298);
            this.fotoPicture.TabIndex = 2;
            this.fotoPicture.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // procesarBtn
            // 
            this.procesarBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.procesarBtn.FlatAppearance.BorderSize = 0;
            this.procesarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procesarBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.procesarBtn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.procesarBtn.Location = new System.Drawing.Point(367, 359);
            this.procesarBtn.Name = "procesarBtn";
            this.procesarBtn.Size = new System.Drawing.Size(170, 52);
            this.procesarBtn.TabIndex = 5;
            this.procesarBtn.Text = "Listo";
            this.procesarBtn.UseVisualStyleBackColor = false;
            this.procesarBtn.Click += new System.EventHandler(this.procesarBtn_Click);
            // 
            // tomadaPicture
            // 
            this.tomadaPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tomadaPicture.Location = new System.Drawing.Point(367, 55);
            this.tomadaPicture.Name = "tomadaPicture";
            this.tomadaPicture.Size = new System.Drawing.Size(346, 298);
            this.tomadaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tomadaPicture.TabIndex = 6;
            this.tomadaPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(703, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Captura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tomadaPicture);
            this.Controls.Add(this.procesarBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fotoPicture);
            this.Controls.Add(this.tomarFotoBtn);
            this.Controls.Add(this.encenderBtn);
            this.Name = "Captura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomar foto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Captura_FormClosed);
            this.Load += new System.EventHandler(this.Captura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encenderBtn;
        private System.Windows.Forms.Button tomarFotoBtn;
        private System.Windows.Forms.PictureBox fotoPicture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button procesarBtn;
        private System.Windows.Forms.PictureBox tomadaPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}