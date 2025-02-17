namespace _39_PrimoEsvisuale
{
    partial class PrimaCalc
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
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.btnMoltiplicazione = new System.Windows.Forms.Button();
            this.btnDivisione = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOp1
            // 
            this.txtOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp1.ForeColor = System.Drawing.Color.Red;
            this.txtOp1.Location = new System.Drawing.Point(12, 12);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOp1.Size = new System.Drawing.Size(100, 26);
            this.txtOp1.TabIndex = 1;
            // 
            // txtOp2
            // 
            this.txtOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp2.ForeColor = System.Drawing.Color.Red;
            this.txtOp2.Location = new System.Drawing.Point(140, 12);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOp2.Size = new System.Drawing.Size(100, 26);
            this.txtOp2.TabIndex = 2;
            // 
            // btnSomma
            // 
            this.btnSomma.AutoSize = true;
            this.btnSomma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomma.Location = new System.Drawing.Point(12, 57);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(228, 30);
            this.btnSomma.TabIndex = 3;
            this.btnSomma.Text = "ADDIZIONE";
            this.btnSomma.UseVisualStyleBackColor = false;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.AutoSize = true;
            this.btnSottrazione.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSottrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSottrazione.Location = new System.Drawing.Point(12, 93);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(228, 30);
            this.btnSottrazione.TabIndex = 4;
            this.btnSottrazione.Text = "SOTTRAZIONE";
            this.btnSottrazione.UseVisualStyleBackColor = false;
            this.btnSottrazione.Click += new System.EventHandler(this.btnSottrazione_Click);
            // 
            // btnMoltiplicazione
            // 
            this.btnMoltiplicazione.AutoSize = true;
            this.btnMoltiplicazione.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMoltiplicazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoltiplicazione.Location = new System.Drawing.Point(12, 129);
            this.btnMoltiplicazione.Name = "btnMoltiplicazione";
            this.btnMoltiplicazione.Size = new System.Drawing.Size(228, 30);
            this.btnMoltiplicazione.TabIndex = 5;
            this.btnMoltiplicazione.Text = "MILTIPLICAZIONE";
            this.btnMoltiplicazione.UseVisualStyleBackColor = false;
            this.btnMoltiplicazione.Click += new System.EventHandler(this.btnMoltiplicazione_Click);
            // 
            // btnDivisione
            // 
            this.btnDivisione.AutoSize = true;
            this.btnDivisione.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDivisione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisione.Location = new System.Drawing.Point(13, 165);
            this.btnDivisione.Name = "btnDivisione";
            this.btnDivisione.Size = new System.Drawing.Size(228, 30);
            this.btnDivisione.TabIndex = 6;
            this.btnDivisione.Text = "DIVISIONE";
            this.btnDivisione.UseVisualStyleBackColor = false;
            this.btnDivisione.Click += new System.EventHandler(this.btnDivisione_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(72, 213);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRisultato.Size = new System.Drawing.Size(100, 28);
            this.lblRisultato.TabIndex = 7;
            this.lblRisultato.Text = "----------------";
            this.lblRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PrimaCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnDivisione);
            this.Controls.Add(this.btnMoltiplicazione);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Name = "PrimaCalc";
            this.Text = "Primo esempio visuale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnSottrazione;
        private System.Windows.Forms.Button btnMoltiplicazione;
        private System.Windows.Forms.Button btnDivisione;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button btnClear;
    }
}

