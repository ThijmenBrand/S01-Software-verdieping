using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverForms;

public class Ooievaar : IDier
{
    private geslacht geslacht;

    public PictureBox OoievaarImage;

    public List<Kikker> maag = new List<Kikker>();
    private ProgressBar maagVol;
    private int maagInhoud = 5;
    private int gegetenKikkers = 0;

    private void MakeOoievaar(PictureBox Stork)
    {
        Stork.Name = "Stork";
        Stork.Location = new Point(400, 400);
        Stork.Size = new Size(80, 80);
        Stork.SizeMode = PictureBoxSizeMode.StretchImage;
        Stork.ImageLocation = "C:/Users/Thijmen/Documents/software_verdieping/EendenVijverVanThijmen2/EendenVijverForms/img/Stork.png";
        Stork.BackColor = Color.Transparent;
        Stork.BringToFront();
    }


    public Ooievaar(geslacht geslacht, PictureBox OoievaarPic, ProgressBar maag)
    {
        this.geslacht = geslacht;
        this.OoievaarImage = OoievaarPic;
        this.maagVol = maag;
        maagVol.Maximum = maagInhoud;
        maagVol.Minimum = 0;

        MakeOoievaar(OoievaarPic);
        maagVol.BringToFront();
    }

    public string VraagGeslacht()
    {
        return "Mijn geslacht is: " + geslacht.ToString();
    }

    public int eetKikker(Kikker kikker)
    {
        if (kikker.geslacht == this.geslacht && maag.Count < maagInhoud)
        {
            maag.Add(kikker);
            gegetenKikkers++;
            updateMaag();
            return 0;
        } else if (maag.Count >= maagInhoud)
        {
            return 1;
        }
        return 2;
    }

    private void updateMaag()
    {
            maagVol.Value = maag.Count;
    }

    public void verteer()
    {
        if(maag.Count > 0)
        {
            maag.RemoveAt(0);

        }
        updateMaag();
    }

    public void moveOoievaar(bool left, bool right, bool up, bool down)
    {
        int speed = 5;
        if (left)
        {
            OoievaarImage.Left -= speed;
        }
        if (right)
        {
            OoievaarImage.Left += speed;
        }
        if (down)
        {
            OoievaarImage.Top += speed;
        }
        if (up)
        {
            OoievaarImage.Top -= speed;
        }
    }

    public override string ToString()
    {
        string kikkerAnnotatie = gegetenKikkers > 1 ? "kikkers" : "kikkers";
        return gegetenKikkers > 0 ? "Ik heb " + gegetenKikkers.ToString() + " " + kikkerAnnotatie + " Gegeten!" : "Ik heb nog geen kikkers gegeten";
    }
}
