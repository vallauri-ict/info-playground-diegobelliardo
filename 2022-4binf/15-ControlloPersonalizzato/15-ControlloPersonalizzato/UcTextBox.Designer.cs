namespace _15_ControlloPersonalizzato
{
    partial class UcTextBox
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

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(0, 0);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(100, 20);
            this.txtTesto.TabIndex = 0;
            this.txtTesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTesto_KeyPress);
            // 
            // UcTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTesto);
            this.Name = "UcTextBox";
            this.Size = new System.Drawing.Size(103, 22);
            this.Leave += new System.EventHandler(this.UcTextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTesto;
    }
}
