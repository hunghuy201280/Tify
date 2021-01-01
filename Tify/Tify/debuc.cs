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
    public partial class debuc : Form
    {
        public debuc()
        {
            InitializeComponent();
        }
        public debuc(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }
    }
}
