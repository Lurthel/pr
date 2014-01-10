using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObslugaMagazynuLib.Dokumenty
{
    public class DocumentList: IDocListManager
    {

        #region Constructors

        public DocumentList()
        {
            _source = new BindingList<DocumentHead>();
        }

        #endregion

        #region PrivateFields

        private BindingList<DocumentHead> _source = null;

        #endregion

        #region Methods and Fields 

        //odswiezenie danych
        public int Refresh()
        {
            return this.ShowItems();
        }
        //usuniecie jednego lub wiekszej liczby zaznaczonych rekordow
        public int RemoveItems(int[] GIDNumber, int[] indexes)
        {
            int result = 0;
            MySQL sql = MySQL.Instance;
            StringBuilder query = new StringBuilder();
            query.Append("(");
            int count = 0;
            foreach (int i in GIDNumber)
            {
                count++;
                if (count < GIDNumber.Count<int>())
                {
                    query.Append(i + ",");
                }
                else
                {
                    query.Append(i);
                }
            }
            query.Append(")");
            int? flag = sql.Query("DELETE FROM dokumenty WHERE dokument_id in " + query);
            if(flag != null)
            {
                foreach (int i in indexes)
                {
                    _source.RemoveAt(i);
                }
            }
            return result;
        }
        //metoda wczytuje wszystkie rekordy z bazy danych sa to naglowki wiec nie trzeba wczytywac kazdego elementu z osobna
        public int ShowItems(string typ = null)
        {
            int result = 0;
            _source.Clear();
            MySQL sql = MySQL.Instance;
             int? flag = null;
            if (typ != null)
            {
                flag = sql.Query("SELECT dokument_typ, dokument_id, dokument_nr, dokument_data, dokument_kon_nazwa, dokument_kon_adres FROM dokumenty where dokument_typ LIKE '" + typ + "'");
            }
            else
            {
                flag = sql.Query("SELECT dokument_typ, dokument_id, dokument_nr, dokument_data, dokument_kon_nazwa, dokument_kon_adres FROM dokumenty");
            }

            if (flag != null)
            {
                while (sql.Fetch(flag))
                {
                    try
                    {
                        DocumentHead k = new DocumentHead(
                           (DokType)Enum.Parse(typeof(DokType), sql.RowByName("dokument_typ", flag), true),
                           sql.RowByName("dokument_id", flag),
                           sql.RowByName("dokument_nr", flag),
                           DateTime.Parse(sql.RowByName("dokument_data", flag)),
                           sql.RowByName("dokument_kon_nazwa", flag),
                           sql.RowByName("dokument_kon_adres", flag)
                           );

                        _source.Add(k);
                    }
                    catch(Exception e)
                    {
                        result = 1;
                    }
                }
            }
            return result;
        }

        public int ShowItemsKli(long pesel)
        {
            int result = 0;
            _source.Clear();
            MySQL sql = MySQL.Instance;
            int? flag = null;
            string typ = "FA";
            flag = sql.Query("SELECT dokument_typ, dokument_id, dokument_nr, dokument_data, dokument_kon_nazwa, dokument_kon_adres FROM dokumenty where dokument_kon_pesel='"+pesel+"' AND dokument_typ LIKE '" + typ + "'");
            if (flag != null)
            {
                while (sql.Fetch(flag))
                {
                    try
                    {
                        DocumentHead k = new DocumentHead(
                           (DokType)Enum.Parse(typeof(DokType), sql.RowByName("dokument_typ", flag), true),
                           sql.RowByName("dokument_id", flag),
                           sql.RowByName("dokument_nr", flag),
                           DateTime.Parse(sql.RowByName("dokument_data", flag)),
                           sql.RowByName("dokument_kon_nazwa", flag),
                           sql.RowByName("dokument_kon_adres", flag)
                           );

                        _source.Add(k);
                    }
                    catch (Exception e)
                    {
                        result = 1;
                    }
                }
            }
            return result;
        }
        
        public Document ShowItem(int Id, DokType type)
        {
            Document result = null;
            MySQL sql = MySQL.Instance;
            int? flag = sql.Query("SELECT * from dokumenty where dokument_id=" + Id.ToString());
            if (flag != null)
            {
                //wszytskie pola z zapytania muszą znaleźć się w obiekcie w zaleznosci od typu dokumentu tworzony jest odpowiedni obiekt
                result = this.GetDocumentType(type);
                if(result != null)
                {
                    while (sql.Fetch(flag))
                    {
                        try
                        {

                            result.ClientRegon = sql.RowByName("dokument_kon_regon", flag);
                            result.ClientPesel = sql.RowByName("dokument_kon_pesel", flag);
                            result.Id = Id;
                            result.GIDNumer = sql.RowByName("dokument_nr", flag);
                            result.ClientNIP = sql.RowByName("dokument_kon_nip", flag);
                            result.ClientName = sql.RowByName("dokument_kon_nazwa", flag);
                            result.ClientAddress = sql.RowByName("dokument_kon_adres", flag);
                            result.Date = DateTime.Parse(sql.RowByName("dokument_data", flag));
                        }

                        catch (DokumentyException e)
                        {
                        }
                    }
                }
                //szukamy wszystkich dolaczonych towarow dla danego dokumentu
                //bład zapytania nie ma kolumny dok_id do poprawy
                flag = sql.Query("select * from dokument_towary where dokument_id=" + Id.ToString());
                //w bazie musi sie znalezc kolumna okreslajaca typ towaru abysmy mogli utowrzyc instncje odpowiedniego towaru
                if (flag != null)
                {
                    while (sql.Fetch(flag))
                    {
                        try
                        {
                            //nazwy kolumn moga byc niepoprawne
                            //zweryfikowac sprawdzanie typu towaru
                            //nie wiem czy dobrze zrozumialem sposob podlaczania towarow do dokumentow, jesli 
                            //nie trzeba bedzie sprawdzic typy dla innych tj. opakowania i komplety i utworzyc ich instancje zgodnie z towarem


                                result.Elements._towarList.Add(new Towary.Towar(
                                        sql.RowByName("dt_nazwa", flag),
                                        Convert.ToDouble(sql.RowByName("dt_cena", flag)),
                                        Convert.ToInt32(sql.RowByName("dt_vat", flag)),
                                        sql.RowByName("dt_jm", flag),
                                        sql.RowByName("dt_nr_kat", flag),
                                        Convert.ToInt32(sql.RowByName("dt_ilosc", flag)),
                                        Convert.ToInt32(sql.RowByName("dt_id", flag))
                                        ));
                            
                        }
                        catch (Exception e)
                        {
                           
                        }
                    }
                }
            }
            return result;
        }

        public BindingList<DocumentHead> GetSource()
        {
            return _source;
        }
        private Document GetDocumentType(DokType type)
        {
            switch(type)
            {
                case DokType.BIL:
                    return new DokBilans();
                case DokType.FA:
                    return new DokFaktura();
                case DokType.KFA:
                    return new DokKorekta();
                case DokType.PT:
                    return new DokPrzyjecie();
                case DokType.WT:
                    return new DokWydanie();
                case DokType.MM:
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
                    return new DokRZ();
                case DokType.ZW:
                    return new DokZwrot();
                default:
                    return null;
            }
        }
        #endregion

    }
    public enum DokType
    {
        FA,
        BIL,
        KFA,
        PT,
        WT,
        MM,
        MMPlus,
        MMMinus,
        PW,
        PZ,
        RW,
        RZ,
        ZW,
    }
}
