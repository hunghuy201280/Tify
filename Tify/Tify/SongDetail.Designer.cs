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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.songDetail_leftPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.volume_trackBar = new MediaSlider.MediaSlider();
            this.volume_detailButton = new System.Windows.Forms.Button();
            this.mediaSlider2 = new MediaSlider.MediaSlider();
            this.panel7 = new System.Windows.Forms.Panel();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.currentTime_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.playingFrom_label = new System.Windows.Forms.Label();
            this.artist_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.songCover_detailPictureBox = new System.Windows.Forms.PictureBox();
            this.songDetailMinimize_button = new System.Windows.Forms.Button();
            this.songDetaillImageList = new System.Windows.Forms.ImageList(this.components);
            this.songDetail_rightPanel = new System.Windows.Forms.Panel();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.songDetail_leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover_detailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.27438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.72562F));
            this.tableLayoutPanel1.Controls.Add(this.songDetail_leftPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.songDetail_rightPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.panel4.Controls.Add(this.progressBar);
            this.panel4.Controls.Add(this.volume_trackBar);
            this.panel4.Controls.Add(this.volume_detailButton);
            this.panel4.Controls.Add(this.mediaSlider2);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.currentTime_label);
            this.panel4.Controls.Add(this.duration_label);
            this.panel4.Controls.Add(this.playingFrom_label);
            this.panel4.Controls.Add(this.artist_label);
            this.panel4.Controls.Add(this.title_label);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(1, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 200);
            this.panel4.TabIndex = 15;
            // 
            // progressBar
            // 
            this.progressBar.EditValue = 50;
            this.progressBar.Location = new System.Drawing.Point(3, 64);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.progressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressBar.Properties.EndColor = System.Drawing.Color.Empty;
            this.progressBar.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.progressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBar.Properties.StartColor = System.Drawing.Color.Empty;
            this.progressBar.Size = new System.Drawing.Size(731, 5);
            this.progressBar.TabIndex = 15;
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            this.progressBar.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
            this.progressBar.MouseHover += new System.EventHandler(this.progressBar_MouseHover);
            this.progressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseMove);
            this.progressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseUp);
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Animated = false;
            this.volume_trackBar.AnimationSize = 0.2F;
            this.volume_trackBar.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.volume_trackBar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.volume_trackBar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.volume_trackBar.AutoSize = true;
            this.volume_trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))));
            this.volume_trackBar.BackGroundImage = null;
            this.volume_trackBar.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volume_trackBar.ButtonBorderColor = System.Drawing.Color.Black;
            this.volume_trackBar.ButtonColor = System.Drawing.Color.White;
            this.volume_trackBar.ButtonCornerRadius = ((uint)(4u));
            this.volume_trackBar.ButtonSize = new System.Drawing.Size(11, 11);
            this.volume_trackBar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.volume_trackBar.ContextMenuStrip = null;
            this.volume_trackBar.LargeChange = 2;
            this.volume_trackBar.Location = new System.Drawing.Point(577, 126);
            this.volume_trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Minimum = 0;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volume_trackBar.ShowButtonOnHover = false;
            this.volume_trackBar.Size = new System.Drawing.Size(130, 12);
            this.volume_trackBar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.volume_trackBar.SmallChange = 1;
            this.volume_trackBar.SmoothScrolling = false;
            this.volume_trackBar.TabIndex = 14;
            this.volume_trackBar.TickColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_trackBar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.volume_trackBar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volume_trackBar.TrackDepth = 3;
            this.volume_trackBar.TrackFillColor = System.Drawing.Color.White;
            this.volume_trackBar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.volume_trackBar.TrackShadow = false;
            this.volume_trackBar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.volume_trackBar.Value = 0;
            this.volume_trackBar.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.volume_trackBar_ValueChanged);
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
            this.volume_detailButton.Click += new System.EventHandler(this.volume_detailButton_Click);
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
            this.panel7.Controls.Add(this.shuffle_button);
            this.panel7.Controls.Add(this.previous_button);
            this.panel7.Controls.Add(this.next_button);
            this.panel7.Controls.Add(this.pause_button);
            this.panel7.Location = new System.Drawing.Point(248, 91);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 100);
            this.panel7.TabIndex = 12;
            // 
            // shuffle_button
            // 
            this.shuffle_button.BackColor = System.Drawing.Color.Transparent;
            this.shuffle_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shuffle_button.BackgroundImage")));
            this.shuffle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shuffle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffle_button.FlatAppearance.BorderSize = 0;
            this.shuffle_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shuffle_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shuffle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffle_button.Location = new System.Drawing.Point(6, 33);
            this.shuffle_button.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(28, 32);
            this.shuffle_button.TabIndex = 11;
            this.shuffle_button.Tag = "on";
            this.shuffle_button.UseVisualStyleBackColor = false;
            this.shuffle_button.Click += new System.EventHandler(this.shuffle_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.BackColor = System.Drawing.Color.Transparent;
            this.previous_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous_button.BackgroundImage")));
            this.previous_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous_button.FlatAppearance.BorderSize = 0;
            this.previous_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previous_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_button.Location = new System.Drawing.Point(69, 32);
            this.previous_button.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(28, 32);
            this.previous_button.TabIndex = 10;
            this.previous_button.UseVisualStyleBackColor = false;
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.Transparent;
            this.next_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_button.BackgroundImage")));
            this.next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button.FlatAppearance.BorderSize = 0;
            this.next_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Location = new System.Drawing.Point(207, 32);
            this.next_button.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(28, 32);
            this.next_button.TabIndex = 9;
            this.next_button.UseVisualStyleBackColor = false;
            // 
            // pause_button
            // 
            this.pause_button.BackColor = System.Drawing.Color.Transparent;
            this.pause_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_button.BackgroundImage")));
            this.pause_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause_button.FlatAppearance.BorderSize = 0;
            this.pause_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pause_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pause_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_button.Location = new System.Drawing.Point(132, 20);
            this.pause_button.Margin = new System.Windows.Forms.Padding(0);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(40, 50);
            this.pause_button.TabIndex = 8;
            this.pause_button.Tag = "pause";
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // currentTime_label
            // 
            this.currentTime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime_label.AutoSize = true;
            this.currentTime_label.BackColor = System.Drawing.Color.Transparent;
            this.currentTime_label.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.currentTime_label.Location = new System.Drawing.Point(10, 89);
            this.currentTime_label.Margin = new System.Windows.Forms.Padding(0);
            this.currentTime_label.Name = "currentTime_label";
            this.currentTime_label.Size = new System.Drawing.Size(50, 19);
            this.currentTime_label.TabIndex = 11;
            this.currentTime_label.Text = "0:14 /";
            // 
            // duration_label
            // 
            this.duration_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duration_label.AutoSize = true;
            this.duration_label.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.duration_label.Location = new System.Drawing.Point(51, 89);
            this.duration_label.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(44, 19);
            this.duration_label.TabIndex = 10;
            this.duration_label.Text = " 3:23";
            // 
            // playingFrom_label
            // 
            this.playingFrom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playingFrom_label.AutoSize = true;
            this.playingFrom_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingFrom_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.playingFrom_label.Location = new System.Drawing.Point(11, 45);
            this.playingFrom_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.playingFrom_label.Name = "playingFrom_label";
            this.playingFrom_label.Size = new System.Drawing.Size(148, 16);
            this.playingFrom_label.TabIndex = 4;
            this.playingFrom_label.Text = "Playing from:  Yorushika";
            // 
            // artist_label
            // 
            this.artist_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.artist_label.AutoSize = true;
            this.artist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.artist_label.Location = new System.Drawing.Point(11, 24);
            this.artist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(64, 16);
            this.artist_label.TabIndex = 3;
            this.artist_label.Text = "Yorushika";
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(11, 7);
            this.title_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(140, 17);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Hole In The Heart";
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SongDetail";
            this.Text = "SongDetail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.songDetail_leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songCover_detailPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel songDetail_leftPanel;
        public System.Windows.Forms.Panel panel4;
        public MediaSlider.MediaSlider volume_trackBar;
        public System.Windows.Forms.Button volume_detailButton;
        public MediaSlider.MediaSlider mediaSlider2;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button shuffle_button;
        public System.Windows.Forms.Button previous_button;
        public System.Windows.Forms.Button next_button;
        public System.Windows.Forms.Button pause_button;
        public System.Windows.Forms.Label playingFrom_label;
        public System.Windows.Forms.Label artist_label;
        public System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox songCover_detailPictureBox;
        private System.Windows.Forms.Button songDetailMinimize_button;
        private System.Windows.Forms.Panel songDetail_rightPanel;
        private System.Windows.Forms.ImageList songDetaillImageList;
        private System.Windows.Forms.ToolTip myToolTip;
        public System.Windows.Forms.Label currentTime_label;
        public System.Windows.Forms.Label duration_label;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
    }
}