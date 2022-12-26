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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.landscapeDesignDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Booking". При необходимости она может быть перемещена или удалена.
            this.bookingTableAdapter.Fill(this.landscapeDesignDataSet.Booking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.AccountingMaterial". При необходимости она может быть перемещена или удалена.
            this.accountingMaterialTableAdapter.Fill(this.landscapeDesignDataSet.AccountingMaterial);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            TerrainCreationWindow TerrainCreationWindowForm = new TerrainCreationWindow();
            TerrainCreationWindowForm.Show();
            TerrainCreationWindowForm.Hide();
        }
    }
}
