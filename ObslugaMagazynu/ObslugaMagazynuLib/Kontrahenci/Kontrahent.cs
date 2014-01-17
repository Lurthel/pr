﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ObslugaMagazynuLib.Kontrahenci
{

    public class Kontrahent
    {
        protected int id;
        protected string nazwa;
        protected string adres;        
        protected long nip;
        protected long regon;
        protected long pesel;
        protected string nr_kontaktowy;
        protected string data_rejestracji;
        protected bool changeflag;

        public bool ChangedFlag { get; set; }
       
       
        public Kontrahent(int ID = 0, string NAZWA = null, string ADRES = null, long NIP = 0, long REGON = 0, long PESEL = 0, string NUMER = null, string DATA = null)
        {
            id = ID;
            nazwa = NAZWA;
            adres = ADRES;
            nip = NIP;
            regon = REGON;
            pesel = PESEL;
            nr_kontaktowy = NUMER;
            data_rejestracji = DATA;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
      
        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                if (value.Length > 3)
                {
                    adres = value;
                }
                else
                {
                    throw new KontrahenciException("Adres posiada mniej niż 4 znaki");
                }
            }
        }
     
        public string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                if (value.Length > 3)
                {
                    nazwa = value;
                }
                else
                {
                    throw new KontrahenciException("Nazwa posiada mniej niż 4 znaki");
                }
            }
        }
   
        public long Nip
        {
            get
            {
                return nip;
            }
            set
            {
                if (value.ToString().Length > 9)
                {
                    nip = value;
                }
                else
                {
                    throw new KontrahenciException("NIP posiada mniej niż 10 znaków");
                }
            }
        }
    
        public long Regon
        {
            get
            {
                return regon;
            }
            set
            {
                if (value.ToString().Length > 8)
                {
                    regon = value;
                }
                else
                {
                    throw new KontrahenciException("REGON posiada mniej niż 9 znaków");
                }
            }
        }
       
        public long Pesel
        {
            get
            {
                return pesel;
            }
            set
            {
                if (value.ToString().Length > 10)
                {
                    pesel = value;
                }
                else
                {
                    throw new KontrahenciException("PESEL posiada mniej niż 11 znaków");
                }
            }
        }
    
        public string Nr_kontaktowy
        {
            get
            {
                return nr_kontaktowy;
            }
            
            set
            {
                if (value.Length > 6)
                {
                    nr_kontaktowy = value;
                }
                else
                {
                    throw new KontrahenciException("Numer kontaktowy posiada mniej niż 7 znaków");
                }
            }
        }
        public string DataRejestracji
        {
            set;
            get;
        }
     
        
        public override string ToString()
        {
            return id.ToString() + "." + nazwa + "/n" + adres + "/n" + ((nip != 0) ? ("NIP:" + nip + "/n") : "") +
                ((regon != 0) ? ("REGON: " + regon + "/n") : "") + ((pesel != 0) ? ("PESEL: " + pesel + "/n") : "") +
             ((nr_kontaktowy != null) ? ("tel. " + nr_kontaktowy + "/n") : "");
        }

    }
}
