namespace _01_WindowsForms
{
    partial class F5
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
            this.btnAzzera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzzera
            // 
            this.btnAzzera.Location = new System.Drawing.Point(13, 13);
            this.btnAzzera.Name = "btnAzzera";
            this.btnAzzera.Size = new System.Drawing.Size(118, 23);
            this.btnAzzera.TabIndex = 0;
            this.btnAzzera.Text = "Azzera Messaggio";
            this.btnAzzera.UseVisualStyleBackColor = true;
            this.btnAzzera.Click += new System.EventHandler(this.btnAzzera_Click);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 171);
            this.Controls.Add(this.btnAzzera);
            this.Name = "F5";
            this.Text = "F5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzzera;
    }
}