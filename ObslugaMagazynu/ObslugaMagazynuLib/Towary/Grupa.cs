
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Towary
{
    public class Grupa
    {
        protected string nazwa;
        protected int id;

        /// <summary>
        /// konstruktor
        /// </summary>
        public Grupa()
        {
            Nazwa = "brak";
            Id = 0;
        }

        public Grupa(string n) : this()
        {
            Nazwa = n;
        }

        public Grupa(string n, int i) : this(n)
        {
            Id = i;
        }

        public Grupa(int id)
        {
            if (id != 0)
            {
                ListaGrup lista = ListaGrup.Instance;
                Grupa result = lista.Find(delegate(Grupa t)
                {
                    return (t.Id == id) ? true : false;
                });
                if (result != null)
                {
                    Nazwa = result.Nazwa;
                    Id = result.Id;
                    return;
                }
            }
            Nazwa = "brak";
            Id = 0;
        }

        public virtual string Nazwa
        {
            get
            {
                return nazwa;
            }
            set
            {
                if(value != null)
                nazwa = value;
            }
        }

        public virtual int Id
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

        public override string ToString()
        {
            return Nazwa;
        }


    }
}

