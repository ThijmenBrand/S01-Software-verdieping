public class bankRekening
{
    public bankRekening()
    {

        private int rekeningnummer;
    private string naam;
    private int saldo;
    private static int volgendeVrijeRekeningnummer = 2001;

    public bankRekening(string naam)
    {
        this.naam = naam;
        saldo = 0;
        rekeningnummer = volgendeVrijeRekeningnummer;
        volgendeVrijeRekeningnummer++;
    }



    public void NeemOp(int bedrag)
    {

    }

    public void Stort(int bedrag)
    {

    }

    public void maakOver(bankRekening andereRekening, int bedrag)
    {

    }
}

}
