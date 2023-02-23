
namespace _50_Uguaglianza
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
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtNomeCerca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVisualizza = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCognomeCerca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(12, 81);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 3;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(287, 81);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // txtNomeCerca
            // 
            this.txtNomeCerca.Location = new System.Drawing.Point(352, 10);
            this.txtNomeCerca.Name = "txtNomeCerca";
            this.txtNomeCerca.Size = new System.Drawing.Size(100, 22);
            this.txtNomeCerca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtVisualizza
            // 
            this.txtVisualizza.Location = new System.Drawing.Point(16, 119);
            this.txtVisualizza.Multiline = true;
            this.txtVisualizza.Name = "txtVisualizza";
            this.txtVisualizza.Size = new System.Drawing.Size(100, 131);
            this.txtVisualizza.TabIndex = 7;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(81, 42);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 22);
            this.txtCognome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // txtCognomeCerca
            // 
            this.txtCognomeCerca.Location = new System.Drawing.Point(352, 42);
            this.txtCognomeCerca.Name = "txtCognomeCerca";
            this.txtCognomeCerca.Size = new System.Drawing.Size(100, 22);
            this.txtCognomeCerca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cognome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 282);
            this.Controls.Add(this.txtCognomeCerca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVisualizza);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtNomeCerca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserisci);
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
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtNomeCerca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVisualizza;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCognomeCerca;
        private System.Windows.Forms.Label label4;
    }
}

