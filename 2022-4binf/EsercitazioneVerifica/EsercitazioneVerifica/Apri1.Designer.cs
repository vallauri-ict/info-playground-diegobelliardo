namespace EsercitazioneVerifica
{
    partial class Apri1
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
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.cmbMacchina = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(13, 23);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(92, 17);
            this.chkPelle.TabIndex = 0;
            this.chkPelle.Text = "Interni in Pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckedChanged += new System.EventHandler(this.chkPelle_CheckedChanged);
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(13, 56);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(95, 17);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Interni in stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // cmbMacchina
            // 
            this.cmbMacchina.FormattingEnabled = true;
            this.cmbMacchina.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbMacchina.Location = new System.Drawing.Point(13, 93);
            this.cmbMacchina.Name = "cmbMacchina";
            this.cmbMacchina.Size = new System.Drawing.Size(121, 21);
            this.cmbMacchina.TabIndex = 1;
            this.cmbMacchina.SelectedIndexChanged += new System.EventHandler(this.cmbMacchina_SelectedIndexChanged);
            // 
            // Apri1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 166);
            this.Controls.Add(this.cmbMacchina);
            this.Controls.Add(this.chkStoffa);
            this.Controls.Add(this.chkPelle);
            this.Name = "Apri1";
            this.Text = "Apri1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Apri1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.ComboBox cmbMacchina;
    }
}