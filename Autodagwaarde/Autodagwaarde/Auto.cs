using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodagwaarde
{
    public enum BrandstofSoort
    {
        benzine = 100,
        diesel = 150,
        LPG = 90,
        electrische = 130
    }

    internal class Auto
    {
        public int Kilometerstand { get; private set; }
        private string kenteken;
        private BrandstofSoort brandstofsoort;
        public int dagwaarde;

        public Auto(string kenteken, BrandstofSoort brandstofsoort)
        {
            this.kenteken = kenteken;
            Kilometerstand = 1;
            this.brandstofsoort = brandstofsoort;
        }

        public bool rijdKilometers(int afstand)
        {
            if (afstand > 0)
            {
                Kilometerstand += afstand;
                return true;
            }
            else return false;
        }

        public int berekenDagwaarde()
        {
            return dagwaarde = 500000 / Kilometerstand * (int)brandstofsoort;
        }

        public override string ToString()
        {
            return kenteken + " " + brandstofsoort + " auto " + Kilometerstand + " km op de teller heeft een dagwaarde van " + berekenDagwaarde();
        }
    }
}
