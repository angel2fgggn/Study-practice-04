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
    public partial class WelcomeWindowDesigner : Form
    {
        public WelcomeWindowDesigner()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            LayoutCharacteristics LayoutCharacteristicsForm = new LayoutCharacteristics();
            LayoutCharacteristicsForm.Show();
        }

        private void buttonSeeBooking_Click(object sender, EventArgs e)
        {
            SeeBookingDesigner SeeBookingForm = new SeeBookingDesigner();
            SeeBookingForm.Show();
            this.Hide();
        }
    }
}
