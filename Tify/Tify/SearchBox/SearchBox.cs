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
        private SearchBox_childForm kid;
        public SearchBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            kid = new SearchBox_childForm();
            kid.TopLevel = false;
            kid.FormBorderStyle = FormBorderStyle.None;
            kid.Dock = DockStyle.Fill;
            //mousehovver

            /*SearchBox_Tracks.MouseHover += MouseHover;
            SearchBox_Artists.MouseHover += MouseHover;
            SearchBox_Album.MouseHover += MouseHover;
            SearchBox_PlayLists.MouseHover += MouseHover;*/





        }


        /*private void MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;

        }*/


      

    
            //test
     
    

        private void SearchBox_Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Button item in top_panel.Controls)
            {
                if (item.Tag == btn.Tag)
                {

                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                    //add childform
                    
                    ChildForm_panel.Controls.Add(kid);
                    kid.Show();

                    foreach (DataGridView data in kid.Controls)
                    {
                        if (data.Tag == btn.Tag)
                        {
                            data.BringToFront();
                          
                        }
                        else 
                        {
                            data.SendToBack();
                        }
                    }
                    

                }
                else
                {
                    item.BackColor = Color.Black;
                    item.ForeColor = Color.White;
                }


            }
        }
    }
}
