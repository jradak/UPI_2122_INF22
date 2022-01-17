using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Skladiste_HMR;


namespace AppTest
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void ProvjeraKolicine_ispodNula_False()
        {
            int kolicina = -1;
            object p = Provjere.ProvjeraKolicine(kolicina);
            Assert.AreEqual(p, false);            
        }
    }
}
