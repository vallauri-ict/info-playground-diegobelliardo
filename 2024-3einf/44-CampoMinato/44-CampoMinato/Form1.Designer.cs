namespace _44_CampoMinato
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
            this.dgvCampoMinato = new System.Windows.Forms.DataGridView();
            this.btnInizia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoMinato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampoMinato
            // 
            this.dgvCampoMinato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampoMinato.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCampoMinato.Location = new System.Drawing.Point(0, 0);
            this.dgvCampoMinato.Name = "dgvCampoMinato";
            this.dgvCampoMinato.Size = new System.Drawing.Size(414, 365);
            this.dgvCampoMinato.TabIndex = 0;
            // 
            // btnInizia
            // 
            this.btnInizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInizia.Location = new System.Drawing.Point(0, 360);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(414, 84);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "INIZIA";
            this.btnInizia.UseVisualStyleBackColor = true;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 441);
            this.Controls.Add(this.btnInizia);
            this.Controls.Add(this.dgvCampoMinato);
            this.Name = "Form1";
            this.Text = "Campo Minato";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampoMinato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCampoMinato;
        private System.Windows.Forms.Button btnInizia;
    }
}

