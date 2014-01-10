using ObslugaMagazynuLib.Magazyn;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestyJednostkowe
{
    
    
    /// <summary>
    ///This is a test class for ListaMagazynowTest and is intended
    ///to contain all ListaMagazynowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListaMagazynowTest
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
        ///A test for dodaj
        ///</summary>
        [TestMethod()]
        public void dodajTest()
        {
            ListaMagazynow target = ListaMagazynow.Instance; // TODO: Initialize to an appropriate value
            Magazyn m = new Magazyn("test111", "nazwa111"); // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.dodaj(m);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for usun
        ///</summary>
        [TestMethod()]
        public void usunTest()
        {
            ListaMagazynow target = ListaMagazynow.Instance; // TODO: Initialize to an appropriate value
            int id = 1; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.usun(id);
            Assert.AreEqual(expected, actual);
      
        }

        /// <summary>
        ///A test for wczytajZDB
        ///</summary>
        [TestMethod(),DeploymentItem("mysql.xml")]
        public void wczytajZDBTest()
        {
            ListaMagazynow target = ListaMagazynow.Instance; // TODO: Initialize to an appropriate value
            target.wczytajZDB();
            Assert.IsTrue(target.Count > 0);
          
        }
    }
}
