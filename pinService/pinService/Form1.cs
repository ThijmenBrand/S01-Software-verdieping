namespace pinService
{
    public partial class Form1 : Form
    {
        string inputCode = "";
        int maxLength = 5;
        public Form1()
        {
            InitializeComponent();
        }

        void showOutput(string output)
        {
            output_box.Text = output;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 1.ToString();
            showOutput(inputCode);
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 2.ToString();
            showOutput(inputCode);
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 3.ToString();
            showOutput(inputCode);
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 4.ToString();
            showOutput(inputCode);
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 5.ToString();
            showOutput(inputCode);
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 6.ToString();
            showOutput(inputCode);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 7.ToString();
            showOutput(inputCode);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 8.ToString();
            showOutput(inputCode);
        }

        private void nein_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 9.ToString();
            showOutput(inputCode);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (inputCode.Length < maxLength) inputCode += 0.ToString();
            showOutput(inputCode);
        }

        private void OK_button_Click(object sender, EventArgs e)
        {

        }

        private void CALCEL_button_Click(object sender, EventArgs e)
        {

        }
    }
}