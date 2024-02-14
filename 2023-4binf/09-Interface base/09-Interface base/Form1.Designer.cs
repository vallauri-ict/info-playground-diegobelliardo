namespace _09_Interface_base
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
            this.quadrato = new System.Windows.Forms.Button();
            this.triangolo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quadrato
            // 
            this.quadrato.Location = new System.Drawing.Point(13, 13);
            this.quadrato.Name = "quadrato";
            this.quadrato.Size = new System.Drawing.Size(102, 23);
            this.quadrato.TabIndex = 0;
            this.quadrato.Text = "P. e A. Quadrato";
            this.quadrato.UseVisualStyleBackColor = true;
            this.quadrato.Click += new System.EventHandler(this.quadrato_Click);
            // 
            // triangolo
            // 
            this.triangolo.Location = new System.Drawing.Point(142, 13);
            this.triangolo.Name = "triangolo";
            this.triangolo.Size = new System.Drawing.Size(102, 23);
            this.triangolo.TabIndex = 1;
            this.triangolo.Text = "P. e A. Triangolo";
            this.triangolo.UseVisualStyleBackColor = true;
            this.triangolo.Click += new System.EventHandler(this.triangolo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.triangolo);
            this.Controls.Add(this.quadrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quadrato;
        private System.Windows.Forms.Button triangolo;
    }
}

