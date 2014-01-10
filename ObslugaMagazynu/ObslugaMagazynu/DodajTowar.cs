using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Towary;
using ObslugaMagazynuLib.Magazyn;

namespace ObslugaMagazynu
{
    public partial class DodajTowar : Form
    {
        public DodajTowar()
        {
            InitializeComponent();
            ListaGrup lg = ListaGrup.Instance;
            foreach (Grupa g in lg)
            {
                comboBox3.Items.Add(g);
            }
        }

        TowarAbstract editedItem = null;
        public DodajTowar(TowarAbstract t) : this(){
            
            if (t != null)
            {
                editedItem = t;

                //
                textBox1.Text = t.Nazwa;
                textBox3.Text = t.Nr_kat;
                textBox4.Text = t.Cena.ToString();
                textBox5.Text = t.Min_marza.ToString();
                textBox7.Text = t.Stan_min.ToString();
                textBox2.Text = t.Stan.ToString();

                // jednostka miary
                int inx = 0;
                foreach (String s in comboBox2.Items)
                {
                    if (s == t.Jm)
                    {
                        comboBox2.SelectedIndex = inx;
                    }
                    inx++;
                }

                // jednostka miary
                inx = 0;
                foreach (String s in comboBox1.Items)
                {
                    if (s == t.Vat.ToString())
                    {
                        comboBox1.SelectedIndex = inx;
                    }
                    inx++;
                }

                // grupy
                foreach (Grupa g in comboBox3.Items)
                {
                    if (g.Nazwa == t.Grupa.Nazwa)
                    {
                        comboBox3.SelectedItem = g;
                    }
                }

                if (t is Opakowanie)
                {
                    textBox6.Text = ((Opakowanie)t).iloscWOpakowaniu.ToString();
                    list.Add(((Opakowanie)t).towarWOpakowaniu.Id);
                    groupBox3.Enabled = false;
                }
                else if (t is Komplet)
                {
                    label14.Text = ((Komplet)t).ListIds.Count.ToString();
                    foreach (int i in ((Komplet)t).ListIds)
                    {
                        list.Add(i);
                    }
                    groupBox2.Enabled = false;

                }
                else
                {
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }

                button1.Text = "Edytuj";
            }
        }

        private List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Nazwa nie może być pusta");
                if (textBox3.Text == "") throw new Exception("Nr katalogowy nie może być pusty");
                if (textBox4.Text == "") throw new Exception("Cena nie może być pusta");
                if (textBox5.Text == "") throw new Exception("Marża może być pusta");
                if (textBox7.Text == "") throw new Exception("Stan minimalny nie może być pusty");

                if (Convert.ToDouble(textBox4.Text) < 0) throw new Exception("Cena nie może być ujemna");
                if (Convert.ToDouble(textBox5.Text) < 0) throw new Exception("Marża nie może być ujemna");
                if (Convert.ToDouble(textBox7.Text) < 0) throw new Exception("Stan minimalny nie może być ujemny");


                TowarAbstract towar = null;
                if (list.Count == 0)
                {
                    towar = new Towar(
                      textBox1.Text,
                      Convert.ToDouble(textBox4.Text),
                      Convert.ToInt32(comboBox1.SelectedItem.ToString()),
                      comboBox2.SelectedItem.ToString(),
                      textBox3.Text,
                      Convert.ToDouble(textBox7.Text),
                      Convert.ToDouble(textBox2.Text),
                      Convert.ToDouble(textBox5.Text),
                      ListaMagazynow.Instance.Aktualny.Id,
                      0,
                      comboBox3.SelectedItem as Grupa
                   );
                    towar.Type = "Towar";

                }
                else if (Convert.ToInt32(label14.Text) > 0 && list.Count > 1)
                {
                    towar = new Komplet(
                        textBox1.Text,
                       Convert.ToDouble(textBox4.Text),
                       Convert.ToInt32(comboBox1.SelectedItem.ToString()),
                       comboBox2.SelectedItem.ToString(),
                       textBox3.Text,
                       Convert.ToDouble(textBox7.Text),
                       Convert.ToDouble(textBox2.Text),
                       Convert.ToDouble(textBox5.Text),
                       ListaMagazynow.Instance.Aktualny.Id,
                       0,
                       comboBox3.SelectedItem as Grupa,
                       list
                     );
                    towar.Type = "Komplet";

                }
                else if (list.Count == 1)
                {
                    Towar towarIn = new Towar(list[0]);
                    towar = new Opakowanie(
                               textBox1.Text,
                               Convert.ToDouble(textBox4.Text),
                               Convert.ToInt32(comboBox1.SelectedItem.ToString()),
                               towarIn,
                               Convert.ToInt32(textBox6.Text),
                               comboBox2.SelectedItem.ToString(),
                               textBox3.Text,
                               Convert.ToDouble(textBox7.Text),
                               Convert.ToDouble(textBox2.Text),
                               Convert.ToDouble(textBox5.Text),
                               ListaMagazynow.Instance.Aktualny.Id,
                               0,
                               comboBox3.SelectedItem as Grupa
                            );
                    towar.Type = "Opakowanie";
                }
                ListaTowarow lista = ListaTowarow.Instance;
                if (editedItem != null)
                {
                    towar.Id = editedItem.Id;
                    bool flag = lista.Edit(towar);
                    if (flag)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Blad edycji!");
                    }
                }
                else
                {
                    bool flag = lista.dodaj(towar);

                    if (flag)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dodanie nowego towaru nie powiodło się!");
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Błąd! " + err.Message);
            }
        }

        private void DodajTowar_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Towary2 t = new Towary2(list);
            DialogResult result = t.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (t.list.Count > 0)
                {
                    list = t.list;
                    Towar tow = new Towar(list[0]);
                    label12.Text = tow.Nazwa;
                    groupBox3.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Towary2 t = new Towary2(list);
            DialogResult result = t.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                if (t.list.Count > 0)
                {
                    list = t.list;
                    label14.Text = list.Count().ToString();
                    groupBox2.Enabled = false;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
