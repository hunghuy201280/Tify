
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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


        

        public MainScreen mainScr;
        private DataTable mixTable = new DataTable();        
        public MyMix(MainScreen callform)
        {
            InitializeComponent();
           

            mainScr = callform;
            //Get user has mix table
            mixTable = Database.getMyMixTableInMyMix(mainScr.CurrentUser.UserID);
            mixDetail = new MixDetail(this);

            firstLoadChildForm();

            // initialize container and mixdetail
            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                mixContainers.Add(new MyMixContainer(this,mixTable.Rows[i]["myMixID"].ToString(),mixDetail));
            }
            mix_Flowpanel.Controls.AddRange(mixContainers.ToArray());


            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }

            
        }

        private List<MyMixContainer> mixContainers=new List<MyMixContainer>();
        private MixDetail mixDetail;


        public void reloadMixContainer(/*string MIXID*/)
        {
            foreach (MyMixContainer container in mixContainers)
            {
               /* if (container.mixID==MIXID)
                {*/
                    container.reloadStatus();
                   /* break;*/
               /* }*/
            }
        }


        #region Mở childForm


        private void firstLoadChildForm()
        {
          
                mixDetail.TopLevel = false;
                mixDetail.FormBorderStyle = FormBorderStyle.None;
                mixDetail.Dock = DockStyle.Fill;
                mainScr.childForm_panel.Controls.Add(mixDetail);
                mixDetail.Show();
            
           
        }

        public void openChildForm(Form childForm)
        {
            mainScr.openChildForm(childForm);

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


        
    }
}
