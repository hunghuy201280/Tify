namespace Tify
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.chart_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.suggestSong1 = new Tify.SuggestSong();
            this.suggestSong2 = new Tify.SuggestSong();
            this.theCharts = new Tify.HomeItemContainer();
            this.mixesForYou = new Tify.HomeItemContainer();
            this.recentlyPlayed = new Tify.HomeItemContainer();
            this.SuspendLayout();
            // 
            // chart_ImageList
            // 
            this.chart_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chart_ImageList.ImageStream")));
            this.chart_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.chart_ImageList.Images.SetKeyName(0, "chart_Vietnam.jpg");
            this.chart_ImageList.Images.SetKeyName(1, "chart_USUK.jpg");
            this.chart_ImageList.Images.SetKeyName(2, "Chart_China.jpg");
            this.chart_ImageList.Images.SetKeyName(3, "chart_Korea.jpg");
            this.chart_ImageList.Images.SetKeyName(4, "chart_JP.jpg");
            // 
            // suggestSong1
            // 
            this.suggestSong1.BackColor = System.Drawing.Color.Black;
            this.suggestSong1.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestSong1.Location = new System.Drawing.Point(0, 1294);
            this.suggestSong1.Name = "suggestSong1";
            this.suggestSong1.Size = new System.Drawing.Size(1412, 340);
            this.suggestSong1.TabIndex = 5;
            // 
            // suggestSong2
            // 
            this.suggestSong2.BackColor = System.Drawing.Color.Black;
            this.suggestSong2.Dock = System.Windows.Forms.DockStyle.Top;
            this.suggestSong2.Location = new System.Drawing.Point(0, 960);
            this.suggestSong2.Name = "suggestSong2";
            this.suggestSong2.Size = new System.Drawing.Size(1412, 334);
            this.suggestSong2.TabIndex = 6;
            // 
            // theCharts
            // 
            this.theCharts.BackColor = System.Drawing.Color.Black;
            this.theCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.theCharts.Location = new System.Drawing.Point(0, 640);
            this.theCharts.MinimumSize = new System.Drawing.Size(0, 320);
            this.theCharts.Name = "theCharts";
            this.theCharts.Size = new System.Drawing.Size(1412, 320);
            this.theCharts.TabIndex = 4;
            // 
            // mixesForYou
            // 
            this.mixesForYou.BackColor = System.Drawing.Color.Black;
            this.mixesForYou.Dock = System.Windows.Forms.DockStyle.Top;
            this.mixesForYou.Location = new System.Drawing.Point(0, 320);
            this.mixesForYou.MinimumSize = new System.Drawing.Size(0, 320);
            this.mixesForYou.Name = "mixesForYou";
            this.mixesForYou.Size = new System.Drawing.Size(1412, 320);
            this.mixesForYou.TabIndex = 3;
            // 
            // recentlyPlayed
            // 
            this.recentlyPlayed.BackColor = System.Drawing.Color.Black;
            this.recentlyPlayed.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentlyPlayed.Location = new System.Drawing.Point(0, 0);
            this.recentlyPlayed.MinimumSize = new System.Drawing.Size(0, 320);
            this.recentlyPlayed.Name = "recentlyPlayed";
            this.recentlyPlayed.Size = new System.Drawing.Size(1412, 320);
            this.recentlyPlayed.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1429, 718);
            this.Controls.Add(this.suggestSong1);
            this.Controls.Add(this.suggestSong2);
            this.Controls.Add(this.theCharts);
            this.Controls.Add(this.mixesForYou);
            this.Controls.Add(this.recentlyPlayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private HomeItemContainer mixesForYou;
        private HomeItemContainer theCharts;
        private SuggestSong suggestSong1;
        private SuggestSong suggestSong2;
        public HomeItemContainer recentlyPlayed;
        private System.Windows.Forms.ImageList chart_ImageList;
    }
}