namespace _11_Interfaccia
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
            this.btnRumorista = new System.Windows.Forms.Button();
            this.btnChitarra = new System.Windows.Forms.Button();
            this.btnTromba = new System.Windows.Forms.Button();
            this.btnSuona = new System.Windows.Forms.Button();
            this.btnStrumento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRumorista
            // 
            this.btnRumorista.Location = new System.Drawing.Point(13, 13);
            this.btnRumorista.Name = "btnRumorista";
            this.btnRumorista.Size = new System.Drawing.Size(75, 23);
            this.btnRumorista.TabIndex = 0;
            this.btnRumorista.Text = "Rumorista";
            this.btnRumorista.UseVisualStyleBackColor = true;
            this.btnRumorista.Click += new System.EventHandler(this.btnRumorista_Click);
            // 
            // btnChitarra
            // 
            this.btnChitarra.Location = new System.Drawing.Point(94, 13);
            this.btnChitarra.Name = "btnChitarra";
            this.btnChitarra.Size = new System.Drawing.Size(75, 23);
            this.btnChitarra.TabIndex = 1;
            this.btnChitarra.Text = "Chitarra";
            this.btnChitarra.UseVisualStyleBackColor = true;
            this.btnChitarra.Click += new System.EventHandler(this.btnChitarra_Click);
            // 
            // btnTromba
            // 
            this.btnTromba.Location = new System.Drawing.Point(175, 13);
            this.btnTromba.Name = "btnTromba";
            this.btnTromba.Size = new System.Drawing.Size(75, 23);
            this.btnTromba.TabIndex = 2;
            this.btnTromba.Text = "Tromba";
            this.btnTromba.UseVisualStyleBackColor = true;
            this.btnTromba.Click += new System.EventHandler(this.btnTromba_Click);
            // 
            // btnSuona
            // 
            this.btnSuona.Location = new System.Drawing.Point(94, 69);
            this.btnSuona.Name = "btnSuona";
            this.btnSuona.Size = new System.Drawing.Size(75, 23);
            this.btnSuona.TabIndex = 3;
            this.btnSuona.Text = "Suona";
            this.btnSuona.UseVisualStyleBackColor = true;
            this.btnSuona.Click += new System.EventHandler(this.btnSuona_Click);
            // 
            // btnStrumento
            // 
            this.btnStrumento.Location = new System.Drawing.Point(256, 13);
            this.btnStrumento.Name = "btnStrumento";
            this.btnStrumento.Size = new System.Drawing.Size(75, 23);
            this.btnStrumento.TabIndex = 4;
            this.btnStrumento.Text = "Strumento";
            this.btnStrumento.UseVisualStyleBackColor = true;
            this.btnStrumento.Click += new System.EventHandler(this.btnStrumento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 104);
            this.Controls.Add(this.btnStrumento);
            this.Controls.Add(this.btnSuona);
            this.Controls.Add(this.btnTromba);
            this.Controls.Add(this.btnChitarra);
            this.Controls.Add(this.btnRumorista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRumorista;
        private System.Windows.Forms.Button btnChitarra;
        private System.Windows.Forms.Button btnTromba;
        private System.Windows.Forms.Button btnSuona;
        private System.Windows.Forms.Button btnStrumento;
    }
}

