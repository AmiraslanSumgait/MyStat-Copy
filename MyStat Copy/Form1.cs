using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace MyStat_Copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox textBox = new TextBox
        {
            MinimumSize = new Size(400, 80),
            Location = new Point(675, 90),
            Size = new Size(400, 80),
        };
        private void picBox_Pencil_Click(object sender, EventArgs e)
        {
            groupBox_1.Controls.Add(textBox);
            GunaAdvenceButton saveButton = new GunaAdvenceButton
            {
                Size = new Size(100, 40),
                Location = new Point(1085, 105),
                Image = null,
                BaseColor = Color.FromArgb(30, 144, 255),
                Animated = true,
                AnimationHoverSpeed = 0.07f,
                AnimationSpeed = 0.03f,
                Text = "Save",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,
                ForeColor=Color.Black
  
            };
            GunaAdvenceButton rejectButton = new GunaAdvenceButton
            {
                Size = new Size(100, 40),
                Location = new Point(1195, 105),
                Image = null,
                BaseColor = Color.FromArgb(30, 144, 255),
                Animated = true,
                AnimationHoverSpeed = 0.07f,
                AnimationSpeed = 0.03f,
                Text = "Reject",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Black

            };
            groupBox_1.Controls.Add(saveButton);
            groupBox_1.Controls.Add(rejectButton);
           
           
            UserControl.Location = new Point(UserControl.Location.X , UserControl.Location.Y+20);
            Seperator1.Location = new Point(Seperator1.Location.X, Seperator1.Location.Y + 20);
            panel_UserProperties.Location = new Point(panel_UserProperties.Location.X, panel_UserProperties.Location.Y + 20);
            saveButton.Click += SaveButton_Click;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Label lbl_LessonSubject = new Label
            {
                Text = textBox.Text,
                Location=new Point(1000,80),
                BackColor=Color.Red,
                 
            };
            groupBox_1.Controls.Add(lbl_LessonSubject);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
                Text = $"X: {e.X}  Y: {e.Y}";
          
        }
    }
}
