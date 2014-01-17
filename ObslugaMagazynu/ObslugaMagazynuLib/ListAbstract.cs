
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib
{
  
    public interface ListAbstract<T>
    {
       
        void wczytajZDB();
       
        void zapiszDoDB();

      
        bool dodaj(T n);

     
        void usun(T n);
        bool usun(int n);

     
        void Push(T n);

       
        void Pop(T n);

        T Pick(int i);
        T Pick(string s);
        T Pick(T n);

    }
}

