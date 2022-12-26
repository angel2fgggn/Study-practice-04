namespace LandscapeDesign
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonVhod = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorLog = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.idUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInformationCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.informationCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.landscapeDesignDataSet = new LandscapeDesign.LandscapeDesignDataSet();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.UsersTableAdapter();
            this.labelNameText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informationCustomerTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter();
            this.labelRoleText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(180, 102);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(227, 44);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "Авторизация";
            // 
            // buttonVhod
            // 
            this.buttonVhod.BackColor = System.Drawing.Color.White;
            this.buttonVhod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVhod.ForeColor = System.Drawing.Color.Brown;
            this.buttonVhod.Location = new System.Drawing.Point(177, 361);
            this.buttonVhod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(236, 30);
            this.buttonVhod.TabIndex = 7;
            this.buttonVhod.Text = "Войти";
            this.buttonVhod.UseVisualStyleBackColor = false;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(144, 194);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 19);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(241, 192);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(183, 22);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(241, 244);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(183, 22);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Пароль";
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.BackColor = System.Drawing.Color.White;
            this.labelErrorPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(429, 231);
            this.labelErrorPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(166, 34);
            this.labelErrorPassword.TabIndex = 16;
            this.labelErrorPassword.Text = "Проверьте правильность \r\nпароля\r\n";
            this.labelErrorPassword.Visible = false;
            // 
            // labelErrorLog
            // 
            this.labelErrorLog.AutoSize = true;
            this.labelErrorLog.BackColor = System.Drawing.Color.White;
            this.labelErrorLog.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorLog.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLog.Location = new System.Drawing.Point(433, 180);
            this.labelErrorLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorLog.Name = "labelErrorLog";
            this.labelErrorLog.Size = new System.Drawing.Size(162, 34);
            this.labelErrorLog.TabIndex = 15;
            this.labelErrorLog.Text = "Проверьте правильность\r\nлогина";
            this.labelErrorLog.Visible = false;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsersDataGridViewTextBoxColumn,
            this.idInformationCustomerDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.usersBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(369, 15);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.Size = new System.Drawing.Size(13, 26);
            this.dataGridViewUser.TabIndex = 17;
            this.dataGridViewUser.Visible = false;
            // 
            // idUsersDataGridViewTextBoxColumn
            // 
            this.idUsersDataGridViewTextBoxColumn.DataPropertyName = "id_Users";
            this.idUsersDataGridViewTextBoxColumn.HeaderText = "id_Users";
            this.idUsersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsersDataGridViewTextBoxColumn.Name = "idUsersDataGridViewTextBoxColumn";
            this.idUsersDataGridViewTextBoxColumn.Width = 125;
            // 
            // idInformationCustomerDataGridViewTextBoxColumn
            // 
            this.idInformationCustomerDataGridViewTextBoxColumn.DataPropertyName = "id_InformationCustomer";
            this.idInformationCustomerDataGridViewTextBoxColumn.DataSource = this.informationCustomerBindingSource;
            this.idInformationCustomerDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.idInformationCustomerDataGridViewTextBoxColumn.HeaderText = "id_InformationCustomer";
            this.idInformationCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idInformationCustomerDataGridViewTextBoxColumn.Name = "idInformationCustomerDataGridViewTextBoxColumn";
            this.idInformationCustomerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idInformationCustomerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idInformationCustomerDataGridViewTextBoxColumn.ValueMember = "id_InformationCustomer";
            this.idInformationCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // informationCustomerBindingSource
            // 
            this.informationCustomerBindingSource.DataMember = "InformationCustomer";
            this.informationCustomerBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // landscapeDesignDataSet
            // 
            this.landscapeDesignDataSet.DataSetName = "LandscapeDesignDataSet";
            this.landscapeDesignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // labelNameText
            // 
            this.labelNameText.AutoSize = true;
            this.labelNameText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameText.Location = new System.Drawing.Point(391, 22);
            this.labelNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameText.Name = "labelNameText";
            this.labelNameText.Size = new System.Drawing.Size(69, 19);
            this.labelNameText.TabIndex = 18;
            this.labelNameText.Text = "lastname";
            this.labelNameText.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LandscapeDesign.Properties.Resources.log2;
            this.pictureBox1.Location = new System.Drawing.Point(231, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // informationCustomerTableAdapter
            // 
            this.informationCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // labelRoleText
            // 
            this.labelRoleText.AutoSize = true;
            this.labelRoleText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleText.Location = new System.Drawing.Point(391, 41);
            this.labelRoleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoleText.Name = "labelRoleText";
            this.labelRoleText.Size = new System.Drawing.Size(37, 19);
            this.labelRoleText.TabIndex = 19;
            this.labelRoleText.Text = "role";
            this.labelRoleText.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 505);
            this.Controls.Add(this.labelRoleText);
            this.Controls.Add(this.labelNameText);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.labelErrorLog);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonVhod);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonVhod;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorLog;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private LandscapeDesignDataSet landscapeDesignDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LandscapeDesignDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label labelNameText;
        private System.Windows.Forms.BindingSource informationCustomerBindingSource;
        private LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter informationCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idInformationCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelRoleText;
    }
}