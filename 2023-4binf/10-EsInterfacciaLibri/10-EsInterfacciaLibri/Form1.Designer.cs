namespace _10_EsInterfacciaLibri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVenduto = new System.Windows.Forms.Button();
            this.btnTotaleVendite = new System.Windows.Forms.Button();
            this.btnLibriVenduti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(55, 10);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(364, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(55, 36);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(220, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore:";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(55, 62);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(84, 20);
            this.txtPrezzo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezzo:";
            // 
            // btnVenduto
            // 
            this.btnVenduto.Location = new System.Drawing.Point(16, 103);
            this.btnVenduto.Name = "btnVenduto";
            this.btnVenduto.Size = new System.Drawing.Size(112, 23);
            this.btnVenduto.TabIndex = 6;
            this.btnVenduto.Text = "Libro venduto";
            this.btnVenduto.UseVisualStyleBackColor = true;
            this.btnVenduto.Click += new System.EventHandler(this.btnVenduto_Click);
            // 
            // btnTotaleVendite
            // 
            this.btnTotaleVendite.Location = new System.Drawing.Point(16, 133);
            this.btnTotaleVendite.Name = "btnTotaleVendite";
            this.btnTotaleVendite.Size = new System.Drawing.Size(112, 23);
            this.btnTotaleVendite.TabIndex = 7;
            this.btnTotaleVendite.Text = "Totale vendite";
            this.btnTotaleVendite.UseVisualStyleBackColor = true;
            this.btnTotaleVendite.Click += new System.EventHandler(this.btnTotaleVendite_Click);
            // 
            // btnLibriVenduti
            // 
            this.btnLibriVenduti.Location = new System.Drawing.Point(163, 133);
            this.btnLibriVenduti.Name = "btnLibriVenduti";
            this.btnLibriVenduti.Size = new System.Drawing.Size(112, 23);
            this.btnLibriVenduti.TabIndex = 8;
            this.btnLibriVenduti.Text = "Elenco libri venduti";
            this.btnLibriVenduti.UseVisualStyleBackColor = true;
            this.btnLibriVenduti.Click += new System.EventHandler(this.btnLibriVenduti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 170);
            this.Controls.Add(this.btnLibriVenduti);
            this.Controls.Add(this.btnTotaleVendite);
            this.Controls.Add(this.btnVenduto);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BookStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVenduto;
        private System.Windows.Forms.Button btnTotaleVendite;
        private System.Windows.Forms.Button btnLibriVenduti;
    }
}

