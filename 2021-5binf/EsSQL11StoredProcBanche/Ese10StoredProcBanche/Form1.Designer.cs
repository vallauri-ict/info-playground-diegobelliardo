namespace Ese10StoredProcBanche
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
            this.btnContaFiliali = new System.Windows.Forms.Button();
            this.txtComune = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanca = new System.Windows.Forms.TextBox();
            this.btnElencoFiliali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContaFiliali
            // 
            this.btnContaFiliali.Location = new System.Drawing.Point(14, 89);
            this.btnContaFiliali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContaFiliali.Name = "btnContaFiliali";
            this.btnContaFiliali.Size = new System.Drawing.Size(120, 29);
            this.btnContaFiliali.TabIndex = 0;
            this.btnContaFiliali.Text = "CONTA FILIALI";
            this.btnContaFiliali.UseVisualStyleBackColor = true;
            this.btnContaFiliali.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtComune
            // 
            this.txtComune.Location = new System.Drawing.Point(94, 18);
            this.txtComune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComune.Name = "txtComune";
            this.txtComune.Size = new System.Drawing.Size(76, 20);
            this.txtComune.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comune";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Banca";
            // 
            // txtBanca
            // 
            this.txtBanca.Location = new System.Drawing.Point(94, 42);
            this.txtBanca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBanca.Name = "txtBanca";
            this.txtBanca.Size = new System.Drawing.Size(76, 20);
            this.txtBanca.TabIndex = 3;
            // 
            // btnElencoFiliali
            // 
            this.btnElencoFiliali.Location = new System.Drawing.Point(160, 89);
            this.btnElencoFiliali.Margin = new System.Windows.Forms.Padding(2);
            this.btnElencoFiliali.Name = "btnElencoFiliali";
            this.btnElencoFiliali.Size = new System.Drawing.Size(120, 29);
            this.btnElencoFiliali.TabIndex = 5;
            this.btnElencoFiliali.Text = "ELENCO FILIALI";
            this.btnElencoFiliali.UseVisualStyleBackColor = true;
            this.btnElencoFiliali.Click += new System.EventHandler(this.btnElencoFiliali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 135);
            this.Controls.Add(this.btnElencoFiliali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComune);
            this.Controls.Add(this.btnContaFiliali);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContaFiliali;
        private System.Windows.Forms.TextBox txtComune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBanca;
        private System.Windows.Forms.Button btnElencoFiliali;
    }
}

