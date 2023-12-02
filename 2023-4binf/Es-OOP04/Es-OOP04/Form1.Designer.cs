namespace Es_OOP04
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
            this.btnValore = new System.Windows.Forms.Button();
            this.btnRiferimento = new System.Windows.Forms.Button();
            this.btnRisultato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValore
            // 
            this.btnValore.Location = new System.Drawing.Point(13, 13);
            this.btnValore.Name = "btnValore";
            this.btnValore.Size = new System.Drawing.Size(75, 34);
            this.btnValore.TabIndex = 0;
            this.btnValore.Text = "Valore";
            this.btnValore.UseVisualStyleBackColor = true;
            this.btnValore.Click += new System.EventHandler(this.btnValore_Click);
            // 
            // btnRiferimento
            // 
            this.btnRiferimento.Location = new System.Drawing.Point(94, 13);
            this.btnRiferimento.Name = "btnRiferimento";
            this.btnRiferimento.Size = new System.Drawing.Size(75, 34);
            this.btnRiferimento.TabIndex = 1;
            this.btnRiferimento.Text = "Riferimento";
            this.btnRiferimento.UseVisualStyleBackColor = true;
            this.btnRiferimento.Click += new System.EventHandler(this.btnRiferimento_Click);
            // 
            // btnRisultato
            // 
            this.btnRisultato.Location = new System.Drawing.Point(175, 13);
            this.btnRisultato.Name = "btnRisultato";
            this.btnRisultato.Size = new System.Drawing.Size(75, 34);
            this.btnRisultato.TabIndex = 2;
            this.btnRisultato.Text = "Risultato";
            this.btnRisultato.UseVisualStyleBackColor = true;
            this.btnRisultato.Click += new System.EventHandler(this.btnRisultato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 99);
            this.Controls.Add(this.btnRisultato);
            this.Controls.Add(this.btnRiferimento);
            this.Controls.Add(this.btnValore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValore;
        private System.Windows.Forms.Button btnRiferimento;
        private System.Windows.Forms.Button btnRisultato;
    }
}

