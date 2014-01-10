using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ObslugaMagazynuLib.Kontrahenci
{
    class Adres
    {
        public Adres(string Ulica = null, string Nr_domu = null, string Nr_lokalu = null, string Miejscowosc = null, string Kod_pocztowy = null, string Region = null, string Panstwo = null)
        {
            try
            {
                ulica = Ulica;
                nr_domu = Nr_domu;
                nr_lokalu = Nr_lokalu;
                miejscowosc = Miejscowosc;
                kod_pocztowy = Kod_pocztowy;
                region = Region;
                panstwo = Panstwo;
                
            }

            catch (KontrahenciException e)
            {
                MessageBox.Show(e.Message);
              
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. Przepraszamy.");
                
            }


        }
        public string ulica
        {
            get
            {
                return ulica;
            }
            set
            {
                if (ulica.Length > 3)
                {
                    ulica = value;
                }
                else
                {
                    throw new KontrahenciException("Ulica posiada mniej niż 4 znaki");
                }
            }

        }
        public string nr_domu
        {
            get
            {
                return nr_domu;
            }
            set
            {
                if (nr_domu.Length > 0)
                {
                    nr_domu = value;
                }
                else
                {
                    throw new KontrahenciException("Nie podałeś numeru domu");
                }
            }
        }
        public string nr_lokalu
        {
            get;
            set;
        }
        public string miejscowosc
        {
            get
            {
                return miejscowosc;
            }
            set
            {
                if (miejscowosc.Length > 3)
                {
                    miejscowosc = value;
                }
                else
                {
                    throw new KontrahenciException("Miejscowość posiada mniej niż 4 znaki");
                }
            }

        }
        public string kod_pocztowy
        {
            get
            {
                return kod_pocztowy;
            }
            set
            {
                if (kod_pocztowy.Length > 2)
                {
                    kod_pocztowy = value;
                }
                else
                {
                    throw new KontrahenciException("Kod pocztowy posiada mniej niż 3 znaki");
                }
            }
        }
        public string region
        {
            get
            {
                return region;
            }
            set
            {

                if (region.Length > 3)
                {
                    region = value;
                }
                else
                {
                    throw new KontrahenciException("Region posiada mniej niż 4 znaki");
                }
            }
        }
        public string panstwo
        {
            get
            {
                return panstwo;
            }
            set
            {
                if (panstwo.Length > 3)
                {
                    panstwo = value;
                }
                else
                {
                    throw new KontrahenciException("Panstwo posiada mniej niż 4 znaki");
                }
            }
        }
        public bool Zmien(string Ulica = null, string Nr_domu = null, string Nr_lokalu = null, string Miejscowosc = null, string Kod_pocztowy = null, string Region = null, string Panstwo = null)
        {
            try
            {
                if (ulica!=null) ulica = Ulica;
                if (nr_domu != null) nr_domu = Nr_domu;
                if (nr_lokalu != null) nr_lokalu = Nr_lokalu;
                if (miejscowosc != null) miejscowosc = Miejscowosc;
                if (kod_pocztowy != null) kod_pocztowy = Kod_pocztowy;
                if (region != null) region = Region;
                if (panstwo != null) panstwo = Panstwo;
                return true;
            }

            catch (KontrahenciException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. Przepraszamy.");
                return false;
            }
        }
        public override string ToString()
        {
            return "ul. " + ulica + " " + ((nr_lokalu != null) ? (nr_domu + "/" + nr_lokalu) : nr_domu)+
                "\n"+kod_pocztowy+" "+miejscowosc+((region!=null) ? ("/n" + region) : "" )+"/n"+panstwo;
         }

    }
}
