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
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel[index].BringToFront();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
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
    }

}
