
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Towary
{
    public class Komplet : TowarAbstract
    {
        List<TowarAbstract> _list = new List<TowarAbstract>();
        List<int> _listIds = new List<int>();
        public Komplet(string n, double c, int v)
        {
            Nazwa = n;
            Cena = c;
            Vat = v;
            Id = 0;
        }

        public Komplet(string n, double c, int v, string j, string nk, double sm, double s, double mm, int m, int i, Grupa g)
            : this(n, c, v)
        {
            Jm = j;
            Nr_kat = nk;
            Stan_min = sm;
            Stan = s;
            Min_marza = mm;
            Magazyn = m;
            Id = i;
            Grupa = g;
        }

        public Komplet(string n, double c, int v, string j, string nk, double sm, double s, double mm, int m, int i, Grupa g, List<int> listaTowarow)
            : this(n, c, v, j, nk, sm, s, mm, m, i, g)
        {
            _listIds = listaTowarow;
        }

        public virtual void wybierzTowary()
        {

        }

        public virtual void DodajDoKompletu(TowarAbstract t)
        {
            _list.Add(t);
            _listIds.Add(t.Id);
        }

        public virtual List<TowarAbstract> List
        {
            get
            {
                return _list;
            }
        }

        public virtual List<int> ListIds
        {
            get
            {
                return _listIds;
            }
        }
    }
}

