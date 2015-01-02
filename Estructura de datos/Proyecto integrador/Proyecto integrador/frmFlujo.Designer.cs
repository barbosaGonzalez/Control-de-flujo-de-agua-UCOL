namespace Proyecto_integrador
{
    partial class frmFlujo
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
            this.txtMostrarGuardar = new System.Windows.Forms.TextBox();
            this.txtMostrarSensor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMostrarGuardar
            // 
            this.txtMostrarGuardar.Font = new System.Drawing.Font("Bodoni MT", 12F);
            this.txtMostrarGuardar.Location = new System.Drawing.Point(16, 59);
            this.txtMostrarGuardar.Multiline = true;
            this.txtMostrarGuardar.Name = "txtMostrarGuardar";
            this.txtMostrarGuardar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarGuardar.Size = new System.Drawing.Size(598, 319);
            this.txtMostrarGuardar.TabIndex = 49;
            // 
            // txtMostrarSensor
            // 
            this.txtMostrarSensor.Enabled = false;
            this.txtMostrarSensor.Font = new System.Drawing.Font("Bodoni MT", 12F);
            this.txtMostrarSensor.Location = new System.Drawing.Point(16, 15);
            this.txtMostrarSensor.Name = "txtMostrarSensor";
            this.txtMostrarSensor.Size = new System.Drawing.Size(129, 27);
            this.txtMostrarSensor.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_integrador.Properties.Resources.DiLogo_ico;
            this.pictureBox1.Location = new System.Drawing.Point(568, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(172, 15);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(85, 27);
            this.btnConectar.TabIndex = 51;
            this.btnConectar.Text = "&Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(263, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 27);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmFlujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(628, 384);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMostrarGuardar);
            this.Controls.Add(this.txtMostrarSensor);
            this.Name = "frmFlujo";
            this.Text = "frmFlujo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrarGuardar;
        private System.Windows.Forms.TextBox txtMostrarSensor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}