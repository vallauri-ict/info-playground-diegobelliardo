namespace _40_AltoBasso
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
            this.rdbBase = new System.Windows.Forms.RadioButton();
            this.rdbIntermedio = new System.Windows.Forms.RadioButton();
            this.rdbAvanzato = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTentativi = new System.Windows.Forms.Label();
            this.btnIndovina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbBase
            // 
            this.rdbBase.AutoSize = true;
            this.rdbBase.Location = new System.Drawing.Point(46, 24);
            this.rdbBase.Name = "rdbBase";
            this.rdbBase.Size = new System.Drawing.Size(53, 17);
            this.rdbBase.TabIndex = 0;
            this.rdbBase.Text = "BASE";
            this.rdbBase.UseVisualStyleBackColor = true;
            this.rdbBase.CheckedChanged += new System.EventHandler(this.rdbBase_CheckedChanged);
            // 
            // rdbIntermedio
            // 
            this.rdbIntermedio.AutoSize = true;
            this.rdbIntermedio.Location = new System.Drawing.Point(207, 24);
            this.rdbIntermedio.Name = "rdbIntermedio";
            this.rdbIntermedio.Size = new System.Drawing.Size(93, 17);
            this.rdbIntermedio.TabIndex = 1;
            this.rdbIntermedio.Text = "INTERMEDIO";
            this.rdbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rdbAvanzato
            // 
            this.rdbAvanzato.AutoSize = true;
            this.rdbAvanzato.Location = new System.Drawing.Point(398, 24);
            this.rdbAvanzato.Name = "rdbAvanzato";
            this.rdbAvanzato.Size = new System.Drawing.Size(83, 17);
            this.rdbAvanzato.TabIndex = 2;
            this.rdbAvanzato.TabStop = true;
            this.rdbAvanzato.Text = "AVANZATO";
            this.rdbAvanzato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "INSERISCI IL NUMERO";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(335, 69);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 32);
            this.txtNumero.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "TENTATIVI RIMASTI:";
            // 
            // lblTentativi
            // 
            this.lblTentativi.AutoSize = true;
            this.lblTentativi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativi.Location = new System.Drawing.Point(306, 121);
            this.lblTentativi.Name = "lblTentativi";
            this.lblTentativi.Size = new System.Drawing.Size(0, 24);
            this.lblTentativi.TabIndex = 6;
            // 
            // btnIndovina
            // 
            this.btnIndovina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndovina.Location = new System.Drawing.Point(178, 165);
            this.btnIndovina.Name = "btnIndovina";
            this.btnIndovina.Size = new System.Drawing.Size(170, 41);
            this.btnIndovina.TabIndex = 7;
            this.btnIndovina.Text = "INDOVINA";
            this.btnIndovina.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 222);
            this.Controls.Add(this.btnIndovina);
            this.Controls.Add(this.lblTentativi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAvanzato);
            this.Controls.Add(this.rdbIntermedio);
            this.Controls.Add(this.rdbBase);
            this.Name = "Form1";
            this.Text = "Gioco Alto-Basso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbBase;
        private System.Windows.Forms.RadioButton rdbIntermedio;
        private System.Windows.Forms.RadioButton rdbAvanzato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTentativi;
        private System.Windows.Forms.Button btnIndovina;
    }
}

