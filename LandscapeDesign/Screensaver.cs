using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign
{
    public partial class Screensaver : Form
    {
        public Screensaver()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.025;
            if (this.Opacity == 0)
            {
                this.timer1.Enabled = false;
                Authorization AuthorizationForm = new Authorization();
                this.Hide();
                AuthorizationForm.Show();

            }
        }
    }
}
