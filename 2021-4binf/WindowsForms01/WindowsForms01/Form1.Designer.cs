namespace WindowsForms01
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
            this.btnApriF2 = new System.Windows.Forms.Button();
            this.btnApriF2b = new System.Windows.Forms.Button();
            this.txtDaPassare = new System.Windows.Forms.TextBox();
            this.btnF2Controllo = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriF2
            // 
            this.btnApriF2.Location = new System.Drawing.Point(13, 13);
            this.btnApriF2.Name = "btnApriF2";
            this.btnApriF2.Size = new System.Drawing.Size(75, 23);
            this.btnApriF2.TabIndex = 0;
            this.btnApriF2.Text = "Apri Form f2";
            this.btnApriF2.UseVisualStyleBackColor = true;
            this.btnApriF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnApriF2b
            // 
            this.btnApriF2b.Location = new System.Drawing.Point(95, 13);
            this.btnApriF2b.Name = "btnApriF2b";
            this.btnApriF2b.Size = new System.Drawing.Size(75, 23);
            this.btnApriF2b.TabIndex = 1;
            this.btnApriF2b.Text = "Apri F2b";
            this.btnApriF2b.UseVisualStyleBackColor = true;
            // 
            // txtDaPassare
            // 
            this.txtDaPassare.Location = new System.Drawing.Point(13, 43);
            this.txtDaPassare.Name = "txtDaPassare";
            this.txtDaPassare.Size = new System.Drawing.Size(100, 20);
            this.txtDaPassare.TabIndex = 2;
            // 
            // btnF2Controllo
            // 
            this.btnF2Controllo.Location = new System.Drawing.Point(128, 41);
            this.btnF2Controllo.Name = "btnF2Controllo";
            this.btnF2Controllo.Size = new System.Drawing.Size(103, 23);
            this.btnF2Controllo.TabIndex = 3;
            this.btnF2Controllo.Text = "Passa TXT a F2";
            this.btnF2Controllo.UseVisualStyleBackColor = true;
            this.btnF2Controllo.Click += new System.EventHandler(this.btnF2Controllo_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(13, 94);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(120, 23);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri Form Modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 242);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnF2Controllo);
            this.Controls.Add(this.txtDaPassare);
            this.Controls.Add(this.btnApriF2b);
            this.Controls.Add(this.btnApriF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriF2;
        private System.Windows.Forms.Button btnApriF2b;
        private System.Windows.Forms.TextBox txtDaPassare;
        private System.Windows.Forms.Button btnF2Controllo;
        private System.Windows.Forms.Button btnFormModale;
    }
}

