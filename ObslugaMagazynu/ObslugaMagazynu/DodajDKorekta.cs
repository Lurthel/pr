using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Dokumenty;
using ObslugaMagazynuLib.Towary;
using System.Text.RegularExpressions;

namespace ObslugaMagazynu
{
    public partial class DodajDKorekta : Form
    {
        private int documentId;
        private BindingList<Towar> _source = null;


        public DodajDKorekta()
        {
            InitializeComponent();
            _source = new BindingList<Towar>();
        }

        public DodajDKorekta(int i)
            : this()
        {
            documentId = i;
        }

        private string cName = "Firma testwowa z o.o";
        private string cAdress = "ul. Jana Pawła II 37, 22-222 Kraków";
        private string cNIP = "NIP: 6643432343";
        private string cRegon = "Regon: 92392349234923423";
        DocumentList faktura = new DocumentList();
        Document fakturaData;

        private void DodajDKorekta_Load(object sender, EventArgs e)
        {

            fakturaData = faktura.ShowItem(documentId, DokType.FA);
          
            label2.Text = "K" + fakturaData.GIDNumer;

            label5.Text = cName;
            label6.Text = cAdress;
            label7.Text = cNIP;
            label8.Text = cRegon;

            textBox1.Text = fakturaData.ClientName;
            textBox2.Text = fakturaData.ClientAddress;
            label11.Text = "NIP: ";
            textBox3.Text = fakturaData.ClientNIP.ToString();
            textBox4.Text = fakturaData.ClientRegon.ToString();
            label12.Text = "Regon: ";

            _source.Clear();
            for (int j = 0; j < fakturaData.Elements._towarList.Count; j++)
            {
                Towar temp = new Towar(
                    fakturaData.Elements._towarList[j].Nazwa,
                    fakturaData.Elements._towarList[j].Cena,
                    fakturaData.Elements._towarList[j].Vat,
                    fakturaData.Elements._towarList[j].Jm,
                    fakturaData.Elements._towarList[j].Nr_kat,
                    fakturaData.Elements._towarList[j].Stan,
                    fakturaData.Elements._towarList[j].Id
                    );
                _source.Add(temp);
            }

            dataGridView1.DataSource = _source;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (button1.Text == "Wydaj Korektę")
                {
                    bool flag = true;
                    DokKorekta k = new DokKorekta();
                    try
                    {

                        k.Year = DateTime.Now.Year;
                        k.Series = Convert.ToInt32(fakturaData.GIDNumer.Split('/')[2]);
                        k.Date = DateTime.Now;
                        k.Id = fakturaData.Id;

                        int tempCounter = 0;
                        foreach(DataGridViewRow r in dataGridView1.Rows)
                        {
                            Towar temp = new Towar(
                                    r.Cells[1].Value.ToString(),
                                    Convert.ToInt32(r.Cells[4].Value),
                                    Convert.ToInt32(r.Cells[5].Value),
                                    r.Cells[2].Value.ToString(),
                                    r.Cells[3].Value.ToString(),
                                    Convert.ToInt32(r.Cells[6].Value),
                                    Convert.ToInt32(r.Cells[0].Value)
                                );
                            k.Elements._towarList.Add(temp);
                            tempCounter++;
                        }  

                        k.ClientName = textBox1.Text;
                        k.ClientAddress = textBox2.Text;
                        k.ClientNIP = textBox3.Text;
                        k.ClientRegon = textBox4.Text;      

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
                            MessageBox.Show("Wydano korektę!");
                        }
                        else
                        {
                            MessageBox.Show("Nie wydano korekty! Wystąpił niezidentyfikowany błąd");
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
