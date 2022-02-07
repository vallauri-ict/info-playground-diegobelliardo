namespace Data_e_orario
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
            this.btnCreaDataPredefinita = new System.Windows.Forms.Button();
            this.btnCreaDataOrario = new System.Windows.Forms.Button();
            this.txtGiorno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecondi = new System.Windows.Forms.TextBox();
            this.btnCreaDataParametri = new System.Windows.Forms.Button();
            this.btnLeggiData = new System.Windows.Forms.Button();
            this.btnScrividata = new System.Windows.Forms.Button();
            this.btnLeggiStringaData = new System.Windows.Forms.Button();
            this.btnLeggiOrario = new System.Windows.Forms.Button();
            this.btnScriviOrario = new System.Windows.Forms.Button();
            this.btnLeggiStringaOrario = new System.Windows.Forms.Button();
            this.btnLeggiGiorno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaDataPredefinita
            // 
            this.btnCreaDataPredefinita.Location = new System.Drawing.Point(62, 50);
            this.btnCreaDataPredefinita.Name = "btnCreaDataPredefinita";
            this.btnCreaDataPredefinita.Size = new System.Drawing.Size(107, 49);
            this.btnCreaDataPredefinita.TabIndex = 0;
            this.btnCreaDataPredefinita.Text = "Crea Data Predefinita";
            this.btnCreaDataPredefinita.UseVisualStyleBackColor = true;
            this.btnCreaDataPredefinita.Click += new System.EventHandler(this.btnCreaDataPredefinita_Click);
            // 
            // btnCreaDataOrario
            // 
            this.btnCreaDataOrario.Location = new System.Drawing.Point(552, 50);
            this.btnCreaDataOrario.Name = "btnCreaDataOrario";
            this.btnCreaDataOrario.Size = new System.Drawing.Size(108, 38);
            this.btnCreaDataOrario.TabIndex = 1;
            this.btnCreaDataOrario.Text = "Crea DataOrario";
            this.btnCreaDataOrario.UseVisualStyleBackColor = true;
            this.btnCreaDataOrario.Click += new System.EventHandler(this.btnCreaDataOrario_Click);
            // 
            // txtGiorno
            // 
            this.txtGiorno.Location = new System.Drawing.Point(332, 202);
            this.txtGiorno.Name = "txtGiorno";
            this.txtGiorno.Size = new System.Drawing.Size(100, 20);
            this.txtGiorno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mese";
            // 
            // txtMese
            // 
            this.txtMese.Location = new System.Drawing.Point(332, 237);
            this.txtMese.Name = "txtMese";
            this.txtMese.Size = new System.Drawing.Size(100, 20);
            this.txtMese.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anno";
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(332, 276);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(100, 20);
            this.txtAnno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ore";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(332, 315);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 20);
            this.txtOre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minuti";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Location = new System.Drawing.Point(332, 352);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(100, 20);
            this.txtMinuti.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Secondi";
            // 
            // txtSecondi
            // 
            this.txtSecondi.Location = new System.Drawing.Point(332, 388);
            this.txtSecondi.Name = "txtSecondi";
            this.txtSecondi.Size = new System.Drawing.Size(100, 20);
            this.txtSecondi.TabIndex = 12;
            // 
            // btnCreaDataParametri
            // 
            this.btnCreaDataParametri.Location = new System.Drawing.Point(62, 105);
            this.btnCreaDataParametri.Name = "btnCreaDataParametri";
            this.btnCreaDataParametri.Size = new System.Drawing.Size(107, 49);
            this.btnCreaDataParametri.TabIndex = 14;
            this.btnCreaDataParametri.Text = "Crea Data con parametri";
            this.btnCreaDataParametri.UseVisualStyleBackColor = true;
            this.btnCreaDataParametri.Click += new System.EventHandler(this.btnCreaDataParametri_Click);
            // 
            // btnLeggiData
            // 
            this.btnLeggiData.Location = new System.Drawing.Point(62, 160);
            this.btnLeggiData.Name = "btnLeggiData";
            this.btnLeggiData.Size = new System.Drawing.Size(107, 49);
            this.btnLeggiData.TabIndex = 15;
            this.btnLeggiData.Text = "Leggi data";
            this.btnLeggiData.UseVisualStyleBackColor = true;
            this.btnLeggiData.Click += new System.EventHandler(this.btnLeggiData_Click);
            // 
            // btnScrividata
            // 
            this.btnScrividata.Location = new System.Drawing.Point(62, 222);
            this.btnScrividata.Name = "btnScrividata";
            this.btnScrividata.Size = new System.Drawing.Size(107, 49);
            this.btnScrividata.TabIndex = 16;
            this.btnScrividata.Text = "Scrivi data";
            this.btnScrividata.UseVisualStyleBackColor = true;
            this.btnScrividata.Click += new System.EventHandler(this.btnScrividata_Click);
            // 
            // btnLeggiStringaData
            // 
            this.btnLeggiStringaData.Location = new System.Drawing.Point(62, 286);
            this.btnLeggiStringaData.Name = "btnLeggiStringaData";
            this.btnLeggiStringaData.Size = new System.Drawing.Size(107, 49);
            this.btnLeggiStringaData.TabIndex = 17;
            this.btnLeggiStringaData.Text = "Leggi stringa data";
            this.btnLeggiStringaData.UseVisualStyleBackColor = true;
            this.btnLeggiStringaData.Click += new System.EventHandler(this.btnLeggiStringaData_Click);
            // 
            // btnLeggiOrario
            // 
            this.btnLeggiOrario.Location = new System.Drawing.Point(553, 123);
            this.btnLeggiOrario.Name = "btnLeggiOrario";
            this.btnLeggiOrario.Size = new System.Drawing.Size(107, 49);
            this.btnLeggiOrario.TabIndex = 18;
            this.btnLeggiOrario.Text = "Leggi Orario";
            this.btnLeggiOrario.UseVisualStyleBackColor = true;
            this.btnLeggiOrario.Click += new System.EventHandler(this.btnLeggiOrario_Click);
            // 
            // btnScriviOrario
            // 
            this.btnScriviOrario.Location = new System.Drawing.Point(552, 202);
            this.btnScriviOrario.Name = "btnScriviOrario";
            this.btnScriviOrario.Size = new System.Drawing.Size(107, 49);
            this.btnScriviOrario.TabIndex = 19;
            this.btnScriviOrario.Text = "ScriviOrario";
            this.btnScriviOrario.UseVisualStyleBackColor = true;
            this.btnScriviOrario.Click += new System.EventHandler(this.btnScriviOrario_Click);
            // 
            // btnLeggiStringaOrario
            // 
            this.btnLeggiStringaOrario.Location = new System.Drawing.Point(553, 279);
            this.btnLeggiStringaOrario.Name = "btnLeggiStringaOrario";
            this.btnLeggiStringaOrario.Size = new System.Drawing.Size(107, 49);
            this.btnLeggiStringaOrario.TabIndex = 20;
            this.btnLeggiStringaOrario.Text = "Leggi stringa orario";
            this.btnLeggiStringaOrario.UseVisualStyleBackColor = true;
            this.btnLeggiStringaOrario.Click += new System.EventHandler(this.btnLeggiStringaOrario_Click);
            // 
            // btnLeggiGiorno
            // 
            this.btnLeggiGiorno.Location = new System.Drawing.Point(62, 352);
            this.btnLeggiGiorno.Name = "btnLeggiGiorno";
            this.btnLeggiGiorno.Size = new System.Drawing.Size(107, 49);
            this.btnLeggiGiorno.TabIndex = 21;
            this.btnLeggiGiorno.Text = "Leggi giorno";
            this.btnLeggiGiorno.UseVisualStyleBackColor = true;
            this.btnLeggiGiorno.Click += new System.EventHandler(this.btnLeggiGiorno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeggiGiorno);
            this.Controls.Add(this.btnLeggiStringaOrario);
            this.Controls.Add(this.btnScriviOrario);
            this.Controls.Add(this.btnLeggiOrario);
            this.Controls.Add(this.btnLeggiStringaData);
            this.Controls.Add(this.btnScrividata);
            this.Controls.Add(this.btnLeggiData);
            this.Controls.Add(this.btnCreaDataParametri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSecondi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinuti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMese);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiorno);
            this.Controls.Add(this.btnCreaDataOrario);
            this.Controls.Add(this.btnCreaDataPredefinita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreaDataPredefinita;
        private System.Windows.Forms.Button btnCreaDataOrario;
        private System.Windows.Forms.TextBox txtGiorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecondi;
        private System.Windows.Forms.Button btnCreaDataParametri;
        private System.Windows.Forms.Button btnLeggiData;
        private System.Windows.Forms.Button btnScrividata;
        private System.Windows.Forms.Button btnLeggiStringaData;
        private System.Windows.Forms.Button btnLeggiOrario;
        private System.Windows.Forms.Button btnScriviOrario;
        private System.Windows.Forms.Button btnLeggiStringaOrario;
        private System.Windows.Forms.Button btnLeggiGiorno;
    }
}

