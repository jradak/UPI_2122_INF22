using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste_HMR
{
    class Korisnik
    {
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private string uloga;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Uloga { get => uloga; set => uloga = value; }

        public Korisnik(string i, string p, string ki, string l, string u)
        {
            this.Ime = i;
            this.Prezime = p;
            this.KorisnickoIme = ki;
            this.Lozinka = l;
            this.Uloga = u;
        }
    }
}
