namespace _13_PrimoEsDelegate
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
            this.btnPiu = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.btnMeno2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPiu
            // 
            this.btnPiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiu.Location = new System.Drawing.Point(13, 13);
            this.btnPiu.Name = "btnPiu";
            this.btnPiu.Size = new System.Drawing.Size(65, 62);
            this.btnPiu.TabIndex = 0;
            this.btnPiu.Text = "+";
            this.btnPiu.UseVisualStyleBackColor = true;
            this.btnPiu.Click += new System.EventHandler(this.btnPiu_Click);
            // 
            // btnPer
            // 
            this.btnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPer.Location = new System.Drawing.Point(105, 13);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(65, 62);
            this.btnPer.TabIndex = 1;
            this.btnPer.Text = "*";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeno.Location = new System.Drawing.Point(200, 13);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(65, 62);
            this.btnMeno.TabIndex = 2;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // btnMeno2
            // 
            this.btnMeno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeno2.Location = new System.Drawing.Point(292, 13);
            this.btnMeno2.Name = "btnMeno2";
            this.btnMeno2.Size = new System.Drawing.Size(65, 62);
            this.btnMeno2.TabIndex = 3;
            this.btnMeno2.Text = "-";
            this.btnMeno2.UseVisualStyleBackColor = true;
            this.btnMeno2.Click += new System.EventHandler(this.btnMeno2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 99);
            this.Controls.Add(this.btnMeno2);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnPiu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiu;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.Button btnMeno2;
    }
}

