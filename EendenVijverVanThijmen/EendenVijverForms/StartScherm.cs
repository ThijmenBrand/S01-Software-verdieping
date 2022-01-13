using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EendenVijverForms
{
    public partial class StartScherm : Form
    {
        public StartScherm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            EendenVijver vijver = new EendenVijver();
            vijver.Show();
            Hide();
        }

        private void SpeelWijze_Click(object sender, EventArgs e)
        {
            regels regels = new regels();
            regels.Show();
            Hide();
        }
    }
}
