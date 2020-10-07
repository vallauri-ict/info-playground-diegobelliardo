namespace _02_FormMDI
{
    partial class ModalEsci
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsciOk = new System.Windows.Forms.Button();
            this.btnEsciAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi Uscire?";
            // 
            // btnEsciOk
            // 
            this.btnEsciOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEsciOk.Location = new System.Drawing.Point(13, 47);
            this.btnEsciOk.Name = "btnEsciOk";
            this.btnEsciOk.Size = new System.Drawing.Size(75, 23);
            this.btnEsciOk.TabIndex = 1;
            this.btnEsciOk.Text = "Ok";
            this.btnEsciOk.UseVisualStyleBackColor = true;
            // 
            // btnEsciAnnulla
            // 
            this.btnEsciAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsciAnnulla.Location = new System.Drawing.Point(95, 46);
            this.btnEsciAnnulla.Name = "btnEsciAnnulla";
            this.btnEsciAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnEsciAnnulla.TabIndex = 2;
            this.btnEsciAnnulla.Text = "Annulla";
            this.btnEsciAnnulla.UseVisualStyleBackColor = true;
            // 
            // ModalEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 88);
            this.Controls.Add(this.btnEsciAnnulla);
            this.Controls.Add(this.btnEsciOk);
            this.Controls.Add(this.label1);
            this.Name = "ModalEsci";
            this.Text = "ModalEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEsciOk;
        private System.Windows.Forms.Button btnEsciAnnulla;
    }
}