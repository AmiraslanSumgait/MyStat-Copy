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
       // public int DiamondCount { get; set; }=
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
        Label lbl_LessonSubject = new Label
        {
            Text = "",

            Location = new Point(860, 59),
            BackColor = Color.Transparent,
            ForeColor = Color.Black,
            Font = new Font("Segoe UI", 14, FontStyle.Italic),
            AutoSize = true
        };
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
            ForeColor = Color.Black

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

        private void picBox_Pencil_Click(object sender, EventArgs e)
        {
            
            saveButton.Visible = true;
            rejectButton.Visible = true;
            textBox.Visible = true;
            groupBox_1.Controls.Add(textBox);
            groupBox_1.Controls.Add(saveButton);
            groupBox_1.Controls.Add(rejectButton);
            UserControl1.Location = new Point(UserControl1.Location.X, UserControl1.Location.Y + 20);
            userControl11.Location = new Point(userControl11.Location.X, userControl11.Location.Y +20);
            userControl12.Location = new Point(userControl12.Location.X, userControl12.Location.Y+20);
            userControl13.Location = new Point(userControl13.Location.X, userControl13.Location.Y+20);
            userControl14.Location = new Point(userControl14.Location.X, userControl14.Location.Y+20);
            Seperator1.Location = new Point(Seperator1.Location.X, Seperator1.Location.Y + 20);
            panel_UserProperties.Location = new Point(panel_UserProperties.Location.X, panel_UserProperties.Location.Y + 20);
            saveButton.Click += SaveButton_Click;
            rejectButton.Click += RejectButton_Click;
        }
        private void RejectButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            saveButton.Visible = false;
            rejectButton.Visible = false;
            textBox.Visible = false;
            UserControl1.Location = new Point(UserControl1.Location.X, UserControl1.Location.Y - 5);
            userControl11.Location = new Point(userControl11.Location.X, userControl11.Location.Y - 5);
            userControl12.Location = new Point(userControl12.Location.X, userControl12.Location.Y - 5);
            userControl13.Location = new Point(userControl13.Location.X, userControl13.Location.Y - 5);
            userControl14.Location = new Point(userControl14.Location.X, userControl14.Location.Y - 5);
            Seperator1.Location = new Point(Seperator1.Location.X, Seperator1.Location.Y - 5);
            panel_UserProperties.Location = new Point(panel_UserProperties.Location.X, panel_UserProperties.Location.Y - 5);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            lbl_LessonSubject.Text = textBox.Text;
            UserControl1.Location = new Point(UserControl1.Location.X, UserControl1.Location.Y - 5);
            userControl11.Location = new Point(userControl11.Location.X, userControl11.Location.Y - 5);
            userControl12.Location = new Point(userControl12.Location.X, userControl12.Location.Y - 5);
            userControl13.Location = new Point(userControl13.Location.X, userControl13.Location.Y - 5);
            userControl14.Location = new Point(userControl14.Location.X, userControl14.Location.Y - 5);
            Seperator1.Location = new Point(Seperator1.Location.X, Seperator1.Location.Y - 5);
            panel_UserProperties.Location = new Point(panel_UserProperties.Location.X, panel_UserProperties.Location.Y - 5);
            picBox_Pencil.Location = new Point(lbl_LessonSubject.Location.X + lbl_LessonSubject.Size.Width, lbl_LessonSubject.Location.Y);
            saveButton.Visible = false;
            rejectButton.Visible = false;
            textBox.Visible = false;
            groupBox_1.Controls.Add(lbl_LessonSubject);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X: {e.X}  Y: {e.Y}";
        }

        private void rb_MarkEveryBody_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
