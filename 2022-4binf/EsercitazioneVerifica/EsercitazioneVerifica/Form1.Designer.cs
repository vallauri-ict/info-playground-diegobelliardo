namespace EsercitazioneVerifica
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apri2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ttsMacchina = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apri1ToolStripMenuItem,
            this.apri2ToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // apri1ToolStripMenuItem
            // 
            this.apri1ToolStripMenuItem.Name = "apri1ToolStripMenuItem";
            this.apri1ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.apri1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.apri1ToolStripMenuItem.ShowShortcutKeys = false;
            this.apri1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri1ToolStripMenuItem.Text = "Apri&1";
            this.apri1ToolStripMenuItem.Click += new System.EventHandler(this.apri1ToolStripMenuItem_Click);
            // 
            // apri2ToolStripMenuItem
            // 
            this.apri2ToolStripMenuItem.Name = "apri2ToolStripMenuItem";
            this.apri2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.apri2ToolStripMenuItem.ShowShortcutKeys = false;
            this.apri2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apri2ToolStripMenuItem.Text = "Apri&2";
            this.apri2ToolStripMenuItem.Click += new System.EventHandler(this.apri2ToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttsMacchina,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ttsMacchina
            // 
            this.ttsMacchina.Name = "ttsMacchina";
            this.ttsMacchina.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apri2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ttsMacchina;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

