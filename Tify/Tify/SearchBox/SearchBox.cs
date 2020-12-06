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
          /*  SearchBox_Tracks.MouseHover += MouseHover;
            SearchBox_Artists.MouseHover += MouseHover;
            SearchBox_Album.MouseHover += MouseHover;
            SearchBox_PlayLists.MouseHover += MouseHover;*/

            //mouseleave
            /*   SearchBox_Tracks.MouseLeave += MouseLeave;
               SearchBox_Artists.MouseLeave += MouseLeave;
               SearchBox_Album.MouseLeave += MouseLeave;
               SearchBox_PlayLists.MouseLeave += MouseLeave;
   */


        }


      /*  private void MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;

        }*/
        /* private void MouseLeave(object sender, EventArgs e)
         {
             Button btn = (Button)sender;
             btn.ForeColor = Color.White;
             btn.BackColor = Color.Black;

         }
 */
        private SearchBox_childForm kid;

        /*  private void loadForm(object sender, EventArgs e)
          {
              kid = new SearchBox_childForm();
              kid.TopLevel = false;
              kid.FormBorderStyle = FormBorderStyle.None;
              kid.Dock = DockStyle.Fill;
              ChildForm_panel.Controls.Add(kid);
              kid.Show();
          }*/

        private void SearchBox_PlayLists_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        
            foreach (Button item in top_panel.Controls)
            {
                if (item == SearchBox_PlayLists)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                }
            }
        

       
        }
       
        private void SearchBox_Artists_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
          
            foreach (Button item in top_panel.Controls)
            {
                if (item == SearchBox_Artists)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                }
            }
        }
        /*   kid = new SearchBox_childForm();
           kid.TopLevel = false;
           kid.FormBorderStyle = FormBorderStyle.None;
           kid.Dock = DockStyle.Fill;
           ChildForm_panel.Controls.Add(kid);


           foreach (DataGridView item in kid.Controls) 
           {
               if (item != kid.Artists_dataGridView)
               {
                   item.SendToBack();
               }
           }
           kid.Artists_dataGridView.BringToFront();
           kid.Artists_dataGridView.Dock = DockStyle.Fill;

           kid.Show();*/
    

        private void SearchBox_Album_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            foreach (Button item in top_panel.Controls)
            {
                if (item == SearchBox_Album)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                }
            }
        }
    

        private void SearchBox_Tracks_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach (Button item in top_panel.Controls)
            {
                if (item == SearchBox_Tracks)
                {

                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                }


            }
        }
    }
}
