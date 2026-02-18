namespace _59_Es22pag116
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
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPunteggio = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstHitParade = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVotaGeneraHitParade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantanti";
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.ItemHeight = 16;
            this.lstCantanti.Location = new System.Drawing.Point(16, 33);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(152, 292);
            this.lstCantanti.TabIndex = 1;
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.ItemHeight = 16;
            this.lstCanzoni.Location = new System.Drawing.Point(174, 33);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(152, 292);
            this.lstCanzoni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Canzoni";
            // 
            // lstPunteggio
            // 
            this.lstPunteggio.FormattingEnabled = true;
            this.lstPunteggio.ItemHeight = 16;
            this.lstPunteggio.Location = new System.Drawing.Point(332, 33);
            this.lstPunteggio.Name = "lstPunteggio";
            this.lstPunteggio.Size = new System.Drawing.Size(152, 292);
            this.lstPunteggio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punteggio";
            // 
            // lstHitParade
            // 
            this.lstHitParade.FormattingEnabled = true;
            this.lstHitParade.ItemHeight = 16;
            this.lstHitParade.Location = new System.Drawing.Point(491, 33);
            this.lstHitParade.Name = "lstHitParade";
            this.lstHitParade.Size = new System.Drawing.Size(120, 292);
            this.lstHitParade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hit Parade";
            // 
            // btnVotaGeneraHitParade
            // 
            this.btnVotaGeneraHitParade.Location = new System.Drawing.Point(633, 123);
            this.btnVotaGeneraHitParade.Name = "btnVotaGeneraHitParade";
            this.btnVotaGeneraHitParade.Size = new System.Drawing.Size(142, 115);
            this.btnVotaGeneraHitParade.TabIndex = 8;
            this.btnVotaGeneraHitParade.Text = "Vota e Genera hit parade";
            this.btnVotaGeneraHitParade.UseVisualStyleBackColor = true;
            this.btnVotaGeneraHitParade.Click += new System.EventHandler(this.btnVotaGeneraHitParade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVotaGeneraHitParade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstHitParade);
            this.Controls.Add(this.lstPunteggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCantanti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPunteggio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstHitParade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVotaGeneraHitParade;
    }
}

