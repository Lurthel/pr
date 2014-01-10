using ObslugaMagazynuLib.Kontrahenci;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestyJednostkowe
{
    /*
    
    /// <summary>
    ///This is a test class for ListaKontrahentowTest and is intended
    ///to contain all ListaKontrahentowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ListaKontrahentowTest
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
        ///A test for ListaKontrahentow Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ObslugaMagazynuLib.dll")]
        public void ListaKontrahentowConstructorTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Pick
        ///</summary>
        [TestMethod()]
        public void PickTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            int n = 0; // TODO: Initialize to an appropriate value
            Kontrahent expected = null; // TODO: Initialize to an appropriate value
            Kontrahent actual;
            actual = target.Pick(n);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Pop
        ///</summary>
        [TestMethod()]
        public void PopTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            Kontrahent k = null; // TODO: Initialize to an appropriate value
            target.Pop(k);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


      
        /// <summary>
        ///A test for dodaj
        ///</summary>
        [TestMethod()]
        public void dodajTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            Kontrahent k = new Kontrahent(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.dodaj(k);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for edytuj
        ///</summary>
        [TestMethod()]
        public void edytujTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            Kontrahent k = new Kontrahent();// TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.edytuj(k);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getBindingSource
        ///</summary>
        [TestMethod()]
        public void getBindingSourceTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            BindingSource expected = null; // TODO: Initialize to an appropriate value
            BindingSource actual;
            actual = target.getBindingSource();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for usun
        ///</summary>
        [TestMethod()]
        public void usunTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            Kontrahent k = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.usun(k);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for usun
        ///</summary>
        [TestMethod()]
        public void usunTest1()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.usun(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for wczytajZDB
        ///</summary>
        [TestMethod()]
        public void wczytajZDBTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            target.wczytajZDB();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for zapiszDoDB
        ///</summary>
        [TestMethod()]
        public void zapiszDoDBTest()
        {
            ListaKontrahentow_Accessor target = new ListaKontrahentow_Accessor(); // TODO: Initialize to an appropriate value
            target.zapiszDoDB();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Instance
        ///</summary>
        [TestMethod()]
        public void InstanceTest()
        {
            ListaKontrahentow actual;
            actual = ListaKontrahentow.Instance;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }*/
}
