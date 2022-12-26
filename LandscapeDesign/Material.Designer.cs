namespace LandscapeDesign
{
    partial class Material
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.landscapeDesignDataSet = new LandscapeDesign.LandscapeDesignDataSet();
            this.accountingMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingMaterialTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.AccountingMaterialTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.BookingTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new LandscapeDesign.LandscapeDesignDataSetTableAdapters.MaterialTableAdapter();
            this.idAccountingMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingMaterialBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccountingMaterialDataGridViewTextBoxColumn,
            this.idMaterialDataGridViewTextBoxColumn,
            this.idBookingDataGridViewTextBoxColumn,
            this.countMaterialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountingMaterialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(407, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // landscapeDesignDataSet
            // 
            this.landscapeDesignDataSet.DataSetName = "LandscapeDesignDataSet";
            this.landscapeDesignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingMaterialBindingSource
            // 
            this.accountingMaterialBindingSource.DataMember = "AccountingMaterial";
            this.accountingMaterialBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // accountingMaterialTableAdapter
            // 
            this.accountingMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Учет материала";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Материал";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialDataGridViewTextBoxColumn1,
            this.nameMaterialDataGridViewTextBoxColumn,
            this.priceMaterialDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.folderPathDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.materialBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(407, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(490, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Brown;
            this.buttonBack.Location = new System.Drawing.Point(11, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(103, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.landscapeDesignDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // idAccountingMaterialDataGridViewTextBoxColumn
            // 
            this.idAccountingMaterialDataGridViewTextBoxColumn.DataPropertyName = "id_AccountingMaterial";
            this.idAccountingMaterialDataGridViewTextBoxColumn.HeaderText = "id_AccountingMaterial";
            this.idAccountingMaterialDataGridViewTextBoxColumn.Name = "idAccountingMaterialDataGridViewTextBoxColumn";
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "id_Material";
            this.idMaterialDataGridViewTextBoxColumn.DataSource = this.materialBindingSource;
            this.idMaterialDataGridViewTextBoxColumn.DisplayMember = "NameMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "id_Material";
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idMaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idMaterialDataGridViewTextBoxColumn.ValueMember = "id_Material";
            // 
            // idBookingDataGridViewTextBoxColumn
            // 
            this.idBookingDataGridViewTextBoxColumn.DataPropertyName = "id_Booking";
            this.idBookingDataGridViewTextBoxColumn.DataSource = this.bookingBindingSource;
            this.idBookingDataGridViewTextBoxColumn.DisplayMember = "OrderDescription";
            this.idBookingDataGridViewTextBoxColumn.HeaderText = "id_Booking";
            this.idBookingDataGridViewTextBoxColumn.Name = "idBookingDataGridViewTextBoxColumn";
            this.idBookingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idBookingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idBookingDataGridViewTextBoxColumn.ValueMember = "id_Booking";
            // 
            // countMaterialDataGridViewTextBoxColumn
            // 
            this.countMaterialDataGridViewTextBoxColumn.DataPropertyName = "CountMaterial";
            this.countMaterialDataGridViewTextBoxColumn.HeaderText = "CountMaterial";
            this.countMaterialDataGridViewTextBoxColumn.Name = "countMaterialDataGridViewTextBoxColumn";
            // 
            // idMaterialDataGridViewTextBoxColumn1
            // 
            this.idMaterialDataGridViewTextBoxColumn1.DataPropertyName = "id_Material";
            this.idMaterialDataGridViewTextBoxColumn1.HeaderText = "id_Material";
            this.idMaterialDataGridViewTextBoxColumn1.Name = "idMaterialDataGridViewTextBoxColumn1";
            // 
            // nameMaterialDataGridViewTextBoxColumn
            // 
            this.nameMaterialDataGridViewTextBoxColumn.DataPropertyName = "NameMaterial";
            this.nameMaterialDataGridViewTextBoxColumn.HeaderText = "NameMaterial";
            this.nameMaterialDataGridViewTextBoxColumn.Name = "nameMaterialDataGridViewTextBoxColumn";
            // 
            // priceMaterialDataGridViewTextBoxColumn
            // 
            this.priceMaterialDataGridViewTextBoxColumn.DataPropertyName = "PriceMaterial";
            this.priceMaterialDataGridViewTextBoxColumn.HeaderText = "PriceMaterial";
            this.priceMaterialDataGridViewTextBoxColumn.Name = "priceMaterialDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // folderPathDataGridViewTextBoxColumn
            // 
            this.folderPathDataGridViewTextBoxColumn.DataPropertyName = "FolderPath";
            this.folderPathDataGridViewTextBoxColumn.HeaderText = "FolderPath";
            this.folderPathDataGridViewTextBoxColumn.Name = "folderPathDataGridViewTextBoxColumn";
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.landscapeDesignDataSet;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 491);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Material";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material";
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landscapeDesignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingMaterialBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LandscapeDesignDataSet landscapeDesignDataSet;
        private System.Windows.Forms.BindingSource accountingMaterialBindingSource;
        private LandscapeDesignDataSetTableAdapters.AccountingMaterialTableAdapter accountingMaterialTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private LandscapeDesignDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private LandscapeDesignDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccountingMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource1;
    }
}