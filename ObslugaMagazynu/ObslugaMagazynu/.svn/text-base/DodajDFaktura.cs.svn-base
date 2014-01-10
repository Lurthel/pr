using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Dokumenty;
using ObslugaMagazynuLib.Kontrahenci;
using ObslugaMagazynuLib.Towary;
using ObslugaMagazynu;


namespace ObslugaMagazynu
{
    public partial class DodajDFaktura : Form
    {

        private BindingList<Towar> _source = null;

        public DodajDFaktura()
        {
            InitializeComponent();
            _source = new BindingList<Towar>();
        }
        DokFaktura editedItem = null;

        public DodajDFaktura(DokFaktura t)
            : this()
        {
            if (t != null)
            {
                editedItem = t;
                textBox1.Text = editedItem.Id.ToString();
                textBox2.Text = editedItem.Series.ToString();
            }
            button1.Text = "Edytuj";

        }

        Form2 chooseClient = new Form2(true);
        int clientId = 0;
        ListaKontrahentow listaKontrahentow = ListaKontrahentow.Instance;

        List<int> chooseProductsList = new List<int>();
        ListaTowarow listaTowarow = ListaTowarow.Instance;

        private void button2_Click(object sender, EventArgs e)
        {
            chooseClient.ShowDialog();
            clientId = chooseClient.selectedId;
            label5.Text = "Wybrany kontrahent:";
            label4.Text = listaKontrahentow.Pick(clientId).Nazwa;
            label6.Text = "ID: " + clientId.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Towary2 chooseProducts = new Towary2(chooseProductsList);
            chooseProducts.ShowDialog(this);

            _source.Clear();

            foreach (int i in chooseProductsList)
            {
                Towar temp = new Towar(
                    listaTowarow.Pick(i).Nazwa,
                    listaTowarow.Pick(i).Cena,
                    listaTowarow.Pick(i).Vat,
                    listaTowarow.Pick(i).Jm,
                    listaTowarow.Pick(i).Nr_kat,
                    listaTowarow.Pick(i).Stan,
                    listaTowarow.Pick(i).Id
                    );
                _source.Add(temp);
            }

            dataGridView1.DataSource = _source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") throw new Exception("Numer nie może być pusty");
                if (textBox2.Text == "") throw new Exception("Seria nie może być pusta");

                if (button1.Text == "Dodaj")
                {
                    bool flag = true;
                    DocumentList lista = null;
                    DokFaktura k = new DokFaktura();
                    try
                    {

                        k.Id = Convert.ToInt32(textBox1.Text);
                        k.Series = Convert.ToInt32(textBox2.Text.ToString());
                        k.Date = dateTimePicker1.Value;
                        k.Year = dateTimePicker1.Value.Year;

                        int tempCounter = 0;
                        foreach(int i in chooseProductsList)
                        {
                            k.Elements._towarList.Add(listaTowarow.Pick(i));
                            if (k.Elements._towarList[tempCounter].Stan < Convert.ToInt32(dataGridView1.Rows[tempCounter].Cells[3].Value))
                                throw new Exception("Ilość pozycji \"" + k.Elements._towarList[tempCounter].Nazwa + "\" nie może być większa niż " + k.Elements._towarList[tempCounter].Stan);
                            k.Elements._towarList[tempCounter].Stan = Convert.ToInt32(dataGridView1.Rows[tempCounter].Cells[3].Value);
                            tempCounter++;
                        }

                        k.ClientName = listaKontrahentow.Pick(clientId).Nazwa;
                        k.ClientAddress = listaKontrahentow.Pick(clientId).Adres;
                        k.ClientNIP = listaKontrahentow.Pick(clientId).Nip.ToString();
                        k.ClientRegon = listaKontrahentow.Pick(clientId).Regon.ToString();
                        k.ClientPesel = listaKontrahentow.Pick(clientId).Pesel.ToString();

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.Message.ToString());
                        flag = false;
                    }
                    if (flag)
                    {

                        if (k.AddNewItem(true) == 1)
                        {
                            MessageBox.Show("Dodano nową fakturę!");
                        }
                        else
                        {
                            MessageBox.Show("Nie dodano faktury! Wystąpił niezidentyfikowany błąd");
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Błąd! " + err.Message);
            }


        }



       
    }
}
