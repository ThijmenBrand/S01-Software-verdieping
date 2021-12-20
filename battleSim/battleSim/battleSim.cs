namespace battleSim
{
    public partial class battleSim : Form
    {
        int knight_sim = 0;
        Random random = new Random();
        speler knightPlayer = new speler("harry", 100);
        speler monsterPlayer = new speler("frank", 100);
        String baseText = "HP: ";
        public battleSim()
        {
            InitializeComponent();
            resetGame();
        }

        private void resetGame()
        {
            knightPlayer.revive();
            monsterPlayer.revive();

            knight_sim = random.Next(0, 2);
            if (knight_sim % 2 == 0)
            {
                monsterAttack.Visible = false;
            }
            else
            {
                knightAttack.Visible = true;
            }
            knightHp.Text = baseText + knightPlayer.hitpoints;
            monsterHp.Text = baseText + monsterPlayer.hitpoints;
        }

        private void playGame()
        {
            string message;
            if (knight_sim % 2 == 0)
            {
                monsterAttack.Visible = false;
                knightAttack.Visible = true;
                message = knightPlayer.dealDamage(monsterPlayer);
                knightHp.Text = knightPlayer.hitpoints.ToString();
                if (message == "died")
                {
                    return;
                }
            }
            else
            {
                monsterAttack.Visible = true;
                knightAttack.Visible = false;
                message = knightPlayer.dealDamage(knightPlayer);
                monsterHp.Text = monsterPlayer.hitpoints.ToString();
                if (message == "died")
                {
                    return;
                }

            }
            hitlabel.Text = message;
            if (knightPlayer.Died || monsterPlayer.Died)
            {
                DialogResult dialogResult = MessageBox.Show(knightPlayer.Died ? knightPlayer.naam + " Lost!" : monsterPlayer.naam + " Lost!", "Do you want to play again?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
            }
        }

        private void knightAttack_Click(object sender, EventArgs e)
        {
            knight_sim++;
            playGame();
        }

        private void monsterAttack_Click(object sender, EventArgs e)
        {
            knight_sim++;
            playGame();
        }

        private void battleSim_Load(object sender, EventArgs e)
        {

        }
    }
}
