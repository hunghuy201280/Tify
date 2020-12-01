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
    public partial class resetPassword : Form
    {

        SqlConnection connection;
        public resetPassword()
        {
            InitializeComponent();
        }

        Account user;
        public resetPassword(Account account)
        {
            InitializeComponent();
            user = account;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
