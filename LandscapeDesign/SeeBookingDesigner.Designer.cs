namespace LandscapeDesign
{
    partial class SeeBookingDesigner
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInformationCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.informationCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.landscapeDesignDataSet = new LandscapeDesign.LandscapeDesignDataSet();
            this.idDevelopmentStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.developmentStageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoOfTheLayoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.BookingTableAdapter();
            this.buttonChangeDevelopStage = new System.Windows.Forms.Button();
            this.informationCustomerTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter();
            this.developmentStageTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.DevelopmentStageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentStageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Brown;
            this.buttonBack.Location = new System.Drawing.Point(6, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBookingDataGridViewTextBoxColumn,
            this.idInformationCustomerDataGridViewTextBoxColumn,
            this.idDevelopmentStageDataGridViewTextBoxColumn,
            this.orderDescriptionDataGridViewTextBoxColumn,
            this.photoOfTheLayoutDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 326);
            this.dataGridView1.TabIndex = 13;
            // 
            // idBookingDataGridViewTextBoxColumn
            // 
            this.idBookingDataGridViewTextBoxColumn.DataPropertyName = "id_Booking";
            this.idBookingDataGridViewTextBoxColumn.HeaderText = "id_Booking";
            this.idBookingDataGridViewTextBoxColumn.Name = "idBookingDataGridViewTextBoxColumn";
            this.idBookingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idInformationCustomerDataGridViewTextBoxColumn
            // 
            this.idInformationCustomerDataGridViewTextBoxColumn.DataPropertyName = "id_InformationCustomer";
            this.idInformationCustomerDataGridViewTextBoxColumn.DataSource = this.informationCustomerBindingSource;
            this.idInformationCustomerDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.idInformationCustomerDataGridViewTextBoxColumn.HeaderText = "id_InformationCustomer";
            this.idInformationCustomerDataGridViewTextBoxColumn.Name = "idInformationCustomerDataGridViewTextBoxColumn";
            this.idInformationCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInformationCustomerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idInformationCustomerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idInformationCustomerDataGridViewTextBoxColumn.ValueMember = "id_InformationCustomer";
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
            // idDevelopmentStageDataGridViewTextBoxColumn
            // 
            this.idDevelopmentStageDataGridViewTextBoxColumn.DataPropertyName = "id_DevelopmentStage";
            this.idDevelopmentStageDataGridViewTextBoxColumn.DataSource = this.developmentStageBindingSource;
            this.idDevelopmentStageDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.idDevelopmentStageDataGridViewTextBoxColumn.HeaderText = "id_DevelopmentStage";
            this.idDevelopmentStageDataGridViewTextBoxColumn.Name = "idDevelopmentStageDataGridViewTextBoxColumn";
            this.idDevelopmentStageDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDevelopmentStageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDevelopmentStageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idDevelopmentStageDataGridViewTextBoxColumn.ValueMember = "id_DevelopmentStage";
            // 
            // developmentStageBindingSource
            // 
            this.developmentStageBindingSource.DataMember = "DevelopmentStage";
            this.developmentStageBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // orderDescriptionDataGridViewTextBoxColumn
            // 
            this.orderDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OrderDescription";
            this.orderDescriptionDataGridViewTextBoxColumn.HeaderText = "OrderDescription";
            this.orderDescriptionDataGridViewTextBoxColumn.Name = "orderDescriptionDataGridViewTextBoxColumn";
            this.orderDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoOfTheLayoutDataGridViewTextBoxColumn
            // 
            this.photoOfTheLayoutDataGridViewTextBoxColumn.DataPropertyName = "PhotoOfTheLayout";
            this.photoOfTheLayoutDataGridViewTextBoxColumn.HeaderText = "PhotoOfTheLayout";
            this.photoOfTheLayoutDataGridViewTextBoxColumn.Name = "photoOfTheLayoutDataGridViewTextBoxColumn";
            this.photoOfTheLayoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // buttonChangeDevelopStage
            // 
            this.buttonChangeDevelopStage.BackColor = System.Drawing.Color.White;
            this.buttonChangeDevelopStage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeDevelopStage.ForeColor = System.Drawing.Color.Brown;
            this.buttonChangeDevelopStage.Location = new System.Drawing.Point(619, 7);
            this.buttonChangeDevelopStage.Name = "buttonChangeDevelopStage";
            this.buttonChangeDevelopStage.Size = new System.Drawing.Size(195, 23);
            this.buttonChangeDevelopStage.TabIndex = 14;
            this.buttonChangeDevelopStage.Text = "Изменить стадию разработки ";
            this.buttonChangeDevelopStage.UseVisualStyleBackColor = false;
            // 
            // informationCustomerTableAdapter
            // 
            this.informationCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // developmentStageTableAdapter
            // 
            this.developmentStageTableAdapter.ClearBeforeFill = true;
            // 
            // SeeBookingDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 400);
            this.Controls.Add(this.buttonChangeDevelopStage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeBookingDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeeBooking";
            this.Load += new System.EventHandler(this.SeeBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developmentStageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LandscapeDesignDataSet landscapeDesignDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private LandscapeDesignDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.Button buttonChangeDevelopStage;
        private System.Windows.Forms.BindingSource informationCustomerBindingSource;
        private LandscapeDesignDataSetTableAdapters.InformationCustomerTableAdapter informationCustomerTableAdapter;
        private System.Windows.Forms.BindingSource developmentStageBindingSource;
        private LandscapeDesignDataSetTableAdapters.DevelopmentStageTableAdapter developmentStageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idInformationCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idDevelopmentStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoOfTheLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
    }
}