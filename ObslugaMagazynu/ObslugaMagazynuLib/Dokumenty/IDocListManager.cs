using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ObslugaMagazynuLib.Dokumenty
{
    public interface IDocListManager
    {
        #region Methods

        int Refresh();
        int RemoveItems(int[] GIDNumber, int[] indexes);
        int ShowItems(string typ = null);
        Document ShowItem(int GIDNumber, DokType type);
        BindingList<DocumentHead> GetSource();

        #endregion
    }
}
