namespace _04_MetodoFactory
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
            this.txtLatoQuadrato = new System.Windows.Forms.TextBox();
            this.btnCreaQuadrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il lato del quadrato:";
            // 
            // txtLatoQuadrato
            // 
            this.txtLatoQuadrato.Location = new System.Drawing.Point(156, 10);
            this.txtLatoQuadrato.Name = "txtLatoQuadrato";
            this.txtLatoQuadrato.Size = new System.Drawing.Size(100, 20);
            this.txtLatoQuadrato.TabIndex = 1;
            // 
            // btnCreaQuadrato
            // 
            this.btnCreaQuadrato.Location = new System.Drawing.Point(91, 52);
            this.btnCreaQuadrato.Name = "btnCreaQuadrato";
            this.btnCreaQuadrato.Size = new System.Drawing.Size(116, 23);
            this.btnCreaQuadrato.TabIndex = 2;
            this.btnCreaQuadrato.Text = "Crea Quadrato";
            this.btnCreaQuadrato.UseVisualStyleBackColor = true;
            this.btnCreaQuadrato.Click += new System.EventHandler(this.btnCreaQuadrato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 120);
            this.Controls.Add(this.btnCreaQuadrato);
            this.Controls.Add(this.txtLatoQuadrato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLatoQuadrato;
        private System.Windows.Forms.Button btnCreaQuadrato;
    }
}

