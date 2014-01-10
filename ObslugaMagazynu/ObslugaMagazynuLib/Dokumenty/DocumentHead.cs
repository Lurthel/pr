using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ObslugaMagazynuLib.Dokumenty
{
    public class DocumentHead
    {
        
        #region Constructors

        public DocumentHead(DokType type, string id, string gidnumer, DateTime date, string contractor, string desc)
        {
            this._type = type;
            this._id = id;
            this._gidnumer = gidnumer;
            this._date = date;
            this._contractor = contractor;
            this._desc = desc;
        }

        #endregion

        #region PrivateFields

        private string _id;
        private string _gidnumer;
        private DateTime _date;
        private string _contractor;
        private string _desc;
        private DokType _type;

        #endregion

        #region PublicProperties

        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string GIDNumer
        {
            get { return _gidnumer; }
            set
            {
                _gidnumer = value;
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
            }
        }
        public string Contractor
        {
            get { return _contractor; }
            set
            {
                _contractor = value;
            }
        }
        public string Desc
        {
            get { return _desc; }
            set
            {
                _desc = value;
            }
        }

        public DokType Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }
        #endregion
    }
}