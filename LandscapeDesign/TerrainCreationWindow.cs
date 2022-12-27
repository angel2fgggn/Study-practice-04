using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LandscapeDesign
{
    public partial class TerrainCreationWindow : Form
    {
        private object currObject = null;


        public TerrainCreationWindow()
        {
            InitializeComponent();

            

            panelMaket.MouseMove += new MouseEventHandler(mouseEvent); //обработка перемещения курсора мыши
            panelMaket.MouseClick += new MouseEventHandler(mouseClick); //обработка клика мыши


            
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button.ToString()== "Right") //при нажатии на правую кнопку мыши, очищение присваивания
            {
                currObject = null;
            }
            
        }

        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if(currObject != null) //при нажатии, данный объект следует за курсором
            {
                currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X, Cursor.Position.Y)); //320 и 120
                
            }
        }


        string IDKlen;
        string IDKastan;
        string IDGazon;

      

        private void SearchTable()
        {
            

            //поиск материала
            materialBindingSource.Filter = string.Format("NameMaterial LIKE '{0}%'", labelnameImage.Text);
            //вынос из таблицы данные о id материала
            labelIDMAt.Text = Convert.ToString(dataGridViewMater.Rows[0].Cells[0].EditedFormattedValue);


            //в зависимости от выбранной картинки идет присваивание ID
            if (labelnameImage.Text == "Клен")
            {
                IDKlen = labelIDMAt.Text;
                
            }
            else if (labelnameImage.Text == "Каштан")
            {
                IDKastan = labelIDMAt.Text;
                
            }
            else if (labelnameImage.Text == "Газон")
            {
                IDGazon= labelIDMAt.Text;
  
            }
            

        }
        private void AddMAterialAndServices()
        { 
            //Добавление материалов в БД
            if(IDKlen != null)
            {

                DataRow nRow = landscapeDesignDataSet.Tables[1].NewRow();
                int rc = dataGridViewAccountingMaterial.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = IDKlen;
                nRow[2] = labelIDBooking.Text;
                nRow[3] = numPBKlen;

                landscapeDesignDataSet.Tables[1].Rows.Add(nRow);
                accountingMaterialTableAdapter.Update(landscapeDesignDataSet.AccountingMaterial);
                landscapeDesignDataSet.Tables[1].AcceptChanges();

                int id_LandscapeServices = 8;
                DataRow nRow1 = landscapeDesignDataSet.Tables[0].NewRow();
                int rc1 = dataGridViewAccountingServices.RowCount + 1;
                nRow1[0] = rc1;
                nRow1[1] = id_LandscapeServices;
                nRow1[2] = labelIDBooking.Text;
                nRow1[3] = 1;

                landscapeDesignDataSet.Tables[0].Rows.Add(nRow1);
                accountingLandscapeServicesTableAdapter.Update(landscapeDesignDataSet.AccountingLandscapeServices);
                landscapeDesignDataSet.Tables[0].AcceptChanges();

                MessageBox.Show("Успешно!");
            }
            else if (IDKastan != null)
            {
                DataRow nRow = landscapeDesignDataSet.Tables[1].NewRow();
                int rc = dataGridViewAccountingMaterial.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = IDKastan;
                nRow[2] = labelIDBooking.Text;
                nRow[3] = numPBKastan;

                landscapeDesignDataSet.Tables[1].Rows.Add(nRow);
                accountingMaterialTableAdapter.Update(landscapeDesignDataSet.AccountingMaterial);
                landscapeDesignDataSet.Tables[1].AcceptChanges();

                int id_LandscapeServices = 8;
                DataRow nRow1 = landscapeDesignDataSet.Tables[0].NewRow();
                int rc1 = dataGridViewAccountingServices.RowCount + 1;
                nRow1[0] = rc1;
                nRow1[1] = id_LandscapeServices;
                nRow1[2] = labelIDBooking.Text;
                nRow1[3] = 1;

                landscapeDesignDataSet.Tables[0].Rows.Add(nRow1);
                accountingLandscapeServicesTableAdapter.Update(landscapeDesignDataSet.AccountingLandscapeServices);
                landscapeDesignDataSet.Tables[0].AcceptChanges();

                MessageBox.Show("Успешно!");
            }
            else
            {
                MessageBox.Show("Упс...Что-то пошло не так :/ ");
            }

        }

        //генерация карты
        private void GenerateMap()
        {


            //рисование сетки
            for (int i = 0; i < 37; i++)
            {

                PictureBox pic = new PictureBox();
                pic.Location = new Point(0 + i * 25, 0);
                pic.BackColor = Color.Black;
                pic.Size = new Size(1, 900);
                panelMaket.Controls.Add(pic);
            }

            for (int i = 0; i < 37; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Location = new Point(0, 0 + i * 25);
                pic.BackColor = Color.Black;
                pic.Size = new Size(900, 1);
                panelMaket.Controls.Add(pic);
            }



            //рисование границ земельного участка
            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point(1, 0);
            pic2.BackColor = Color.Red;
            pic2.Size = new Size(3, Convert.ToInt32(labelHeight.Text));
            panelMaket.Controls.Add(pic2);

            PictureBox pic3 = new PictureBox();
            pic3.Location = new Point(0, 1);
            pic3.BackColor = Color.Red;
            pic3.Size = new Size(Convert.ToInt32(labelWidht.Text), 3);
            panelMaket.Controls.Add(pic3);

            PictureBox pic4 = new PictureBox();
            pic4.Location = new Point(Convert.ToInt32(labelWidht.Text), 0);
            pic4.BackColor = Color.Red;
            pic4.Size = new Size(3, Convert.ToInt32(labelHeight.Text));
            panelMaket.Controls.Add(pic4);

            PictureBox pic5 = new PictureBox();
            pic5.Location = new Point(0, Convert.ToInt32(labelHeight.Text));
            pic5.BackColor = Color.Red;
            pic5.Size = new Size(Convert.ToInt32(labelWidht.Text), 3);
            panelMaket.Controls.Add(pic5);



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.AccountingLandscapeServices". При необходимости она может быть перемещена или удалена.
            this.accountingLandscapeServicesTableAdapter.Fill(this.landscapeDesignDataSet.AccountingLandscapeServices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.InformationCustomer". При необходимости она может быть перемещена или удалена.
            this.informationCustomerTableAdapter.Fill(this.landscapeDesignDataSet.InformationCustomer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Booking". При необходимости она может быть перемещена или удалена.
            this.bookingTableAdapter.Fill(this.landscapeDesignDataSet.Booking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.landscapeDesignDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.landscapeDesignDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.landscapeDesignDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "landscapeDesignDataSet.AccountingMaterial". При необходимости она может быть перемещена или удалена.
            this.accountingMaterialTableAdapter.Fill(this.landscapeDesignDataSet.AccountingMaterial);


            GenerateMap();

            //подсказки для картинок
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBoxKlen, "Клен"); 
            t.SetToolTip(pictureBoxKastan, "Каштан");
            t.SetToolTip(pictureBoxKamen, "Каменная брусчатка");
            t.SetToolTip(pictureBoxGazon, "Газон");

            //поиск заказчика
            informationCustomerBindingSource1.Filter = string.Format("LastName LIKE '{0}%'", labelnamec.Text);

            //вынос из таблицы данные о id заказчика
            labelIDCustomer.Text = Convert.ToString(dataGridViewCustomer.Rows[0].Cells[0].EditedFormattedValue);

            //поиск материала
            bookingBindingSource.Filter = "id_InformationCustomer = " + labelIDCustomer.Text;
            
            //вынос из таблицы данные о id материала
            labelIDBooking.Text = Convert.ToString(dataGridViewBooking.Rows[0].Cells[0].EditedFormattedValue);

            
        }

        
        int numPBKlen = 0; //кол-во клена

        int PRICE = 0; //цена макета
        
        
        List<string> listElements = new List<string>();
            


        //создание картинки на панели редактирования
        private void pictureBoxKlen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox newPB = new PictureBox();
            newPB.Name = "newnPBKlen" + numPBKlen;
            newPB.Size = new Size(25, 25);
            newPB.Image = LandscapeDesign.Properties.Resources.Клен;
            newPB.SizeMode = PictureBoxSizeMode.StretchImage;
            newPB.Click += new EventHandler(PB_click);
            panelMaket.Controls.Add(newPB);
            newPB.BringToFront();
            numPBKlen += 1;
            PRICE += 1000;
            labelprice.Text = PRICE.ToString();
            labelnameImage.Text = "Клен";
           
            SearchTable();


            comboBoxElements.Items.Add(newPB.Name);
        }

        int numPBKastan = 0;//кол-во каштан
        private void pictureBoxKastan_Click(object sender, EventArgs e)
        {
            PictureBox newPB = new PictureBox();
            newPB.Name = "newnPBKastan" + numPBKastan;
            newPB.Size = new Size(25, 25);
            newPB.Image = LandscapeDesign.Properties.Resources.Каштан;
            newPB.SizeMode = PictureBoxSizeMode.StretchImage;
            newPB.Click += new EventHandler(PB_click);
            this.Controls.Add(newPB);
            newPB.BringToFront();
            numPBKastan += 1;
            PRICE += 500;
            labelprice.Text = PRICE.ToString();
            labelnameImage.Text = "Каштан";
  
            SearchTable();

            comboBoxElements.Items.Add(newPB.Name);
        }

      

        public void PB_click(object sender, EventArgs e)
        {
            currObject = sender;//присваивание элементу нажатие кнопки
        }

        //переход между формами
        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeWindowDesigner WelcomeWindowDesignerForm = new WelcomeWindowDesigner();
            WelcomeWindowDesignerForm.Show();
            this.Hide();
        }


        //сохранение ПАнели как ФОТО
        private void фотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Рисунок.bmp | *.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int width, height;
                width = panelMaket.Width;
                height = panelMaket.Height;
                Bitmap bmp = new Bitmap(width, height);
                panelMaket.DrawToBitmap(bmp, panelMaket.ClientRectangle);
                bmp.Save(sfd.FileName);
            }
        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMAterialAndServices();
        }

  
        //Уменьшение размера
        //!!ссылка на обьект не указывает на экземпляр класса
        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            string name = comboBoxElements.Text;

            label9.Text = comboBoxElements.Text;


            this.Controls[name].Width -= 20;
            this.Controls[name].Height -= 20;
        }
    }
}
