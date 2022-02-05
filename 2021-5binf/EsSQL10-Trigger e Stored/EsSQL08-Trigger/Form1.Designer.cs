namespace EsSQL08_Trigger
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
            this.btnStoricCancellazioni = new System.Windows.Forms.Button();
            this.btnStoricoAggiornamenti = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserire la data:";
            // 
            // btnStoricCancellazioni
            // 
            this.btnStoricCancellazioni.Location = new System.Drawing.Point(16, 70);
            this.btnStoricCancellazioni.Name = "btnStoricCancellazioni";
            this.btnStoricCancellazioni.Size = new System.Drawing.Size(133, 23);
            this.btnStoricCancellazioni.TabIndex = 2;
            this.btnStoricCancellazioni.Text = "Elementi cancellati";
            this.btnStoricCancellazioni.UseVisualStyleBackColor = true;
            this.btnStoricCancellazioni.Click += new System.EventHandler(this.btnStoricCancellazioni_Click);
            // 
            // btnStoricoAggiornamenti
            // 
            this.btnStoricoAggiornamenti.Location = new System.Drawing.Point(197, 70);
            this.btnStoricoAggiornamenti.Name = "btnStoricoAggiornamenti";
            this.btnStoricoAggiornamenti.Size = new System.Drawing.Size(133, 23);
            this.btnStoricoAggiornamenti.TabIndex = 3;
            this.btnStoricoAggiornamenti.Text = "Elementi aggiornati";
            this.btnStoricoAggiornamenti.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(120, 7);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 138);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnStoricoAggiornamenti);
            this.Controls.Add(this.btnStoricCancellazioni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStoricCancellazioni;
        private System.Windows.Forms.Button btnStoricoAggiornamenti;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}

