using System;

namespace Skladiste_HMR
{
    static class Konstante
    {
        //string za spajanje na bazu
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Skladiste;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
    public static class Provjere
    {
        public static bool KratkaProvjeraUnosa(string unos)
        {
            if (unos.Length < 3 || unos.Length > 50)
            {
                return false;
            }
            return true;
        }
        public static bool ProvjeraUnosa(string unos)
        {
            if (unos.Length < 3)
            {
                return false;
            }
            if (!Char.IsLetter(unos, 0) || Char.IsLower(unos, 0))
            {
                return false;
            }
            for (int i = 1; i < unos.Length; i++)
            {
                if (!Char.IsLetter(unos, i) || Char.IsUpper(unos, i))
                {
                    return false;
                }
            }

            return true;
        }
        public static bool ProvjeraKorImena(string unos)
        {
            if (unos.Length < 3)
            {
                return false;
            }
            foreach (char znak in unos)
            {
                if (!Char.IsLetterOrDigit(znak) || Char.IsUpper(znak))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ProvjeraLozinke(string unos)
        {
            if (unos.Length < 7)
            {
                return false;
            }
            return true;
        }
        public static bool ProvjeraCijene(string cijena)
        {
            if (cijena.Length < 1)
            {
                return false;
            }
            double pomocna = 0;
            bool uspjeh = double.TryParse(cijena, out pomocna);
            if (!uspjeh)
            {
                return false;
            }
            return true;
        }
        public static bool ProvjeraKolicine(int kolicina)
        {
            if (kolicina <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
