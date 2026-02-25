namespace _61_Es24pag116
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
            this.lstAnimali = new System.Windows.Forms.ListBox();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.Specie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animali";
            // 
            // lstAnimali
            // 
            this.lstAnimali.FormattingEnabled = true;
            this.lstAnimali.ItemHeight = 16;
            this.lstAnimali.Location = new System.Drawing.Point(13, 33);
            this.lstAnimali.Name = "lstAnimali";
            this.lstAnimali.Size = new System.Drawing.Size(138, 292);
            this.lstAnimali.TabIndex = 1;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.ItemHeight = 16;
            this.lstSpecie.Location = new System.Drawing.Point(193, 33);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(138, 292);
            this.lstSpecie.TabIndex = 3;
            // 
            // Specie
            // 
            this.Specie.AutoSize = true;
            this.Specie.Location = new System.Drawing.Point(193, 13);
            this.Specie.Name = "Specie";
            this.Specie.Size = new System.Drawing.Size(50, 16);
            this.Specie.TabIndex = 2;
            this.Specie.Text = "Specie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.Specie);
            this.Controls.Add(this.lstAnimali);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAnimali;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Label Specie;
    }
}

