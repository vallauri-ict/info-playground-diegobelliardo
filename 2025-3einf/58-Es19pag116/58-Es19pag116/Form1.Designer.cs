namespace _58_Es19pag116
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
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantante = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canzoni";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.ItemHeight = 16;
            this.lstCanzoni.Location = new System.Drawing.Point(12, 32);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(134, 244);
            this.lstCanzoni.TabIndex = 1;
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.ItemHeight = 16;
            this.lstCantanti.Location = new System.Drawing.Point(152, 32);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(134, 244);
            this.lstCantanti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantanti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome cantante:";
            // 
            // txtCantante
            // 
            this.txtCantante.Location = new System.Drawing.Point(384, 32);
            this.txtCantante.Name = "txtCantante";
            this.txtCantante.Size = new System.Drawing.Size(184, 22);
            this.txtCantante.TabIndex = 5;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(384, 61);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(143, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca Canzoni";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtCantante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCantanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantante;
        private System.Windows.Forms.Button btnCerca;
    }
}

