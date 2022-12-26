namespace LandscapeDesign
{
    partial class LayoutCharacteristics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreate2 = new System.Windows.Forms.Button();
            this.textBoxNameMaket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNameCus = new System.Windows.Forms.ComboBox();
            this.informationCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.landscapeDesignDataSet = new LandscapeDesign.LandscapeDesignDataSet();
            this.informationCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationCustomerTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter();
            this.labelError = new System.Windows.Forms.Label();
            this.informationCustomerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(108, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длина";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(267, 50);
            this.width.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(155, 22);
            this.width.TabIndex = 6;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(267, 89);
            this.length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(155, 22);
            this.length.TabIndex = 7;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.White;
            this.buttonCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCreate.Location = new System.Drawing.Point(155, 169);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(220, 30);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCreate2
            // 
            this.buttonCreate2.BackColor = System.Drawing.Color.White;
            this.buttonCreate2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate2.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCreate2.Location = new System.Drawing.Point(128, 206);
            this.buttonCreate2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate2.Name = "buttonCreate2";
            this.buttonCreate2.Size = new System.Drawing.Size(285, 30);
            this.buttonCreate2.TabIndex = 9;
            this.buttonCreate2.Text = "Создать стандартное полотно";
            this.buttonCreate2.UseVisualStyleBackColor = false;
            this.buttonCreate2.Click += new System.EventHandler(this.buttonCreate2_Click);
            // 
            // textBoxNameMaket
            // 
            this.textBoxNameMaket.Location = new System.Drawing.Point(267, 17);
            this.textBoxNameMaket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameMaket.Name = "textBoxNameMaket";
            this.textBoxNameMaket.Size = new System.Drawing.Size(155, 22);
            this.textBoxNameMaket.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название макета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(108, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Заказ для";
            // 
            // comboBoxNameCus
            // 
            this.comboBoxNameCus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.informationCustomerBindingSource1, "id_InformationCustomer", true));
            this.comboBoxNameCus.DataSource = this.informationCustomerBindingSource;
            this.comboBoxNameCus.DisplayMember = "LastName";
            this.comboBoxNameCus.FormattingEnabled = true;
            this.comboBoxNameCus.Location = new System.Drawing.Point(267, 122);
            this.comboBoxNameCus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNameCus.Name = "comboBoxNameCus";
            this.comboBoxNameCus.Size = new System.Drawing.Size(155, 24);
            this.comboBoxNameCus.TabIndex = 13;
            this.comboBoxNameCus.ValueMember = "id_InformationCustomer";
            // 
            // informationCustomerBindingSource1
            // 
            this.informationCustomerBindingSource1.DataMember = "InformationCustomer";
            this.informationCustomerBindingSource1.DataSource = this.landscapeDesignDataSet;
            // 
            // landscapeDesignDataSet
            // 
            this.landscapeDesignDataSet.DataSetName = "LandscapeDesignDataSet";
            this.landscapeDesignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationCustomerBindingSource
            // 
            this.informationCustomerBindingSource.DataMember = "InformationCustomer";
            this.informationCustomerBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // informationCustomerTableAdapter
            // 
            this.informationCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.White;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(383, 177);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(127, 17);
            this.labelError.TabIndex = 16;
            this.labelError.Text = "Поля не заполнены";
            this.labelError.Visible = false;
            // 
            // informationCustomerBindingSource2
            // 
            this.informationCustomerBindingSource2.DataMember = "InformationCustomer";
            this.informationCustomerBindingSource2.DataSource = this.landscapeDesignDataSet;
            // 
            // LayoutCharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 242);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxNameCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNameMaket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreate2);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.length);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LayoutCharacteristics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание полотна";
            this.Load += new System.EventHandler(this.LayoutCharacteristics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreate2;
        private System.Windows.Forms.TextBox textBoxNameMaket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNameCus;
        private LandscapeDesignDataSet landscapeDesignDataSet;
        private System.Windows.Forms.BindingSource informationCustomerBindingSource;
        private LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter informationCustomerTableAdapter;
        private System.Windows.Forms.BindingSource informationCustomerBindingSource1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.BindingSource informationCustomerBindingSource2;
    }
}