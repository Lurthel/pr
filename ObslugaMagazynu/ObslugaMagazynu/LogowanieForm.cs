using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ObslugaMagazynu
{
    public partial class LogowanieForm : Form
    {
        public LogowanieForm()
        {
            InitializeComponent();
        }
        public void frmNewFormThread()
    {

        Application.Run(new Form1());

    }

        private void zalogujbutton_Click(object sender, EventArgs e)
        {
            string uzytkownik = this.loginbox.Text;
            string haslo = this.haslobox.Text;

            if (SprawdzNazweiHaslo(uzytkownik, haslo))
            {
                //MessageBox.Show("Jest w systemie", "Zaalogowano");
                  //  this.Hide();
                // dalej tutaj mozecie tworzyc nowe formularze i dalsza czesc programu ...
                   // Form1 fr = new Form1();
                   // fr.Show();

                System.Threading.Thread newThread;
                Form1 frmNewForm = new Form1();

                newThread = new System.Threading.Thread(new System.Threading.ThreadStart(frmNewFormThread));
                this.Close();
                newThread.SetApartmentState(System.Threading.ApartmentState.STA);
                newThread.Start();

                    
               
                
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło", "Błąd logowania");
                return;
            }
        }
        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {
            if (uzytkownik == "admin" & haslo == "admin")
                return true;
            else
                return false;

        }
    }
}
