namespace _12_UserControl
{
    partial class ucTextBox
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
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(100, 20);
            this.txtTextBox.TabIndex = 0;
            this.txtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextBox_KeyPress);
            this.txtTextBox.Leave += new System.EventHandler(this.txtTextBox_Leave);
            // 
            // ucTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTextBox);
            this.Name = "ucTextBox";
            this.Size = new System.Drawing.Size(101, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextBox;
    }
}
