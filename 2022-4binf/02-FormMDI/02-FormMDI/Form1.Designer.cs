namespace _02_FormMDI
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
            this.btnApriFiglia1 = new System.Windows.Forms.Button();
            this.btnFiglia2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFinestra1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFinestra2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApriFiglia1
            // 
            this.btnApriFiglia1.Location = new System.Drawing.Point(13, 33);
            this.btnApriFiglia1.Name = "btnApriFiglia1";
            this.btnApriFiglia1.Size = new System.Drawing.Size(75, 23);
            this.btnApriFiglia1.TabIndex = 1;
            this.btnApriFiglia1.Text = "Apri Figlia1";
            this.btnApriFiglia1.UseVisualStyleBackColor = true;
            this.btnApriFiglia1.Click += new System.EventHandler(this.btnApriFiglia1_Click);
            // 
            // btnFiglia2
            // 
            this.btnFiglia2.Location = new System.Drawing.Point(94, 33);
            this.btnFiglia2.Name = "btnFiglia2";
            this.btnFiglia2.Size = new System.Drawing.Size(75, 23);
            this.btnFiglia2.TabIndex = 2;
            this.btnFiglia2.Text = "Apri Figlia2";
            this.btnFiglia2.UseVisualStyleBackColor = true;
            this.btnFiglia2.Click += new System.EventHandler(this.btnFiglia2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriFinestra1ToolStripMenuItem,
            this.apriFinestra2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // apriFinestra1ToolStripMenuItem
            // 
            this.apriFinestra1ToolStripMenuItem.Name = "apriFinestra1ToolStripMenuItem";
            this.apriFinestra1ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.apriFinestra1ToolStripMenuItem.Text = "Apri finestra &1";
            this.apriFinestra1ToolStripMenuItem.Click += new System.EventHandler(this.btnApriFiglia1_Click);
            // 
            // apriFinestra2ToolStripMenuItem
            // 
            this.apriFinestra2ToolStripMenuItem.Name = "apriFinestra2ToolStripMenuItem";
            this.apriFinestra2ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.apriFinestra2ToolStripMenuItem.Text = "Apri finestra &2";
            this.apriFinestra2ToolStripMenuItem.Click += new System.EventHandler(this.btnFiglia2_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(581, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFiglia2);
            this.Controls.Add(this.btnApriFiglia1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriFiglia1;
        private System.Windows.Forms.Button btnFiglia2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFinestra1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFinestra2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
    }
}

