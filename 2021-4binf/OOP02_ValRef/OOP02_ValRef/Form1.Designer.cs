namespace OOP02_ValRef
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
            this.btnVal = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(13, 13);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(158, 23);
            this.btnVal.TabIndex = 0;
            this.btnVal.Text = "Passaggio per Valore";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(13, 42);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(158, 23);
            this.btnRef.TabIndex = 1;
            this.btnRef.Text = "Passaggio per Riferimento";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 94);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnVal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnRef;
    }
}

