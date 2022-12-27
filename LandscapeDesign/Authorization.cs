using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        public string Login
        {
            get { return textBoxUsername.Text; }
            set { textBoxUsername.Text = value; }
        }
        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            int logg = 0;
        

            var textLogin = textBoxUsername.Text;
            var textPassword = textBoxPassword.Text;



            textBoxUsername.Text = textLogin;
            textBoxPassword.Text = textPassword;


            textBoxUsername.SelectionStart = textBoxUsername.Text.Length;
            textBoxPassword.SelectionStart = textBoxPassword.Text.Length;

           
            SqlDataReader Username;
            SqlDataReader Password;
            SqlConnection conn = new SqlConnection("Data Source=it224-8;Initial Catalog=LandscapeDesign;Integrated Security=True");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"Select Login, Password from Users where Login = '{textLogin}' and Password = '{textPassword}'";
            SqlCommand command = new SqlCommand(query, conn);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            SqlCommand cmd = new SqlCommand("select * from Users where Login = @username", conn);
            SqlCommand cmd1 = new SqlCommand("select * from Users where Password= @password", conn);
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmd1.Parameters.AddWithValue("@password", textBoxPassword.Text);

            //поиск пользователя
            usersBindingSource.Filter = string.Format("Login LIKE '{0}%'", textBoxUsername.Text);
            //вынос из таблицы данные о фамилии пользлователя
            for (int i = 0; i < dataGridViewUser.RowCount; i++)
            {
                labelNameText.Text = Convert.ToString(dataGridViewUser.Rows[i].Cells[1].EditedFormattedValue);
            }
            //вынос из таблицы данные о роли пользлователя
            for (int i = 0; i < dataGridViewUser.RowCount; i++)
            {
                labelRoleText.Text = Convert.ToString(dataGridViewUser.Rows[i].Cells[4].EditedFormattedValue);
            }

            Username = cmd.ExecuteReader();
            if (Username != null && Username.HasRows)
            {
                labelErrorLog.Visible = false;
                logg++;
            }
            else
            {
                labelErrorLog.Visible = true;
            }
            Username.Close();


            Password = cmd1.ExecuteReader();


            if (Password != null && Password.HasRows)
            {
                labelErrorPassword.Visible = false;
            }
            else
            {
                labelErrorPassword.Visible = true;

            }
            if (logg == 1 && Password != null && Password.HasRows)
            {
                if (table.Rows.Count == 1)
                {
                    if(labelRoleText.Text == "User")
                    {
                        WelcomeWindowUser WelcomeWindowUserForm = new WelcomeWindowUser();
                        WelcomeWindowUserForm.labelName.Text = labelNameText.Text + " !";
                        WelcomeWindowUserForm.Show();
                        Hide();
                    }
                    else if(labelRoleText.Text == "Designer")
                    {
                        WelcomeWindowDesigner WelcomeWindowDesignerForm = new WelcomeWindowDesigner();
                        WelcomeWindowDesignerForm.Show();
                        Hide();
                    }
                    
                }
                conn.Close();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.InformationCustomer". При необходимости она может быть перемещена или удалена.
            this.informationCustomerTableAdapter.Fill(this.landscapeDesignDataSet.InformationCustomer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.landscapeDesignDataSet.Users);

        }

     
    }
}
