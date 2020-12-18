namespace _10_OOP_PersoneStudenti
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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddStudente = new System.Windows.Forms.Button();
            this.listStudenti = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnInserisciVoto = new System.Windows.Forms.Button();
            this.btnVoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(94, 36);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(94, 62);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Età";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(94, 88);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 20);
            this.txtSesso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sesso";
            // 
            // btnAddStudente
            // 
            this.btnAddStudente.Location = new System.Drawing.Point(50, 138);
            this.btnAddStudente.Name = "btnAddStudente";
            this.btnAddStudente.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudente.TabIndex = 8;
            this.btnAddStudente.Text = "Carcia";
            this.btnAddStudente.UseVisualStyleBackColor = true;
            this.btnAddStudente.Click += new System.EventHandler(this.btnAddStudente_Click);
            // 
            // listStudenti
            // 
            this.listStudenti.HideSelection = false;
            this.listStudenti.Location = new System.Drawing.Point(230, 10);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(129, 280);
            this.listStudenti.TabIndex = 9;
            this.listStudenti.UseCompatibleStateImageBehavior = false;
            this.listStudenti.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voto";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(477, 10);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 11;
            // 
            // btnInserisciVoto
            // 
            this.btnInserisciVoto.Location = new System.Drawing.Point(477, 54);
            this.btnInserisciVoto.Name = "btnInserisciVoto";
            this.btnInserisciVoto.Size = new System.Drawing.Size(75, 23);
            this.btnInserisciVoto.TabIndex = 12;
            this.btnInserisciVoto.Text = "Carica Voto";
            this.btnInserisciVoto.UseVisualStyleBackColor = true;
            this.btnInserisciVoto.Click += new System.EventHandler(this.btnInserisciVoto_Click);
            // 
            // btnVoti
            // 
            this.btnVoti.Location = new System.Drawing.Point(477, 122);
            this.btnVoti.Name = "btnVoti";
            this.btnVoti.Size = new System.Drawing.Size(118, 23);
            this.btnVoti.TabIndex = 13;
            this.btnVoti.Text = "Visualizza Voti";
            this.btnVoti.UseVisualStyleBackColor = true;
            this.btnVoti.Click += new System.EventHandler(this.btnVoti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoti);
            this.Controls.Add(this.btnInserisciVoto);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.btnAddStudente);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
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
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddStudente;
        private System.Windows.Forms.ListView listStudenti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnInserisciVoto;
        private System.Windows.Forms.Button btnVoti;
    }
}

