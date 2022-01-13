namespace EendenVijverForms
{
    public partial class EendenVijver : Form
    {
        bool left, right, up, down;
        public List<dynamic> LevendeDieren = new List<dynamic>();
        public List<dynamic> DodeDieren = new List<dynamic>();
        private Ooievaar Stork;
        Random rnd = new Random();

        public EendenVijver()
        {
            InitializeComponent();
        }

        private void EendenVijver_Load(object sender, EventArgs e)
        {
            Stork = new Ooievaar(RandomGeslacht(), makeStork(), OoievaarMaag);
            Stork.OoievaarImage.Click += (s, e) => { MessageBox.Show(Stork.VraagGeslacht()+"\n"+Stork.ToString()); };
            int aantalKikkers = rnd.Next(10, 20);
            int aantalEenden = 26;

            for (int i = 0; i < aantalKikkers; i++)
            {
                LevendeDieren.Add(new Kikker(RandomGeslacht(), makeKikker()));
            }

            for (int i = 0; i < aantalEenden; i++)
            {
                LevendeDieren.Add(new Eend(RandomGeslacht(), makeEend()));
            }

            maagTimer.Stop();
            maagInhoud.BringToFront();
        }
        #region Timers
        private void AnimalTickSpeed(object sender, EventArgs e)
        {
            //Check colisions
            CheckIfToilet();
            KikkerColision();

        }

        private void DierMovement(object sender, EventArgs e)
        {
            //Kikker Movement
            foreach (dynamic k in LevendeDieren)
            {
                if (k.GetType() == typeof(Kikker))
                {
                    randomGeslachtVerandering(k);

                }
                if (k.Dierimage.Top <= 0)
                {
                    k.moveDier(rnd.Next(0, 10), rnd.Next(-10, 10));
                }
                else if (k.Dierimage.Left <= 0)
                {
                    k.moveDier(rnd.Next(-10, 10), rnd.Next(0, 10));
                }
                else if (k.Dierimage.Top >= Height - k.Dierimage.Height)
                {
                    k.moveDier(rnd.Next(-10, 0), rnd.Next(-10, 10));
                }
                else if (k.Dierimage.Left >= Width - k.Dierimage.Width)
                {
                    k.moveDier(rnd.Next(-10, 10), rnd.Next(-10, 0));
                }
                else
                {
                    k.moveDier(rnd.Next(-10, 10), rnd.Next(-10, 10));
                }

            }
        }

        private void OoievaarMovement(object sender, EventArgs e)
        {
            //Ooievaar movement
            if (Stork.OoievaarImage.Left > 0)
            {
                Stork.moveOoievaar(left, right, up, down);
            }
            if (Stork.OoievaarImage.Left < Width - Stork.OoievaarImage.Width)
            {
                Stork.moveOoievaar(left, right, up, down);
            }
            if (Stork.OoievaarImage.Top < Height - Stork.OoievaarImage.Height)
            {
                Stork.moveOoievaar(left, right, up, down);
            }
            if (Stork.OoievaarImage.Top > 0)
            {
                Stork.moveOoievaar(left, right, up, down);
            }
        }

        //Tijd om maag te legen 
        private void maagtimer(object sender, EventArgs e)
        {
            Stork.verteer();
            MessageValue.Text = "";
        }

        #endregion

        #region AnimalMakers
        private PictureBox makeKikker()
        {
            PictureBox Kikker = new PictureBox();

            Controls.Add(Kikker);

            return Kikker;
        }

        private PictureBox makeStork()
        {
            PictureBox Strok = new PictureBox();

            Controls.Add(Strok);

            return Strok;
        }

        private PictureBox makeEend()
        {
            PictureBox Eend = new PictureBox();

            Controls.Add(Eend);

            return Eend;
        }
        #endregion


        #region HelperFunctions
        private geslacht RandomGeslacht()
        {
            string[] values = System.Enum.GetNames(typeof(geslacht));
            string randomGeslacht = values[rnd.Next(values.Length)];
            geslacht Geslacht = (geslacht)Enum.Parse(typeof(geslacht), randomGeslacht);

            return Geslacht;
        }
        #endregion


        #region ColisionDetection
        private void CheckIfToilet()
        {
            if (Stork.OoievaarImage.Bounds.Left >= StorkToilet.Bounds.Left && Stork.OoievaarImage.Bounds.Bottom <= StorkToilet.Bounds.Bottom)
            {
                maagTimer.Start();
            }
            else
            {
                maagTimer.Stop();
            }
        }

        public void KikkerColision()
        {
            foreach (dynamic k in LevendeDieren)
            {
                if (k.GetType() == typeof(Kikker))
                {
                    if (k.Dierimage.Bounds.IntersectsWith(Stork.OoievaarImage.Bounds))
                    {
                        int kikkerEet = Stork.eetKikker(k);
                        if (kikkerEet == 0)
                        {
                            k.Dierimage.Size = Size.Empty;
                            LevendeDieren.Remove(k);
                            DodeDieren.Add(k);
                            return;
                        }
                        else if (kikkerEet == 1)
                        {
                            MessageValue.Text = "Ik zit vol!";
                        }
                    }
                }
            }
        }
        #endregion


        private void randomGeslachtVerandering(Kikker k)
        {
            if (rnd.Next(0, 10) >= 9)
            {
                k.veranderGeslacht();
            }
        }











        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
        }
    }
}