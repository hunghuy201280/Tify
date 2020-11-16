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
            Text_PlayList_Count.Text = Description_TextBox.Text.Length.ToString() + "/ 500";



        }
       

        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            Description_TextBox.MaxLength = 5;
            Text_PlayList_Count.Text = (Description_TextBox.Text.Length).ToString() + "/ 500";
        }
    }
}
