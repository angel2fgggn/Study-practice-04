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
    public partial class SeeBookingDesigner : Form
    {
        public SeeBookingDesigner()
        {
            InitializeComponent();
        }

        private void SeeBooking_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.DevelopmentStage". При необходимости она может быть перемещена или удалена.
            this.developmentStageTableAdapter.Fill(this.landscapeDesignDataSet.DevelopmentStage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.InformationCustomer". При необходимости она может быть перемещена или удалена.
            this.informationCustomerTableAdapter.Fill(this.landscapeDesignDataSet.InformationCustomer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Booking". При необходимости она может быть перемещена или удалена.
            this.bookingTableAdapter.Fill(this.landscapeDesignDataSet.Booking);

        }

       

        private void buttonBack_Click(object sender, EventArgs e)
        {
            WelcomeWindowDesigner WelcomeWindowDesignerForm = new WelcomeWindowDesigner();
            WelcomeWindowDesignerForm.Show();
            this.Hide();
        }
    }
}
