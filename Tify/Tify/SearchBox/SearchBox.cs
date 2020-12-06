using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Tify
{
    public partial class SearchBox : Form
    {
        public SearchBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

           
        }

        private DataTable trackTable;
        public SearchBox(DataTable trackTb)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            trackTable = trackTb;   
        }



        private void SearchBox_Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (var item in top_panel.Controls)
            {
                Button currentBtn;
                if (item is Button)
                    currentBtn = item as Button;
                else
                    continue;
                if (currentBtn.Tag == btn.Tag)
                {
                    currentBtn.BackColor = Color.White;
                    currentBtn.ForeColor = Color.Black;
                }
                else
                {
                    currentBtn.BackColor = Color.Black;
                    currentBtn.ForeColor = Color.White;
                }
            }
        }
    }
}