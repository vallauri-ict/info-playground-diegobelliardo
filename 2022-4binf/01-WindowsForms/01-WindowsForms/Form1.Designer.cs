namespace _01_WindowsForms
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
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF4Param = new System.Windows.Forms.Button();
            this.txtMesaggio = new System.Windows.Forms.TextBox();
            this.btnF5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(13, 13);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(75, 23);
            this.btnF2.TabIndex = 0;
            this.btnF2.Text = "Apri Form F2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF3
            // 
            this.btnF3.Location = new System.Drawing.Point(94, 13);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(75, 23);
            this.btnF3.TabIndex = 1;
            this.btnF3.Text = "Apri Form F3";
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF4Param
            // 
            this.btnF4Param.Location = new System.Drawing.Point(176, 13);
            this.btnF4Param.Name = "btnF4Param";
            this.btnF4Param.Size = new System.Drawing.Size(138, 23);
            this.btnF4Param.TabIndex = 2;
            this.btnF4Param.Text = "Apri form con parametro";
            this.btnF4Param.UseVisualStyleBackColor = true;
            this.btnF4Param.Click += new System.EventHandler(this.btnF4Param_Click);
            // 
            // txtMesaggio
            // 
            this.txtMesaggio.Location = new System.Drawing.Point(94, 59);
            this.txtMesaggio.Name = "txtMesaggio";
            this.txtMesaggio.Size = new System.Drawing.Size(100, 20);
            this.txtMesaggio.TabIndex = 3;
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(13, 57);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(75, 23);
            this.btnF5.TabIndex = 4;
            this.btnF5.Text = "Apri form 5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 209);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.txtMesaggio);
            this.Controls.Add(this.btnF4Param);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF4Param;
        private System.Windows.Forms.TextBox txtMesaggio;
        private System.Windows.Forms.Button btnF5;
    }
}

