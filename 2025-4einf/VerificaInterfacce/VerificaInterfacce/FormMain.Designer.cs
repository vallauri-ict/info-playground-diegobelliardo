namespace BibliotecaSolution
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInserimento = new System.Windows.Forms.TabPage();
            this.grpSpecifici = new System.Windows.Forms.GroupBox();
            this.lblSpec3 = new System.Windows.Forms.Label();
            this.txtSpec3 = new System.Windows.Forms.TextBox();
            this.lblSpec2 = new System.Windows.Forms.Label();
            this.txtSpec2 = new System.Windows.Forms.TextBox();
            this.lblSpec1 = new System.Windows.Forms.Label();
            this.txtSpec1 = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.grpComuni = new System.Windows.Forms.GroupBox();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.lblValore = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.lblAnno = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.cmbTipoContenuto = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tabCatalogo = new System.Windows.Forms.TabPage();
            this.lstCatalogo = new System.Windows.Forms.ListBox();
            this.grpFiltri = new System.Windows.Forms.GroupBox();
            this.btnMostraTutto = new System.Windows.Forms.Button();
            this.btnFiltraCategoria = new System.Windows.Forms.Button();
            this.txtFiltroCategoria = new System.Windows.Forms.TextBox();
            this.btnFiltraTipo = new System.Windows.Forms.Button();
            this.cmbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.tabPrestiti = new System.Windows.Forms.TabPage();
            this.grpRestituisci = new System.Windows.Forms.GroupBox();
            this.btnRestituisci = new System.Windows.Forms.Button();
            this.txtCodiceRestituzione = new System.Windows.Forms.TextBox();
            this.lblCodiceRestituzione = new System.Windows.Forms.Label();
            this.lstContenutiInPrestito = new System.Windows.Forms.ListBox();
            this.lblInPrestito = new System.Windows.Forms.Label();
            this.grpPresta = new System.Windows.Forms.GroupBox();
            this.btnPresta = new System.Windows.Forms.Button();
            this.txtNomeUtente = new System.Windows.Forms.TextBox();
            this.lblNomeUtente = new System.Windows.Forms.Label();
            this.txtCodicePrestito = new System.Windows.Forms.TextBox();
            this.lblCodicePrestito = new System.Windows.Forms.Label();
            this.lstContenutiDisponibili = new System.Windows.Forms.ListBox();
            this.lblDisponibili = new System.Windows.Forms.Label();
            this.tabStatistiche = new System.Windows.Forms.TabPage();
            this.txtStatistiche = new System.Windows.Forms.TextBox();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInserimento.SuspendLayout();
            this.grpSpecifici.SuspendLayout();
            this.grpComuni.SuspendLayout();
            this.tabCatalogo.SuspendLayout();
            this.grpFiltri.SuspendLayout();
            this.tabPrestiti.SuspendLayout();
            this.grpRestituisci.SuspendLayout();
            this.grpPresta.SuspendLayout();
            this.tabStatistiche.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInserimento);
            this.tabControl1.Controls.Add(this.tabCatalogo);
            this.tabControl1.Controls.Add(this.tabPrestiti);
            this.tabControl1.Controls.Add(this.tabStatistiche);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInserimento
            // 
            this.tabInserimento.Controls.Add(this.grpSpecifici);
            this.tabInserimento.Controls.Add(this.btnInserisci);
            this.tabInserimento.Controls.Add(this.grpComuni);
            this.tabInserimento.Location = new System.Drawing.Point(4, 22);
            this.tabInserimento.Name = "tabInserimento";
            this.tabInserimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabInserimento.Size = new System.Drawing.Size(976, 535);
            this.tabInserimento.TabIndex = 0;
            this.tabInserimento.Text = "Inserimento";
            this.tabInserimento.UseVisualStyleBackColor = true;
            // 
            // grpSpecifici
            // 
            this.grpSpecifici.Controls.Add(this.lblSpec3);
            this.grpSpecifici.Controls.Add(this.txtSpec3);
            this.grpSpecifici.Controls.Add(this.lblSpec2);
            this.grpSpecifici.Controls.Add(this.txtSpec2);
            this.grpSpecifici.Controls.Add(this.lblSpec1);
            this.grpSpecifici.Controls.Add(this.txtSpec1);
            this.grpSpecifici.Location = new System.Drawing.Point(20, 270);
            this.grpSpecifici.Name = "grpSpecifici";
            this.grpSpecifici.Size = new System.Drawing.Size(500, 160);
            this.grpSpecifici.TabIndex = 2;
            this.grpSpecifici.TabStop = false;
            this.grpSpecifici.Text = "Dati specifici";
            // 
            // lblSpec3
            // 
            this.lblSpec3.AutoSize = true;
            this.lblSpec3.Location = new System.Drawing.Point(20, 115);
            this.lblSpec3.Name = "lblSpec3";
            this.lblSpec3.Size = new System.Drawing.Size(42, 13);
            this.lblSpec3.TabIndex = 5;
            this.lblSpec3.Text = "Campo:";
            // 
            // txtSpec3
            // 
            this.txtSpec3.Location = new System.Drawing.Point(150, 112);
            this.txtSpec3.Name = "txtSpec3";
            this.txtSpec3.Size = new System.Drawing.Size(320, 20);
            this.txtSpec3.TabIndex = 4;
            // 
            // lblSpec2
            // 
            this.lblSpec2.AutoSize = true;
            this.lblSpec2.Location = new System.Drawing.Point(20, 75);
            this.lblSpec2.Name = "lblSpec2";
            this.lblSpec2.Size = new System.Drawing.Size(42, 13);
            this.lblSpec2.TabIndex = 3;
            this.lblSpec2.Text = "Campo:";
            // 
            // txtSpec2
            // 
            this.txtSpec2.Location = new System.Drawing.Point(150, 72);
            this.txtSpec2.Name = "txtSpec2";
            this.txtSpec2.Size = new System.Drawing.Size(320, 20);
            this.txtSpec2.TabIndex = 2;
            // 
            // lblSpec1
            // 
            this.lblSpec1.AutoSize = true;
            this.lblSpec1.Location = new System.Drawing.Point(20, 35);
            this.lblSpec1.Name = "lblSpec1";
            this.lblSpec1.Size = new System.Drawing.Size(42, 13);
            this.lblSpec1.TabIndex = 1;
            this.lblSpec1.Text = "Campo:";
            // 
            // txtSpec1
            // 
            this.txtSpec1.Location = new System.Drawing.Point(150, 32);
            this.txtSpec1.Name = "txtSpec1";
            this.txtSpec1.Size = new System.Drawing.Size(320, 20);
            this.txtSpec1.TabIndex = 0;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisci.Location = new System.Drawing.Point(180, 450);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(200, 40);
            this.btnInserisci.TabIndex = 1;
            this.btnInserisci.Text = "Inserisci nel Catalogo";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // grpComuni
            // 
            this.grpComuni.Controls.Add(this.txtValore);
            this.grpComuni.Controls.Add(this.lblValore);
            this.grpComuni.Controls.Add(this.txtCategoria);
            this.grpComuni.Controls.Add(this.lblCategoria);
            this.grpComuni.Controls.Add(this.txtAnno);
            this.grpComuni.Controls.Add(this.lblAnno);
            this.grpComuni.Controls.Add(this.txtTitolo);
            this.grpComuni.Controls.Add(this.lblTitolo);
            this.grpComuni.Controls.Add(this.cmbTipoContenuto);
            this.grpComuni.Controls.Add(this.lblTipo);
            this.grpComuni.Location = new System.Drawing.Point(20, 20);
            this.grpComuni.Name = "grpComuni";
            this.grpComuni.Size = new System.Drawing.Size(500, 230);
            this.grpComuni.TabIndex = 0;
            this.grpComuni.TabStop = false;
            this.grpComuni.Text = "Dati comuni";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(150, 182);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(320, 20);
            this.txtValore.TabIndex = 9;
            // 
            // lblValore
            // 
            this.lblValore.AutoSize = true;
            this.lblValore.Location = new System.Drawing.Point(20, 185);
            this.lblValore.Name = "lblValore";
            this.lblValore.Size = new System.Drawing.Size(102, 13);
            this.lblValore.TabIndex = 8;
            this.lblValore.Text = "Valore commerciale:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(150, 142);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(320, 20);
            this.txtCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 145);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(150, 102);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(320, 20);
            this.txtAnno.TabIndex = 5;
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(20, 105);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(115, 13);
            this.lblAnno.TabIndex = 4;
            this.lblAnno.Text = "Anno di pubblicazione:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(150, 62);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(320, 20);
            this.txtTitolo.TabIndex = 3;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(20, 65);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(36, 13);
            this.lblTitolo.TabIndex = 2;
            this.lblTitolo.Text = "Titolo:";
            // 
            // cmbTipoContenuto
            // 
            this.cmbTipoContenuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContenuto.FormattingEnabled = true;
            this.cmbTipoContenuto.Location = new System.Drawing.Point(150, 25);
            this.cmbTipoContenuto.Name = "cmbTipoContenuto";
            this.cmbTipoContenuto.Size = new System.Drawing.Size(320, 21);
            this.cmbTipoContenuto.TabIndex = 1;
            this.cmbTipoContenuto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContenuto_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(88, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo di contenuto:";
            // 
            // tabCatalogo
            // 
            this.tabCatalogo.Controls.Add(this.lstCatalogo);
            this.tabCatalogo.Controls.Add(this.grpFiltri);
            this.tabCatalogo.Location = new System.Drawing.Point(4, 22);
            this.tabCatalogo.Name = "tabCatalogo";
            this.tabCatalogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCatalogo.Size = new System.Drawing.Size(976, 535);
            this.tabCatalogo.TabIndex = 1;
            this.tabCatalogo.Text = "Catalogo";
            this.tabCatalogo.UseVisualStyleBackColor = true;
            // 
            // lstCatalogo
            // 
            this.lstCatalogo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCatalogo.FormattingEnabled = true;
            this.lstCatalogo.HorizontalScrollbar = true;
            this.lstCatalogo.ItemHeight = 14;
            this.lstCatalogo.Location = new System.Drawing.Point(20, 140);
            this.lstCatalogo.Name = "lstCatalogo";
            this.lstCatalogo.Size = new System.Drawing.Size(936, 368);
            this.lstCatalogo.TabIndex = 1;
            // 
            // grpFiltri
            // 
            this.grpFiltri.Controls.Add(this.btnMostraTutto);
            this.grpFiltri.Controls.Add(this.btnFiltraCategoria);
            this.grpFiltri.Controls.Add(this.txtFiltroCategoria);
            this.grpFiltri.Controls.Add(this.btnFiltraTipo);
            this.grpFiltri.Controls.Add(this.cmbFiltroTipo);
            this.grpFiltri.Location = new System.Drawing.Point(20, 20);
            this.grpFiltri.Name = "grpFiltri";
            this.grpFiltri.Size = new System.Drawing.Size(936, 100);
            this.grpFiltri.TabIndex = 0;
            this.grpFiltri.TabStop = false;
            this.grpFiltri.Text = "Filtri";
            // 
            // btnMostraTutto
            // 
            this.btnMostraTutto.Location = new System.Drawing.Point(750, 35);
            this.btnMostraTutto.Name = "btnMostraTutto";
            this.btnMostraTutto.Size = new System.Drawing.Size(150, 30);
            this.btnMostraTutto.TabIndex = 4;
            this.btnMostraTutto.Text = "Mostra Tutto";
            this.btnMostraTutto.UseVisualStyleBackColor = true;
            this.btnMostraTutto.Click += new System.EventHandler(this.btnMostraTutto_Click);
            // 
            // btnFiltraCategoria
            // 
            this.btnFiltraCategoria.Location = new System.Drawing.Point(550, 35);
            this.btnFiltraCategoria.Name = "btnFiltraCategoria";
            this.btnFiltraCategoria.Size = new System.Drawing.Size(150, 30);
            this.btnFiltraCategoria.TabIndex = 3;
            this.btnFiltraCategoria.Text = "Filtra per Categoria";
            this.btnFiltraCategoria.UseVisualStyleBackColor = true;
            this.btnFiltraCategoria.Click += new System.EventHandler(this.btnFiltraCategoria_Click);
            // 
            // txtFiltroCategoria
            // 
            this.txtFiltroCategoria.Location = new System.Drawing.Point(380, 40);
            this.txtFiltroCategoria.Name = "txtFiltroCategoria";
            this.txtFiltroCategoria.Size = new System.Drawing.Size(150, 20);
            this.txtFiltroCategoria.TabIndex = 2;
            // 
            // btnFiltraTipo
            // 
            this.btnFiltraTipo.Location = new System.Drawing.Point(210, 35);
            this.btnFiltraTipo.Name = "btnFiltraTipo";
            this.btnFiltraTipo.Size = new System.Drawing.Size(150, 30);
            this.btnFiltraTipo.TabIndex = 1;
            this.btnFiltraTipo.Text = "Filtra per Tipo";
            this.btnFiltraTipo.UseVisualStyleBackColor = true;
            this.btnFiltraTipo.Click += new System.EventHandler(this.btnFiltraTipo_Click);
            // 
            // cmbFiltroTipo
            // 
            this.cmbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipo.FormattingEnabled = true;
            this.cmbFiltroTipo.Location = new System.Drawing.Point(30, 40);
            this.cmbFiltroTipo.Name = "cmbFiltroTipo";
            this.cmbFiltroTipo.Size = new System.Drawing.Size(160, 21);
            this.cmbFiltroTipo.TabIndex = 0;
            // 
            // tabPrestiti
            // 
            this.tabPrestiti.Controls.Add(this.grpRestituisci);
            this.tabPrestiti.Controls.Add(this.grpPresta);
            this.tabPrestiti.Location = new System.Drawing.Point(4, 22);
            this.tabPrestiti.Name = "tabPrestiti";
            this.tabPrestiti.Size = new System.Drawing.Size(976, 535);
            this.tabPrestiti.TabIndex = 2;
            this.tabPrestiti.Text = "Prestiti";
            this.tabPrestiti.UseVisualStyleBackColor = true;
            // 
            // grpRestituisci
            // 
            this.grpRestituisci.Controls.Add(this.btnRestituisci);
            this.grpRestituisci.Controls.Add(this.txtCodiceRestituzione);
            this.grpRestituisci.Controls.Add(this.lblCodiceRestituzione);
            this.grpRestituisci.Controls.Add(this.lstContenutiInPrestito);
            this.grpRestituisci.Controls.Add(this.lblInPrestito);
            this.grpRestituisci.Location = new System.Drawing.Point(500, 20);
            this.grpRestituisci.Name = "grpRestituisci";
            this.grpRestituisci.Size = new System.Drawing.Size(456, 490);
            this.grpRestituisci.TabIndex = 1;
            this.grpRestituisci.TabStop = false;
            this.grpRestituisci.Text = "Restituzione";
            // 
            // btnRestituisci
            // 
            this.btnRestituisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestituisci.Location = new System.Drawing.Point(150, 430);
            this.btnRestituisci.Name = "btnRestituisci";
            this.btnRestituisci.Size = new System.Drawing.Size(180, 35);
            this.btnRestituisci.TabIndex = 4;
            this.btnRestituisci.Text = "Restituisci";
            this.btnRestituisci.UseVisualStyleBackColor = true;
            this.btnRestituisci.Click += new System.EventHandler(this.btnRestituisci_Click);
            // 
            // txtCodiceRestituzione
            // 
            this.txtCodiceRestituzione.Location = new System.Drawing.Point(150, 390);
            this.txtCodiceRestituzione.Name = "txtCodiceRestituzione";
            this.txtCodiceRestituzione.Size = new System.Drawing.Size(280, 20);
            this.txtCodiceRestituzione.TabIndex = 3;
            // 
            // lblCodiceRestituzione
            // 
            this.lblCodiceRestituzione.AutoSize = true;
            this.lblCodiceRestituzione.Location = new System.Drawing.Point(20, 393);
            this.lblCodiceRestituzione.Name = "lblCodiceRestituzione";
            this.lblCodiceRestituzione.Size = new System.Drawing.Size(96, 13);
            this.lblCodiceRestituzione.TabIndex = 2;
            this.lblCodiceRestituzione.Text = "Codice contenuto:";
            // 
            // lstContenutiInPrestito
            // 
            this.lstContenutiInPrestito.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContenutiInPrestito.FormattingEnabled = true;
            this.lstContenutiInPrestito.HorizontalScrollbar = true;
            this.lstContenutiInPrestito.ItemHeight = 14;
            this.lstContenutiInPrestito.Location = new System.Drawing.Point(20, 50);
            this.lstContenutiInPrestito.Name = "lstContenutiInPrestito";
            this.lstContenutiInPrestito.Size = new System.Drawing.Size(410, 312);
            this.lstContenutiInPrestito.TabIndex = 1;
            this.lstContenutiInPrestito.DoubleClick += new System.EventHandler(this.lstContenutiInPrestito_DoubleClick);
            // 
            // lblInPrestito
            // 
            this.lblInPrestito.AutoSize = true;
            this.lblInPrestito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInPrestito.Location = new System.Drawing.Point(20, 25);
            this.lblInPrestito.Name = "lblInPrestito";
            this.lblInPrestito.Size = new System.Drawing.Size(136, 15);
            this.lblInPrestito.TabIndex = 0;
            this.lblInPrestito.Text = "Contenuti in prestito:";
            // 
            // grpPresta
            // 
            this.grpPresta.Controls.Add(this.btnPresta);
            this.grpPresta.Controls.Add(this.txtNomeUtente);
            this.grpPresta.Controls.Add(this.lblNomeUtente);
            this.grpPresta.Controls.Add(this.txtCodicePrestito);
            this.grpPresta.Controls.Add(this.lblCodicePrestito);
            this.grpPresta.Controls.Add(this.lstContenutiDisponibili);
            this.grpPresta.Controls.Add(this.lblDisponibili);
            this.grpPresta.Location = new System.Drawing.Point(20, 20);
            this.grpPresta.Name = "grpPresta";
            this.grpPresta.Size = new System.Drawing.Size(456, 490);
            this.grpPresta.TabIndex = 0;
            this.grpPresta.TabStop = false;
            this.grpPresta.Text = "Prestito";
            // 
            // btnPresta
            // 
            this.btnPresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresta.Location = new System.Drawing.Point(150, 430);
            this.btnPresta.Name = "btnPresta";
            this.btnPresta.Size = new System.Drawing.Size(180, 35);
            this.btnPresta.TabIndex = 6;
            this.btnPresta.Text = "Presta";
            this.btnPresta.UseVisualStyleBackColor = true;
            this.btnPresta.Click += new System.EventHandler(this.btnPresta_Click);
            // 
            // txtNomeUtente
            // 
            this.txtNomeUtente.Location = new System.Drawing.Point(150, 395);
            this.txtNomeUtente.Name = "txtNomeUtente";
            this.txtNomeUtente.Size = new System.Drawing.Size(280, 20);
            this.txtNomeUtente.TabIndex = 5;
            // 
            // lblNomeUtente
            // 
            this.lblNomeUtente.AutoSize = true;
            this.lblNomeUtente.Location = new System.Drawing.Point(20, 398);
            this.lblNomeUtente.Name = "lblNomeUtente";
            this.lblNomeUtente.Size = new System.Drawing.Size(73, 13);
            this.lblNomeUtente.TabIndex = 4;
            this.lblNomeUtente.Text = "Nome utente:";
            // 
            // txtCodicePrestito
            // 
            this.txtCodicePrestito.Location = new System.Drawing.Point(150, 360);
            this.txtCodicePrestito.Name = "txtCodicePrestito";
            this.txtCodicePrestito.Size = new System.Drawing.Size(280, 20);
            this.txtCodicePrestito.TabIndex = 3;
            // 
            // lblCodicePrestito
            // 
            this.lblCodicePrestito.AutoSize = true;
            this.lblCodicePrestito.Location = new System.Drawing.Point(20, 363);
            this.lblCodicePrestito.Name = "lblCodicePrestito";
            this.lblCodicePrestito.Size = new System.Drawing.Size(96, 13);
            this.lblCodicePrestito.TabIndex = 2;
            this.lblCodicePrestito.Text = "Codice contenuto:";
            // 
            // lstContenutiDisponibili
            // 
            this.lstContenutiDisponibili.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContenutiDisponibili.FormattingEnabled = true;
            this.lstContenutiDisponibili.HorizontalScrollbar = true;
            this.lstContenutiDisponibili.ItemHeight = 14;
            this.lstContenutiDisponibili.Location = new System.Drawing.Point(20, 50);
            this.lstContenutiDisponibili.Name = "lstContenutiDisponibili";
            this.lstContenutiDisponibili.Size = new System.Drawing.Size(410, 284);
            this.lstContenutiDisponibili.TabIndex = 1;
            this.lstContenutiDisponibili.DoubleClick += new System.EventHandler(this.lstContenutiDisponibili_DoubleClick);
            // 
            // lblDisponibili
            // 
            this.lblDisponibili.AutoSize = true;
            this.lblDisponibili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibili.Location = new System.Drawing.Point(20, 25);
            this.lblDisponibili.Name = "lblDisponibili";
            this.lblDisponibili.Size = new System.Drawing.Size(143, 15);
            this.lblDisponibili.TabIndex = 0;
            this.lblDisponibili.Text = "Contenuti disponibili:";
            // 
            // tabStatistiche
            // 
            this.tabStatistiche.Controls.Add(this.txtStatistiche);
            this.tabStatistiche.Controls.Add(this.btnAggiorna);
            this.tabStatistiche.Location = new System.Drawing.Point(4, 22);
            this.tabStatistiche.Name = "tabStatistiche";
            this.tabStatistiche.Size = new System.Drawing.Size(976, 535);
            this.tabStatistiche.TabIndex = 3;
            this.tabStatistiche.Text = "Statistiche";
            this.tabStatistiche.UseVisualStyleBackColor = true;
            // 
            // txtStatistiche
            // 
            this.txtStatistiche.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatistiche.Location = new System.Drawing.Point(20, 70);
            this.txtStatistiche.Multiline = true;
            this.txtStatistiche.Name = "txtStatistiche";
            this.txtStatistiche.ReadOnly = true;
            this.txtStatistiche.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatistiche.Size = new System.Drawing.Size(936, 440);
            this.txtStatistiche.TabIndex = 1;
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiorna.Location = new System.Drawing.Point(380, 20);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(200, 35);
            this.btnAggiorna.TabIndex = 0;
            this.btnAggiorna.Text = "Aggiorna Statistiche";
            this.btnAggiorna.UseVisualStyleBackColor = true;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Biblioteca Comunale - Gestione Catalogo Multimediale";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInserimento.ResumeLayout(false);
            this.grpSpecifici.ResumeLayout(false);
            this.grpSpecifici.PerformLayout();
            this.grpComuni.ResumeLayout(false);
            this.grpComuni.PerformLayout();
            this.tabCatalogo.ResumeLayout(false);
            this.grpFiltri.ResumeLayout(false);
            this.grpFiltri.PerformLayout();
            this.tabPrestiti.ResumeLayout(false);
            this.grpRestituisci.ResumeLayout(false);
            this.grpRestituisci.PerformLayout();
            this.grpPresta.ResumeLayout(false);
            this.grpPresta.PerformLayout();
            this.tabStatistiche.ResumeLayout(false);
            this.tabStatistiche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInserimento;
        private System.Windows.Forms.TabPage tabCatalogo;
        private System.Windows.Forms.TabPage tabPrestiti;
        private System.Windows.Forms.TabPage tabStatistiche;
        private System.Windows.Forms.GroupBox grpComuni;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoContenuto;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.Label lblValore;
        private System.Windows.Forms.GroupBox grpSpecifici;
        private System.Windows.Forms.Label lblSpec1;
        private System.Windows.Forms.TextBox txtSpec1;
        private System.Windows.Forms.Label lblSpec2;
        private System.Windows.Forms.TextBox txtSpec2;
        private System.Windows.Forms.Label lblSpec3;
        private System.Windows.Forms.TextBox txtSpec3;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.ListBox lstCatalogo;
        private System.Windows.Forms.GroupBox grpFiltri;
        private System.Windows.Forms.ComboBox cmbFiltroTipo;
        private System.Windows.Forms.Button btnFiltraTipo;
        private System.Windows.Forms.TextBox txtFiltroCategoria;
        private System.Windows.Forms.Button btnFiltraCategoria;
        private System.Windows.Forms.Button btnMostraTutto;
        private System.Windows.Forms.GroupBox grpPresta;
        private System.Windows.Forms.Label lblDisponibili;
        private System.Windows.Forms.ListBox lstContenutiDisponibili;
        private System.Windows.Forms.TextBox txtCodicePrestito;
        private System.Windows.Forms.Label lblCodicePrestito;
        private System.Windows.Forms.TextBox txtNomeUtente;
        private System.Windows.Forms.Label lblNomeUtente;
        private System.Windows.Forms.Button btnPresta;
        private System.Windows.Forms.GroupBox grpRestituisci;
        private System.Windows.Forms.Button btnRestituisci;
        private System.Windows.Forms.TextBox txtCodiceRestituzione;
        private System.Windows.Forms.Label lblCodiceRestituzione;
        private System.Windows.Forms.ListBox lstContenutiInPrestito;
        private System.Windows.Forms.Label lblInPrestito;
        private System.Windows.Forms.TextBox txtStatistiche;
        private System.Windows.Forms.Button btnAggiorna;
    }
}
