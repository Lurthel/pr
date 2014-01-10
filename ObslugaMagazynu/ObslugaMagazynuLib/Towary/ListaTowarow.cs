
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib.Magazyn;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace ObslugaMagazynuLib.Towary
{
    public class ListaTowarow : List<TowarAbstract>
    {
        private bool changedItems = false;

        protected static ListaTowarow _instance = new ListaTowarow();
        private ListaTowarow()
        {
            changedItems = true;
        }


        public static ListaTowarow Instance
        {
            get
            {
                return _instance;
            }
        }

        public void MarkAsChanged(){
            changedItems = true;
        }
        public void wczytajZDB()
        {
            Thread th = new Thread(new ThreadStart(wczytajZDBStart));
            th.Start();
        }

        public void wczytajZDBStart()
        {
            if (!changedItems && this.Count!=0)
                return;
            MySQL sql = MySQL.Instance;

            int id = ListaMagazynow.Instance.Aktualny.Id ; // id magazynu
            int? flag = sql.Query("SELECT t.*, tt.*, o.towar_id AS opakowanie_id, o.towar_nazwa AS opakowanie_nazwa, o.towar_cena AS opakowanie_cena, o.towar_vat AS opakowanie_vat, o.towar_jm AS opakowanie_jm, o.towar_nr_kat AS opakowanie_nk, o.towar_stan_min AS opakowanie_sm, o.towar_stan AS opakowanie_s, o.towar_min_marza AS opakowanie_mm, o.magazyn_id AS opakowanie_mag, o.towar_id AS opakowanie_id, o.grupa_id AS opakowanie_grupa, k.towar_id AS k_id, k.towar_nazwa AS k_nazwa, k.towar_cena AS k_cena, k.towar_vat AS k_vat, k.magazyn_id AS k_mag, k.grupa_id AS k_grupa, k.towar_min_marza AS k_mm, k.towar_stan AS k_s, k.towar_stan_min AS k_sm, k.towar_jm AS k_jm, k.towar_nr_kat AS k_nk FROM towary AS t LEFT JOIN grupy AS g ON g.grupa_id = t.grupa_id LEFT JOIN towary_towary AS tt ON tt.tt_komplet_id = t.towar_id LEFT JOIN towary AS k ON k.towar_id = tt.tt_towar_id LEFT JOIN towary AS o ON o.towar_id = t.towar_opakowanie_id WHERE t.magazyn_id = " + id.ToString());
            if (flag != null)
            {
                Clear();
                while (sql.Fetch(flag))
                {

                    TowarAbstract towar = null;
                    if (sql.Returned(flag) && !sql.Row("tt_komplet_id", flag).Equals("0"))
                    {
                        // zadanie nietrywialne, komplet moze miec duzo towarow w sobie , ale jest tylko jeden takiego typu..

                        TowarAbstract result = Find(delegate(TowarAbstract t)
                        {
                            int i = sql.RowInt("towar_id", flag);
                            return (t.Id == i) ? true : false;
                        });

                        if (result == null)
                        {
                            towar = new Komplet(
                                sql.Row("towar_nazwa", flag),
                                sql.RowDouble("towar_cena", flag),
                                sql.RowInt("towar_vat", flag),
                                sql.Row("towar_jm", flag),
                                sql.Row("towar_nr_kat", flag),
                                sql.RowDouble("towar_stan_min", flag),
                                sql.RowDouble("towar_stan", flag),
                                sql.RowDouble("towar_min_marza", flag),
                                sql.RowInt("magazyn_id", flag),
                                sql.RowInt("towar_id", flag),
                                new Grupa(sql.RowInt("grupa_id", flag))
                                );
                            towar.Type = "Komplet"; // komplet
                            result = towar;
                        }
                        Towar towarKompletowany = new Towar(
                            sql.Row("k_nazwa"),
                            Convert.ToDouble(sql.Row("k_cena", flag)),
                            Convert.ToInt32(sql.Row("k_vat", flag)),
                            sql.Row("k_jm", flag),
                            sql.Row("k_nk", flag),
                            Convert.ToDouble(sql.Row("k_sm", flag)),
                            Convert.ToDouble(sql.Row("k_s", flag)),
                            Convert.ToDouble(sql.Row("k_mm", flag)),
                            Convert.ToInt32(sql.Row("k_mag", flag)),
                            Convert.ToInt32(sql.Row("k_id", flag)),
                            new Grupa(sql.Row("k_grupa", flag))
                        );

                        (result as Komplet).DodajDoKompletu(towarKompletowany);


                    }
                    else if (sql.Returned(flag) && !sql.Row("towar_opakowanie_id", flag).Equals("0"))
                    {
                        Towar towarOpakowany = new Towar(
                            sql.Row("opakowanie_nazwa", flag),
                            Convert.ToDouble(sql.Row("opakowanie_cena", flag)),
                            Convert.ToInt32(sql.Row("opakowanie_vat", flag)),
                            sql.Row("opakowanie_jm", flag),
                            sql.Row("opakowanie_nk", flag),
                            Convert.ToDouble(sql.Row("opakowanie_sm", flag)),
                            Convert.ToDouble(sql.Row("opakowanie_s", flag)),
                            Convert.ToDouble(sql.Row("opakowanie_mm", flag)),
                            Convert.ToInt32(sql.Row("opakowanie_mag", flag)),
                            Convert.ToInt32(sql.Row("opakowanie_id", flag)),
                            new Grupa(sql.Row("opakowanie_grupa", flag))
                        );

                        towar = new Opakowanie(
                            sql.Row("towar_nazwa", flag),
                            Convert.ToDouble(sql.Row("towar_cena", flag)),
                            Convert.ToInt32(sql.Row("towar_vat", flag)),
                            towarOpakowany,
                            Convert.ToInt32(sql.Row("towar_sztuk_opakowanie", flag)),
                            sql.Row("towar_jm", flag),
                            sql.Row("towar_nr_kat", flag),
                            sql.RowDouble("towar_stan_min", flag),
                            sql.RowDouble("towar_stan", flag),
                            sql.RowDouble("towar_min_marza", flag),
                            sql.RowInt("magazyn_id", flag),
                            sql.RowInt("towar_id", flag),
                            new Grupa(sql.RowInt("grupa_id", flag))
                        );

                        towar.Type = "Opakowanie"; // opakowanie

                    }
                    else if (sql.Returned(flag))
                    {
                        towar = new Towar(
                            sql.Row("towar_nazwa", flag),
                            sql.RowDouble("towar_cena", flag),
                            Convert.ToInt32(sql.Row("towar_vat", flag)),
                            sql.Row("towar_jm", flag),
                            sql.Row("towar_nr_kat", flag),
                            sql.RowDouble("towar_stan_min", flag),
                            sql.RowDouble("towar_stan", flag),
                            sql.RowDouble("towar_min_marza", flag),
                            Convert.ToInt32(sql.Row("magazyn_id", flag)),
                            Convert.ToInt32(sql.Row("towar_id", flag)),
                            new Grupa(sql.RowInt("grupa_id", flag))
                        );

                        towar.Type = "Towar"; // zwykly towar
                    }

                    if (towar != null)
                        Push(towar);
                }
                changedItems = false;
            }
        }

        public void zapiszDoDB()
        {
            throw new System.NotImplementedException();
        }

        public void dodaj()
        {
            throw new TowaryException("Nie podano typu!");
        }

        public bool dodaj(TowarAbstract t)
        {
            if (t is Komplet)
            {
                return dodaj(t as Komplet);
            }
            else if (t is Opakowanie)
            {
                return dodaj(t as Opakowanie);
            }
            else if (t is Towar)
            {
                return dodaj(t as Towar);
            }
            return false;
        }

        public bool dodaj(Towar t)
        {
            if (t.Id <= 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("INSERT INTO towary(towar_nazwa,towar_cena,towar_vat,towar_stan,towar_stan_min,towar_jm,towar_min_marza,towar_nr_kat,grupa_id,magazyn_id) VALUES ('" + t.Nazwa + "'," + t.Cena + "," + t.Vat + "," + t.Stan + "," + t.Stan_min + ",'" + t.Jm + "'," + t.Min_marza + ",'" + t.Nr_kat + "'," + t.Grupa.Id + ","+ListaMagazynow.Instance.Aktualny.Id.ToString()+")");
                if (flag != null)
                {
                    changedItems = true;
                    return true;
                }
            }
            return false;
        }

        public bool dodaj(Opakowanie t)
        {
            if (t.Id <= 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("INSERT INTO towary(towar_nazwa,towar_cena,towar_vat,towar_stan,towar_stan_min,towar_jm,towar_min_marza,towar_nr_kat,grupa_id,towar_opakowanie_id,towar_sztuk_opakowanie,magazyn_id) VALUES ('" + t.Nazwa + "'," + t.Cena + "," + t.Vat + "," + t.Stan + "," + t.Stan_min + ",'" + t.Jm + "'," + t.Min_marza + ",'" + t.Nr_kat + "'," + t.Grupa.Id + "," + t.towarWOpakowaniu.Id + "," + t.iloscWOpakowaniu + ","+ListaMagazynow.Instance.Aktualny.Id.ToString()+")");
                if (flag != null)
                {
                    changedItems = true;
                    return true;
                }
            }
            return false;
        }

        public bool dodaj(Komplet t)
        {
            if (t.Id <= 0)
            {
                MySQL sql = MySQL.Instance;
                int? flag = sql.Query("INSERT INTO towary(towar_nazwa,towar_cena,towar_vat,towar_stan,towar_stan_min,towar_jm,towar_min_marza,towar_nr_kat,grupa_id,magazyn_id) VALUES ('" + t.Nazwa + "'," + t.Cena + "," + t.Vat + "," + t.Stan + "," + t.Stan_min + ",'" + t.Jm + "'," + t.Min_marza + ",'" + t.Nr_kat + "'," + t.Grupa.Id + ","+ListaMagazynow.Instance.Aktualny.Id.ToString()+")");
                if (flag != null)
                {
                    int LastId = new Int32();
                    LastId = sql.LastId;
                    foreach (TowarAbstract a in t.List)
                    {
                        sql.Query("INSERT INTO towary_towary(tt_komplet_id,tt_towar_id) VALUES(" + LastId + "," + a.Id + ")");
                    }
                    foreach (int i in t.ListIds)
                    {
                        sql.Query("INSERT INTO towary_towary(tt_komplet_id,tt_towar_id) VALUES(" + LastId + "," + i + ")");
                    }
                    changedItems = true;
                    return true;
                }
            }
            return false;
        }

        public void usun(TowarAbstract t)
        {
            if (t is Komplet)
            {
                usun(t as Komplet);
            }
            else if (t is Opakowanie)
            {
                usun(t as Opakowanie);
            }
            else if (t is Towar)
            {
                usun(t as Towar);
            }
        }

        public void usun(int i)
        {
            TowarAbstract result = Find(delegate(TowarAbstract t)
            {
                return (t.Id == i) ? true : false;
            });

            if (result != null)
            {
                usun(result);
            }

        }

        public void usun(Towar t)
        {
            MySQL sql = MySQL.Instance;

            int? flag = sql.Query("SELECT count(*) AS ilosc FROM towary_towary WHERE tt_towar_id = " + t.Id + " LIMIT 1");
            if (flag != null && sql.Returned(flag) && sql.Fetch(flag) && sql.RowInt("ilosc", flag) > 0)
            {
                throw new TowaryException("Towar przypisany jest przynajmniej do jednego kompletu!");
            }
            sql.Detach(flag);

            flag = sql.Query("SELECT count(*) AS ilosc FROM towary WHERE towar_opakowanie_id = " + t.Id + " LIMIT 1");
            if (flag != null && sql.Returned(flag) && sql.Fetch(flag) && sql.RowInt("ilosc", flag) > 0)
            {
                throw new TowaryException("Towar znajduje się w przynajmniej jednym opakowaniu!");
            }
            sql.Detach(flag);

            sql.Query("DELETE FROM towary WHERE towar_id = " + t.Id);
            Pop(t as TowarAbstract);
            changedItems = true;
        }

        public void usun(Komplet k)
        {
            MySQL sql = MySQL.Instance;
            sql.Query("DELETE FROM towary WHERE towar_id = " + k.Id + " LIMIT 1");
            sql.Query("DELETE FROM towary_towary WHERE tt_komplet_id = " + k.Id + " LIMIT 1");
            Pop(k as TowarAbstract);
            changedItems = true;
        }

        public void usun(Opakowanie o)
        {
            MySQL sql = MySQL.Instance;
            sql.Query("DELETE FROM towary WHERE towar_id = " + o.Id + " LIMIT 1");

            Pop(o as TowarAbstract);
            changedItems = true;
        }

        public TowarAbstract Edit(int id)
        {
            TowarAbstract result = Find(delegate(TowarAbstract t)
            {
                return t.Id == id ? true : false;
            });

            if (result != null)
            {
                return result;
            }
            return null;
        }

        public bool Edit(TowarAbstract t)
        {
            if (t is Towar)
            {
                return Edit(t as Towar);
            }
            else if (t is Opakowanie)
            {
                return Edit(t as Opakowanie);
            }
            else if (t is Komplet)
            {
                return Edit(t as Komplet);
            }
            return false;
        }

        public bool Edit(Towar t)
        {
            TowarAbstract result = Find(delegate(TowarAbstract tw)
            {
                return tw.Id == t.Id ? true : false;
            });

            if (result != null)
            {
                int inx = 0;
                foreach (TowarAbstract tf in this)
                {
                    if (tf is Towar && tf.Id == t.Id)
                    {
                        this[inx] = t;
                        break;
                    }
                    inx++;
                }

                MySQL sql = MySQL.Instance;
                int? u = sql.Query("UPDATE towary SET towar_nazwa = '" + t.Nazwa + "', towar_cena = " + t.Cena.ToString() + ",towar_stan = '" + t.Stan.ToString() + "',towar_stan_min = '" + t.Stan_min.ToString() + "',towar_min_marza = '" + t.Min_marza.ToString() + "',towar_jm = '" + t.Jm + "',towar_nr_kat = '" + t.Nr_kat + "',towar_vat = '" + t.Vat.ToString() + "',grupa_id = '" + t.Grupa.Id.ToString() + "' WHERE towar_id = " + t.Id + " LIMIT 1");
                if (u != null)
                {
                    Rebind();
                    return true;
                }
            }
            return false;
        }

        public bool Edit(Opakowanie t)
        {
            TowarAbstract result = Find(delegate(TowarAbstract tw)
            {
                return tw.Id == t.Id ? true : false;
            });

            if (result != null)
            {
                int inx = 0;
                foreach (TowarAbstract tf in this)
                {
                    if (tf is Opakowanie && tf.Id == t.Id)
                    {
                        this[inx] = t;
                        break;
                    }
                    inx++;
                }

                MySQL sql = MySQL.Instance;
                int? u = sql.Query("UPDATE towary SET towar_nazwa = '" + t.Nazwa + "', towar_cena = " + t.Cena.ToString() + ",towar_stan = '" + t.Stan + "',towar_stan_min = '" + t.Stan_min.ToString() + "',towar_min_marza = '" + t.Min_marza.ToString() + "',towar_jm = '" + t.Jm + "',towar_nr_kat = '" + t.Nr_kat + "',towar_vat = '" + t.Vat.ToString() + "',grupa_id = '" + t.Grupa.Id.ToString() + "',towar_opakowanie_id = '" + t.towarWOpakowaniu.Id.ToString() + "',towar_sztuk_opakowanie = '" + t.iloscWOpakowaniu.ToString() + "' WHERE towar_id = " + t.Id + " LIMIT 1");
                if (u != null)
                {
                    Rebind();
                    return true;
                }
            }
            return false;
        }

        public bool Edit(Komplet t)
        {
            TowarAbstract result = Find(delegate(TowarAbstract tw)
            {
                return tw.Id == t.Id ? true : false;
            });

            if (result != null)
            {
                int inx = 0;
                foreach (TowarAbstract tf in this)
                {
                    if (tf is Komplet && tf.Id == t.Id)
                    {
                        this[inx] = t;
                        break;
                    }
                    inx++;
                }

                MySQL sql = MySQL.Instance;
                int? u = sql.Query("UPDATE towary SET towar_nazwa = '" + t.Nazwa + "', towar_cena = " + t.Cena.ToString() + ",towar_stan = '" + t.Stan + "',towar_stan_min = '" + t.Stan_min.ToString() + "',towar_min_marza = '" + t.Min_marza.ToString() + "',towar_jm = '" + t.Jm + "',towar_nr_kat = '" + t.Nr_kat + "',towar_vat = '" + t.Vat.ToString() + "',grupa_id = '" + t.Grupa.Id.ToString() + "' WHERE towar_id = " + t.Id + " LIMIT 1");
                if (u != null)
                {
                    u = sql.Query("DELETE FROM towary_towary WHERE tt_komplet_id = " + t.Id);
                    if (u != null)
                    {
                        foreach (int a in t.ListIds)
                        {
                            sql.Query("INSERT INTO towary_towary(tt_komplet_id,tt_towar_id) VALUES(" + t.Id + "," + a + ")");
                        }
                        Rebind();
                        return true;
                    }
                }
            }
            return false;
        }

        public void Push(Towar t)
        {
            Push(t as TowarAbstract);
        }

        public void Push(Komplet k)
        {
            Push(k as TowarAbstract);
        }

        public void Push(Opakowanie o)
        {
            Push(o as TowarAbstract);
        }

        public void Push(TowarAbstract t)
        {
            Add(t);
        }

        public void Pop(TowarAbstract t)
        {
            try
            {
                Remove(t);
            }
            catch { }
        }

        public TowarAbstract Pick(int id)
        {
            TowarAbstract result = Find(delegate(TowarAbstract tw)
            {
                return tw.Id == id ? true : false;
            });

            return result;
        }

        public void Rebind()
        {
            getBindingSource().DataSource = null;
            getBindingSource().DataSource = this;
        }

        // omg do testow.. w testach nie da sie odwolac do Count..
        public int Ile
        {
            get
            {
                return Count;
            }
        }

        BindingSource s = null;
        public BindingSource getBindingSource()
        {

            if (s == null)
            {
                s = new BindingSource();
                getBindingSource().AllowNew = true;
                s.DataSource = this;
            }
            return s;
        }
    }
}

