using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Towary
{
    class TowaryException : Exception
    {
        public TowaryException(string msg) : base(msg) { }
    }
}
