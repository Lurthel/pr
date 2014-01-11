using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Magazyn;
using ObslugaMagazynuLib.Towary;

namespace ObslugaMagazynu
{
    public partial class Form1 : FormAbstract 
    {
        public Form1()
        {
            InitializeComponent();
            base.menuStrip1.Enabled = false;
            ListaMagazynow lista = ListaMagazynow.Instance;
            comboBox1.DataSource = lista.getBindingSource();
            lista.Rebind();
        }


        private void pokażWszystkichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // ListaGrup lg = ListaGrup.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ListaMagazynow lista = ListaMagazynow.Instance;
            
            Magazyn temp = (Magazyn)comboBox1.SelectedItem;
            lista.Aktualny = temp;
            label2.Text = lista.Aktualny.ToString();
            base.menuStrip1.Enabled = true;
            ListaTowarow.Instance.MarkAsChanged();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {



        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

       
    }
}
