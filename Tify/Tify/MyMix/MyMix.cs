
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


        SqlConnection connection;

        public MainScreen mainScr;
        private DataTable mixTable = new DataTable();        
        public MyMix(MainScreen callform)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            mainScr = callform;
            //Get number of mixs from user
            connection.Open();
            using (SqlCommand cmd= new SqlCommand("select * from UserHasMix where userID=8 order by myMixID asc;", connection))
            {
                cmd.Parameters.AddWithValue("@userID", mainScr.currentUser.UserID);
                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    mixTable.Load(reader);
                }
            }
            connection.Close();


            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                mixContainers.Add(new MyMixContainer(this,mixTable.Rows[i]["myMixID"].ToString()));
                mixDetails.Add(new MixDetail());
            }
            mix_Flowpanel.Controls.AddRange(mixContainers.ToArray());
            this.DoubleBuffered = true;
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
            firstLoadChildForm();

            
        }

        private List<MyMixContainer> mixContainers=new List<MyMixContainer>();
        private List<MixDetail> mixDetails=new List<MixDetail>();





        #region Mở childForm


        private void firstLoadChildForm()
        {
            for (int i = 0; i < mixTable.Rows.Count; i++)
            {
                //mixDetails[i] = new MixDetail();
                mixDetails[i].TopLevel = false;
                mixDetails[i].FormBorderStyle = FormBorderStyle.None;
                mixDetails[i].Dock = DockStyle.Fill;
                mainScr.childForm_panel.Controls.Add(mixDetails[i]);
                mixDetails[i].Show();
            }
           
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

            int index = int.Parse((sender as Panel).Tag.ToString());
            mixDetails[index].loadMixDetailContent(mixContainers[index].mixID, mixContainers[index].index);
            openChildForm(mixDetails[index]);
        }
    }
}
