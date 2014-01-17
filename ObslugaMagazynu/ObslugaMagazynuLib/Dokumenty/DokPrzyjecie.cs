
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Dokumenty
{
    public class DokPrzyjecie : Document
    {
        public override string Type { get { return "PT"; } }
        public override bool Execute()
        {
           
            this.AddNewItem(_elements._towarList.Count > 0 ? true : false);

            MySQL sql = MySQL.Instance;
            foreach (Towary.TowarAbstract t in _elements._towarList)
            {
                
                int? r = sql.Query("UPDATE towary SET towar_stan = towar_stan + " + t.Stan + " WHERE towar_id = " + t.Id);
                if (r == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

