namespace EendenVijverlibrary;

public class Eend : IDier
{
    private geslacht geslacht;
    public geslacht Geslacht
    {
        get => geslacht;
        private set => geslacht = value;
    }

    public Eend(geslacht geslacht)
    {
        this.Geslacht = geslacht;
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + Geslacht.ToString();
    }
}
