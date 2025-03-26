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
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTANTI";
            // 
            // dgvCantanti
            // 
            this.dgvCantanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantanti.Location = new System.Drawing.Point(20, 46);
            this.dgvCantanti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCantanti.Name = "dgvCantanti";
            this.dgvCantanti.RowHeadersWidth = 62;
            this.dgvCantanti.Size = new System.Drawing.Size(507, 377);
            this.dgvCantanti.TabIndex = 1;
            // 
            // dgvCanzoni
            // 
            this.dgvCanzoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanzoni.Location = new System.Drawing.Point(579, 46);
            this.dgvCanzoni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCanzoni.Name = "dgvCanzoni";
            this.dgvCanzoni.RowHeadersWidth = 62;
            this.dgvCanzoni.Size = new System.Drawing.Size(507, 377);
            this.dgvCanzoni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CANZONI";
            // 
            // btnCanzoniVendute
            // 
            this.btnCanzoniVendute.Location = new System.Drawing.Point(20, 466);
            this.btnCanzoniVendute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCanzoniVendute.Name = "btnCanzoniVendute";
            this.btnCanzoniVendute.Size = new System.Drawing.Size(507, 91);
            this.btnCanzoniVendute.TabIndex = 4;
            this.btnCanzoniVendute.Text = "Ricevuto in ingresso il nome del cantante, contare il numero totale di conzoni ve" +
    "ndute, visualizzandole in un DataGridView";
            this.btnCanzoniVendute.UseVisualStyleBackColor = true;
            this.btnCanzoniVendute.Click += new System.EventHandler(this.btnCanzoniVendute_Click);
            // 
            // btnClassificaCantanti
            // 
            this.btnClassificaCantanti.Location = new System.Drawing.Point(579, 466);
            this.btnClassificaCantanti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClassificaCantanti.Name = "btnClassificaCantanti";
            this.btnClassificaCantanti.Size = new System.Drawing.Size(507, 91);
            this.btnClassificaCantanti.TabIndex = 5;
            this.btnClassificaCantanti.Text = "Dopo aver calcolato per ogni cantante il totale venduto delle loro canzoni, visua" +
    "lizzarne la classifica";
            this.btnClassificaCantanti.UseVisualStyleBackColor = true;
            this.btnClassificaCantanti.Click += new System.EventHandler(this.btnClassificaCantanti_Click);
            // 
            // dgvCanzoniRis
            // 
            this.dgvCanzoniRis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanzoniRis.Location = new System.Drawing.Point(18, 566);
            this.dgvCanzoniRis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCanzoniRis.Name = "dgvCanzoniRis";
            this.dgvCanzoniRis.RowHeadersWidth = 62;
            this.dgvCanzoniRis.Size = new System.Drawing.Size(507, 377);
            this.dgvCanzoniRis.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1031);
            this.Controls.Add(this.dgvCanzoniRis);
            this.Controls.Add(this.btnClassificaCantanti);
            this.Controls.Add(this.btnCanzoniVendute);
            this.Controls.Add(this.dgvCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCantanti);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

