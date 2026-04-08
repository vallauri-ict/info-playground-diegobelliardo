namespace P6CaricamentoFile
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
            this.btnScrivi = new System.Windows.Forms.Button();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScrivi
            // 
            this.btnScrivi.Location = new System.Drawing.Point(13, 13);
            this.btnScrivi.Name = "btnScrivi";
            this.btnScrivi.Size = new System.Drawing.Size(75, 31);
            this.btnScrivi.TabIndex = 0;
            this.btnScrivi.Text = "Scrivi File";
            this.btnScrivi.UseVisualStyleBackColor = true;
            this.btnScrivi.Click += new System.EventHandler(this.btnScrivi_Click);
            // 
            // btnLeggi
            // 
            this.btnLeggi.Location = new System.Drawing.Point(94, 13);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(75, 31);
            this.btnLeggi.TabIndex = 1;
            this.btnLeggi.Text = "Leggi File";
            this.btnLeggi.UseVisualStyleBackColor = true;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codice Libro:";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(116, 48);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 22);
            this.txtCodice.TabIndex = 3;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(251, 44);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(94, 31);
            this.btnCerca.TabIndex = 4;
            this.btnCerca.Text = "Cerca Libro";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 106);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeggi);
            this.Controls.Add(this.btnScrivi);
            this.Name = "Form1";
            this.Text = "P6-Carica File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScrivi;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Button btnCerca;
    }
}

