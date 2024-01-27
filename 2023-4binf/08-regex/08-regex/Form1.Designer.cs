namespace _08_regex
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
            this.btnTelefono = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.btnImporto = new System.Windows.Forms.Button();
            this.btnCodicefiscale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTelefono
            // 
            this.btnTelefono.Location = new System.Drawing.Point(29, 231);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(99, 50);
            this.btnTelefono.TabIndex = 0;
            this.btnTelefono.Text = "TELEFONO";
            this.btnTelefono.UseVisualStyleBackColor = true;
            // 
            // btnSpec
            // 
            this.btnSpec.Location = new System.Drawing.Point(166, 231);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(116, 50);
            this.btnSpec.TabIndex = 1;
            this.btnSpec.Text = "SPECIALZZAZIONE (INF, MEC,ELT)";
            this.btnSpec.UseVisualStyleBackColor = true;
            // 
            // btnClasse
            // 
            this.btnClasse.Location = new System.Drawing.Point(325, 231);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(101, 50);
            this.btnClasse.TabIndex = 2;
            this.btnClasse.Text = "CLASSE (4C INF)";
            this.btnClasse.UseVisualStyleBackColor = true;
            // 
            // btnImporto
            // 
            this.btnImporto.Location = new System.Drawing.Point(487, 231);
            this.btnImporto.Name = "btnImporto";
            this.btnImporto.Size = new System.Drawing.Size(112, 50);
            this.btnImporto.TabIndex = 3;
            this.btnImporto.Text = "IMPORTO";
            this.btnImporto.UseVisualStyleBackColor = true;
            // 
            // btnCodicefiscale
            // 
            this.btnCodicefiscale.Location = new System.Drawing.Point(650, 231);
            this.btnCodicefiscale.Name = "btnCodicefiscale";
            this.btnCodicefiscale.Size = new System.Drawing.Size(108, 50);
            this.btnCodicefiscale.TabIndex = 4;
            this.btnCodicefiscale.Text = "CODICE FISCALE";
            this.btnCodicefiscale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "input da controllare:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(132, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(189, 20);
            this.txtInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCodicefiscale);
            this.Controls.Add(this.btnImporto);
            this.Controls.Add(this.btnClasse);
            this.Controls.Add(this.btnSpec);
            this.Controls.Add(this.btnTelefono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button btnImporto;
        private System.Windows.Forms.Button btnCodicefiscale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
    }
}

