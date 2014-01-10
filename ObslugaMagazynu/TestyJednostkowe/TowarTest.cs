using ObslugaMagazynuLib.Towary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestyJednostkowe
{
    
    
    /// <summary>
    ///This is a test class for TowarTest and is intended
    ///to contain all TowarTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TowarTest
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
        ///A test for Towar Constructor
        ///</summary>
        [TestMethod()]
        public void TowarConstructorTest()
        {
            string n = "test"; // TODO: Initialize to an appropriate value
            float c = 0F; // TODO: Initialize to an appropriate value
            int v = 0; // TODO: Initialize to an appropriate value
            Towar target = new Towar(n, c, v);
            Assert.AreEqual(target.Nazwa,n);
            Assert.AreEqual(target.Cena, c);
            Assert.AreEqual(target.Vat, v);
        }
    }
}
