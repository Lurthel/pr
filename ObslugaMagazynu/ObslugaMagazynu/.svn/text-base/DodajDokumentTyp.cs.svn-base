using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObslugaMagazynu
{
    public partial class DodajDokumentTyp : Form
    {
        public DodajDokumentTyp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new DodajDPrzyjecie()).ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            (new DodajDWydanie()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Dokumenty("FA","Korekta")).ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Dokumenty("FA", "Zwrot")).ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Close();
            (new DodajDFaktura()).ShowDialog();
        }
    }
}
