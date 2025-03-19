namespace _45_Es_Cantanti
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
            this.dgvCantanti = new System.Windows.Forms.DataGridView();
            this.dgvCanzoni = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCanzoniVendute = new System.Windows.Forms.Button();
            this.btnClassificaCantanti = new System.Windows.Forms.Button();
            this.dgvCanzoniRis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanzoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanzoniRis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTANTI";
            // 
            // dgvCantanti
            // 
            this.dgvCantanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantanti.Location = new System.Drawing.Point(13, 30);
            this.dgvCantanti.Name = "dgvCantanti";
            this.dgvCantanti.Size = new System.Drawing.Size(338, 245);
            this.dgvCantanti.TabIndex = 1;
            // 
            // dgvCanzoni
            // 
            this.dgvCanzoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanzoni.Location = new System.Drawing.Point(386, 30);
            this.dgvCanzoni.Name = "dgvCanzoni";
            this.dgvCanzoni.Size = new System.Drawing.Size(338, 245);
            this.dgvCanzoni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CANZONI";
            // 
            // btnCanzoniVendute
            // 
            this.btnCanzoniVendute.Location = new System.Drawing.Point(13, 303);
            this.btnCanzoniVendute.Name = "btnCanzoniVendute";
            this.btnCanzoniVendute.Size = new System.Drawing.Size(338, 59);
            this.btnCanzoniVendute.TabIndex = 4;
            this.btnCanzoniVendute.Text = "Ricevuto in ingresso il nome del cantante, contare il numero totale di conzoni ve" +
    "ndute, visualizzandole in un DataGridView";
            this.btnCanzoniVendute.UseVisualStyleBackColor = true;
            // 
            // btnClassificaCantanti
            // 
            this.btnClassificaCantanti.Location = new System.Drawing.Point(386, 303);
            this.btnClassificaCantanti.Name = "btnClassificaCantanti";
            this.btnClassificaCantanti.Size = new System.Drawing.Size(338, 59);
            this.btnClassificaCantanti.TabIndex = 5;
            this.btnClassificaCantanti.Text = "Dopo aver calcolato per ogni cantante il totale venduto delle loro canzoni, visua" +
    "lizzarne la classifica";
            this.btnClassificaCantanti.UseVisualStyleBackColor = true;
//            this.btnClassificaCantanti.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCanzoniRis
            // 
            this.dgvCanzoniRis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanzoniRis.Location = new System.Drawing.Point(12, 368);
            this.dgvCanzoniRis.Name = "dgvCanzoniRis";
            this.dgvCanzoniRis.Size = new System.Drawing.Size(338, 245);
            this.dgvCanzoniRis.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.dgvCanzoniRis);
            this.Controls.Add(this.btnClassificaCantanti);
            this.Controls.Add(this.btnCanzoniVendute);
            this.Controls.Add(this.dgvCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCantanti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanzoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanzoniRis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCantanti;
        private System.Windows.Forms.DataGridView dgvCanzoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCanzoniVendute;
        private System.Windows.Forms.Button btnClassificaCantanti;
        private System.Windows.Forms.DataGridView dgvCanzoniRis;
    }
}

