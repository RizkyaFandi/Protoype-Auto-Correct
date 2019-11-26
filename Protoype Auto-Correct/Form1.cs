using System;
using System.Drawing;
using System.Windows.Forms;

namespace Protoype_Auto_Correct
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            Search.ReadLines();
        }

        private void btnkoreksi_Click(object sender, EventArgs e)
        {
            tboutput.Text = Correction.MasukTeks(tbinput.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources.closeAC1;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources.closeAC;
        }

        private void tbinput_Enter(object sender, EventArgs e)
        {
            tbinput.BackColor = ColorTranslator.FromHtml("#E0FFFF");
        }

        private void tbinput_Leave(object sender, EventArgs e)
        {
            tbinput.BackColor = ColorTranslator.FromHtml("#00FFFF");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);
                Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
