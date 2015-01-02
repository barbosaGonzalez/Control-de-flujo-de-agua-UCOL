namespace Proyecto_Grafos_Colima
{
    partial class frmMain
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
            this.btnShow = new System.Windows.Forms.Button();
            this.tbxOutRutes = new System.Windows.Forms.TextBox();
            this.combobxInitialPoint = new System.Windows.Forms.ComboBox();
            this.combobxFinalPoint = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShow.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(304, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(83, 48);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Mostrar Ruta";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxOutRutes
            // 
            this.tbxOutRutes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxOutRutes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutRutes.Location = new System.Drawing.Point(12, 79);
            this.tbxOutRutes.Multiline = true;
            this.tbxOutRutes.Name = "tbxOutRutes";
            this.tbxOutRutes.Size = new System.Drawing.Size(375, 63);
            this.tbxOutRutes.TabIndex = 1;
            // 
            // combobxInitialPoint
            // 
            this.combobxInitialPoint.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combobxInitialPoint.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxInitialPoint.FormattingEnabled = true;
            this.combobxInitialPoint.Items.AddRange(new object[] {
            "Manzanillo",
            "Minatitlán",
            "Comala",
            "Villa de Álvarez",
            "Coquimatlán",
            "Armería",
            "Cuauhtémoc",
            "El Chanal",
            "La Capacha",
            "Colima",
            "Ixtlahuacán",
            "Tecomán"});
            this.combobxInitialPoint.Location = new System.Drawing.Point(14, 14);
            this.combobxInitialPoint.Name = "combobxInitialPoint";
            this.combobxInitialPoint.Size = new System.Drawing.Size(284, 27);
            this.combobxInitialPoint.TabIndex = 3;
            this.combobxInitialPoint.Text = "Elige el origen";
            // 
            // combobxFinalPoint
            // 
            this.combobxFinalPoint.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combobxFinalPoint.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxFinalPoint.FormattingEnabled = true;
            this.combobxFinalPoint.Items.AddRange(new object[] {
            "Manzanillo",
            "Minatitlán",
            "Comala",
            "Villa de Álvarez",
            "Coquimatlán",
            "Armería",
            "Cuauhtémoc",
            "El Chanal",
            "La Capacha",
            "Colima",
            "Ixtlahuacán",
            "Tecomán"});
            this.combobxFinalPoint.Location = new System.Drawing.Point(14, 41);
            this.combobxFinalPoint.Name = "combobxFinalPoint";
            this.combobxFinalPoint.Size = new System.Drawing.Size(284, 27);
            this.combobxFinalPoint.TabIndex = 4;
            this.combobxFinalPoint.Text = "Elige el destino";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Grafos_Colima.Properties.Resources.Digital_Artwork_Black_Abstract_Lines_107506_detail_thumb;
            this.ClientSize = new System.Drawing.Size(399, 161);
            this.Controls.Add(this.combobxFinalPoint);
            this.Controls.Add(this.combobxInitialPoint);
            this.Controls.Add(this.tbxOutRutes);
            this.Controls.Add(this.btnShow);
            this.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Best Rute 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbxOutRutes;
        private System.Windows.Forms.ComboBox combobxInitialPoint;
        private System.Windows.Forms.ComboBox combobxFinalPoint;
    }
}

