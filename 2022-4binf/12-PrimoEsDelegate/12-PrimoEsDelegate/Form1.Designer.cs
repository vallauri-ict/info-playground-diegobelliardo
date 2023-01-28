namespace _12_PrimoEsDelegate
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
            this.btnPiu = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPiu
            // 
            this.btnPiu.Location = new System.Drawing.Point(13, 13);
            this.btnPiu.Name = "btnPiu";
            this.btnPiu.Size = new System.Drawing.Size(75, 23);
            this.btnPiu.TabIndex = 0;
            this.btnPiu.Text = "+";
            this.btnPiu.UseVisualStyleBackColor = true;
            this.btnPiu.Click += new System.EventHandler(this.btnPiu_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Location = new System.Drawing.Point(94, 13);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(75, 23);
            this.btnMeno.TabIndex = 1;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(175, 13);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(75, 23);
            this.btnPer.TabIndex = 2;
            this.btnPer.Text = "*";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 79);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnPiu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiu;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.Button btnPer;
    }
}

