using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tify
{
    public partial class LoadingContainer : UserControl
    {
        public LoadingContainer()
        {
            InitializeComponent();
           
            panel1.Location = new Point(this.ClientSize.Width / 2 - this.Size.Width / 2, this.ClientSize.Height / 2 - this.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }
    }
}
