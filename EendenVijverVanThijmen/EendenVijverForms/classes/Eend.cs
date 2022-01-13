using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverForms;

public class Eend : IDier
{
    private geslacht geslacht;
    public PictureBox Dierimage;

    private void makeEend(PictureBox Eend)
    {
        Random rnd = new Random();
        int EendHeight = 50;
        int eendWidth = 50;

        Eend.Name = "Stork";
        Eend.Location = new Point(rnd.Next(0, 1549 - eendWidth), rnd.Next(0, 914 - EendHeight));
        Eend.Size = new Size(eendWidth, EendHeight);
        Eend.SizeMode = PictureBoxSizeMode.StretchImage;
        Eend.ImageLocation = "C:/Users/Thijmen/Documents/software_verdieping/EendenVijverVanThijmen2/EendenVijverForms/img/Duck.png";
        Eend.BackColor = Color.Transparent;

    }
    public Eend(geslacht geslacht, PictureBox EendImage)
    {
        this.geslacht = geslacht;
        this.Dierimage = EendImage;

        makeEend(EendImage);
    }

    public void moveDier(int locationX, int locationY)
    {
        Dierimage.Top += locationX;
        Dierimage.Left += locationY;
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + geslacht.ToString();
    }
}
