using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObslugaMagazynuLib.Magazyn;

namespace ObslugaMagazynu
{
    public partial class Magazyny : FormAbstract
    {
        public Magazyny()
        {
            InitializeComponent();
            Magazyny_Load(this, null);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Magazyny_Load(object sender, EventArgs e)
        {
            ListaMagazynow lista = ListaMagazynow.Instance;
            dataGridView1.DataSource = lista.getBindingSource();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
            
            }
         

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            (new DodajMagazyn()).ShowDialog();
            ListaMagazynow.Instance.Rebind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
            if (!(e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1)))
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Usun")
                {
                    DialogResult flag = MessageBox.Show("Czy na pewno chcesz usunąć ten magazyn ?", "Usuwanie magazynu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (flag == DialogResult.Yes)
                    {
                        ListaMagazynow list = ListaMagazynow.Instance;
                        int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        list.usun(i);
                        list.Rebind();
                        dataGridView1.Refresh();
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edytuj")
                {
                  
                    ListaMagazynow list = ListaMagazynow.Instance;
                    int i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                   
                   (new DodajMagazyn(list.Pick(i))).ShowDialog();
                   list.Rebind();
                   dataGridView1.Refresh();

                }
            }
        }

    }
}
