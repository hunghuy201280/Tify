using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightClickCreatePlayList
{
    public partial class RightClickCreatePlayList: UserControl
    {
        public RightClickCreatePlayList()
        {
            InitializeComponent();
        }
        public string getPlaylistName()
        {
            return PlayList_Name.Text;
        }
        public void setPlaylistName(string name)
        {
            PlayList_Name.Text = name;
        }
        public void SetPictureBox(Image input)
        {
            input=pictureBox1.Image;
        
        }
        public Image GetPictureBox()
        {
            return pictureBox1.Image;
        }
        public Button GetPlayNow()
        {
            return PlayList_PlayNow;
        }
        public Button GetShuffle()
        {
            return PlayList_Shuffle;
        }
        public Button GetPlayNext()
        {
            return PlayList_PlayNext;
        }
        public Button GetAddToPlayList()
        {
            return PlayList_AddToPlayList;
        }
        public Button GetEditPlayList()
        {
            return PlayList_EditPL;
        }
        public Button GetDelete()
        {
            return PlayList_Delete; 
        }
        public void setcntItems(int cnt,int time)
        {
            PlayList_cntItems.Text = cnt.ToString() + "items "+"("+time+")";
        }

    }
}
