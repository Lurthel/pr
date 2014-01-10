using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Dokumenty
{
    public class DokElements
    {   
        public List<Towary.TowarAbstract> _towarList;
        public DokElements()
        {
            _towarList = new List<Towary.TowarAbstract>();
        }
        public void AddTowar(Towary.TowarAbstract twr)
        {
            _towarList.Add(twr);
        }
        public void DeleteTowar(int index)
        {
            _towarList.RemoveAt(index);
        }        
    }
}
