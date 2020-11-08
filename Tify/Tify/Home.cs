using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }
        private MainScreen callForm = null;
        public Home(MainScreen parentForm)
        {
            callForm= parentForm;
            InitializeComponent();
            flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            flowLayoutPanel1.HorizontalScroll.Maximum = 195 * flowLayoutPanel1.Controls.Count+195-flowLayoutPanel1.Size.Width;
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size=new Size(callForm.childForm_panel.Size.Width - 16, callForm.childForm_panel.Height - 39);
            //MainScreen.hideScrollBar(flowLayoutPanel1, "flow");
           
        }

        //test
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Button() { Size= new Size(100,100)});
            flowLayoutPanel1.HorizontalScroll.Maximum = 100 * flowLayoutPanel1.Controls.Count + 100 - flowLayoutPanel1.Size.Width;
        }


        private int location = 0;
        private void previous_Click(object sender, EventArgs e)
        {
            if (location - 180 > 0)
            {
                location -= 180;
                flowLayoutPanel1.HorizontalScroll.Value = location;
            }
            else
            {
                // If scroll position is below 0 set the position to 0 (MIN)
                location = 0;
                flowLayoutPanel1.AutoScrollPosition = new Point(location, 0);
            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (location + 180 < flowLayoutPanel1.HorizontalScroll.Maximum)
            {
                location += 180;
                flowLayoutPanel1.HorizontalScroll.Value = location;
            }
            else
            {
               
                location = flowLayoutPanel1.HorizontalScroll.Maximum;
                flowLayoutPanel1.AutoScrollPosition = new Point(location, 0);
            }
        }

        private void flowLayoutPanel2_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            foreach (var item in panel.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox temp = item as GroupBox;
                    temp.Size = new Size(panel.Size.Width, temp.Size.Height);
                }
            }
        }
    }
}
