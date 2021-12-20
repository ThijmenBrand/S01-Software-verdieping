namespace Autodagwaarde
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            List<Auto> autos = new List<Auto>();
            Auto auto1 = new Auto("ABC-1-1", BrandstofSoort.electrische);
            Auto auto2 = new Auto("CBA-23-6", BrandstofSoort.LPG);
            Auto auto3 = new Auto("wrv-h-1", BrandstofSoort.diesel);
            Auto auto4 = new Auto("APF-5-d", BrandstofSoort.benzine);
            autos.Add(auto1);
            autos.Add(auto2);
            autos.Add(auto3);
            autos.Add(auto4);

            for(int i = 0; i < autos.Count; i++)
            {
                Console.WriteLine(autos[i].ToString());
                autos[i].rijdKilometers(random.Next(1000, 2000));
                Console.WriteLine(autos[i].ToString());
            }


        }
    }
}