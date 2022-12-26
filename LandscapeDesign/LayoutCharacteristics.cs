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
    public partial class LayoutCharacteristics : Form
    {
        public LayoutCharacteristics()
        {
            InitializeComponent();
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxNameMaket.Text!="" && length.Text !="" && width.Text!="")
            {
                TerrainCreationWindow TerrainCreationWindowForm = new TerrainCreationWindow();
                TerrainCreationWindowForm.labelWidht.Text = width.Text;
                TerrainCreationWindowForm.labelHeight.Text = length.Text;
                TerrainCreationWindowForm.labelnamec.Text = comboBoxNameCus.Text;
                TerrainCreationWindowForm.labelTitle.Text = textBoxNameMaket.Text;
                TerrainCreationWindowForm.Show();

                foreach (Form f in Application.OpenForms)
                    // спрячем все формы кроме основной
                    if (f.GetType() != typeof(TerrainCreationWindow))
                        f.Hide();
            }
            else 
            {
                labelError.Visible = true;

            }
            

           
        }



        private void buttonCreate2_Click(object sender, EventArgs e)
        {
            TerrainCreationWindow TerrainCreationWindowForm = new TerrainCreationWindow();
            TerrainCreationWindowForm.labelWidht.Text = Convert.ToString(847);
            TerrainCreationWindowForm.labelHeight.Text = Convert.ToString(609);
            TerrainCreationWindowForm.Show();

            foreach (Form f in Application.OpenForms)
                // спрячем все формы кроме основной
                if (f.GetType() != typeof(TerrainCreationWindow))
                    f.Hide();
        }

        private void LayoutCharacteristics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.InformationCustomer". При необходимости она может быть перемещена или удалена.
            this.informationCustomerTableAdapter.Fill(this.landscapeDesignDataSet.InformationCustomer);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.InformationCustomer". При необходимости она может быть перемещена или удалена.
            this.informationCustomerTableAdapter.Fill(this.landscapeDesignDataSet.InformationCustomer);
         
        }

  
    }
}
