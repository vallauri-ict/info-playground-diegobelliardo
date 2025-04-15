using System;
using System.Drawing;
using System.Windows.Forms;

namespace _47_PrimoEsFile
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            rtbUno.Font = new Font("Consolas", 12, FontStyle.Regular);
            rtbDue.Font = new Font("Consolas", 12, FontStyle.Italic);
            cmbParole.Font = new Font("Consolas", 12, FontStyle.Regular);
            CaricaCombo("input.txt");
        }

        private void CaricaCombo(string inputFile)
        {
            cmbParole.Items.Clear();
            string[] parole = new string[100];

            parole = ClsFile.LeggiParoleNonRipetute(inputFile);

            int i=0;
            while (parole[i] != null)
            {
                cmbParole.Items.Add(parole[i]);
                i++;
            }
        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
            string contenuto = ClsFile.LeggiTutto("input.txt");
            rtbUno.Text = contenuto;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ClsFile.ModificaFile("input.txt", rtbUno.Text);
            MessageBox.Show("File modificato, ora verrà ricaricato...");
            rtbUno.Text = ClsFile.LeggiTutto("input.txt");
            CaricaCombo("input.txt");
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            string contenutoPrimoFile = ClsFile.LeggiTutto("input.txt");
            ClsFile.ModificaFile("output.txt", contenutoPrimoFile);
            rtbDue.Text = contenutoPrimoFile;
            MessageBox.Show("Il file input.txt è stato copiato nel file output.txt");
        }

        private void btnContaLineeParole_Click(object sender, EventArgs e)
        {
            int nLinee = 0, nParole = 0;
            ClsFile.ContaLineeParole("input.txt", ref nLinee, ref nParole);
            string message = $"Linee: {nLinee}\nParole: {nParole}";
            MessageBox.Show(message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbParole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int occorrenze = ClsFile.ContaOccorrenze("input.txt", cmbParole.SelectedItem.ToString());
            if (occorrenze > 0)
                MessageBox.Show($"{occorrenze} occorrenze", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Nessuna occorrenza!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
