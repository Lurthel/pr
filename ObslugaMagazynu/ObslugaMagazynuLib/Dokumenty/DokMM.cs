﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObslugaMagazynuLib.Towary;

namespace ObslugaMagazynuLib.Dokumenty
{
    //przesuniecie miedzymagazynowe
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
