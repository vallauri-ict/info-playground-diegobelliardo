namespace Es_OOP03
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCittà = new System.Windows.Forms.Label();
            this.labelVoti = new System.Windows.Forms.Label();
            this.labelMediaVoti = new System.Windows.Forms.Label();
            this.buttonVoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelCittà
            // 
            this.labelCittà.AutoSize = true;
            this.labelCittà.Location = new System.Drawing.Point(13, 53);
            this.labelCittà.Name = "labelCittà";
            this.labelCittà.Size = new System.Drawing.Size(33, 16);
            this.labelCittà.TabIndex = 1;
            this.labelCittà.Text = "Città";
            // 
            // labelVoti
            // 
            this.labelVoti.AutoSize = true;
            this.labelVoti.Location = new System.Drawing.Point(13, 97);
            this.labelVoti.Name = "labelVoti";
            this.labelVoti.Size = new System.Drawing.Size(30, 16);
            this.labelVoti.TabIndex = 2;
            this.labelVoti.Text = "Voti";
            // 
            // labelMediaVoti
            // 
            this.labelMediaVoti.AutoSize = true;
            this.labelMediaVoti.Location = new System.Drawing.Point(9, 141);
            this.labelMediaVoti.Name = "labelMediaVoti";
            this.labelMediaVoti.Size = new System.Drawing.Size(71, 16);
            this.labelMediaVoti.TabIndex = 3;
            this.labelMediaVoti.Text = "Media Voti";
            // 
            // buttonVoti
            // 
            this.buttonVoti.Location = new System.Drawing.Point(16, 187);
            this.buttonVoti.Name = "buttonVoti";
            this.buttonVoti.Size = new System.Drawing.Size(113, 28);
            this.buttonVoti.TabIndex = 4;
            this.buttonVoti.Text = "Assegna Voti";
            this.buttonVoti.UseVisualStyleBackColor = true;
            this.buttonVoti.Click += new System.EventHandler(this.buttonAssegnaVoti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoti);
            this.Controls.Add(this.labelMediaVoti);
            this.Controls.Add(this.labelVoti);
            this.Controls.Add(this.labelCittà);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCittà;
        private System.Windows.Forms.Label labelVoti;
        private System.Windows.Forms.Label labelMediaVoti;
        private System.Windows.Forms.Button buttonVoti;
    }
}

