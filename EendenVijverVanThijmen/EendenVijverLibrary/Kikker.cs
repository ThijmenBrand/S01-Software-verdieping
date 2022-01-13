namespace EendenVijverlibrary;

public class Kikker : IDier
{
    private geslacht geslacht;
    public geslacht Geslacht
    {
        get => geslacht;
        private set => geslacht = value;
    }

    public Kikker(geslacht geslacht)
    {
        this.Geslacht = geslacht;
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + Geslacht.ToString();
    }
}
