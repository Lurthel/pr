
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObslugaMagazynuLib
{

    public interface ListAbstract<T>
    {
        /// <summary>
        /// 
        /// Wczytuje wszystkie pozycje z bazy badz jakas czesc. Do wyboru
        /// </summary>
        void wczytajZDB();
        /// <summary>
        /// Zapisuje zmienione elementy w bazie 
        /// </summary>
        void zapiszDoDB();

        /// <summary>
        /// Metoda dodaje nowy element do bazy
        /// </summary>
        bool dodaj(T n);

        /// <summary>
        /// Metoda usuwa element z bazy
        /// </summary>
        void usun(T n);
        bool usun(int n);

        /// <summary>
        /// Metoda pushuje obiekt na lsite
        /// </summary>
        void Push(T n);

        /// <summary>
        /// Metoda kasuje obiekt z listy ale nie z bazy
        /// </summary>
        void Pop(T n);

        /// <summary>
        /// Metoda pobiera obiekt o określonych parametrach z listy
        /// </summary>
        T Pick(int i);
        T Pick(string s);
        T Pick(T n);

    }
}

