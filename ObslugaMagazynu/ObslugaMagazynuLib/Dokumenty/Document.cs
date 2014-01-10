using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Dokumenty
{
    public abstract class Document
    {
        public virtual string Type { get { return "Dokument"; } }

        #region ProtectedFields

        protected int _id;
        protected string _gidnumer;
        protected DateTime _date;
        protected string _desc;
        protected Elements _elements;
        protected const int _startYear = 2000;
        protected int _series;
        protected int _year;
        protected string _clientName;
        protected string _clientAddress;
        protected string _clientNIP;
        protected string _clientRegon;
        protected string _clientPesel;

        //wymyslic jakies glupoty do faktur

        #endregion

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int Series
        {
            get
            {
                return _series;
            }
            set
            {
                if (value.ToString().Length > 3)
                {
                    _series = value;
                }
                else
                {
                    throw new DokumentyException("Nieprawidłowa seria");
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value.Year > _startYear)
                {
                    if (value <= DateTime.Now)
                    {
                        _date = value;
                    }
                    else
                    {
                        throw new DokumentyException("Faktura z przyszłości?");
                    }
                }
                else
                {
                    throw new DokumentyException("Faktura musi być wystawiona po założeniu firmy! (Rok " +_startYear+ ")");
                }
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public Elements Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new Elements();

                return _elements;
            }
            set
            {
                _elements = value;
            }
        }

        public string ClientName
        {
            get
            {
                return _clientName;
            }
            set
            {
                _clientName = value;
            }
        }

        public string ClientAddress
        {
            get
            {
                return _clientAddress;
            }
            set
            {
                _clientAddress = value;
            }
        }

        public string ClientNIP
        {
            get
            {
                return _clientNIP;
            }
            set
            {
                _clientNIP = value;
            }
        }

        public string ClientRegon
        {
            get
            {
                return _clientRegon;
            }
            set
            {
                _clientRegon = value;
            }
        }

        public string GIDNumer
        {
            get
            {
                return _gidnumer;
            }
            set
            {
                _gidnumer = value;
            }
        }

        public string ClientPesel
        {
            get
            {
                return _clientPesel;
            }
            set
            {
                _clientPesel = value;
            }
        }

        #region VirtualMethods

        public virtual int AddNewItem(bool elements)
        {
            //dodanie do bazy dokumentu
            int result = 0;
            MySQL sql = MySQL.Instance;
            //trzeba wstawic odpowiednie pola
            int? flag = sql.Query("INSERT INTO dokumenty(dokument_typ, dokument_nr_seria, dokument_nr_numer, dokument_nr_rok, dokument_nr, dokument_kon_nazwa, dokument_kon_adres, dokument_kon_nip, dokument_kon_regon, dokument_kon_pesel, dokument_data) VALUES ('" + this.Type + "','" + this.Series + "','" + this.Id + "','" + this.Year + "','" + this.Type + "/" + this.Year + "/" + this.Series + "','" + this.ClientName + "','" + this.ClientAddress + "','" + this.ClientNIP + "','" + this.ClientRegon + "','" + this.ClientPesel + "','" + this.Date + "')");
            
            if (flag != null)
            {
               if(elements)
               {
                    int documentLastId = sql.LastId;
                    for (int i = 0; i < this.Elements._towarList.Count; i++)
                    {
                        sql.Query("INSERT INTO dokument_towary(dt_nazwa, dt_jm, dt_cena, dt_vat, dt_ilosc, dt_nr_kat, dokument_id) VALUES ('" + this.Elements._towarList[i].Nazwa + "','" + this.Elements._towarList[i].Jm + "','" + this.Elements._towarList[i].Cena + "','" + this.Elements._towarList[i].Vat + "','" + this.Elements._towarList[i].Stan + "','" + this.Elements._towarList[i].Nr_kat + "','" + documentLastId + "')");
                    }
               }       
                // foreach (Towary.TowarAbstract twr in _elements._towarList)
                result = 1;
            }
            //po wykonaniu insertu nalezy odswiezyc liste poprzez wczytanie jej z bazy co jest rozwiazaniem niezbyt dobrym
            return result;
        }

        public virtual int RemoveItem()
        {
            int result = 0;
            MySQL sql = MySQL.Instance;
            foreach(Towary.TowarAbstract twr in _elements._towarList)
            {
                sql.Query("DELETE FROM dok_twr WHERE twr_id = " + twr.Id);
            }
            int? flag = sql.Query("DELETE FROM dokumenty WHERE dokumenty_gidnumer = " + _gidnumer.ToString());
            //po wykonaniu deletu z poziomu otwartego dokumentu trzeba wykonac wczytywanie wszystkich dokumentow na nowo do listy
            return result;
        }
        public virtual void AddElement(Towary.TowarAbstract element)
        {
           // _elements._towarList.dodaj(element);
            _elements._towarList.Add(element);
        }
        public virtual bool Execute()
        {
            return false;
        }

        #endregion
    }
}
