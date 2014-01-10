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
    public partial class Grupy : FormAbstract
    {
        public Grupy()
        {
            InitializeComponent();
        }

        private void Grupy_Load(object sender, EventArgs e)
        {
            ListaGrup lg = ListaGrup.Instance;
            dataGridView1.DataSource = lg.getBindingSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                if (edited_id > 0)
                {
                    ListaGrup lg = ListaGrup.Instance;
                    lg.Edit(edited_id, textBox1.Text);
                    edited_id = 0;
                    textBox1.Clear();
                    button1.Text = "Dodaj nową grupę";
                }
                else
                {
                    ListaGrup lg = ListaGrup.Instance;
                    Grupa g = new Grupa(textBox1.Text);
                    lg.dodaj(g);
                    textBox1.Clear();
                }
            }
        }

        private int edited_id = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Usun")
                {
                    DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ta grupe ?", "Usuwanie grupy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (flag == DialogResult.Yes)
                    {
                        ListaGrup list = ListaGrup.Instance;
                        int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value); // 3 to id
                        list.usun(i);
                        dataGridView1.Refresh();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edytuj")
                {
                    textBox1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value; // 4 to nazwa
                    edited_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value); // 3 to id
                    button1.Text = "Edytuj grupę";

                }
        }
    }
}
