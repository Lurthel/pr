using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib.Magazyn
{
    class MagazynException : Exception
    {
           public MagazynException(string msg) : base(msg){
            
        }
    }
}
