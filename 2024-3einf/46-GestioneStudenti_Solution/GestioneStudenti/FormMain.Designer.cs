namespace GestioneStudenti
{
    partial class FormMain
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnStudSenzaVoti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnInserisciStudente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterie = new System.Windows.Forms.ComboBox();
            this.nudVoto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLaboratorio = new System.Windows.Forms.RadioButton();
            this.rdbOrale = new System.Windows.Forms.RadioButton();
            this.rdbScritto = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMatricole = new System.Windows.Forms.ComboBox();
            this.btnRicStudMat = new System.Windows.Forms.Button();
            this.btnRicStudCogN = new System.Windows.Forms.Button();
            this.btnOrdinaStudNominativo = new System.Windows.Forms.Button();
            this.btnContaStudClasse = new System.Windows.Forms.Button();
            this.btnContaVotiStudClasse = new System.Windows.Forms.Button();
            this.btnInserisciVoto = new System.Windows.Forms.Button();
            this.btnMediaPerMateria = new System.Windows.Forms.Button();
            this.btnContaVotiPerTipoPerStudente = new System.Windows.Forms.Button();
            this.btnNumVotiPerStudente = new System.Windows.Forms.Button();
            this.btnCercaStudenteMediaMaggiore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(8, 8);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 62;
            this.dgvStudenti.RowTemplate.Height = 28;
            this.dgvStudenti.Size = new System.Drawing.Size(485, 156);
            this.dgvStudenti.TabIndex = 0;
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(505, 8);
            this.dgvValutazioni.Margin = new System.Windows.Forms.Padding(2);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.RowHeadersWidth = 62;
            this.dgvValutazioni.RowTemplate.Height = 28;
            this.dgvValutazioni.Size = new System.Drawing.Size(443, 156);
            this.dgvValutazioni.TabIndex = 1;
            // 
            // btnStudSenzaVoti
            // 
            this.btnStudSenzaVoti.Location = new System.Drawing.Point(955, 8);
            this.btnStudSenzaVoti.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudSenzaVoti.Name = "btnStudSenzaVoti";
            this.btnStudSenzaVoti.Size = new System.Drawing.Size(139, 25);
            this.btnStudSenzaVoti.TabIndex = 2;
            this.btnStudSenzaVoti.Text = "STUDENTI SENZA VOTI";
            this.btnStudSenzaVoti.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COGNOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLASSE:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(74, 177);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(2);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(139, 20);
            this.txtCognome.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 203);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 20);
            this.txtNome.TabIndex = 7;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(74, 229);
            this.cmbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(139, 21);
            this.cmbClasse.TabIndex = 8;
            // 
            // btnInserisciStudente
            // 
            this.btnInserisciStudente.Location = new System.Drawing.Point(9, 261);
            this.btnInserisciStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserisciStudente.Name = "btnInserisciStudente";
            this.btnInserisciStudente.Size = new System.Drawing.Size(204, 25);
            this.btnInserisciStudente.TabIndex = 9;
            this.btnInserisciStudente.Text = "INSERISCI STUDENTE";
            this.btnInserisciStudente.UseVisualStyleBackColor = true;
            this.btnInserisciStudente.Click += new System.EventHandler(this.btnInserisciStudente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "VOTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MATERIA:";
            // 
            // cmbMaterie
            // 
            this.cmbMaterie.FormattingEnabled = true;
            this.cmbMaterie.Items.AddRange(new object[] {
            "Italiano",
            "Matematica",
            "Storia",
            "Informatica",
            "Sistemi",
            "Inglese",
            "TPSIT",
            "Telecominucazioni",
            "Motoria"});
            this.cmbMaterie.Location = new System.Drawing.Point(578, 176);
            this.cmbMaterie.Name = "cmbMaterie";
            this.cmbMaterie.Size = new System.Drawing.Size(139, 21);
            this.cmbMaterie.TabIndex = 14;
            // 
            // nudVoto
            // 
            this.nudVoto.Location = new System.Drawing.Point(578, 203);
            this.nudVoto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVoto.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudVoto.Name = "nudVoto";
            this.nudVoto.Size = new System.Drawing.Size(139, 20);
            this.nudVoto.TabIndex = 15;
            this.nudVoto.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbLaboratorio);
            this.groupBox1.Controls.Add(this.rdbOrale);
            this.groupBox1.Controls.Add(this.rdbScritto);
            this.groupBox1.Location = new System.Drawing.Point(505, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // rdbLaboratorio
            // 
            this.rdbLaboratorio.AutoSize = true;
            this.rdbLaboratorio.Location = new System.Drawing.Point(42, 65);
            this.rdbLaboratorio.Name = "rdbLaboratorio";
            this.rdbLaboratorio.Size = new System.Drawing.Size(102, 17);
            this.rdbLaboratorio.TabIndex = 2;
            this.rdbLaboratorio.TabStop = true;
            this.rdbLaboratorio.Text = "LABORATORIO";
            this.rdbLaboratorio.UseVisualStyleBackColor = true;
            // 
            // rdbOrale
            // 
            this.rdbOrale.AutoSize = true;
            this.rdbOrale.Location = new System.Drawing.Point(42, 42);
            this.rdbOrale.Name = "rdbOrale";
            this.rdbOrale.Size = new System.Drawing.Size(61, 17);
            this.rdbOrale.TabIndex = 1;
            this.rdbOrale.TabStop = true;
            this.rdbOrale.Text = "ORALE";
            this.rdbOrale.UseVisualStyleBackColor = true;
            // 
            // rdbScritto
            // 
            this.rdbScritto.AutoSize = true;
            this.rdbScritto.Location = new System.Drawing.Point(42, 19);
            this.rdbScritto.Name = "rdbScritto";
            this.rdbScritto.Size = new System.Drawing.Size(72, 17);
            this.rdbScritto.TabIndex = 0;
            this.rdbScritto.TabStop = true;
            this.rdbScritto.Text = "SCRITTO";
            this.rdbScritto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "MATRICOLA:";
            // 
            // cmbMatricole
            // 
            this.cmbMatricole.FormattingEnabled = true;
            this.cmbMatricole.Location = new System.Drawing.Point(579, 335);
            this.cmbMatricole.Name = "cmbMatricole";
            this.cmbMatricole.Size = new System.Drawing.Size(139, 21);
            this.cmbMatricole.TabIndex = 18;
            // 
            // btnRicStudMat
            // 
            this.btnRicStudMat.Location = new System.Drawing.Point(9, 296);
            this.btnRicStudMat.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicStudMat.Name = "btnRicStudMat";
            this.btnRicStudMat.Size = new System.Drawing.Size(204, 43);
            this.btnRicStudMat.TabIndex = 19;
            this.btnRicStudMat.Text = "RICERCA STUDENTE IN BASE ALLA MATRICOLA";
            this.btnRicStudMat.UseVisualStyleBackColor = true;
            this.btnRicStudMat.Click += new System.EventHandler(this.btnRicStudMat_Click);
            // 
            // btnRicStudCogN
            // 
            this.btnRicStudCogN.Location = new System.Drawing.Point(9, 343);
            this.btnRicStudCogN.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicStudCogN.Name = "btnRicStudCogN";
            this.btnRicStudCogN.Size = new System.Drawing.Size(204, 43);
            this.btnRicStudCogN.TabIndex = 20;
            this.btnRicStudCogN.Text = "RICERCA STUDENTE IN BASE A COGNOME E NOME";
            this.btnRicStudCogN.UseVisualStyleBackColor = true;
            this.btnRicStudCogN.Click += new System.EventHandler(this.btnRicStudCogN_Click);
            // 
            // btnOrdinaStudNominativo
            // 
            this.btnOrdinaStudNominativo.Location = new System.Drawing.Point(9, 390);
            this.btnOrdinaStudNominativo.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdinaStudNominativo.Name = "btnOrdinaStudNominativo";
            this.btnOrdinaStudNominativo.Size = new System.Drawing.Size(204, 43);
            this.btnOrdinaStudNominativo.TabIndex = 21;
            this.btnOrdinaStudNominativo.Text = "ORDINA STUDENTE IN BASE AL NOMINATIVO";
            this.btnOrdinaStudNominativo.UseVisualStyleBackColor = true;
            this.btnOrdinaStudNominativo.Click += new System.EventHandler(this.btnOrdinaStudNominativo_Click);
            // 
            // btnContaStudClasse
            // 
            this.btnContaStudClasse.Location = new System.Drawing.Point(10, 437);
            this.btnContaStudClasse.Margin = new System.Windows.Forms.Padding(2);
            this.btnContaStudClasse.Name = "btnContaStudClasse";
            this.btnContaStudClasse.Size = new System.Drawing.Size(203, 43);
            this.btnContaStudClasse.TabIndex = 22;
            this.btnContaStudClasse.Text = "CONTA NUMERO STUDENTI IN CLASSE";
            this.btnContaStudClasse.UseVisualStyleBackColor = true;
            this.btnContaStudClasse.Click += new System.EventHandler(this.btnContaStudClasse_Click);
            // 
            // btnContaVotiStudClasse
            // 
            this.btnContaVotiStudClasse.Location = new System.Drawing.Point(10, 484);
            this.btnContaVotiStudClasse.Margin = new System.Windows.Forms.Padding(2);
            this.btnContaVotiStudClasse.Name = "btnContaVotiStudClasse";
            this.btnContaVotiStudClasse.Size = new System.Drawing.Size(203, 43);
            this.btnContaVotiStudClasse.TabIndex = 23;
            this.btnContaVotiStudClasse.Text = "CONTA NUMERO DI VOTI DI STUDENTI CLASSE";
            this.btnContaVotiStudClasse.UseVisualStyleBackColor = true;
            this.btnContaVotiStudClasse.Click += new System.EventHandler(this.btnContaVotiStudClasse_Click);
            // 
            // btnInserisciVoto
            // 
            this.btnInserisciVoto.Location = new System.Drawing.Point(505, 361);
            this.btnInserisciVoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserisciVoto.Name = "btnInserisciVoto";
            this.btnInserisciVoto.Size = new System.Drawing.Size(240, 25);
            this.btnInserisciVoto.TabIndex = 24;
            this.btnInserisciVoto.Text = "INSERISCI VOTO";
            this.btnInserisciVoto.UseVisualStyleBackColor = true;
            this.btnInserisciVoto.Click += new System.EventHandler(this.btnInserisciVoto_Click);
            // 
            // btnMediaPerMateria
            // 
            this.btnMediaPerMateria.Location = new System.Drawing.Point(505, 390);
            this.btnMediaPerMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnMediaPerMateria.Name = "btnMediaPerMateria";
            this.btnMediaPerMateria.Size = new System.Drawing.Size(240, 43);
            this.btnMediaPerMateria.TabIndex = 25;
            this.btnMediaPerMateria.Text = "CALCOLA MEDIA VOTI per MATERIA SELEZIONATA";
            this.btnMediaPerMateria.UseVisualStyleBackColor = true;
            this.btnMediaPerMateria.Click += new System.EventHandler(this.btnMediaPerMateria_Click);
            // 
            // btnContaVotiPerTipoPerStudente
            // 
            this.btnContaVotiPerTipoPerStudente.Location = new System.Drawing.Point(505, 437);
            this.btnContaVotiPerTipoPerStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnContaVotiPerTipoPerStudente.Name = "btnContaVotiPerTipoPerStudente";
            this.btnContaVotiPerTipoPerStudente.Size = new System.Drawing.Size(240, 43);
            this.btnContaVotiPerTipoPerStudente.TabIndex = 26;
            this.btnContaVotiPerTipoPerStudente.Text = "CONTA NUMERO VOTI per TIPO SELEZIONATO con NOMINATIVO in INPUT";
            this.btnContaVotiPerTipoPerStudente.UseVisualStyleBackColor = true;
            this.btnContaVotiPerTipoPerStudente.Click += new System.EventHandler(this.btnContaVotiPerTipoPerStudente_Click);
            // 
            // btnNumVotiPerStudente
            // 
            this.btnNumVotiPerStudente.Location = new System.Drawing.Point(505, 484);
            this.btnNumVotiPerStudente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumVotiPerStudente.Name = "btnNumVotiPerStudente";
            this.btnNumVotiPerStudente.Size = new System.Drawing.Size(240, 43);
            this.btnNumVotiPerStudente.TabIndex = 27;
            this.btnNumVotiPerStudente.Text = "CONTARE IL NUMERO DI VOTI PER CIASCUN STUDENTE";
            this.btnNumVotiPerStudente.UseVisualStyleBackColor = true;
            // 
            // btnCercaStudenteMediaMaggiore
            // 
            this.btnCercaStudenteMediaMaggiore.Location = new System.Drawing.Point(505, 531);
            this.btnCercaStudenteMediaMaggiore.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercaStudenteMediaMaggiore.Name = "btnCercaStudenteMediaMaggiore";
            this.btnCercaStudenteMediaMaggiore.Size = new System.Drawing.Size(240, 43);
            this.btnCercaStudenteMediaMaggiore.TabIndex = 28;
            this.btnCercaStudenteMediaMaggiore.Text = "CERCA STUDENTE MEDIA MAGGIORE";
            this.btnCercaStudenteMediaMaggiore.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 576);
            this.Controls.Add(this.btnCercaStudenteMediaMaggiore);
            this.Controls.Add(this.btnNumVotiPerStudente);
            this.Controls.Add(this.btnContaVotiPerTipoPerStudente);
            this.Controls.Add(this.btnMediaPerMateria);
            this.Controls.Add(this.btnInserisciVoto);
            this.Controls.Add(this.btnContaVotiStudClasse);
            this.Controls.Add(this.btnContaStudClasse);
            this.Controls.Add(this.btnOrdinaStudNominativo);
            this.Controls.Add(this.btnRicStudCogN);
            this.Controls.Add(this.btnRicStudMat);
            this.Controls.Add(this.cmbMatricole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudVoto);
            this.Controls.Add(this.cmbMaterie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserisciStudente);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudSenzaVoti);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.dgvStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Gestione Studenti";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnStudSenzaVoti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnInserisciStudente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaterie;
        private System.Windows.Forms.NumericUpDown nudVoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLaboratorio;
        private System.Windows.Forms.RadioButton rdbOrale;
        private System.Windows.Forms.RadioButton rdbScritto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMatricole;
        private System.Windows.Forms.Button btnRicStudMat;
        private System.Windows.Forms.Button btnRicStudCogN;
        private System.Windows.Forms.Button btnOrdinaStudNominativo;
        private System.Windows.Forms.Button btnContaStudClasse;
        private System.Windows.Forms.Button btnContaVotiStudClasse;
        private System.Windows.Forms.Button btnInserisciVoto;
        private System.Windows.Forms.Button btnMediaPerMateria;
        private System.Windows.Forms.Button btnContaVotiPerTipoPerStudente;
        private System.Windows.Forms.Button btnNumVotiPerStudente;
        private System.Windows.Forms.Button btnCercaStudenteMediaMaggiore;
    }
}

