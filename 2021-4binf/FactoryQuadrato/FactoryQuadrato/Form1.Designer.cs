namespace FactoryQuadrato
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
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactory
            // 
            this.btnFactory.Location = new System.Drawing.Point(13, 13);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(68, 52);
            this.btnFactory.TabIndex = 0;
            this.btnFactory.Text = "Prova metodo Factory";
            this.btnFactory.UseVisualStyleBackColor = true;
            this.btnFactory.Click += new System.EventHandler(this.btnFactory_Click);
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(100, 13);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(68, 52);
            this.btnSingleton.TabIndex = 1;
            this.btnSingleton.Text = "Prova metodo Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(188, 13);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(68, 52);
            this.btnIndex.TabIndex = 2;
            this.btnIndex.Text = "Prova stringhe indexate";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 109);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnSingleton);
            this.Controls.Add(this.btnFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnIndex;
    }
}

