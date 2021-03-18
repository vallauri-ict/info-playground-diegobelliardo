
namespace _15_Uso_InterfacciaIComparer
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
            this.btnCognome = new System.Windows.Forms.Button();
            this.btnNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCognome
            // 
            this.btnCognome.Location = new System.Drawing.Point(13, 13);
            this.btnCognome.Name = "btnCognome";
            this.btnCognome.Size = new System.Drawing.Size(168, 34);
            this.btnCognome.TabIndex = 0;
            this.btnCognome.Text = "Ordina per Cognome";
            this.btnCognome.UseVisualStyleBackColor = true;
            this.btnCognome.Click += new System.EventHandler(this.btnCognome_Click);
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(187, 13);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(168, 34);
            this.btnNome.TabIndex = 1;
            this.btnNome.Text = "Ordina per Nome";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 80);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.btnCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCognome;
        private System.Windows.Forms.Button btnNome;
    }
}

