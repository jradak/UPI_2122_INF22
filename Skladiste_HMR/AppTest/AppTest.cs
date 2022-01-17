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
        [TestMethod]
        public void ProvjeraCijene_ManjeOdJedan_False()
        {
            string cijena1 = " ";
            object p = Provjere.ProvjeraCijene(cijena1);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraCijene_UspjehTrue_True()
        {
            string cijena2 ="ab";
            object p = Provjere.ProvjeraCijene(cijena2);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraLozinke_KraceOdSedam_False()
        {
            string lozinka = "slova";
            object p = Provjere.ProvjeraLozinke(lozinka);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraKorImena_ManjeOdTri_False()
        {
            string imek = "Ed";
            object p = Provjere.ProvjeraKorImena(imek);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraKorImena_NekiZnakUppercase_False()
        {
            string imeko= "GLASNI";
            Object p = Provjere.ProvjeraKorImena(imeko);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraKorImena_NijeBrojIliSlovo_False()
        {
            string imekor = "GL@SNI";
            Object p = Provjere.ProvjeraKorImena(imekor);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraUnosa_ManjeOdTri_False()
        {
            string unos1 = "Si";
            object p = Provjere.ProvjeraUnosa(unos1);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraUnosa_PrvoJeSlovoLowercase_False()
        {
            string unos2 = "prijava";
            object p = Provjere.ProvjeraUnosa(unos2);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraUnosa_PrvoNijeSlovo_False()
        {
            string unos3 = "7UP";
            object p = Provjere.ProvjeraUnosa(unos3);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraUnosa_JeSlovoUpercase_False()
        {
            string unos4 = "ProvjerA";
            object p = Provjere.ProvjeraUnosa(unos4);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void ProvjeraUnosa_NijeSlovoUUnosu_False()
        {
            string unos5 = "Provj3ra";
            object p = Provjere.ProvjeraUnosa(unos5);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void KratkaProvjeraUnosa_DuzeOd50_False()
        {
            string unosK = "asdfghjklcasdghjklcasdfghjklcasdfghjklcaas";
            object p = Provjere.ProvjeraUnosa(unosK);
            Assert.AreEqual(p, false);
        }
        [TestMethod]
        public void KratkaProvjeraUnosa_KraceOdTri_False()
        {
            string unosKr = "as";
            object p = Provjere.ProvjeraUnosa(unosKr);
            Assert.AreEqual(p, false);
        }
    }
}
