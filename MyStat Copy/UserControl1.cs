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

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //gunaRadioButton1.CheckedOffColor

        }

        private void picBox_Diamond1_Click(object sender, EventArgs e)
        {

            if (picBox_Diamond1.Image.Equals(Properties.Resources.undiamond))
            {
                picBox_Diamond1.Image = Properties.Resources.diamond;
            }
            else if (picBox_Diamond1.Tag.Equals(Properties.Resources.diamond)){
                picBox_Diamond1.Image = Properties.Resources.undiamond;
            }

        }
    }
}
