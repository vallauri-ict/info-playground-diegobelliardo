namespace _14_SecondoEsDelegateDispense
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
            this.txtValoreSoglia = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnIncrementa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valore Soglia";
            // 
            // txtValoreSoglia
            // 
            this.txtValoreSoglia.Location = new System.Drawing.Point(88, 10);
            this.txtValoreSoglia.Name = "txtValoreSoglia";
            this.txtValoreSoglia.Size = new System.Drawing.Size(100, 20);
            this.txtValoreSoglia.TabIndex = 1;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(16, 56);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(98, 23);
            this.btnCrea.TabIndex = 2;
            this.btnCrea.Text = "Crea contatore";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnIncrementa
            // 
            this.btnIncrementa.Location = new System.Drawing.Point(16, 85);
            this.btnIncrementa.Name = "btnIncrementa";
            this.btnIncrementa.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementa.TabIndex = 3;
            this.btnIncrementa.Text = "Incrementa";
            this.btnIncrementa.UseVisualStyleBackColor = true;
            this.btnIncrementa.Click += new System.EventHandler(this.btnIncrementa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 123);
            this.Controls.Add(this.btnIncrementa);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtValoreSoglia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValoreSoglia;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnIncrementa;
    }
}

