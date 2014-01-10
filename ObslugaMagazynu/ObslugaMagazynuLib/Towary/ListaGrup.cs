
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib;
using System.Windows.Forms;

namespace ObslugaMagazynuLib.Towary
{
    public class ListaGrup : List<Grupa>, ISingleton
    {

        private ListaGrup() {
            wczytajZDB();
        }

        private static ListaGrup _instance = null;

        public static ListaGrup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListaGrup();
                }
                return _instance;
            }
        }

        public bool zapiszDoDB()
        {
            return false;
        }

        public Grupa dodaj()
        {
            return new Grupa();
        }

        public bool dodaj(Grupa m)
        {
            if (m.Id == 0)
            {
                MySQL sql = MySQL.Instance;

                int? flag = sql.Query("INSERT INTO grupy(grupa_nazwa) VALUES('" + m.Nazwa + "')");
                if (flag != null)
                {
                    flag = sql.Query("SELECT * FROM grupy ORDER BY grupa_id DESC LIMIT 1");
                    if (flag != null)
                    {
                        sql.Fetch(flag);
                        m.Id = Convert.ToInt32(sql.RowByName("grupa_id"));

                        Push(m);
                        return true;
                    }
                }
                else
                {
                    throw new TowaryException("Nie można dodać grupy");
                }
            }
            return false;
        }

        public  void usun()
        {
            throw new TowaryException("Nie podano identyfikatora grupy");
        }

        public bool usun(int id)
        {
            MySQL sql = MySQL.Instance;
            int? check = sql.Query("SELECT count(*) as ilosc FROM towary WHERE grupa_id = " + id.ToString() + " LIMIT 1");
            if (check != null && sql.Fetch(check) && Convert.ToInt32(sql.RowByName("ilosc", check)) == 0)
            {
                int? flag = sql.Query("DELETE FROM grupy WHERE grupa_id = " + id.ToString() + " LIMIT 1");
                if (flag != null)
                {
                    Pop(id);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nie można usunąć grupy ponieważ zawiera przypisane towary!");
            }
            return false;
        }

        public bool usun(Grupa m)
        {
            return usun(m.Id);
        }

        public void wczytajZDB()
        {
            Clear();
            MySQL sql = MySQL.Instance;

            int? flag = sql.Query("SELECT * FROM grupy");
            if (flag != null)
            {
                while (sql.Fetch(flag))
                {
                    Grupa m = new Grupa(
                        sql.Row("grupa_nazwa", flag),
                        sql.RowInt("grupa_id", flag)
                   );

                    Push(m);
                }
            }
            sql.Detach();

        }

        public void Push(Grupa m)
        {
            Add(m);
            Rebind();
        }

        public void Pop(Grupa g)
        {
            Remove(g);
            Rebind();
        }

        public void Pop(int id)
        {
            Grupa result = Find(delegate(Grupa g) {
                return g.Id == id ? true : false;
            });

            if (result != null)
            {
                Remove(result);
                Rebind();
            }
        }

        public void Edit(int id, string nazwa)
        {
            Grupa result = Find(delegate(Grupa g)
            {
                return g.Id == id ? true : false;
            });

            if (result != null && nazwa != result.Nazwa)
            {
                result.Nazwa = nazwa;
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("UPDATE grupy SET grupa_nazwa = '" + result.Nazwa + "' WHERE grupa_id = " + result.Id + " LIMIT 1");
                if (flag != null)
                {
                    Rebind();
                }
                
            }
        }

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

