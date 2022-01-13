namespace EendenVijverForms;

public class Kikker : IDier
{
    public geslacht geslacht { get; private set; }

    public PictureBox Dierimage;

    private void makeKikker(PictureBox Kikker)
    {
        Random rnd = new Random();
        int KikkerHeight = 50;
        int KikkerWidth = 50;

        Kikker.Name = "Kikker";
        Kikker.Location = new Point(rnd.Next(0, 1549 - KikkerWidth), rnd.Next(0, 914 - KikkerHeight));
        Kikker.Size = new Size(KikkerWidth, KikkerHeight);
        Kikker.SizeMode = PictureBoxSizeMode.StretchImage;
        Kikker.ImageLocation = "C:/Users/Thijmen/Documents/software_verdieping/EendenVijverVanThijmen2/EendenVijverForms/img/Frog.png";
        Kikker.BackColor = Color.Transparent;
        Kikker.Click += (s, e) => { MessageBox.Show(VraagGeslacht()); };
    }

    public Kikker(geslacht geslacht, PictureBox Kikker)
    {
        this.geslacht = geslacht;
        this.Dierimage = Kikker;

        makeKikker(Kikker);
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + geslacht.ToString();
    }

    public void moveDier(int locationX, int locationY)
    {
        Dierimage.Top += locationX;
        Dierimage.Left += locationY;
    }

    public void veranderGeslacht()
    {
        Random rnd = new Random();

        int NewGaslacht = rnd.Next(0, 1);
        if (geslacht == geslacht.mannetje)
        {
            if (NewGaslacht == 0)
            {
                geslacht = geslacht.vrouwtje;
            }
            else
            {
                geslacht = geslacht.apacheAttachHelicopter;
            }
        }
        else if (geslacht == geslacht.vrouwtje)
        {
            if (NewGaslacht == 0)
            {
                geslacht = geslacht.apacheAttachHelicopter;
            }
            else
            {
                geslacht = geslacht.mannetje;
            }
        }
        else if (geslacht == geslacht.apacheAttachHelicopter)
        {
            if (NewGaslacht == 0)
            {
                geslacht = geslacht.mannetje;
            }
            else
            {
                geslacht = geslacht.vrouwtje;
            }
        }
    }
}
