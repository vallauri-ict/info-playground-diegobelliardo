namespace _05_ClesseSingleton
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreaClasse = new System.Windows.Forms.Button();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci un valore";
            // 
            // btnCreaClasse
            // 
            this.btnCreaClasse.Location = new System.Drawing.Point(30, 47);
            this.btnCreaClasse.Name = "btnCreaClasse";
            this.btnCreaClasse.Size = new System.Drawing.Size(75, 23);
            this.btnCreaClasse.TabIndex = 1;
            this.btnCreaClasse.Text = "Crea classe";
            this.btnCreaClasse.UseVisualStyleBackColor = true;
            this.btnCreaClasse.Click += new System.EventHandler(this.btnCreaClasse_Click);
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(111, 10);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 92);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.btnCreaClasse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreaClasse;
        private System.Windows.Forms.TextBox txtValore;
    }
}

