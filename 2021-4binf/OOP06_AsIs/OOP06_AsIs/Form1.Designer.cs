namespace OOP06_AsIs
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
            this.btnGeneraMostro = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDue = new System.Windows.Forms.Button();
            this.btnTre = new System.Windows.Forms.Button();
            this.lblUno = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblTre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneraMostro
            // 
            this.btnGeneraMostro.Location = new System.Drawing.Point(13, 13);
            this.btnGeneraMostro.Name = "btnGeneraMostro";
            this.btnGeneraMostro.Size = new System.Drawing.Size(110, 23);
            this.btnGeneraMostro.TabIndex = 0;
            this.btnGeneraMostro.Text = "Genera Mostro";
            this.btnGeneraMostro.UseVisualStyleBackColor = true;
            this.btnGeneraMostro.Click += new System.EventHandler(this.btnGeneraMostro_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(13, 84);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 23);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "button1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDue
            // 
            this.btnDue.Location = new System.Drawing.Point(94, 84);
            this.btnDue.Name = "btnDue";
            this.btnDue.Size = new System.Drawing.Size(75, 23);
            this.btnDue.TabIndex = 2;
            this.btnDue.Text = "button2";
            this.btnDue.UseVisualStyleBackColor = true;
            this.btnDue.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnTre
            // 
            this.btnTre.Location = new System.Drawing.Point(175, 84);
            this.btnTre.Name = "btnTre";
            this.btnTre.Size = new System.Drawing.Size(75, 23);
            this.btnTre.TabIndex = 3;
            this.btnTre.Text = "button3";
            this.btnTre.UseVisualStyleBackColor = true;
            this.btnTre.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(10, 110);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(35, 13);
            this.lblUno.TabIndex = 4;
            this.lblUno.Text = "label1";
            this.lblUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(91, 110);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(35, 13);
            this.lblDue.TabIndex = 5;
            this.lblDue.Text = "label2";
            this.lblDue.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // lblTre
            // 
            this.lblTre.AutoSize = true;
            this.lblTre.Location = new System.Drawing.Point(172, 110);
            this.lblTre.Name = "lblTre";
            this.lblTre.Size = new System.Drawing.Size(35, 13);
            this.lblTre.TabIndex = 6;
            this.lblTre.Text = "label3";
            this.lblTre.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 164);
            this.Controls.Add(this.lblTre);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.btnTre);
            this.Controls.Add(this.btnDue);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnGeneraMostro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneraMostro;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDue;
        private System.Windows.Forms.Button btnTre;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblTre;
    }
}

