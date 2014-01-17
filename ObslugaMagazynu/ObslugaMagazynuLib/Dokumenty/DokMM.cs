
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib.Towary;

namespace ObslugaMagazynuLib.Dokumenty
{
   
    public class DokMM : Document
    {
        private string _magDoc;
        public string MagDoc
        {
            get { return _magDoc; }
            set { _magDoc = value; }
        }
        public override string Type { get { return "MM"; } }
    }
}

