using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMix
{
    public partial class MyMix : UserControl
    {
        public MyMix()
        {
            InitializeComponent();
        }

        public string getMyMixtName()
        {
            return MyMixName_label.Text;
        }
        public void setPlaylistName(string name)
        {
            MyMixName_label.Text = name;
        }
        public string getArtist()
        {
            return MyMixArtist_label.Text;
        }
        int count = 0;
        public void setArtist(string artist)
        {
            if(count>3)
            {
                MyMixArtist_label.Text = MyMixArtist_label + "...";
            }
            else
            {
                MyMixArtist_label.Text += MyMixArtist_label.Text + ", ";
                count++;

            }


        }
        public void setPlaylistCover(Image image)
        {
            MyMixCover_pictureBox.BackgroundImage = image;
        }
        public Image getPlaylistCover()
        {
            return MyMixCover_pictureBox.BackgroundImage;
        }
    }
}
