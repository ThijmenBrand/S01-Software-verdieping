using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankzaken
{
    internal class Bankrekening
    {
        private int rekeningnummer;
        private string naam;
        private int saldo;
        public int Saldo
        { get { return saldo; } }
        private static int volgendeVrijeRekeningnummer = 2001;


        public Bankrekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;
            volgendeVrijeRekeningnummer++;
        }



        public bool NeemOp(int bedrag)
        {
            if(bedrag > saldo)
            {
                return false;
            }
            saldo -= bedrag;
            return true;
        }

        public void Stort(int bedrag)
        {
            saldo += bedrag;
        }

        public bool maakOver(Bankrekening andereRekening, int bedrag)
        {
            if(bedrag > saldo)
            {
                return false;
            }
            saldo -= bedrag;
            andereRekening.Stort(bedrag);
            return true;
        }
    }
}
