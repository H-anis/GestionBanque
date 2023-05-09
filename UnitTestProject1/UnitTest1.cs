using System;
using WindowsFormsApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        static Client c = new Client(99, "Hamila", "Anis", "11 rue des pirouettes");
        Compte co = new CompteCourant(99, c);


        [TestMethod]
        public void TestGenerer()
        {


            co.crediter(200);
            Assert.AreEqual(200, co.getSolde(), "Erreur au créditage.");

            co.débiter(100);
            Assert.AreEqual(100, co.getSolde(), "Erreur au débitage.");
        }
    }
}
