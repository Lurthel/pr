using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Towary;

namespace ObslugaMagazynu
{
    public partial class Towary2 : FormAbstract
    {
        public Towary2()
        {
            InitializeComponent();
        }

        public Towary2(List<int> listIn)
            : this()
        {
            list.Clear();
            list = listIn;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            (new DodajTowar()).ShowDialog();
            ListaTowarow list = ListaTowarow.Instance;
            list.Rebind();
        }

        private void Towary2_Load(object sender, EventArgs e)
        {
           
            ListaTowarow lista = ListaTowarow.Instance;

            lista.wczytajZDB();

            dataGridView1.DataSource = lista.getBindingSource();

            if (Owner is DodajTowar || Owner is DodajDFaktura || Owner is DodajDPrzyjecie || Owner is DodajDWydanie)
            {
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Edytuj"].Visible = false;
                dataGridView1.Columns["Usun"].Visible = false;
                if (list.Count > 0)
                {
                    foreach (int i in list)
                    {
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if ((int)r.Cells["Id"].Value == i)
                            {
                                r.Cells["Zaznacz"].Value = true;
                            }
                        }
                    }
                }
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Usun")
            {
                DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ten towar ?", "Usuwanie towaru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (flag == DialogResult.Yes)
                {
                    ListaTowarow list = ListaTowarow.Instance;
                    int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    list.usun(i);
                    list.Rebind();
                    dataGridView1.Refresh();
                }
            }else if(dataGridView1.Columns[e.ColumnIndex].Name == "Edytuj"){
                ListaTowarow list = ListaTowarow.Instance;
                int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                (new DodajTowar(list.Edit(i))).ShowDialog();
                dataGridView1.Refresh();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaTowarow list = ListaTowarow.Instance;
            int i = dataGridView1.FirstDisplayedScrollingRowIndex;
            if (dataGridView1.Rows.Count == 0)
            {
                list.Rebind();
            }
            dataGridView1.Refresh();
            
            if (i != -1)
            {
                timer1.Enabled = false;
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void Towary2_Shown(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        public List<int> list = new List<int>();
        private void button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if ((bool)r.Cells["Zaznacz"].EditedFormattedValue == true)
                {
                    list.Add((int)r.Cells["Id"].Value);
                }
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listaTowarowBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        
    }
}
