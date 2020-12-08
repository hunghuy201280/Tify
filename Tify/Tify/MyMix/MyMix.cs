
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
    public partial class MyMix : Form
    {
        public MyMix()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }
         

        private MainScreen mainScr;
        int countMix;
        public MyMix(MainScreen callform)
        {
            InitializeComponent();

            mainScr = callform;
            


            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            firstLoadChildForm();

            test = new MyMixContainer(this);
            mix_Flowpanel.Controls.Add(test);
        }

        private MyMixContainer test;





        #region Mở childForm


        private MixDetail mixDetail;
        private void firstLoadChildForm()
        {
            mixDetail = new MixDetail();
            mixDetail.TopLevel = false;
            mixDetail.FormBorderStyle = FormBorderStyle.None;
            mixDetail.Dock = DockStyle.Fill;
            mainScr.childForm_panel.Controls.Add(mixDetail);
            mixDetail.Show();
        }

        public void openChildForm(Form childForm)
        {
            if (mainScr.activeForm != null)
            {
                if (mainScr.activeForm == childForm)
                    return;
                mainScr.activeForm.SendToBack();
            }

            mainScr.activeForm = childForm;

            childForm.BringToFront();
        }

        #endregion Mở childForm

        private void MyMix_Load(object sender, EventArgs e)
        {

            MyMix_GroupBox.Visible = true;

        }


       
        private void groupBox1_Resize(object sender, EventArgs e)
        {

            MyMix_GroupBox.Width = this.Width - 12;
            MyMix_GroupBox.Height = this.Height - 12;
        }


        public void opacity_panel_Click(object sender, EventArgs e)
        {
           
            openChildForm(mixDetail);
        }
    }
}
