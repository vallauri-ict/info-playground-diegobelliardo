namespace Es_Cambieri_Impossibile
{
    partial class FormScrutinio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvScrutinio = new System.Windows.Forms.DataGridView();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblStud = new System.Windows.Forms.Label();
            this.cmbStudente = new System.Windows.Forms.ComboBox();
            this.gbContaEsititi = new System.Windows.Forms.GroupBox();
            this.btnContaEsiti = new System.Windows.Forms.Button();
            this.rdbRimandati = new System.Windows.Forms.RadioButton();
            this.rdbBocciati = new System.Windows.Forms.RadioButton();
            this.rdbPromossi = new System.Windows.Forms.RadioButton();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnMateriaBalorda = new System.Windows.Forms.Button();
            this.btnStudSùGiù = new System.Windows.Forms.Button();
            this.btnVotoTraDue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrutinio)).BeginInit();
            this.gbContaEsititi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScrutinio
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScrutinio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvScrutinio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScrutinio.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvScrutinio.Location = new System.Drawing.Point(0, 0);
            this.dgvScrutinio.Name = "dgvScrutinio";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScrutinio.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvScrutinio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvScrutinio.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvScrutinio.RowTemplate.Height = 30;
            this.dgvScrutinio.Size = new System.Drawing.Size(970, 552);
            this.dgvScrutinio.TabIndex = 0;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.Location = new System.Drawing.Point(1071, 10);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(147, 25);
            this.lblStat.TabIndex = 1;
            this.lblStat.Text = "STATISTICHE";
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud.Location = new System.Drawing.Point(979, 62);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(79, 20);
            this.lblStud.TabIndex = 2;
            this.lblStud.Text = "Studente:";
            // 
            // cmbStudente
            // 
            this.cmbStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudente.FormattingEnabled = true;
            this.cmbStudente.Location = new System.Drawing.Point(1064, 59);
            this.cmbStudente.Name = "cmbStudente";
            this.cmbStudente.Size = new System.Drawing.Size(227, 28);
            this.cmbStudente.TabIndex = 3;
            this.cmbStudente.SelectedIndexChanged += new System.EventHandler(this.cmbStudente_SelectedIndexChanged);
            // 
            // gbContaEsititi
            // 
            this.gbContaEsititi.Controls.Add(this.btnContaEsiti);
            this.gbContaEsititi.Controls.Add(this.rdbRimandati);
            this.gbContaEsititi.Controls.Add(this.rdbBocciati);
            this.gbContaEsititi.Controls.Add(this.rdbPromossi);
            this.gbContaEsititi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContaEsititi.Location = new System.Drawing.Point(983, 106);
            this.gbContaEsititi.Name = "gbContaEsititi";
            this.gbContaEsititi.Size = new System.Drawing.Size(308, 138);
            this.gbContaEsititi.TabIndex = 4;
            this.gbContaEsititi.TabStop = false;
            this.gbContaEsititi.Text = "CONTA ESITI";
            // 
            // btnContaEsiti
            // 
            this.btnContaEsiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaEsiti.Location = new System.Drawing.Point(160, 72);
            this.btnContaEsiti.Name = "btnContaEsiti";
            this.btnContaEsiti.Size = new System.Drawing.Size(142, 35);
            this.btnContaEsiti.TabIndex = 3;
            this.btnContaEsiti.Text = "Conta Esiti";
            this.btnContaEsiti.UseVisualStyleBackColor = true;
            this.btnContaEsiti.Click += new System.EventHandler(this.btnContaEsiti_Click);
            // 
            // rdbRimandati
            // 
            this.rdbRimandati.AutoSize = true;
            this.rdbRimandati.Location = new System.Drawing.Point(21, 86);
            this.rdbRimandati.Name = "rdbRimandati";
            this.rdbRimandati.Size = new System.Drawing.Size(89, 21);
            this.rdbRimandati.TabIndex = 2;
            this.rdbRimandati.TabStop = true;
            this.rdbRimandati.Text = "Rimandati";
            this.rdbRimandati.UseVisualStyleBackColor = true;
            // 
            // rdbBocciati
            // 
            this.rdbBocciati.AutoSize = true;
            this.rdbBocciati.Location = new System.Drawing.Point(21, 59);
            this.rdbBocciati.Name = "rdbBocciati";
            this.rdbBocciati.Size = new System.Drawing.Size(75, 21);
            this.rdbBocciati.TabIndex = 1;
            this.rdbBocciati.TabStop = true;
            this.rdbBocciati.Text = "Bocciati";
            this.rdbBocciati.UseVisualStyleBackColor = true;
            // 
            // rdbPromossi
            // 
            this.rdbPromossi.AutoSize = true;
            this.rdbPromossi.Location = new System.Drawing.Point(21, 32);
            this.rdbPromossi.Name = "rdbPromossi";
            this.rdbPromossi.Size = new System.Drawing.Size(84, 21);
            this.rdbPromossi.TabIndex = 0;
            this.rdbPromossi.TabStop = true;
            this.rdbPromossi.Text = "Promossi";
            this.rdbPromossi.UseVisualStyleBackColor = true;
            // 
            // cmbMateria
            // 
            this.cmbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(1051, 271);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(240, 28);
            this.cmbMateria.TabIndex = 6;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(979, 274);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 20);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia:";
            // 
            // btnMateriaBalorda
            // 
            this.btnMateriaBalorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriaBalorda.Location = new System.Drawing.Point(983, 332);
            this.btnMateriaBalorda.Name = "btnMateriaBalorda";
            this.btnMateriaBalorda.Size = new System.Drawing.Size(308, 51);
            this.btnMateriaBalorda.TabIndex = 9;
            this.btnMateriaBalorda.Text = "Materia Balorda";
            this.btnMateriaBalorda.UseVisualStyleBackColor = true;
            // 
            // btnStudSùGiù
            // 
            this.btnStudSùGiù.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudSùGiù.Location = new System.Drawing.Point(983, 489);
            this.btnStudSùGiù.Name = "btnStudSùGiù";
            this.btnStudSùGiù.Size = new System.Drawing.Size(308, 51);
            this.btnStudSùGiù.TabIndex = 10;
            this.btnStudSùGiù.Text = "Studenti sù e giù";
            this.btnStudSùGiù.UseVisualStyleBackColor = true;
            // 
            // btnVotoTraDue
            // 
            this.btnVotoTraDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotoTraDue.Location = new System.Drawing.Point(983, 410);
            this.btnVotoTraDue.Name = "btnVotoTraDue";
            this.btnVotoTraDue.Size = new System.Drawing.Size(308, 51);
            this.btnVotoTraDue.TabIndex = 11;
            this.btnVotoTraDue.Text = "Voto tra due valori";
            this.btnVotoTraDue.UseVisualStyleBackColor = true;
            // 
            // FormScrutinio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 552);
            this.Controls.Add(this.btnVotoTraDue);
            this.Controls.Add(this.btnStudSùGiù);
            this.Controls.Add(this.btnMateriaBalorda);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.gbContaEsititi);
            this.Controls.Add(this.cmbStudente);
            this.Controls.Add(this.lblStud);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.dgvScrutinio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormScrutinio";
            this.Text = "Scrutinio";
            this.Load += new System.EventHandler(this.FormScrutinio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrutinio)).EndInit();
            this.gbContaEsititi.ResumeLayout(false);
            this.gbContaEsititi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScrutinio;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblStud;
        private System.Windows.Forms.ComboBox cmbStudente;
        private System.Windows.Forms.GroupBox gbContaEsititi;
        private System.Windows.Forms.RadioButton rdbRimandati;
        private System.Windows.Forms.RadioButton rdbBocciati;
        private System.Windows.Forms.RadioButton rdbPromossi;
        private System.Windows.Forms.Button btnContaEsiti;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnMateriaBalorda;
        private System.Windows.Forms.Button btnStudSùGiù;
        private System.Windows.Forms.Button btnVotoTraDue;
    }
}

