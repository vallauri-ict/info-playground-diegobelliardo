namespace _06_QueueProntoSoccorso
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnProssimoPaziente = new System.Windows.Forms.Button();
            this.cmbColori = new System.Windows.Forms.ComboBox();
            this.btnInserisci2 = new System.Windows.Forms.Button();
            this.btnProssimoPaziente2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(77, 36);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Età:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colore:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(12, 102);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnProssimoPaziente
            // 
            this.btnProssimoPaziente.Location = new System.Drawing.Point(120, 102);
            this.btnProssimoPaziente.Name = "btnProssimoPaziente";
            this.btnProssimoPaziente.Size = new System.Drawing.Size(75, 55);
            this.btnProssimoPaziente.TabIndex = 7;
            this.btnProssimoPaziente.Text = "Prossimo paziente";
            this.btnProssimoPaziente.UseVisualStyleBackColor = true;
            this.btnProssimoPaziente.Click += new System.EventHandler(this.btnProssimoPaziente_Click);
            // 
            // cmbColori
            // 
            this.cmbColori.FormattingEnabled = true;
            this.cmbColori.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbColori.Location = new System.Drawing.Point(77, 62);
            this.cmbColori.Name = "cmbColori";
            this.cmbColori.Size = new System.Drawing.Size(121, 21);
            this.cmbColori.TabIndex = 8;
            // 
            // btnInserisci2
            // 
            this.btnInserisci2.Location = new System.Drawing.Point(12, 184);
            this.btnInserisci2.Name = "btnInserisci2";
            this.btnInserisci2.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci2.TabIndex = 9;
            this.btnInserisci2.Text = "Inserisci2";
            this.btnInserisci2.UseVisualStyleBackColor = true;
            this.btnInserisci2.Click += new System.EventHandler(this.btnInserisci2_Click);
            // 
            // btnProssimoPaziente2
            // 
            this.btnProssimoPaziente2.Location = new System.Drawing.Point(120, 184);
            this.btnProssimoPaziente2.Name = "btnProssimoPaziente2";
            this.btnProssimoPaziente2.Size = new System.Drawing.Size(75, 55);
            this.btnProssimoPaziente2.TabIndex = 10;
            this.btnProssimoPaziente2.Text = "Prossimo paziente2";
            this.btnProssimoPaziente2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 264);
            this.Controls.Add(this.btnProssimoPaziente2);
            this.Controls.Add(this.btnInserisci2);
            this.Controls.Add(this.cmbColori);
            this.Controls.Add(this.btnProssimoPaziente);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnProssimoPaziente;
        private System.Windows.Forms.ComboBox cmbColori;
        private System.Windows.Forms.Button btnInserisci2;
        private System.Windows.Forms.Button btnProssimoPaziente2;
    }
}

