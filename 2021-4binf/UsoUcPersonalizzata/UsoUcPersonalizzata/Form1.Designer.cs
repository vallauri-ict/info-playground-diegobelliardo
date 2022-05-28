namespace UsoUcPersonalizzata
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
            this.txtMiaTextBox = new MioControllo.UserCTextBox();
            this.chkNumeri = new System.Windows.Forms.CheckBox();
            this.nudCifreDecimali = new System.Windows.Forms.NumericUpDown();
            this.btbVisualizza = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiaTextBox
            // 
            this.txtMiaTextBox.CifreDecimali = 0;
            this.txtMiaTextBox.Location = new System.Drawing.Point(13, 12);
            this.txtMiaTextBox.Name = "txtMiaTextBox";
            this.txtMiaTextBox.Numero = false;
            this.txtMiaTextBox.Size = new System.Drawing.Size(101, 24);
            this.txtMiaTextBox.TabIndex = 0;
            this.txtMiaTextBox.Testo = "";
            // 
            // chkNumeri
            // 
            this.chkNumeri.AutoSize = true;
            this.chkNumeri.Location = new System.Drawing.Point(13, 63);
            this.chkNumeri.Name = "chkNumeri";
            this.chkNumeri.Size = new System.Drawing.Size(80, 21);
            this.chkNumeri.TabIndex = 1;
            this.chkNumeri.Text = "Numero";
            this.chkNumeri.UseVisualStyleBackColor = true;
            this.chkNumeri.CheckedChanged += new System.EventHandler(this.chkNumeri_CheckedChanged);
            // 
            // nudCifreDecimali
            // 
            this.nudCifreDecimali.Location = new System.Drawing.Point(13, 91);
            this.nudCifreDecimali.Name = "nudCifreDecimali";
            this.nudCifreDecimali.Size = new System.Drawing.Size(49, 22);
            this.nudCifreDecimali.TabIndex = 2;
            this.nudCifreDecimali.ValueChanged += new System.EventHandler(this.nudCifreDecimali_ValueChanged);
            // 
            // btbVisualizza
            // 
            this.btbVisualizza.Location = new System.Drawing.Point(172, 30);
            this.btbVisualizza.Name = "btbVisualizza";
            this.btbVisualizza.Size = new System.Drawing.Size(112, 23);
            this.btbVisualizza.TabIndex = 3;
            this.btbVisualizza.Text = "Visualizza";
            this.btbVisualizza.UseVisualStyleBackColor = true;
            this.btbVisualizza.Click += new System.EventHandler(this.btbVisualizza_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(172, 75);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(112, 23);
            this.btnPulisci.TabIndex = 4;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 158);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btbVisualizza);
            this.Controls.Add(this.nudCifreDecimali);
            this.Controls.Add(this.chkNumeri);
            this.Controls.Add(this.txtMiaTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MioControllo.UserCTextBox txtMiaTextBox;
        private System.Windows.Forms.CheckBox chkNumeri;
        private System.Windows.Forms.NumericUpDown nudCifreDecimali;
        private System.Windows.Forms.Button btbVisualizza;
        private System.Windows.Forms.Button btnPulisci;
    }
}

