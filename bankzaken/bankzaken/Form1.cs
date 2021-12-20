namespace bankzaken
{
    public partial class bankzakenForm : Form
    {
        private Bankrekening bankRekeningLinks;
        private Bankrekening bankRekeningRechts;

        public bankzakenForm()
        {
            InitializeComponent();
            bankRekeningLinks = new Bankrekening("Dagobert duck");
            bankRekeningRechts = new Bankrekening("Gijs gans");
            balanceBox1.Text = bankRekeningLinks.Saldo.ToString();
            balanceBox2.Text = bankRekeningRechts.Saldo.ToString();
        }

        private void perfAction1_Click(object sender, EventArgs e)
        {
            string input = bedrag1.Text;
            int bedrag;
            if (Stort1.Checked)
            {
                if(int.TryParse(input, out bedrag))
                {
                    bankRekeningLinks.Stort(bedrag);
                } else
                {
                    MessageBox.Show("Please insert a valid number!");
                }
            } else if (neemop1.Checked)
            {
                if(int.TryParse(input, out bedrag))
                {
                    if(!bankRekeningLinks.NeemOp(bedrag))
                    {
                        MessageBox.Show("You do not have enough balance to perform this action");
                    }
                }
            } else if (schrijfOver1.Checked)
            {
                if(int.TryParse(input, out bedrag))
                {
                    if(!bankRekeningLinks.maakOver(bankRekeningRechts, bedrag))
                    {
                        MessageBox.Show("You do not have enough balance to perform this action");
                    }
                }
            }
            showBalance(1);
            showBalance(2);
            bedrag1.ResetText();
        }

        private void showBalance(int rekening)
        {
            if(rekening == 1)
            {
                balanceBox1.Text = bankRekeningLinks.Saldo.ToString();
            } else
            {
                balanceBox2.Text = bankRekeningRechts.Saldo.ToString();
            }
        }

        private void Stort1_CheckedChanged(object sender, EventArgs e)
        {
            perfAction1.Text = "Stort";
        }

        private void neemop1_CheckedChanged(object sender, EventArgs e)
        {
            perfAction1.Text = "Neem op";
        }

        private void schrijfOver1_CheckedChanged(object sender, EventArgs e)
        {
            perfAction1.Text = "Schrijf";
        }

        private void perfAction2_Click(object sender, EventArgs e)
        {
            string input = bedrag2.Text;
            int bedrag;
            if (stort2.Checked)
            {
                if (int.TryParse(input, out bedrag))
                {
                    bankRekeningRechts.Stort(bedrag);
                }
                else
                {
                    MessageBox.Show("Please insert a valid number!");
                }
            }
            else if (neemop2.Checked)
            {
                if (int.TryParse(input, out bedrag))
                {
                    if (!bankRekeningRechts.NeemOp(bedrag))
                    {
                        MessageBox.Show("You do not have enough balance to perform this action");
                    }
                }
            }
            else if (schrijfOver2.Checked)
            {
                if (int.TryParse(input, out bedrag))
                {
                    if (!bankRekeningRechts.maakOver(bankRekeningLinks, bedrag))
                    {
                        MessageBox.Show("You do not have enough balance to perform this action");
                    }
                }
            }
            showBalance(2);
            showBalance(1);
            bedrag2.ResetText();
        }

        private void stort2_CheckedChanged(object sender, EventArgs e)
        {
            perfAction2.Text = "Stort";
        }

        private void neemop2_CheckedChanged(object sender, EventArgs e)
        {
            perfAction2.Text = "Neem";
        }

        private void schrijfOver2_CheckedChanged(object sender, EventArgs e)
        {
            perfAction2.Text = "schrijf";
        }
    }
}