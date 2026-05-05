namespace _68_Es22Pag174
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
            this.dgvElencoGiocatori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroGoal = new System.Windows.Forms.TextBox();
            this.btnContaGiocatori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoGiocatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElencoGiocatori
            // 
            this.dgvElencoGiocatori.AllowUserToAddRows = false;
            this.dgvElencoGiocatori.AllowUserToDeleteRows = false;
            this.dgvElencoGiocatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElencoGiocatori.Location = new System.Drawing.Point(12, 45);
            this.dgvElencoGiocatori.Name = "dgvElencoGiocatori";
            this.dgvElencoGiocatori.RowHeadersVisible = false;
            this.dgvElencoGiocatori.RowHeadersWidth = 62;
            this.dgvElencoGiocatori.RowTemplate.Height = 28;
            this.dgvElencoGiocatori.Size = new System.Drawing.Size(1082, 454);
            this.dgvElencoGiocatori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elenco giocatori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero goal:";
            // 
            // txtNumeroGoal
            // 
            this.txtNumeroGoal.Location = new System.Drawing.Point(192, 522);
            this.txtNumeroGoal.Name = "txtNumeroGoal";
            this.txtNumeroGoal.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroGoal.TabIndex = 3;
            // 
            // btnContaGiocatori
            // 
            this.btnContaGiocatori.Location = new System.Drawing.Point(336, 513);
            this.btnContaGiocatori.Name = "btnContaGiocatori";
            this.btnContaGiocatori.Size = new System.Drawing.Size(158, 44);
            this.btnContaGiocatori.TabIndex = 4;
            this.btnContaGiocatori.Text = "Conta Giocatori";
            this.btnContaGiocatori.UseVisualStyleBackColor = true;
            this.btnContaGiocatori.Click += new System.EventHandler(this.btnContaGiocatori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 570);
            this.Controls.Add(this.btnContaGiocatori);
            this.Controls.Add(this.txtNumeroGoal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvElencoGiocatori);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvElencoGiocatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElencoGiocatori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroGoal;
        private System.Windows.Forms.Button btnContaGiocatori;
    }
}

