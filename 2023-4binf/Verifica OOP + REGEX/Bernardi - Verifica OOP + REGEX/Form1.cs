using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bernardi___Verifica_OOP___REGEX {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            RegexLevel1 regexLevel = new RegexLevel1();
            if (regexLevel.Check("43")) {
                MessageBox.Show("Match");
            }
            else {
                MessageBox.Show("Not match");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            RegexLevel regexLevel = new RegexLevel2();
            if (regexLevel.Check("-43.12")) {
                MessageBox.Show("Match");
            }
            else {
                MessageBox.Show("Not match");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            RegexLevel regexLevel = new RegexLevel3();
            if (regexLevel.Check("+39 02 3323329")) {
                MessageBox.Show("Match");
            }
            else {
                MessageBox.Show("Not match");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            RegexLevel regexLevel = new RegexLevel4();
            if (regexLevel.Check("s.bernardi.2625@vallauri.edu")) {
                MessageBox.Show("Match");
            }
            else {
                MessageBox.Show("Not match");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            RegexLevel regexLevel = new RegexLevel5();
            if (regexLevel.Check("abc caabccxyz")) {
                MessageBox.Show("Match");
            }
            else {
                MessageBox.Show("Not match");
            }
        }
    }
}
