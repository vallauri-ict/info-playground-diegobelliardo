﻿namespace WindowsForms01
{
    partial class FormFiglia
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
            this.btnFfDiChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFfDiChi
            // 
            this.btnFfDiChi.Location = new System.Drawing.Point(13, 13);
            this.btnFfDiChi.Name = "btnFfDiChi";
            this.btnFfDiChi.Size = new System.Drawing.Size(132, 23);
            this.btnFfDiChi.TabIndex = 0;
            this.btnFfDiChi.Text = "Di chi sono figlia?";
            this.btnFfDiChi.UseVisualStyleBackColor = true;
            this.btnFfDiChi.Click += new System.EventHandler(this.btnFfDiChi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 223);
            this.Controls.Add(this.btnFfDiChi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFfDiChi;
    }
}