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
            //mouseenter
            SearchBox_Tracks.MouseEnter += MouseEnter;
            SearchBox_Artists.MouseEnter += MouseEnter;
            SearchBox_Album.MouseEnter += MouseEnter;
            SearchBox_PlayLists.MouseEnter += MouseEnter;

            //mouseleave
            SearchBox_Tracks.MouseLeave += MouseLeave;
            SearchBox_Artists.MouseLeave += MouseLeave;
            SearchBox_Album.MouseLeave += MouseLeave;
            SearchBox_PlayLists.MouseLeave += MouseLeave;

            //mouseclick
            SearchBox_Tracks.MouseClick += MouseClick;
            SearchBox_Artists.MouseClick += MouseClick;
            SearchBox_Album.MouseClick += MouseClick;
            SearchBox_PlayLists.MouseClick += MouseClick;
        }


        private void MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.Black;

        }
        private void MouseClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Click += loadForm;


        }
        private SearchBox_childForm kid;

        private void loadForm(object sender, EventArgs e)
        {
            kid = new SearchBox_childForm();
            kid.TopLevel = false;
            kid.FormBorderStyle = FormBorderStyle.None;
            kid.Dock = DockStyle.Fill;
            ChildForm_panel.Controls.Add(kid);
            kid.Show();
        }
        
       
    }
}
