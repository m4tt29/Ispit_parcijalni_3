using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return $"Moguće je surfati na URL-u: {url}";
            }
            else
            {
                return "Neispravan URL";
            }
        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                return $"Moguće je zvati broj: {telefonski_broj}";
            }
            else
            {
                return "Neispravan telefonski broj";
            }
        }

        private bool ProvjeriAkoJeValidanUrl(string url)
        {
            foreach (char znak in url)
            {
                if (char.IsDigit(znak))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            foreach (char znak in telefonski_broj)
            {
                if (!char.IsDigit(znak))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
