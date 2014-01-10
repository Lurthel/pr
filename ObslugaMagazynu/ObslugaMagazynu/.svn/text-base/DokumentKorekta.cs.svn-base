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

namespace ObslugaMagazynu
{
    public partial class DokumentKorekta : Form
    {
        private int documentId;
        private BindingList<Towar> _source = null;


        public DokumentKorekta()
        {
            InitializeComponent();
            _source = new BindingList<Towar>();
        }

        public DokumentKorekta(int i) : this(){
            documentId = i;
        }

        private string cName = "Firma testwowa z o.o";
        private string cAdress = "ul. Jana Pawła II 37, 22-222 Kraków";
        private string cNIP = "NIP: 6643432343";
        private string cRegon = "Regon: 92392349234923423";

        private void DokumentKorekta_Load(object sender, EventArgs e)
        {
            DocumentList faktura = new DocumentList();
            DocumentList oryginal = new DocumentList();
            Document fakturaData = faktura.ShowItem(documentId, DokType.KFA);
            Document oryginalData = oryginal.ShowItem(fakturaData.Id, DokType.FA);

            //label2.Text =  "FA/" + fakturaData.Year + "/" + fakturaData.Series + "/K";
            label2.Text = oryginalData.GIDNumer;

            label5.Text = cName;
            label6.Text = cAdress;
            label7.Text = cNIP;
            label8.Text = cRegon;

            label9.Text = fakturaData.ClientName;
            label10.Text = fakturaData.ClientAddress;
            label11.Text = "NIP: " + fakturaData.ClientNIP.ToString();
            label12.Text = "Regon: " + fakturaData.ClientRegon.ToString();

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

            documentId = oryginalData.Id;


        }

        
    }
}
