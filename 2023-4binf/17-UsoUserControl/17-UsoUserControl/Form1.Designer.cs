namespace _17_UsoUserControl
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
            this.txtMiaTextBox = new _16_UserControl.ucTextBox();
            this.chkNumeri = new System.Windows.Forms.CheckBox();
            this.nudCifreDecimali = new System.Windows.Forms.NumericUpDown();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiaTextBox
            // 
            this.txtMiaTextBox.CifreDecimali = 0;
            this.txtMiaTextBox.Location = new System.Drawing.Point(72, 44);
            this.txtMiaTextBox.Name = "txtMiaTextBox";
            this.txtMiaTextBox.Numero = false;
            this.txtMiaTextBox.Size = new System.Drawing.Size(131, 23);
            this.txtMiaTextBox.TabIndex = 0;
            this.txtMiaTextBox.Testo = "";
            // 
            // chkNumeri
            // 
            this.chkNumeri.AutoSize = true;
            this.chkNumeri.Location = new System.Drawing.Point(36, 91);
            this.chkNumeri.Name = "chkNumeri";
            this.chkNumeri.Size = new System.Drawing.Size(125, 17);
            this.chkNumeri.TabIndex = 1;
            this.chkNumeri.Text = "Accetta solo Numero";
            this.chkNumeri.UseVisualStyleBackColor = true;
            // 
            // nudCifreDecimali
            // 
            this.nudCifreDecimali.Location = new System.Drawing.Point(234, 91);
            this.nudCifreDecimali.Name = "nudCifreDecimali";
            this.nudCifreDecimali.Size = new System.Drawing.Size(42, 20);
            this.nudCifreDecimali.TabIndex = 2;
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(176, 139);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 23);
            this.btnPulisci.TabIndex = 3;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Visualizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPulisci);
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

        private _16_UserControl.ucTextBox txtMiaTextBox;
        private System.Windows.Forms.CheckBox chkNumeri;
        private System.Windows.Forms.NumericUpDown nudCifreDecimali;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button button1;
    }
}

