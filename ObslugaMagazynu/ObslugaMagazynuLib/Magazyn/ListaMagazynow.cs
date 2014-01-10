
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib;
using System.Windows.Forms;

namespace ObslugaMagazynuLib.Magazyn
{
    public class ListaMagazynow : List<Magazyn>
    {
        protected Magazyn aktualny = new Magazyn();
        private static ListaMagazynow instance;
       
        /// <summary>
        /// konstruktor zapełniający automatycznie listę, prywatny, wywoływany przez metodą instance jako że klasa jest singletonem
        /// </summary>
        private ListaMagazynow() { this.wczytajZDB(); }
        /// <summary>
        /// metoda operująca na polu określającym aktualnie wybrany magazyn, jako że lista jest singletonem aktualny może być tylko jeden magazyn 
        /// </summary>
        public Magazyn Aktualny
        {
            get
            {
                return aktualny;                
            }
            set
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("SELECT count(*) as ilosc FROM magazyny WHERE magazyn_id ="+value.Id.ToString());
                if (flag != null && sql.Fetch(flag) && Convert.ToInt32(sql.RowByName("ilosc", flag)) > 0)
                {
                    aktualny.Id = value.Id;
                    int? flaga = sql.Query("SELECT * FROM magazyny WHERE magazyn_id =" + value.Id.ToString());
                    if (flaga != null && sql.Fetch(flaga))
                    {
                        aktualny.Nazwa = sql.RowByName("magazyn_nazwa", flaga).ToString();
                        aktualny.Lokalizacja = sql.RowByName("magazyn_lokalizacja", flaga).ToString();;
                        aktualny.DataUtworzenia = sql.RowByName("magazyn_data_utworzenia", flaga).ToString(); ;
                    }
                }
                else
                {
                    throw new MagazynException("Magazyn o takim id nie istnieje w bazie");
                }
                
            }
        }
        /// <summary>
        /// metoda zwracająca listę magazynów, lub tworząca ją jeżeli jeszcze nie istnieje
        /// </summary>
        public static ListaMagazynow Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ListaMagazynow();
                }
                return instance;
            }
        }        
        /// <summary>
        /// zapisanie nowych danych z listy do bazy danych, oraz update poprzednich
        /// </summary>
        public  void  zapiszDoDB()
        {
            foreach (Magazyn mag in this)
            {
                if (mag.Id != 0 && mag.ChangedFlag == true)
                {
                    MySQL sql = MySQL.Instance;
                    int? flaga = sql.Query("UPDATE magazyny SET magazyn_nazwa="+mag.Nazwa+", magazyn_lokalizacja="+mag.Lokalizacja
                        +", magazyn_data_utworzenia="+mag.DataUtworzenia+" WHERE magazyn_id =" + mag.Id.ToString());
                    if (flaga == null)
                    {
                        throw new MagazynException("Nie udało się zaktualizować bazy magazynów.");
                    }
                    
                }
                else if(mag.Id ==0)
                {
                    MySQL sql = MySQL.Instance;
                    int? flaga = sql.Query("INSERT INTO magazyny(magazyn_nazwa, magazyn_lokalizacja, magazyn_data_utworzenia) VALUES("+mag.Nazwa+", "+mag.Lokalizacja+", "+ mag.DataUtworzenia +")");
                    if (flaga == null)
                    {
                        throw new MagazynException("Nie udało się zaktualizować bazy magazynów.");
                    }
                }
                else throw new MagazynException("Nie udało się zaktualizować bazy magazynów.");
            }
        }
        /// <summary>
        /// funkcja wczytuje z bazy danych wszystkie magazyny
        /// </summary>
        public  void wczytajZDB()
        {
            this.Clear();
            MySQL sql = MySQL.Instance;
            int? flag = sql.Query("SELECT * FROM magazyny");
            if (flag != null)
            {
                while (sql.Fetch(flag))
                {
                    Magazyn m = new Magazyn(
                       Convert.ToInt32(sql.RowByName("magazyn_id", flag)),
                       sql.RowByName("magazyn_nazwa", flag),
                       sql.RowByName("magazyn_lokalizacja", flag),
                       sql.RowByName("magazyn_data_utworzenia", flag)
                   );

                    this.Add(m);
                }
                Rebind();
            }
        }       
        /// <summary>
        /// funkcja dodaję magazyn do listy ale nie do bazy danych
        /// </summary>
        public void Push(Magazyn m)
        {
            foreach (Magazyn mag in this)
            {
                if (m.Nazwa == mag.Nazwa && m.Lokalizacja == mag.Lokalizacja)
                {
                    throw new MagazynException("Taki magazyn już istnieje na liście");
                }

            }
            if (m.DataUtworzenia == null) { m.DataUtworzenia = DateTime.Now.ToString(); }
            this.Add(m);
        }
        /// <summary>
        /// metoda kasuje element z listy jednak nie z bazy danych
        /// </summary>
        /// <param name="m"></param>
        public void Pop(Magazyn m)
        {
            foreach (Magazyn mag in this)
            {
                if (m.Equals(mag))
                {
                    this.Remove(mag);
                }
            }
        }
        /// <summary>
        /// metoda pobiera element z listy ale tylko gdy najwyżej jeden element pasuje do kryteriów
        /// </summary>
      

        public Magazyn Pick(int n)
        {
            List<Magazyn> temp = new List<Magazyn>();
            foreach (Magazyn mag in this)
            {
                if (mag.Id == n) { temp.Add(mag); }
            }
            if (temp.Count == 1) return temp[0];
            else throw new MagazynException("więcej niż jeden magazyn z listy pasuje do kryterium");
        }
        /// <summary>
        /// metoda pobiera element z listy ale tylko gdy najwyżej jeden element pasuje do kryteriów
        /// </summary>
        public Magazyn Pick(string n)
        {
            List<Magazyn> temp = new List<Magazyn>();
            foreach (Magazyn mag in this)
            {
                if (mag.Nazwa == n) { temp.Add(mag); }
                else if (mag.Lokalizacja == n) { temp.Add(mag); }

            }
            if (temp.Count == 1) return temp[0];
            else throw new MagazynException("więcej niż jeden magazyn z listy pasuje do kryterium");
        }
        /// <summary>
        /// metoda pobiera element z listy ale tylko gdy najwyżej jeden element pasuje do kryteriów
        /// </summary>
        public Magazyn Pick(Magazyn n)
        {
            List<Magazyn> temp = new List<Magazyn>();
            foreach (Magazyn mag in this)
            {
                if (mag.Equals(n)) { temp.Add(mag); }
                
            }
            if (temp.Count == 1) return temp[0];
            else throw new MagazynException("więcej niż jeden magazyn z listy pasuje do kryterium");
        }
        /// <summary>
        /// metoda dodaje magazyn do listy oraz do bazy dancyh
        /// </summary>

        public bool dodaj(Magazyn m)
        {
            if (m.Id == 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("INSERT INTO magazyny(magazyn_nazwa, magazyn_lokalizacja, magazyn_data_utworzenia) VALUES('" + m.Nazwa + "','" + m.Lokalizacja + "','" + DateTime.Now + "')");
                if (flag != null)
                {
                    flag = sql.Query("SELECT * FROM magazyny ORDER BY magazyn_id DESC LIMIT 1");
                    if (flag != null)
                    {
                        sql.Fetch(flag);
                        m.Id = Convert.ToInt32(sql.RowByName("magazyn_id", flag));
                        m.DataUtworzenia = sql.RowByName("magazyn_data_utworzenia", flag);

                        this.Add(m);
                        this.Rebind();
                        return true;
                    }
                }
                else
                {
                    throw new MagazynException("Nie można dodać magazynu");
                }
            }

            return false;
        }
        /// <summary>
        /// metoda pozwala na edycję magazynów
        /// </summary>
        
        public bool edytuj(Magazyn m)
        {
            if (m.Id != 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("UPDATE magazyny SET magazyn_nazwa='" + m.Nazwa + "' , magazyn_lokalizacja='" + m.Lokalizacja + "' WHERE magazyn_id=" + m.Id + " LIMIT 1");
                if (flag != null)
                {
                    wczytajZDB();
                    return true;
                    
                }

                else
                {
                    throw new MagazynException("Nie można zmienić magazynu");
                }
            }

            return false;
        }
        /// <summary>
        /// jeżeli do magazynu nie są przyporządkowane towary funkcja kasuje ten magazyn zarówno z listy jak i z bazy dancyh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool usun(int id)
        {
            MySQL sql = MySQL.Instance;
            int? check = sql.Query("SELECT count(*) as ilosc FROM towary WHERE magazyn_id = " + id.ToString());

            if (check != null && Convert.ToInt32(sql.RowByName("ilosc")) == 0)
            {

                int? flag = sql.Query("DELETE FROM magazyny WHERE magazyn_id = " + id.ToString());
                if (flag == null)
                {
                    return false;
                }
                else
                {
                    wczytajZDB();
                    return true;
                }
            }
            else if (Convert.ToInt32(sql.RowByName("ilosc")) != 0)
            {
                throw new MagazynException("Do magazynu który próbujesz skasowac są przyporządkowane towary. Operacja niedozwolona!");
               
            }
            return false;
        }
        /// <summary>
        /// metoda wywołuję funkcję usun(int id)
        /// </summary>
    
        public void usun(Magazyn m)
        {
            bool flag =  usun(m.Id);
            if (flag == true)
            {
                Pop(m);
                
            }
            else throw new MagazynException("Wystąpił błąd. Operacja niedozwolona!");
            
        }
        /// <summary>
        /// funkcja służąca do odświeżenia danych w DGV
        /// </summary>
        public void Rebind()
        {
            getBindingSource().DataSource = null;
            getBindingSource().DataSource = this;
        }


        BindingSource s = null;
        public BindingSource getBindingSource()
        {

            if (s == null)
            {
                s = new BindingSource();
                s.DataSource = this;
            }
            return s;
        }


      



    }
}

