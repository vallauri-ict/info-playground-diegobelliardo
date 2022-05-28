namespace MioControllo
{
    partial class UserCTextBox
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
            this.UcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UcTextBox
            // 
            this.UcTextBox.Location = new System.Drawing.Point(0, 0);
            this.UcTextBox.Name = "UcTextBox";
            this.UcTextBox.Size = new System.Drawing.Size(100, 22);
            this.UcTextBox.TabIndex = 0;
            this.UcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.UcTextBox.Leave += new System.EventHandler(this.OnLeave);
            // 
            // UserCTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UcTextBox);
            this.Name = "UserCTextBox";
            this.Size = new System.Drawing.Size(101, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UcTextBox;
    }
}
