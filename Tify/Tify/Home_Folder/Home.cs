using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    //Recently,chart,mix for you,
    //2 cai because you listened to
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private MainScreen callForm = null;
        public Home(MainScreen parentForm)
        {
            
            InitializeComponent();
            callForm = parentForm;
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Size=new Size(callForm.childForm_panel.Size.Width - 16, callForm.childForm_panel.Height - 39);
            //MainScreen.hideScrollBar(flowLayoutPanel1, "flow");
            DoubleBuffered = true;

            mixesForYou.setContainerName("Mixes For You");
            theCharts.setContainerName("The Charts");

            hideScrollBar();
        }

        //test

        

      

        #region đổi kích thước của group box khi form resize vì không dùng dock được
        private void home_flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            foreach (var item in panel.Controls)
            {
                if (item is HomeItemContainer)
                {
                    HomeItemContainer temp = item as HomeItemContainer;
                    temp.Size = new Size(panel.Size.Width-15, temp.Size.Height);
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            recentlyPlayed.addItem(new PlaylistContainer());
            HomeItemContainer a = new HomeItemContainer();
         }

        #region hideScrollBar

        private void hideScrollBar()
        {
            home_flowLayoutPanel.AutoScroll = false;
            home_flowLayoutPanel.HorizontalScroll.Maximum = 0;
            home_flowLayoutPanel.AutoScrollPosition = new Point(0, 0);
            home_flowLayoutPanel.AutoScroll = true;
        }
        #endregion

        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Home";
            this.ResumeLayout(false);

        }
    }
}
