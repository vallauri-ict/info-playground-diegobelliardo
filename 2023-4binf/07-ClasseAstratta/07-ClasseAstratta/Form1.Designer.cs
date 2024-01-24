namespace _07_ClasseAstratta
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
            this.btnSStudenti = new System.Windows.Forms.Button();
            this.btnSCalciatori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSStudenti
            // 
            this.btnSStudenti.Location = new System.Drawing.Point(13, 13);
            this.btnSStudenti.Name = "btnSStudenti";
            this.btnSStudenti.Size = new System.Drawing.Size(176, 34);
            this.btnSStudenti.TabIndex = 0;
            this.btnSStudenti.Text = "Stampa Studenti";
            this.btnSStudenti.UseVisualStyleBackColor = true;
            this.btnSStudenti.Click += new System.EventHandler(this.btnSStudenti_Click);
            // 
            // btnSCalciatori
            // 
            this.btnSCalciatori.Location = new System.Drawing.Point(253, 13);
            this.btnSCalciatori.Name = "btnSCalciatori";
            this.btnSCalciatori.Size = new System.Drawing.Size(176, 34);
            this.btnSCalciatori.TabIndex = 1;
            this.btnSCalciatori.Text = "Stampa Calciatori";
            this.btnSCalciatori.UseVisualStyleBackColor = true;
            this.btnSCalciatori.Click += new System.EventHandler(this.btnSCalciatori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 85);
            this.Controls.Add(this.btnSCalciatori);
            this.Controls.Add(this.btnSStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSStudenti;
        private System.Windows.Forms.Button btnSCalciatori;
    }
}

