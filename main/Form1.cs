using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPT_Teacher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.OwnerDraw = true;
            toolTip.Draw += ToolTip_Draw;
            toolTip.SetToolTip(buttonShowSidebar, "Show Sidebar");
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            //Customizing the tooltip appearance
            e.DrawBackground();
            e.DrawBorder();

            //Setting up the tooltip background color
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            //Setting up the tooltip text color
            using (var brush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(e.ToolTipText, e.Font, brush, e.Bounds.X + 6, e.Bounds.Y + 2);
            }
        }

        private void buttonShowSidebar_Click(object sender, EventArgs e)
        {

        }

        private void panelUpgrade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void panelProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfileUpgrade_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHideNavbar_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewchat_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sideFooterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
