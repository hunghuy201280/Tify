namespace Tify
{
    partial class SongDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongDetail));
            this.songDetail_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.songDetail_leftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.volume_detailTrackBar = new MediaSlider.MediaSlider();
            this.progressBar_detail = new System.Windows.Forms.ProgressBar();
            this.volume_detailButton = new System.Windows.Forms.Button();
            this.mediaSlider2 = new MediaSlider.MediaSlider();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pause_detailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.songCover_detailPictureBox = new System.Windows.Forms.PictureBox();
            this.songDetailMinimize_button = new System.Windows.Forms.Button();
            this.songDetaillImageList = new System.Windows.Forms.ImageList(this.components);
            this.songDetail_rightPanel = new System.Windows.Forms.Panel();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.songDetail_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.songDetail_leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover_detailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // songDetail_panel
            // 
            this.songDetail_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.songDetail_panel.Controls.Add(this.tableLayoutPanel1);
            this.songDetail_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songDetail_panel.Location = new System.Drawing.Point(0, 0);
            this.songDetail_panel.Name = "songDetail_panel";
            this.songDetail_panel.Size = new System.Drawing.Size(1094, 757);
            this.songDetail_panel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.27438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.72562F));
            this.tableLayoutPanel1.Controls.Add(this.songDetail_leftPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.songDetail_rightPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 757);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // songDetail_leftPanel
            // 
            this.songDetail_leftPanel.Controls.Add(this.panel4);
            this.songDetail_leftPanel.Controls.Add(this.songCover_detailPictureBox);
            this.songDetail_leftPanel.Controls.Add(this.songDetailMinimize_button);
            this.songDetail_leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songDetail_leftPanel.Location = new System.Drawing.Point(3, 3);
            this.songDetail_leftPanel.Name = "songDetail_leftPanel";
            this.songDetail_leftPanel.Size = new System.Drawing.Size(729, 751);
            this.songDetail_leftPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.panel4.Controls.Add(this.volume_detailTrackBar);
            this.panel4.Controls.Add(this.progressBar_detail);
            this.panel4.Controls.Add(this.volume_detailButton);
            this.panel4.Controls.Add(this.mediaSlider2);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 200);
            this.panel4.TabIndex = 15;
            // 
            // volume_detailTrackBar
            // 
            this.volume_detailTrackBar.Animated = false;
            this.volume_detailTrackBar.AnimationSize = 0.2F;
            this.volume_detailTrackBar.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.volume_detailTrackBar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.volume_detailTrackBar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.volume_detailTrackBar.AutoSize = true;
            this.volume_detailTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.volume_detailTrackBar.BackGroundImage = null;
            this.volume_detailTrackBar.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volume_detailTrackBar.ButtonBorderColor = System.Drawing.Color.Black;
            this.volume_detailTrackBar.ButtonColor = System.Drawing.Color.White;
            this.volume_detailTrackBar.ButtonCornerRadius = ((uint)(4u));
            this.volume_detailTrackBar.ButtonSize = new System.Drawing.Size(11, 11);
            this.volume_detailTrackBar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.volume_detailTrackBar.ContextMenuStrip = null;
            this.volume_detailTrackBar.LargeChange = 2;
            this.volume_detailTrackBar.Location = new System.Drawing.Point(577, 126);
            this.volume_detailTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.volume_detailTrackBar.Maximum = 100;
            this.volume_detailTrackBar.Minimum = 0;
            this.volume_detailTrackBar.Name = "volume_detailTrackBar";
            this.volume_detailTrackBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volume_detailTrackBar.ShowButtonOnHover = false;
            this.volume_detailTrackBar.Size = new System.Drawing.Size(130, 12);
            this.volume_detailTrackBar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.volume_detailTrackBar.SmallChange = 1;
            this.volume_detailTrackBar.SmoothScrolling = false;
            this.volume_detailTrackBar.TabIndex = 14;
            this.volume_detailTrackBar.TickColor = System.Drawing.Color.DarkGray;
            this.volume_detailTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_detailTrackBar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.volume_detailTrackBar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volume_detailTrackBar.TrackDepth = 3;
            this.volume_detailTrackBar.TrackFillColor = System.Drawing.Color.White;
            this.volume_detailTrackBar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.volume_detailTrackBar.TrackShadow = false;
            this.volume_detailTrackBar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.volume_detailTrackBar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.volume_detailTrackBar.Value = 0;
            // 
            // progressBar_detail
            // 
            this.progressBar_detail.Location = new System.Drawing.Point(3, 72);
            this.progressBar_detail.Name = "progressBar_detail";
            this.progressBar_detail.Size = new System.Drawing.Size(731, 5);
            this.progressBar_detail.TabIndex = 15;
            // 
            // volume_detailButton
            // 
            this.volume_detailButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volume_detailButton.BackColor = System.Drawing.Color.Transparent;
            this.volume_detailButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_detailButton.BackgroundImage")));
            this.volume_detailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volume_detailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_detailButton.FlatAppearance.BorderSize = 0;
            this.volume_detailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volume_detailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volume_detailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume_detailButton.Location = new System.Drawing.Point(523, 115);
            this.volume_detailButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.volume_detailButton.Name = "volume_detailButton";
            this.volume_detailButton.Size = new System.Drawing.Size(44, 40);
            this.volume_detailButton.TabIndex = 14;
            this.volume_detailButton.Tag = "on";
            this.volume_detailButton.UseVisualStyleBackColor = false;
            // 
            // mediaSlider2
            // 
            this.mediaSlider2.Animated = false;
            this.mediaSlider2.AnimationSize = 0.2F;
            this.mediaSlider2.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.mediaSlider2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.mediaSlider2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.mediaSlider2.AutoSize = true;
            this.mediaSlider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.mediaSlider2.BackGroundImage = null;
            this.mediaSlider2.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mediaSlider2.ButtonBorderColor = System.Drawing.Color.Black;
            this.mediaSlider2.ButtonColor = System.Drawing.Color.White;
            this.mediaSlider2.ButtonCornerRadius = ((uint)(4u));
            this.mediaSlider2.ButtonSize = new System.Drawing.Size(11, 11);
            this.mediaSlider2.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.mediaSlider2.ContextMenuStrip = null;
            this.mediaSlider2.LargeChange = 2;
            this.mediaSlider2.Location = new System.Drawing.Point(951, 48);
            this.mediaSlider2.Margin = new System.Windows.Forms.Padding(0);
            this.mediaSlider2.Maximum = 100;
            this.mediaSlider2.Minimum = 0;
            this.mediaSlider2.Name = "mediaSlider2";
            this.mediaSlider2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.mediaSlider2.ShowButtonOnHover = false;
            this.mediaSlider2.Size = new System.Drawing.Size(130, 12);
            this.mediaSlider2.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.mediaSlider2.SmallChange = 1;
            this.mediaSlider2.SmoothScrolling = false;
            this.mediaSlider2.TabIndex = 13;
            this.mediaSlider2.TickColor = System.Drawing.Color.DarkGray;
            this.mediaSlider2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mediaSlider2.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.mediaSlider2.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mediaSlider2.TrackDepth = 3;
            this.mediaSlider2.TrackFillColor = System.Drawing.Color.White;
            this.mediaSlider2.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.mediaSlider2.TrackShadow = false;
            this.mediaSlider2.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.mediaSlider2.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.mediaSlider2.Value = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.pause_detailButton);
            this.panel7.Location = new System.Drawing.Point(248, 91);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 100);
            this.panel7.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 32);
            this.button2.TabIndex = 11;
            this.button2.Tag = "on";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(69, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 32);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(207, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 32);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pause_detailButton
            // 
            this.pause_detailButton.BackColor = System.Drawing.Color.Transparent;
            this.pause_detailButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_detailButton.BackgroundImage")));
            this.pause_detailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause_detailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_detailButton.FlatAppearance.BorderSize = 0;
            this.pause_detailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pause_detailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pause_detailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_detailButton.Location = new System.Drawing.Point(132, 20);
            this.pause_detailButton.Margin = new System.Windows.Forms.Padding(0);
            this.pause_detailButton.Name = "pause_detailButton";
            this.pause_detailButton.Size = new System.Drawing.Size(40, 50);
            this.pause_detailButton.TabIndex = 8;
            this.pause_detailButton.Tag = "pause";
            this.pause_detailButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(10, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "0:14 /";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = " 3:23";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Playing from:  Yorushika";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(11, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yorushika";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hole In The Heart";
            // 
            // songCover_detailPictureBox
            // 
            this.songCover_detailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songCover_detailPictureBox.Image")));
            this.songCover_detailPictureBox.Location = new System.Drawing.Point(185, 94);
            this.songCover_detailPictureBox.Name = "songCover_detailPictureBox";
            this.songCover_detailPictureBox.Size = new System.Drawing.Size(360, 360);
            this.songCover_detailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songCover_detailPictureBox.TabIndex = 2;
            this.songCover_detailPictureBox.TabStop = false;
            // 
            // songDetailMinimize_button
            // 
            this.songDetailMinimize_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songDetailMinimize_button.FlatAppearance.BorderSize = 0;
            this.songDetailMinimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songDetailMinimize_button.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDetailMinimize_button.ForeColor = System.Drawing.Color.White;
            this.songDetailMinimize_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songDetailMinimize_button.ImageIndex = 0;
            this.songDetailMinimize_button.ImageList = this.songDetaillImageList;
            this.songDetailMinimize_button.Location = new System.Drawing.Point(15, 11);
            this.songDetailMinimize_button.Margin = new System.Windows.Forms.Padding(5);
            this.songDetailMinimize_button.Name = "songDetailMinimize_button";
            this.songDetailMinimize_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.songDetailMinimize_button.Size = new System.Drawing.Size(117, 37);
            this.songDetailMinimize_button.TabIndex = 1;
            this.songDetailMinimize_button.Text = "Minimized";
            this.songDetailMinimize_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.songDetailMinimize_button.UseVisualStyleBackColor = true;
            this.songDetailMinimize_button.Click += new System.EventHandler(this.songDetailMinimize_button_Click);
            // 
            // songDetaillImageList
            // 
            this.songDetaillImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("songDetaillImageList.ImageStream")));
            this.songDetaillImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.songDetaillImageList.Images.SetKeyName(0, "minimize.png");
            // 
            // songDetail_rightPanel
            // 
            this.songDetail_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songDetail_rightPanel.Location = new System.Drawing.Point(738, 3);
            this.songDetail_rightPanel.Name = "songDetail_rightPanel";
            this.songDetail_rightPanel.Size = new System.Drawing.Size(353, 751);
            this.songDetail_rightPanel.TabIndex = 3;
            // 
            // SongDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 757);
            this.Controls.Add(this.songDetail_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SongDetail";
            this.Text = "SongDetail";
            this.songDetail_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.songDetail_leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songCover_detailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel songDetail_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel songDetail_leftPanel;
        public System.Windows.Forms.Panel panel4;
        public MediaSlider.MediaSlider volume_detailTrackBar;
        private System.Windows.Forms.ProgressBar progressBar_detail;
        public System.Windows.Forms.Button volume_detailButton;
        public MediaSlider.MediaSlider mediaSlider2;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button pause_detailButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox songCover_detailPictureBox;
        private System.Windows.Forms.Button songDetailMinimize_button;
        private System.Windows.Forms.Panel songDetail_rightPanel;
        private System.Windows.Forms.ImageList songDetaillImageList;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}