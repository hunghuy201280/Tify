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
        private FlowLayoutPanel menu_pnl;
        private MainScreen mainScr;
        public CreatePlayList(MainScreen callForm)
        {
            InitializeComponent();
            mainScr = callForm;
            menu_pnl = mainScr.getCreatePlayList_FlowPanel();
           

        }


        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            Description_TextBox.MaxLength = 500;
            Text_PlayList_Count.Text = (Description_TextBox.Text.Length).ToString() + "/ 500";
        }

        private void CreatePlayList_Button_Click(object sender, EventArgs e)
        {
            
            Button newbutton = new Button();
            newbutton.FlatStyle = FlatStyle.Flat;
            newbutton.FlatAppearance.BorderSize = 0;
            newbutton.Text = Title_TextBox.Text;
            newbutton.Font = new Font("Nationale", 12);
            newbutton.AutoSize = false;
            newbutton.MouseHover += mainScr.menu_panel_MouseHover;
            newbutton.MouseLeave += mainScr.menu_panel_MouseLeave;
            newbutton.TextAlign = ContentAlignment.MiddleLeft;
            newbutton.ForeColor = Color.White;
            newbutton.Width = 210;
            newbutton.Height = 46;
            menu_pnl.FlowDirection = FlowDirection.TopDown;
            newbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 78, 84);
            menu_pnl.Controls.Add(newbutton);
          



        }
    }
}
