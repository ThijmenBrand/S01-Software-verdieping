using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinoGame
{

    public partial class dinogame : Form
    {
        bool red, green = false;
        int counter = 0;
        bool left, right, up, down = false;
        bord green_bord;
        bord red_bord;
        public dinogame()
        {
            InitializeComponent();
            green_bord = new bord(106, 296, green_dino_picture, green_dino_box.Width, green_dino_box.Height, munt);
            red_bord = new bord(106, 296, red_dino_picture, red_dino_box.Width, red_dino_box.Height, munt);
            this.KeyPreview = true;
            red_bord.spawnMunt();
        }

        private void movement(object sender, EventArgs e)
        {
            if(red)
            {
                red_bord.moveDino(left,right,up,down,red_dino_picture);
            } else if(green)
            {
                green_bord.moveDino(left, right, up, down,green_dino_picture);
            }
            if(red_bord.botsing() || green_bord.botsing())
            {
                counter++;
                Score.Text = counter.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void activate_red_Click(object sender, EventArgs e)
        {
            red = true;
            green = false;
        }

        private void activate_green_Click(object sender, EventArgs e)
        {
            red = false;
            green = true;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                up = true;
            }
            if(e.KeyCode == Keys.S)
            {
                down = true;
            }
            if(e.KeyCode == Keys.D)
            {
                right = true;
            }
            if(e.KeyCode == Keys.A)
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
