namespace _11_EsInterfacceLibreria
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNTessera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggUtente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsAutore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitoloInsLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserisciLibro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitoloPrestito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPrestito = new System.Windows.Forms.Button();
            this.btnRestituisci = new System.Windows.Forms.Button();
            this.btnStatoPrestiti = new System.Windows.Forms.Button();
            this.txtInsPagine = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtNTessera
            // 
            this.txtNTessera.Location = new System.Drawing.Point(152, 110);
            this.txtNTessera.Name = "txtNTessera";
            this.txtNTessera.Size = new System.Drawing.Size(146, 26);
            this.txtNTessera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero tessera:";
            // 
            // btnAggUtente
            // 
            this.btnAggUtente.Location = new System.Drawing.Point(63, 158);
            this.btnAggUtente.Name = "btnAggUtente";
            this.btnAggUtente.Size = new System.Drawing.Size(183, 38);
            this.btnAggUtente.TabIndex = 5;
            this.btnAggUtente.Text = "Aggiungi Utente";
            this.btnAggUtente.UseVisualStyleBackColor = true;
            this.btnAggUtente.Click += new System.EventHandler(this.btnAggUtente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "LIBRI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInsAutore
            // 
            this.txtInsAutore.Location = new System.Drawing.Point(448, 101);
            this.txtInsAutore.Name = "txtInsAutore";
            this.txtInsAutore.Size = new System.Drawing.Size(212, 26);
            this.txtInsAutore.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autore:";
            // 
            // txtTitoloInsLibro
            // 
            this.txtTitoloInsLibro.Location = new System.Drawing.Point(448, 69);
            this.txtTitoloInsLibro.Name = "txtTitoloInsLibro";
            this.txtTitoloInsLibro.Size = new System.Drawing.Size(213, 26);
            this.txtTitoloInsLibro.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Titolo:";
            // 
            // btnInserisciLibro
            // 
            this.btnInserisciLibro.Location = new System.Drawing.Point(422, 180);
            this.btnInserisciLibro.Name = "btnInserisciLibro";
            this.btnInserisciLibro.Size = new System.Drawing.Size(183, 38);
            this.btnInserisciLibro.TabIndex = 12;
            this.btnInserisciLibro.Text = "Inserisci libro";
            this.btnInserisciLibro.UseVisualStyleBackColor = true;
            this.btnInserisciLibro.Click += new System.EventHandler(this.btnInserisciLibro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRESTITO/RESTITUZIONE";
            // 
            // txtTitoloPrestito
            // 
            this.txtTitoloPrestito.Location = new System.Drawing.Point(93, 306);
            this.txtTitoloPrestito.Name = "txtTitoloPrestito";
            this.txtTitoloPrestito.Size = new System.Drawing.Size(213, 26);
            this.txtTitoloPrestito.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Titolo:";
            // 
            // btnPrestito
            // 
            this.btnPrestito.Location = new System.Drawing.Point(23, 360);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(183, 38);
            this.btnPrestito.TabIndex = 16;
            this.btnPrestito.Text = "Prendi in prestito";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // btnRestituisci
            // 
            this.btnRestituisci.Location = new System.Drawing.Point(242, 360);
            this.btnRestituisci.Name = "btnRestituisci";
            this.btnRestituisci.Size = new System.Drawing.Size(183, 38);
            this.btnRestituisci.TabIndex = 17;
            this.btnRestituisci.Text = "Restituisci";
            this.btnRestituisci.UseVisualStyleBackColor = true;
            // 
            // btnStatoPrestiti
            // 
            this.btnStatoPrestiti.Location = new System.Drawing.Point(682, 269);
            this.btnStatoPrestiti.Name = "btnStatoPrestiti";
            this.btnStatoPrestiti.Size = new System.Drawing.Size(239, 128);
            this.btnStatoPrestiti.TabIndex = 18;
            this.btnStatoPrestiti.Text = "Visualizza stato prestiti";
            this.btnStatoPrestiti.UseVisualStyleBackColor = true;
            this.btnStatoPrestiti.Click += new System.EventHandler(this.btnStatoPrestiti_Click);
            // 
            // txtInsPagine
            // 
            this.txtInsPagine.Location = new System.Drawing.Point(447, 133);
            this.txtInsPagine.Name = "txtInsPagine";
            this.txtInsPagine.Size = new System.Drawing.Size(212, 26);
            this.txtInsPagine.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "N Pagine:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(833, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "DVD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 416);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInsPagine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStatoPrestiti);
            this.Controls.Add(this.btnRestituisci);
            this.Controls.Add(this.btnPrestito);
            this.Controls.Add(this.txtTitoloPrestito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInserisciLibro);
            this.Controls.Add(this.txtInsAutore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitoloInsLibro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAggUtente);
            this.Controls.Add(this.txtNTessera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNTessera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggUtente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsAutore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitoloInsLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserisciLibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitoloPrestito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrestito;
        private System.Windows.Forms.Button btnRestituisci;
        private System.Windows.Forms.Button btnStatoPrestiti;
        private System.Windows.Forms.TextBox txtInsPagine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

