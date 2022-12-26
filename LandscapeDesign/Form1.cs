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
    public partial class Form1 : Form
    {
        private object currObject = null;


        public Form1()
        {
            InitializeComponent();

            panel1.MouseMove += new MouseEventHandler(mouseEvent); //обработка перемещения курсора мыши
            panel1.MouseClick += new MouseEventHandler(mouseClick); //обработка клика мыши


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
                currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X-110, Cursor.Position.Y-160));
            }
        }
        
   
        public void PB_click(object sender, EventArgs e)
        {
            currObject = sender; //присваивание элементу нажатие кнопки
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBoxKlen, "Клен"); //подсказки
            t.SetToolTip(pictureBoxKastan, "Каштан");
            t.SetToolTip(pictureBoxKamen, "Каменная брусчатка");
            t.SetToolTip(pictureBoxGazon, "Газон");
        }

        int numPBKlen = 0;

        int PRICE = 0; //цена макета
        
        private void pictureBoxKlen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox newPB = new PictureBox();
            newPB.Name = "newnPB" + numPBKlen;
            newPB.Size = new Size(50, 50);
            newPB.Image = LandscapeDesign.Properties.Resources.клен;
            newPB.SizeMode = PictureBoxSizeMode.StretchImage;
            newPB.Click += new EventHandler(PB_click);
            panel1.Controls.Add(newPB);
            newPB.BringToFront();
            numPBKlen += 1;
            PRICE += 1000;
            label1.Text = PRICE.ToString();
        }
        int numPBKastan = 0;
        private void pictureBoxKastan_Click(object sender, EventArgs e)
        {
            PictureBox newPB = new PictureBox();
            newPB.Name = "newnPB" + numPBKastan;
            newPB.Size = new Size(50, 50);
            newPB.Image = LandscapeDesign.Properties.Resources.каштан;
            newPB.SizeMode = PictureBoxSizeMode.StretchImage;
            newPB.Click += new EventHandler(PB_click);
            this.Controls.Add(newPB);
            newPB.BringToFront();
            numPBKastan += 1;
            PRICE += 500;
            label1.Text = PRICE.ToString();

        }
    }
}
