namespace OOP05_Dictionary
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAggiungiLibro = new System.Windows.Forms.Button();
            this.btnVisElm = new System.Windows.Forms.Button();
            this.nudIndiceLibro = new System.Windows.Forms.NumericUpDown();
            this.btnVisIndiceLibro = new System.Windows.Forms.Button();
            this.btnAggiungiCoda = new System.Windows.Forms.Button();
            this.btnAggiungiPila = new System.Windows.Forms.Button();
            this.btnEstraiCoda = new System.Windows.Forms.Button();
            this.btnEstraiPila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndiceLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(83, 10);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(83, 36);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore";
            // 
            // btnAggiungiLibro
            // 
            this.btnAggiungiLibro.Location = new System.Drawing.Point(55, 71);
            this.btnAggiungiLibro.Name = "btnAggiungiLibro";
            this.btnAggiungiLibro.Size = new System.Drawing.Size(128, 23);
            this.btnAggiungiLibro.TabIndex = 4;
            this.btnAggiungiLibro.Text = "Aggiungi in dizionario";
            this.btnAggiungiLibro.UseVisualStyleBackColor = true;
            this.btnAggiungiLibro.Click += new System.EventHandler(this.btnAggiungiLibro_Click);
            // 
            // btnVisElm
            // 
            this.btnVisElm.Location = new System.Drawing.Point(249, 8);
            this.btnVisElm.Name = "btnVisElm";
            this.btnVisElm.Size = new System.Drawing.Size(129, 23);
            this.btnVisElm.TabIndex = 5;
            this.btnVisElm.Text = "Visualizza elementi";
            this.btnVisElm.UseVisualStyleBackColor = true;
            this.btnVisElm.Click += new System.EventHandler(this.btnVisElm_Click);
            // 
            // nudIndiceLibro
            // 
            this.nudIndiceLibro.Location = new System.Drawing.Point(249, 74);
            this.nudIndiceLibro.Name = "nudIndiceLibro";
            this.nudIndiceLibro.Size = new System.Drawing.Size(39, 20);
            this.nudIndiceLibro.TabIndex = 6;
            // 
            // btnVisIndiceLibro
            // 
            this.btnVisIndiceLibro.Location = new System.Drawing.Point(304, 71);
            this.btnVisIndiceLibro.Name = "btnVisIndiceLibro";
            this.btnVisIndiceLibro.Size = new System.Drawing.Size(84, 23);
            this.btnVisIndiceLibro.TabIndex = 7;
            this.btnVisIndiceLibro.Text = "Vis Libro";
            this.btnVisIndiceLibro.UseVisualStyleBackColor = true;
            this.btnVisIndiceLibro.Click += new System.EventHandler(this.btnVisIndiceLibro_Click);
            // 
            // btnAggiungiCoda
            // 
            this.btnAggiungiCoda.Location = new System.Drawing.Point(55, 101);
            this.btnAggiungiCoda.Name = "btnAggiungiCoda";
            this.btnAggiungiCoda.Size = new System.Drawing.Size(128, 23);
            this.btnAggiungiCoda.TabIndex = 8;
            this.btnAggiungiCoda.Text = "Aggiungi in Coda";
            this.btnAggiungiCoda.UseVisualStyleBackColor = true;
            this.btnAggiungiCoda.Click += new System.EventHandler(this.btnAggiungiCoda_Click);
            // 
            // btnAggiungiPila
            // 
            this.btnAggiungiPila.Location = new System.Drawing.Point(55, 130);
            this.btnAggiungiPila.Name = "btnAggiungiPila";
            this.btnAggiungiPila.Size = new System.Drawing.Size(128, 23);
            this.btnAggiungiPila.TabIndex = 9;
            this.btnAggiungiPila.Text = "Aggiungi in Pila";
            this.btnAggiungiPila.UseVisualStyleBackColor = true;
            this.btnAggiungiPila.Click += new System.EventHandler(this.btnAggiungiPila_Click);
            // 
            // btnEstraiCoda
            // 
            this.btnEstraiCoda.Location = new System.Drawing.Point(249, 101);
            this.btnEstraiCoda.Name = "btnEstraiCoda";
            this.btnEstraiCoda.Size = new System.Drawing.Size(107, 23);
            this.btnEstraiCoda.TabIndex = 10;
            this.btnEstraiCoda.Text = "Estrai da Coda";
            this.btnEstraiCoda.UseVisualStyleBackColor = true;
            this.btnEstraiCoda.Click += new System.EventHandler(this.btnEstraiCoda_Click);
            // 
            // btnEstraiPila
            // 
            this.btnEstraiPila.Location = new System.Drawing.Point(249, 130);
            this.btnEstraiPila.Name = "btnEstraiPila";
            this.btnEstraiPila.Size = new System.Drawing.Size(107, 23);
            this.btnEstraiPila.TabIndex = 11;
            this.btnEstraiPila.Text = "Estrai da Pila";
            this.btnEstraiPila.UseVisualStyleBackColor = true;
            this.btnEstraiPila.Click += new System.EventHandler(this.btnEstraiPila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 172);
            this.Controls.Add(this.btnEstraiPila);
            this.Controls.Add(this.btnEstraiCoda);
            this.Controls.Add(this.btnAggiungiPila);
            this.Controls.Add(this.btnAggiungiCoda);
            this.Controls.Add(this.btnVisIndiceLibro);
            this.Controls.Add(this.nudIndiceLibro);
            this.Controls.Add(this.btnVisElm);
            this.Controls.Add(this.btnAggiungiLibro);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndiceLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAggiungiLibro;
        private System.Windows.Forms.Button btnVisElm;
        private System.Windows.Forms.NumericUpDown nudIndiceLibro;
        private System.Windows.Forms.Button btnVisIndiceLibro;
        private System.Windows.Forms.Button btnAggiungiCoda;
        private System.Windows.Forms.Button btnAggiungiPila;
        private System.Windows.Forms.Button btnEstraiCoda;
        private System.Windows.Forms.Button btnEstraiPila;
    }
}

