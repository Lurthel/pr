using ObslugaMagazynuLib.Towary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestyJednostkowe
{
    
    
    /// <summary>
    ///This is a test class for ListaTowarowTest and is intended
    ///to contain all ListaTowarowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListaTowarowTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for wczytajZDB
        ///</summary>
        [TestMethod()]
        public void wczytajZDBTest()
        {
            ListaTowarow target = ListaTowarow.Instance; // TODO: Initialize to an appropriate value
            target.wczytajZDB();
            Assert.IsTrue(target.Count > 0);
        }

        /// <summary>
        ///A test for dodaj
        ///</summary>
        [TestMethod()]
        public void dodajTest()
        {
            ListaTowarow_Accessor target = new ListaTowarow_Accessor(); // TODO: Initialize to an appropriate value
            target.wczytajZDB();
            string ib = target.Ile.ToString();
            int ibb = Convert.ToInt32(ib);
            Towar t = new Towar("test jednostkowy",1,1,"szt","tj",2,2,2,0,0,new Grupa(0)); // TODO: Initialize to an appropriate value
            target.wczytajZDB();
            string ie = target.Ile.ToString(); // czyli ze dodalo jedne rekord wiecej do bazy..
            int iee = Convert.ToInt32(ie);
            target.dodaj(t);
            Assert.AreEqual(ibb, iee);
        }
    }
}
