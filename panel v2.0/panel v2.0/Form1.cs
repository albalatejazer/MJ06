using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // magsisilbing DATA FLIP sa mga panels
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPanels(counter);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // check muna kung ano ang naka show na PANEL
            // add dahil next step OR next panel
            if (counter == 2)
                counter = 2;
            else
                counter++;

            RefreshPanels(counter);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // check muna kung ano ang naka show na PANEL
            // diminished dahil pabalik
            if (counter == 0)
                counter = 0;
            else
                counter--;

            RefreshPanels(counter);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        // magsisilbing REFRESHER ng PANELS
        private void RefreshPanels(int counter)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            switch (counter)
            {
                case 0:
                    panel1.Show();
                    break;
                case 1:
                    panel2.Show();
                    break;
                case 2:
                    panel3.Show();
                    break;
            }
        }
    }
}
