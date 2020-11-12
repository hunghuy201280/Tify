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
    public partial class CreatePlayList : Form
    {
        public CreatePlayList()
        {
            InitializeComponent();
            Text_PlayList_Count.Text = Description_TextBox.Text.Length.ToString() +"/ 500" ;


        }
        int count = 0;
        private void Description_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            /* Text_PlayList_Count.Text = Description_TextBox.Text.Length.ToString() + "/ 500";*/
            if (e.KeyChar == '\b')
            {
                count--;
            }
            else if (count >= 500)
            {
                e.Handled = true;
            }
            else
                count++;
            if (count <= 0)
                count = 0;
            Text_PlayList_Count.Text = count.ToString() + "/ 500";
        }

    }
}
