namespace _57_Es17Pag116
{
    partial class FormCanzoni
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
            this.lstCantanti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCanzoniCercate = new System.Windows.Forms.ListBox();
            this.txtNomeCantante = new System.Windows.Forms.TextBox();
            this.btnCercaCanzoni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCantanti
            // 
            this.lstCantanti.FormattingEnabled = true;
            this.lstCantanti.ItemHeight = 16;
            this.lstCantanti.Location = new System.Drawing.Point(16, 32);
            this.lstCantanti.Name = "lstCantanti";
            this.lstCantanti.Size = new System.Drawing.Size(185, 276);
            this.lstCantanti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantanti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Canzoni";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.ItemHeight = 16;
            this.lstCanzoni.Location = new System.Drawing.Point(208, 32);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(185, 276);
            this.lstCanzoni.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Cantante da cercare:";
            // 
            // lstCanzoniCercate
            // 
            this.lstCanzoniCercate.FormattingEnabled = true;
            this.lstCanzoniCercate.ItemHeight = 16;
            this.lstCanzoniCercate.Location = new System.Drawing.Point(482, 91);
            this.lstCanzoniCercate.Name = "lstCanzoniCercate";
            this.lstCanzoniCercate.Size = new System.Drawing.Size(185, 212);
            this.lstCanzoniCercate.TabIndex = 5;
            // 
            // txtNomeCantante
            // 
            this.txtNomeCantante.Location = new System.Drawing.Point(482, 33);
            this.txtNomeCantante.Name = "txtNomeCantante";
            this.txtNomeCantante.Size = new System.Drawing.Size(233, 22);
            this.txtNomeCantante.TabIndex = 6;
            // 
            // btnCercaCanzoni
            // 
            this.btnCercaCanzoni.Location = new System.Drawing.Point(482, 62);
            this.btnCercaCanzoni.Name = "btnCercaCanzoni";
            this.btnCercaCanzoni.Size = new System.Drawing.Size(233, 23);
            this.btnCercaCanzoni.TabIndex = 7;
            this.btnCercaCanzoni.Text = "Cerca Canzoni";
            this.btnCercaCanzoni.UseVisualStyleBackColor = true;
            this.btnCercaCanzoni.Click += new System.EventHandler(this.btnCercaCanzoni_Click);
            // 
            // FormCanzoni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 340);
            this.Controls.Add(this.btnCercaCanzoni);
            this.Controls.Add(this.txtNomeCantante);
            this.Controls.Add(this.lstCanzoniCercate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCantanti);
            this.Name = "FormCanzoni";
            this.Text = "Canzoni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCantanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCanzoniCercate;
        private System.Windows.Forms.TextBox txtNomeCantante;
        private System.Windows.Forms.Button btnCercaCanzoni;
    }
}

