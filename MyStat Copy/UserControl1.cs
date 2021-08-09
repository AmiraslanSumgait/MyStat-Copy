using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStat_Copy
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Image undiamond = Properties.Resources.undiamond;
        Image diamond = Properties.Resources.diamond;
        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //gunaRadioButton1.CheckedOffColor

        }
        public bool Diamond1 { get; set; } = false;
        public bool Diamond2 { get; set; } = false;
        public bool Diamond3 { get; set; } = false;
        private void picBox_Diamond1_Click(object sender, EventArgs e)
        {
           
            if (Diamond1)
            {
                picBox_Diamond1.Image=Properties.Resources.undiamond;
                Diamond1 = false;
            }
            else {
                picBox_Diamond1.Image = diamond;
                Diamond1 = true;
            }
          

        }

        private void picBox_Diamond2_Click(object sender, EventArgs e)
        {
            if (Diamond2)
            {
                picBox_Diamond2.Image = Properties.Resources.undiamond;
                Diamond2 = false;
            }
            else
            {
                picBox_Diamond2.Image = diamond;
                Diamond2 = true;
            }
        }

        private void picBox_Diamond3_Click(object sender, EventArgs e)
        {
            if (Diamond3)
            {
                picBox_Diamond3.Image = Properties.Resources.undiamond;
                Diamond3 = false;
            }
            else
            {
                picBox_Diamond3.Image = diamond;
                Diamond3 = true;
            }
        }
        private void picbox_DltDiamonds_Click(object sender, EventArgs e)
        {
            picBox_Diamond1.Image = undiamond;
            picBox_Diamond2.Image = undiamond;
            picBox_Diamond3.Image = undiamond;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox
            {
                Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y),
                Size = new Size(60,60),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.Screenshot__41_,
                 
            };
            gpBox_User.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            gpBox_User.Controls.RemoveAt(0);
        }
    }
}
