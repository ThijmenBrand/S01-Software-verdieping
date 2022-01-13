using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinoGame
{ 

    internal class bord
    {
        private int bord_width;
        private int bord_height;
        private int dino_location_x;
        private int dino_location_y;
        private int munt_location_x;
        private int munt_location_y;
        private int speed;
        private PictureBox dino;
        private PictureBox munt;
        private Random rand = new Random();

        public bord(int location_x, int location_y, PictureBox box, int bord_width, int bord_height, PictureBox munt)
        {
            this.dino_location_x = location_x;
            this.dino_location_y = location_y;
            this.bord_width = bord_width;
            this.bord_height = bord_height;
            this.munt = munt;
            dino = box;
            speed = 5;
        }

        public void moveDino(bool left, bool right, bool up, bool down, PictureBox box)
        {
            if (left && box.Left > 0)
            {
                dino_location_x -= speed;
                box.Left -= speed;
            }
            if (right && box.Left < bord_width - box.Width)
            {
                dino_location_x += speed;
                box.Left += speed;
            }
            if (down && box.Top < bord_height - box.Height)
            {
                dino_location_y += speed;
                box.Top += speed;
            }
            if (up && box.Top > 0)
            {
                dino_location_x -= speed;
                box.Top -= speed;
            }
        }

        public bool botsing()
        {
            if(dino.Bounds.IntersectsWith(munt.Bounds))
            {
                return true;
            }
            return false;
        }

        public void spawnMunt()
        {
            munt_location_x = rand.Next(0, bord_width);
            munt_location_y = rand.Next(0, bord_height);
            munt.Left = munt_location_x;
            munt.Top = munt_location_y;
        }
    }
}
