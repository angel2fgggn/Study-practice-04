namespace LandscapeDesign
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxKlen = new System.Windows.Forms.PictureBox();
            this.pictureBoxKastan = new System.Windows.Forms.PictureBox();
            this.pictureBoxKamen = new System.Windows.Forms.PictureBox();
            this.pictureBoxGazon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKastan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGazon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxKlen);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxKastan);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxKamen);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxGazon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(877, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 609);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxKlen
            // 
            this.pictureBoxKlen.Image = global::LandscapeDesign.Properties.Resources.клен;
            this.pictureBoxKlen.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxKlen.Name = "pictureBoxKlen";
            this.pictureBoxKlen.Size = new System.Drawing.Size(57, 55);
            this.pictureBoxKlen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKlen.TabIndex = 2;
            this.pictureBoxKlen.TabStop = false;
            this.pictureBoxKlen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxKlen_MouseDoubleClick);
            // 
            // pictureBoxKastan
            // 
            this.pictureBoxKastan.Image = global::LandscapeDesign.Properties.Resources.каштан;
            this.pictureBoxKastan.Location = new System.Drawing.Point(66, 3);
            this.pictureBoxKastan.Name = "pictureBoxKastan";
            this.pictureBoxKastan.Size = new System.Drawing.Size(57, 55);
            this.pictureBoxKastan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKastan.TabIndex = 3;
            this.pictureBoxKastan.TabStop = false;
            this.pictureBoxKastan.Click += new System.EventHandler(this.pictureBoxKastan_Click);
            // 
            // pictureBoxKamen
            // 
            this.pictureBoxKamen.Image = global::LandscapeDesign.Properties.Resources.камень;
            this.pictureBoxKamen.Location = new System.Drawing.Point(129, 3);
            this.pictureBoxKamen.Name = "pictureBoxKamen";
            this.pictureBoxKamen.Size = new System.Drawing.Size(57, 55);
            this.pictureBoxKamen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKamen.TabIndex = 4;
            this.pictureBoxKamen.TabStop = false;
            // 
            // pictureBoxGazon
            // 
            this.pictureBoxGazon.Image = global::LandscapeDesign.Properties.Resources.газон;
            this.pictureBoxGazon.Location = new System.Drawing.Point(192, 3);
            this.pictureBoxGazon.Name = "pictureBoxGazon";
            this.pictureBoxGazon.Size = new System.Drawing.Size(57, 55);
            this.pictureBoxGazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGazon.TabIndex = 5;
            this.pictureBoxGazon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 609);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Итоговая цена макета:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 739);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Landscape Design";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKlen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKastan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxKlen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxKastan;
        private System.Windows.Forms.PictureBox pictureBoxKamen;
        private System.Windows.Forms.PictureBox pictureBoxGazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

