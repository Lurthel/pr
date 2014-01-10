using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Magazyn;
using ObslugaMagazynu;


namespace ObslugaMagazynu
{
    public partial class DodajMagazyn : Form
    {
        public DodajMagazyn()
        {
            InitializeComponent();
        }
        Magazyn editedItem = null;
        public DodajMagazyn(Magazyn t): this()
        {
            if (t != null)
            {
                editedItem = t;
                textBox1.Text = editedItem.Nazwa.ToString();
                textBox2.Text = editedItem.Lokalizacja.ToString();
            }
            button1.Text = "Edytuj";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Dodaj")
            {
                bool flag = true;
                ListaMagazynow lista = ListaMagazynow.Instance;
                Magazyn m = new Magazyn();
                try
                {
                    m.Nazwa = textBox1.Text.ToString();
                    m.Lokalizacja = textBox2.Text.ToString();
                    m.DataUtworzenia = DateTime.Now.ToString();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message.ToString());
                    flag = false;
                }
                if (flag)
                {

                    if (lista.dodaj(m))
                    {
                        MessageBox.Show("Dodano magazyn!");
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano magazynu! Wystąpił niezidentyfikowany błąd");
                    }
                    this.Close();
                }
              
            }
            else if (button1.Text == "Edytuj")
            {
                bool flag = true;
                ListaMagazynow lista = ListaMagazynow.Instance;
                Magazyn m = new Magazyn();
                try
                {
                    m.Nazwa = textBox1.Text.ToString();
                    m.Lokalizacja = textBox2.Text.ToString();
                    m.DataUtworzenia = DateTime.Now.ToString();
                    m.Id = editedItem.Id;
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message.ToString());
                    flag = false;
                }
                if (flag)
                {
                    if (lista.edytuj(m))
                    {
                        MessageBox.Show("Zmieniono magazyn!");

                    }
                    else
                    {
                        MessageBox.Show("Nie zmieniono magazynu! Wystąpił niezidentyfikowany błąd");
                    }
                    this.Close();
                }
            }
        }
    }
}
