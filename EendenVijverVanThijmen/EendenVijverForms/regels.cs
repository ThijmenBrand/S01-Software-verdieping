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
    public partial class regels : Form
    {
        public regels()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StartScherm startscherm = new StartScherm();
            startscherm.Show();
            Hide();
        }
    }
}
