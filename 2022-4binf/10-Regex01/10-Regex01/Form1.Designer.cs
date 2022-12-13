namespace _10_Regex01
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
            this.txtStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOneCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(178, 23);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(176, 20);
            this.txtStr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci la stringa da controllare:";
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(92, 61);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(143, 23);
            this.btnCarta.TabIndex = 2;
            this.btnCarta.Text = "Testa Numero Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uso di Match nella stringa: \"One car red car blue car\"";
            // 
            // btnOneCar
            // 
            this.btnOneCar.Location = new System.Drawing.Point(515, 61);
            this.btnOneCar.Name = "btnOneCar";
            this.btnOneCar.Size = new System.Drawing.Size(75, 23);
            this.btnOneCar.TabIndex = 4;
            this.btnOneCar.Text = "Test stringa";
            this.btnOneCar.UseVisualStyleBackColor = true;
            this.btnOneCar.Click += new System.EventHandler(this.btnOneCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uso di Split su: 123ABCDE456FGHIJKL789MNOPQ012";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(92, 159);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Test Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 318);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOneCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOneCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSplit;
    }
}

