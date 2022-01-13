namespace EendenVijverlibrary;

public class Ooievaar : IDier
{
    private geslacht geslacht;
    public geslacht Geslacht
    {
        get => geslacht;
        private set => geslacht = value;
    }
    private List<Kikker> maag = new List<Kikker>();


    public Ooievaar(geslacht geslacht)
    {
        this.Geslacht = geslacht;
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + Geslacht.ToString();
    }

    public bool eetKikker(Kikker kikker)
    {
        if (kikker.Geslacht == Geslacht)
        {
            maag.Add(kikker);
            return true;
        }
        return false;
    }
}
