namespace EendenVijverlibrary;
internal interface IDier
{
    geslacht Geslacht
    {
        get => Geslacht;
        private set => Geslacht = value;
    }

    public string VraagGeslacht();
}
