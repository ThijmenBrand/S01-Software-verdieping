using EendenVijverlibrary;


class Program
{
    static void Main(string[] args)
    {
        int aantalEenden = 26;
        Random random = new Random();
        List<dynamic> Vijver = new List<dynamic>();

        for(int i = 0; i <= aantalEenden; i++)
        {
            int geslachtCijfer = random.Next(0,3);
            if(geslachtCijfer == 0)
            {
                Vijver.Add(new Eend(geslacht.mannetje));
            } else if (geslachtCijfer == 1)
            {
                Vijver.Add(new Eend(geslacht.vrouwtje));
            } else
            {
                Vijver.Add(new Eend(geslacht.nonbinair));
            }
        }
    }
}