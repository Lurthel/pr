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
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void frmNewFormThread()
    {

        Application.Run(new Form1());
     

    }

        
        public bool SprawdzNazweiHaslo(string uzytkownik, string haslo)
        {
            if (uzytkownik == "admin" & haslo == "admin")
                return true;
            else
                return false;
           
        }

        private void LogowanieForm_KeyDown(object sender, KeyEventArgs e)
        {
            string uzytkownik = this.loginbox.Text;
            string haslo = this.haslobox.Text;
                
                if (e.KeyCode == Keys.Return)
                {


                    if (SprawdzNazweiHaslo(uzytkownik, haslo))
                    {
                        
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
            
        }

        private void zalogujbutton_Click_1(object sender, EventArgs e)
        {
            string uzytkownik = this.loginbox.Text;
            string haslo = this.haslobox.Text;

            if (SprawdzNazweiHaslo(uzytkownik, haslo))
            {
               
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

        

       
    

      

    

       
      
    }
}
