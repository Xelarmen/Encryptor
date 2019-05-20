using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hakkında1.BringToFront();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            menu11.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            hakkında1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//simge durumuna getirir       
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int Mov;
        int mx;
        int my;
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;
        }
    }
}
