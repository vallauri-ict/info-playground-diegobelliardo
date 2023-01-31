namespace _16_UsoControlloPersonalizzato
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMiaTextBox = new _15_ControlloPersonalizzato.UcTextBox();
            this.chkSoloNumeri = new System.Windows.Forms.CheckBox();
            this.nudCifreDecimali = new System.Windows.Forms.NumericUpDown();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.Visualizza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiaTextBox
            // 
            this.txtMiaTextBox.CifreDecimali = 0;
            this.txtMiaTextBox.Location = new System.Drawing.Point(59, 33);
            this.txtMiaTextBox.Name = "txtMiaTextBox";
            this.txtMiaTextBox.Numero = false;
            this.txtMiaTextBox.Size = new System.Drawing.Size(103, 22);
            this.txtMiaTextBox.TabIndex = 0;
            this.txtMiaTextBox.Testo = "";
            this.txtMiaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiaTextBox_KeyPress);
            // 
            // chkSoloNumeri
            // 
            this.chkSoloNumeri.AutoSize = true;
            this.chkSoloNumeri.Location = new System.Drawing.Point(13, 82);
            this.chkSoloNumeri.Name = "chkSoloNumeri";
            this.chkSoloNumeri.Size = new System.Drawing.Size(119, 17);
            this.chkSoloNumeri.TabIndex = 1;
            this.chkSoloNumeri.Text = "Accetta solo numeri";
            this.chkSoloNumeri.UseVisualStyleBackColor = true;
            this.chkSoloNumeri.CheckedChanged += new System.EventHandler(this.chkSoloNumeri_CheckedChanged);
            // 
            // nudCifreDecimali
            // 
            this.nudCifreDecimali.Location = new System.Drawing.Point(201, 81);
            this.nudCifreDecimali.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCifreDecimali.Name = "nudCifreDecimali";
            this.nudCifreDecimali.Size = new System.Drawing.Size(39, 20);
            this.nudCifreDecimali.TabIndex = 2;
            this.nudCifreDecimali.ValueChanged += new System.EventHandler(this.nudCifreDecimali_ValueChanged);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(12, 124);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 23);
            this.btnPulisci.TabIndex = 3;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // Visualizza
            // 
            this.Visualizza.Location = new System.Drawing.Point(151, 124);
            this.Visualizza.Name = "Visualizza";
            this.Visualizza.Size = new System.Drawing.Size(103, 23);
            this.Visualizza.TabIndex = 4;
            this.Visualizza.Text = "Visualizza dato";
            this.Visualizza.UseVisualStyleBackColor = true;
            this.Visualizza.Click += new System.EventHandler(this.Visualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 170);
            this.Controls.Add(this.Visualizza);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.nudCifreDecimali);
            this.Controls.Add(this.chkSoloNumeri);
            this.Controls.Add(this.txtMiaTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _15_ControlloPersonalizzato.UcTextBox txtMiaTextBox;
        private System.Windows.Forms.CheckBox chkSoloNumeri;
        private System.Windows.Forms.NumericUpDown nudCifreDecimali;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button Visualizza;
    }
}

