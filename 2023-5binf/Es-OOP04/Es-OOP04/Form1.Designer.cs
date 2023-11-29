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
            this.btnMostro = new System.Windows.Forms.Button();
            this.btnMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostro
            // 
            this.btnMostro.Location = new System.Drawing.Point(13, 13);
            this.btnMostro.Name = "btnMostro";
            this.btnMostro.Size = new System.Drawing.Size(190, 88);
            this.btnMostro.TabIndex = 0;
            this.btnMostro.Text = "Mostro";
            this.btnMostro.UseVisualStyleBackColor = true;
            this.btnMostro.Click += new System.EventHandler(this.btnMostro_Click);
            // 
            // btnMannaro
            // 
            this.btnMannaro.Location = new System.Drawing.Point(237, 13);
            this.btnMannaro.Name = "btnMannaro";
            this.btnMannaro.Size = new System.Drawing.Size(190, 88);
            this.btnMannaro.TabIndex = 1;
            this.btnMannaro.Text = "Mannaro";
            this.btnMannaro.UseVisualStyleBackColor = true;
            this.btnMannaro.Click += new System.EventHandler(this.btnMannaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 117);
            this.Controls.Add(this.btnMannaro);
            this.Controls.Add(this.btnMostro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostro;
        private System.Windows.Forms.Button btnMannaro;
    }
}

