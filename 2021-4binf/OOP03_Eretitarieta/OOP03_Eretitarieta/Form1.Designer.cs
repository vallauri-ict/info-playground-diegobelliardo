namespace OOP03_Eretitarieta
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
            this.btnCreaMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaMannaro
            // 
            this.btnCreaMannaro.Location = new System.Drawing.Point(13, 13);
            this.btnCreaMannaro.Name = "btnCreaMannaro";
            this.btnCreaMannaro.Size = new System.Drawing.Size(103, 23);
            this.btnCreaMannaro.TabIndex = 0;
            this.btnCreaMannaro.Text = "Crea Mannaro";
            this.btnCreaMannaro.UseVisualStyleBackColor = true;
            this.btnCreaMannaro.Click += new System.EventHandler(this.btnCreaMannaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 227);
            this.Controls.Add(this.btnCreaMannaro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaMannaro;
    }
}

