namespace dinoGame
{
    public partial class poc_movement : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 5;

        public poc_movement()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void poc_movement_Load(object sender, EventArgs e)
        {

        }

        private void movement(object sender, EventArgs e)
        {
            if (moveLeft && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= speed;
            }
            if(moveRight && pictureBox1.Left < 822-pictureBox1.Width)
            {
                pictureBox1.Left += speed;
            }
            if(moveDown && pictureBox1.Top < 506-pictureBox1.Height)
            {
                pictureBox1.Top += speed;
            }
            if(moveUp && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= speed;
            }

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                moveUp = true;
            }
            if(e.KeyCode==Keys.Down || e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
        }
    }
}
