using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Dokumenty
{
    class DokumentyException : Exception
    {
        public DokumentyException(string wiadomosc):base(wiadomosc){}
    }
}