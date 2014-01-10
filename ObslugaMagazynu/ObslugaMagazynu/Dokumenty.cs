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
    public partial class Dokumenty : FormAbstract
    {
        public int selectedId;
        private string _option;
        string fakturaTyp;
        public long pesel;

        public Dokumenty()
        {
            _option = null;
            InitializeComponent();
        }
        public Dokumenty(long pe)
        {
            _option = null;
            pesel = pe;
            InitializeComponent();
            
        }

        public Dokumenty(string option)
        {
            _option = option;
            InitializeComponent();
        }

        public Dokumenty(string option, string _fakturaTyp)
        {
            _option = option;
            fakturaTyp = _fakturaTyp;
            InitializeComponent();
        }

        private DocumentList lista = new DocumentList();

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Dokumenty_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "ID";
            idColumn.HeaderText = "Id";

            DataGridViewTextBoxColumn gidnumerColumn = new DataGridViewTextBoxColumn();
            gidnumerColumn.DataPropertyName = "GIDNumer";
            gidnumerColumn.HeaderText = "Numer";

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Data utworzenia";

            DataGridViewTextBoxColumn contColumn = new DataGridViewTextBoxColumn();
            contColumn.DataPropertyName = "Contractor";
            contColumn.HeaderText = "Kontrahent";

            DataGridViewTextBoxColumn descColumn = new DataGridViewTextBoxColumn();
            descColumn.DataPropertyName = "Desc";
            descColumn.HeaderText = "Opis";

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            descColumn.DataPropertyName = "Type";
            descColumn.HeaderText = "Typ";

            this.dataGridView1.Columns.Add(idColumn);
            this.dataGridView1.Columns.Add(gidnumerColumn);
            this.dataGridView1.Columns.Add(dateColumn);
            this.dataGridView1.Columns.Add(contColumn);
            this.dataGridView1.Columns.Add(descColumn);
            this.dataGridView1.Columns.Add(type);

            if (pesel > 0)
            {
                lista.ShowItemsKli(pesel);
            }
            else
            {
                lista.ShowItems(_option);
            }
            dataGridView1.DataSource = lista.GetSource();

            if (Owner is DodajDokumentTyp)
            {
                dataGridView1.Columns["Zaznacz"].Visible = false;
                dataGridView1.Columns["Usun"].Visible = false;
                dataGridView1.Columns["Show"].HeaderText = "Wybierz";
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Usun")
                {
                    DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ten dokument ?", "Usuwanie towaru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (flag == DialogResult.Yes)
                    {
                        int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                        int[] tablica1 = new int[1];
                        tablica1[0] = i;

                        int[] tablica2 = new int[1];
                        tablica2[0] = e.RowIndex;

                        lista.RemoveItems(tablica1, tablica2);
                        dataGridView1.DataSource = lista.GetSource();
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Show")
                {
                    int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    DokType j = new DokType();
                    j = (DokType)Enum.Parse(typeof(DokType), (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()), true); 
                   
                    DocumentList faktura = new DocumentList();
                    Document fakturaData = faktura.ShowItem(i, DokType.FA);
                   
                    switch (j)
                    {
                       // case DokType.BIL:
                            //return new DokBilans();
                        case DokType.FA:
                            switch (fakturaTyp)
                            {
                                case "Korekta":
                                    (new DodajDKorekta(i)).ShowDialog();
                                    this.Close();
                                    break;
                                case "Zwrot":
                                    //(new DokumentFaktura(i)).ShowDialog();
                                   // this.Close();
                                        DocumentList zwrot = new DocumentList();
                                        Document zwrotData = faktura.ShowItem(i, DokType.FA);
                                        
                                        bool flag = true;
                                        DokZwrot nowy = new DokZwrot();
                                        try
                                        {                                       
                                            for (int l = 0; l < zwrotData.Elements._towarList.Count; l++)
                                            {
                                                Towar temp = new Towar(
                                                    zwrotData.Elements._towarList[l].Nazwa,
                                                    zwrotData.Elements._towarList[l].Cena,
                                                    zwrotData.Elements._towarList[l].Vat,
                                                    zwrotData.Elements._towarList[l].Jm,
                                                    zwrotData.Elements._towarList[l].Nr_kat,
                                                    zwrotData.Elements._towarList[l].Stan,
                                                    zwrotData.Elements._towarList[l].Id
                                                    );
                                                nowy.Elements._towarList.Add(temp);
                                            }

                                            nowy.Id = zwrotData.Id;
                                            nowy.Series = Convert.ToInt32(zwrotData.GIDNumer.Split('/')[2]);
                                            nowy.Date = DateTime.Now;
                                            nowy.Year = DateTime.Now.Year;

                                            nowy.ClientName = zwrotData.ClientName;
                                            nowy.ClientAddress = zwrotData.ClientAddress;
                                            nowy.ClientNIP = zwrotData.ClientNIP;
                                            nowy.ClientRegon = zwrotData.ClientRegon; 
                                        }
                                        catch (Exception msg)
                                        {
                                            MessageBox.Show(msg.Message.ToString());
                                            flag = false;
                                        }
                                        if (flag)
                                        {
                                            nowy.Execute();
                                            ListaTowarow.Instance.MarkAsChanged();
                                            MessageBox.Show("Przyjęto zwrot na Magazyn!"); 
                                            this.Close();
                                        }                                      
                                    break;
                                default:
                                    (new DokumentFaktura(i)).ShowDialog();
                                    break;
                            }
                            break;
                        case DokType.PT:
                            (new DokumentPrzyjecie(i)).ShowDialog();
                            break;
                        case DokType.WT:
                            (new DokumentWydanie(i)).ShowDialog();
                            break;
                        case DokType.KFA:
                            (new DokumentKorekta(i)).ShowDialog();
                            break;
                        /* case DokType.MM:
                             return new DokMM();
                         case DokType.MMMinus:
                             return new DokMMMinus();
                         case DokType.MMPlus:
                             return new DokMMPlus();
                         case DokType.PW:
                             return new DokPW();
                         case DokType.PZ:
                             return new DokPZ();
                         case DokType.RW:
                             return new DokRW();
                         case DokType.RZ:
                             return new DokRZ(); */
                        case DokType.ZW:
                            (new DokumentFaktura(i, "Zwrot")).ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Błąd!");
                            break;
                    }
                    
                    dataGridView1.Refresh();

                }
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Wybierz")
                {
                    selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    DialogResult = System.Windows.Forms.DialogResult.OK;

                }
            }
        }

        private void towaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Towary2_Load_1(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new DodajDokumentTyp()).ShowDialog();
            lista.ShowItems();
            dataGridView1.DataSource = lista.GetSource();
        }

        private void dokumentyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DocumentList lista = new DocumentList();
            lista.ShowItems();
            dataGridView1.DataSource = lista.GetSource();
        }
    }
}
