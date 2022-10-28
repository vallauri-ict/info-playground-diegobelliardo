namespace EsercitazioneVerifica
{
    partial class Apri2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFormattazione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormattazione
            // 
            this.lblFormattazione.AutoSize = true;
            this.lblFormattazione.Location = new System.Drawing.Point(47, 64);
            this.lblFormattazione.Name = "lblFormattazione";
            this.lblFormattazione.Size = new System.Drawing.Size(0, 13);
            this.lblFormattazione.TabIndex = 0;
            // 
            // Apri2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 238);
            this.Controls.Add(this.lblFormattazione);
            this.Name = "Apri2";
            this.Text = "Apri2";
            this.Load += new System.EventHandler(this.Apri2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormattazione;
    }
}