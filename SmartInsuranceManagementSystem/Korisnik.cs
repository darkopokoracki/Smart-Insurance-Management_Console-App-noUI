using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInsuranceManagementSystem
{
    internal class Korisnik
    {
        string ime;
        string prezime;
        string email;
        string lozinka;
        string tipKorisnika;

        public Korisnik(string ime, string prezime, string email, string lozinka, string tipKorisnika)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.lozinka = lozinka;
            this.tipKorisnika = tipKorisnika;
        }

        public override string ToString()
        {
            return $"{ime} {prezime} je {tipKorisnika}";
        }
    }
}
