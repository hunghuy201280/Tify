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
    public partial class SearchBox_childForm : Form
    {
        public SearchBox_childForm()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                MainScreen.EnableDoubleBuferring(control);
            }
        }
        private void SearchBox_dataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (SearchBox_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(19, 19, 20))
            {
                return;
            }
            foreach (DataGridViewCell cell in SearchBox_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.FromArgb(19, 19, 20);
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
                return;
            if (SearchBox_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
            {
                return;
            }
            foreach (DataGridViewCell cell in SearchBox_dataGridView.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = Color.Black;
            }
        }
    }
}
