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
            this.home_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.recentlyPlayed = new Tify.HomeItemContainer();
            this.mixesForYou = new Tify.HomeItemContainer();
            this.theCharts = new Tify.HomeItemContainer();
            this.suggestSong1 = new Tify.SuggestSong();
            this.suggestSong2 = new Tify.SuggestSong();
            this.home_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_flowLayoutPanel
            // 
            this.home_flowLayoutPanel.AutoScroll = true;
            this.home_flowLayoutPanel.Controls.Add(this.button1);
            this.home_flowLayoutPanel.Controls.Add(this.recentlyPlayed);
            this.home_flowLayoutPanel.Controls.Add(this.mixesForYou);
            this.home_flowLayoutPanel.Controls.Add(this.theCharts);
            this.home_flowLayoutPanel.Controls.Add(this.suggestSong1);
            this.home_flowLayoutPanel.Controls.Add(this.suggestSong2);
            this.home_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.home_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.home_flowLayoutPanel.Name = "home_flowLayoutPanel";
            this.home_flowLayoutPanel.Size = new System.Drawing.Size(1191, 718);
            this.home_flowLayoutPanel.TabIndex = 1;
            this.home_flowLayoutPanel.WrapContents = false;
            this.home_flowLayoutPanel.Resize += new System.EventHandler(this.home_flowLayoutPanel_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recentlyPlayed
            // 
            this.recentlyPlayed.BackColor = System.Drawing.Color.Black;
            this.recentlyPlayed.Location = new System.Drawing.Point(3, 32);
            this.recentlyPlayed.Name = "recentlyPlayed";
            this.recentlyPlayed.Size = new System.Drawing.Size(1045, 285);
            this.recentlyPlayed.TabIndex = 2;
            // 
            // mixesForYou
            // 
            this.mixesForYou.BackColor = System.Drawing.Color.Black;
            this.mixesForYou.Location = new System.Drawing.Point(3, 323);
            this.mixesForYou.Name = "mixesForYou";
            this.mixesForYou.Size = new System.Drawing.Size(1045, 285);
            this.mixesForYou.TabIndex = 3;
            // 
            // theCharts
            // 
            this.theCharts.BackColor = System.Drawing.Color.Black;
            this.theCharts.Location = new System.Drawing.Point(3, 614);
            this.theCharts.Name = "theCharts";
            this.theCharts.Size = new System.Drawing.Size(1045, 285);
            this.theCharts.TabIndex = 4;
            // 
            // suggestSong1
            // 
            this.suggestSong1.BackColor = System.Drawing.Color.Black;
            this.suggestSong1.Location = new System.Drawing.Point(3, 905);
            this.suggestSong1.Name = "suggestSong1";
            this.suggestSong1.Size = new System.Drawing.Size(1045, 340);
            this.suggestSong1.TabIndex = 5;
            // 
            // suggestSong2
            // 
            this.suggestSong2.BackColor = System.Drawing.Color.Black;
            this.suggestSong2.Location = new System.Drawing.Point(3, 1251);
            this.suggestSong2.Name = "suggestSong2";
            this.suggestSong2.Size = new System.Drawing.Size(1045, 340);
            this.suggestSong2.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1191, 718);
            this.Controls.Add(this.home_flowLayoutPanel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.home_flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel home_flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private HomeItemContainer recentlyPlayed;
        private HomeItemContainer mixesForYou;
        private HomeItemContainer theCharts;
        private SuggestSong suggestSong1;
        private SuggestSong suggestSong2;
    }
}