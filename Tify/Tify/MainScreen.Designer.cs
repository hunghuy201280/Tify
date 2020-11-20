namespace Tify
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.player_panel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.volume_button = new System.Windows.Forms.Button();
            this.volume_trackBar = new MediaSlider.MediaSlider();
            this.play_pause_panel = new System.Windows.Forms.Panel();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.currentTime_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.playingFrom_label = new System.Windows.Forms.Label();
            this.artist_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.songImg_pictureBox = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.createNewPlaylist_button = new System.Windows.Forms.Button();
            this.createPlaylist_imgList = new System.Windows.Forms.ImageList(this.components);
            this.myPlaylist_label = new System.Windows.Forms.Label();
            this.account_button = new System.Windows.Forms.Button();
            this.menu_imgList = new System.Windows.Forms.ImageList(this.components);
            this.myCollection_label = new System.Windows.Forms.Label();
            this.home_pictureBox = new System.Windows.Forms.PictureBox();
            this.myMix_button = new System.Windows.Forms.Button();
            this.albums_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.playlist_button = new System.Windows.Forms.Button();
            this.artists_button = new System.Windows.Forms.Button();
            this.tracks_button = new System.Windows.Forms.Button();
            this.searchBar_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBar_textBox = new System.Windows.Forms.TextBox();
            this.searchBar_icon = new System.Windows.Forms.PictureBox();
            this.childForm_panel = new System.Windows.Forms.Panel();
            this.player_imageList = new System.Windows.Forms.ImageList(this.components);
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.onesec = new System.Windows.Forms.Timer(this.components);
            this.player_panel.SuspendLayout();
            this.play_pause_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songImg_pictureBox)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).BeginInit();
            this.searchBar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.player_panel.Controls.Add(this.progressBar);
            this.player_panel.Controls.Add(this.volume_button);
            this.player_panel.Controls.Add(this.volume_trackBar);
            this.player_panel.Controls.Add(this.play_pause_panel);
            this.player_panel.Controls.Add(this.currentTime_label);
            this.player_panel.Controls.Add(this.duration_label);
            this.player_panel.Controls.Add(this.playingFrom_label);
            this.player_panel.Controls.Add(this.artist_label);
            this.player_panel.Controls.Add(this.title_label);
            this.player_panel.Controls.Add(this.songImg_pictureBox);
            this.player_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.player_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_panel.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_panel.Location = new System.Drawing.Point(0, 784);
            this.player_panel.Margin = new System.Windows.Forms.Padding(4);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(1463, 123);
            this.player_panel.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1463, 6);
            this.progressBar.TabIndex = 15;
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            this.progressBar.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
            this.progressBar.MouseHover += new System.EventHandler(this.progressBar_MouseHover);
            // 
            // volume_button
            // 
            this.volume_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volume_button.BackColor = System.Drawing.Color.Transparent;
            this.volume_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_button.BackgroundImage")));
            this.volume_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volume_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_button.FlatAppearance.BorderSize = 0;
            this.volume_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.volume_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.volume_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume_button.Location = new System.Drawing.Point(1196, 37);
            this.volume_button.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.volume_button.Name = "volume_button";
            this.volume_button.Size = new System.Drawing.Size(59, 49);
            this.volume_button.TabIndex = 14;
            this.volume_button.Tag = "on";
            this.myToolTip.SetToolTip(this.volume_button, "Volume");
            this.volume_button.UseVisualStyleBackColor = false;
            this.volume_button.Click += new System.EventHandler(this.volume_button_Click);
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
            this.volume_trackBar.ButtonSize = new System.Drawing.Size(14, 14);
            this.volume_trackBar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.volume_trackBar.ContextMenuStrip = null;
            this.volume_trackBar.LargeChange = 2;
            this.volume_trackBar.Location = new System.Drawing.Point(1268, 55);
            this.volume_trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Minimum = 0;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volume_trackBar.ShowButtonOnHover = false;
            this.volume_trackBar.Size = new System.Drawing.Size(173, 14);
            this.volume_trackBar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.volume_trackBar.SmallChange = 1;
            this.volume_trackBar.SmoothScrolling = false;
            this.volume_trackBar.TabIndex = 13;
            this.volume_trackBar.TickColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_trackBar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.volume_trackBar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volume_trackBar.TrackDepth = 6;
            this.volume_trackBar.TrackFillColor = System.Drawing.Color.White;
            this.volume_trackBar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.volume_trackBar.TrackShadow = false;
            this.volume_trackBar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.volume_trackBar.Value = 0;
            this.volume_trackBar.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.volume_trackBar_ValueChanged);
            // 
            // play_pause_panel
            // 
            this.play_pause_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play_pause_panel.Controls.Add(this.shuffle_button);
            this.play_pause_panel.Controls.Add(this.previous_button);
            this.play_pause_panel.Controls.Add(this.next_button);
            this.play_pause_panel.Controls.Add(this.pause_button);
            this.play_pause_panel.Location = new System.Drawing.Point(575, 0);
            this.play_pause_panel.Margin = new System.Windows.Forms.Padding(4);
            this.play_pause_panel.Name = "play_pause_panel";
            this.play_pause_panel.Size = new System.Drawing.Size(313, 123);
            this.play_pause_panel.TabIndex = 12;
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
            this.shuffle_button.Location = new System.Drawing.Point(8, 41);
            this.shuffle_button.Margin = new System.Windows.Forms.Padding(0, 0, 47, 0);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.Size = new System.Drawing.Size(37, 39);
            this.shuffle_button.TabIndex = 11;
            this.shuffle_button.Tag = "on";
            this.myToolTip.SetToolTip(this.shuffle_button, "Shuffle");
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
            this.previous_button.Location = new System.Drawing.Point(92, 39);
            this.previous_button.Margin = new System.Windows.Forms.Padding(0, 0, 47, 0);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(37, 39);
            this.previous_button.TabIndex = 10;
            this.myToolTip.SetToolTip(this.previous_button, "Previous");
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
            this.next_button.Location = new System.Drawing.Point(276, 39);
            this.next_button.Margin = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(37, 39);
            this.next_button.TabIndex = 9;
            this.myToolTip.SetToolTip(this.next_button, "Next");
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
            this.pause_button.Location = new System.Drawing.Point(176, 25);
            this.pause_button.Margin = new System.Windows.Forms.Padding(0);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(53, 62);
            this.pause_button.TabIndex = 8;
            this.pause_button.Tag = "pause";
            this.myToolTip.SetToolTip(this.pause_button, "Pause");
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
            this.currentTime_label.Location = new System.Drawing.Point(1051, 49);
            this.currentTime_label.Margin = new System.Windows.Forms.Padding(0);
            this.currentTime_label.Name = "currentTime_label";
            this.currentTime_label.Size = new System.Drawing.Size(60, 24);
            this.currentTime_label.TabIndex = 11;
            this.currentTime_label.Text = "0:14 /";
            // 
            // duration_label
            // 
            this.duration_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duration_label.AutoSize = true;
            this.duration_label.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.duration_label.Location = new System.Drawing.Point(1105, 49);
            this.duration_label.Margin = new System.Windows.Forms.Padding(4, 0, 33, 0);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(53, 24);
            this.duration_label.TabIndex = 10;
            this.duration_label.Text = " 3:23";
            // 
            // playingFrom_label
            // 
            this.playingFrom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playingFrom_label.AutoSize = true;
            this.playingFrom_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingFrom_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.playingFrom_label.Location = new System.Drawing.Point(139, 75);
            this.playingFrom_label.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.playingFrom_label.Name = "playingFrom_label";
            this.playingFrom_label.Size = new System.Drawing.Size(193, 22);
            this.playingFrom_label.TabIndex = 4;
            this.playingFrom_label.Text = "Playing from:  Yorushika";
            // 
            // artist_label
            // 
            this.artist_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.artist_label.AutoSize = true;
            this.artist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.artist_label.Location = new System.Drawing.Point(139, 49);
            this.artist_label.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(83, 22);
            this.artist_label.TabIndex = 3;
            this.artist_label.Text = "Yorushika";
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(139, 28);
            this.title_label.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(173, 23);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Hole In The Heart";
            // 
            // songImg_pictureBox
            // 
            this.songImg_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("songImg_pictureBox.Image")));
            this.songImg_pictureBox.Location = new System.Drawing.Point(24, 21);
            this.songImg_pictureBox.Margin = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.songImg_pictureBox.Name = "songImg_pictureBox";
            this.songImg_pictureBox.Size = new System.Drawing.Size(87, 80);
            this.songImg_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songImg_pictureBox.TabIndex = 0;
            this.songImg_pictureBox.TabStop = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.menu_panel.Controls.Add(this.createNewPlaylist_button);
            this.menu_panel.Controls.Add(this.myPlaylist_label);
            this.menu_panel.Controls.Add(this.account_button);
            this.menu_panel.Controls.Add(this.myCollection_label);
            this.menu_panel.Controls.Add(this.home_pictureBox);
            this.menu_panel.Controls.Add(this.myMix_button);
            this.menu_panel.Controls.Add(this.albums_button);
            this.menu_panel.Controls.Add(this.home_button);
            this.menu_panel.Controls.Add(this.playlist_button);
            this.menu_panel.Controls.Add(this.artists_button);
            this.menu_panel.Controls.Add(this.tracks_button);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Margin = new System.Windows.Forms.Padding(4);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(320, 784);
            this.menu_panel.TabIndex = 2;
            this.menu_panel.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.menu_panel.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // createNewPlaylist_button
            // 
            this.createNewPlaylist_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewPlaylist_button.FlatAppearance.BorderSize = 0;
            this.createNewPlaylist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.createNewPlaylist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewPlaylist_button.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPlaylist_button.ForeColor = System.Drawing.Color.White;
            this.createNewPlaylist_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewPlaylist_button.ImageIndex = 0;
            this.createNewPlaylist_button.ImageList = this.createPlaylist_imgList;
            this.createNewPlaylist_button.Location = new System.Drawing.Point(12, 623);
            this.createNewPlaylist_button.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.createNewPlaylist_button.Name = "createNewPlaylist_button";
            this.createNewPlaylist_button.Size = new System.Drawing.Size(287, 58);
            this.createNewPlaylist_button.TabIndex = 23;
            this.createNewPlaylist_button.Tag = "Create new playlist";
            this.createNewPlaylist_button.Text = "Create new playlist";
            this.createNewPlaylist_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewPlaylist_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createNewPlaylist_button.UseVisualStyleBackColor = true;
            this.createNewPlaylist_button.Click += new System.EventHandler(this.createNewPlaylist_button_Click);
            this.createNewPlaylist_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.createNewPlaylist_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // createPlaylist_imgList
            // 
            this.createPlaylist_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("createPlaylist_imgList.ImageStream")));
            this.createPlaylist_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.createPlaylist_imgList.Images.SetKeyName(0, "add.png");
            // 
            // myPlaylist_label
            // 
            this.myPlaylist_label.AutoSize = true;
            this.myPlaylist_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPlaylist_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.myPlaylist_label.Location = new System.Drawing.Point(20, 590);
            this.myPlaylist_label.Margin = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.myPlaylist_label.Name = "myPlaylist_label";
            this.myPlaylist_label.Size = new System.Drawing.Size(133, 23);
            this.myPlaylist_label.TabIndex = 22;
            this.myPlaylist_label.Tag = "MY PLAYLIST";
            this.myPlaylist_label.Text = "MY PLAYLIST";
            this.myPlaylist_label.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.myPlaylist_label.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.Transparent;
            this.account_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(128)))), ((int)(((byte)(137)))));
            this.account_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_button.ForeColor = System.Drawing.Color.White;
            this.account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.ImageIndex = 10;
            this.account_button.ImageList = this.menu_imgList;
            this.account_button.Location = new System.Drawing.Point(12, 17);
            this.account_button.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(287, 55);
            this.account_button.TabIndex = 18;
            this.account_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            this.account_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.account_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // menu_imgList
            // 
            this.menu_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menu_imgList.ImageStream")));
            this.menu_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.menu_imgList.Images.SetKeyName(0, "my_mix_white.png");
            this.menu_imgList.Images.SetKeyName(1, "my_mix.png");
            this.menu_imgList.Images.SetKeyName(2, "playlist_white.png");
            this.menu_imgList.Images.SetKeyName(3, "playlist.png");
            this.menu_imgList.Images.SetKeyName(4, "album_white.png");
            this.menu_imgList.Images.SetKeyName(5, "album.png");
            this.menu_imgList.Images.SetKeyName(6, "track_white.png");
            this.menu_imgList.Images.SetKeyName(7, "track.png");
            this.menu_imgList.Images.SetKeyName(8, "artist_white.png");
            this.menu_imgList.Images.SetKeyName(9, "artist.png");
            this.menu_imgList.Images.SetKeyName(10, "account.png");
            this.menu_imgList.Images.SetKeyName(11, "add.png");
            // 
            // myCollection_label
            // 
            this.myCollection_label.AutoSize = true;
            this.myCollection_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCollection_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.myCollection_label.Location = new System.Drawing.Point(20, 197);
            this.myCollection_label.Margin = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.myCollection_label.Name = "myCollection_label";
            this.myCollection_label.Size = new System.Drawing.Size(168, 23);
            this.myCollection_label.TabIndex = 21;
            this.myCollection_label.Tag = "MY COLLECTION";
            this.myCollection_label.Text = "MY COLLECTION";
            this.myCollection_label.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.myCollection_label.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // home_pictureBox
            // 
            this.home_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("home_pictureBox.Image")));
            this.home_pictureBox.Location = new System.Drawing.Point(20, 105);
            this.home_pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.home_pictureBox.Name = "home_pictureBox";
            this.home_pictureBox.Size = new System.Drawing.Size(53, 49);
            this.home_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_pictureBox.TabIndex = 20;
            this.home_pictureBox.TabStop = false;
            this.home_pictureBox.Visible = false;
            this.home_pictureBox.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.home_pictureBox.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // myMix_button
            // 
            this.myMix_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myMix_button.FlatAppearance.BorderSize = 0;
            this.myMix_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.myMix_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myMix_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myMix_button.ForeColor = System.Drawing.Color.White;
            this.myMix_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myMix_button.ImageIndex = 0;
            this.myMix_button.ImageList = this.menu_imgList;
            this.myMix_button.Location = new System.Drawing.Point(12, 242);
            this.myMix_button.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.myMix_button.Name = "myMix_button";
            this.myMix_button.Size = new System.Drawing.Size(287, 58);
            this.myMix_button.TabIndex = 13;
            this.myMix_button.Tag = "My Mix";
            this.myMix_button.Text = "My Mix";
            this.myMix_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myMix_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.myMix_button.UseVisualStyleBackColor = true;
            this.myMix_button.Click += new System.EventHandler(this.menu_button_Click);
            this.myMix_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.myMix_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // albums_button
            // 
            this.albums_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albums_button.FlatAppearance.BorderSize = 0;
            this.albums_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.albums_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albums_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albums_button.ForeColor = System.Drawing.Color.White;
            this.albums_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albums_button.ImageIndex = 4;
            this.albums_button.ImageList = this.menu_imgList;
            this.albums_button.Location = new System.Drawing.Point(12, 368);
            this.albums_button.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.albums_button.Name = "albums_button";
            this.albums_button.Size = new System.Drawing.Size(287, 55);
            this.albums_button.TabIndex = 15;
            this.albums_button.Tag = "Albums";
            this.albums_button.Text = "Albums";
            this.albums_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albums_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.albums_button.UseVisualStyleBackColor = true;
            this.albums_button.Click += new System.EventHandler(this.menu_button_Click);
            this.albums_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.albums_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // home_button
            // 
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.Location = new System.Drawing.Point(12, 98);
            this.home_button.Margin = new System.Windows.Forms.Padding(0, 98, 0, 0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(287, 55);
            this.home_button.TabIndex = 12;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // playlist_button
            // 
            this.playlist_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlist_button.FlatAppearance.BorderSize = 0;
            this.playlist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.playlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlist_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlist_button.ForeColor = System.Drawing.Color.White;
            this.playlist_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlist_button.ImageIndex = 2;
            this.playlist_button.ImageList = this.menu_imgList;
            this.playlist_button.Location = new System.Drawing.Point(12, 306);
            this.playlist_button.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.playlist_button.Name = "playlist_button";
            this.playlist_button.Size = new System.Drawing.Size(287, 55);
            this.playlist_button.TabIndex = 14;
            this.playlist_button.Tag = "Playlist";
            this.playlist_button.Text = "Playlist";
            this.playlist_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playlist_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playlist_button.UseVisualStyleBackColor = true;
            this.playlist_button.Click += new System.EventHandler(this.menu_button_Click);
            this.playlist_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.playlist_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // artists_button
            // 
            this.artists_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artists_button.FlatAppearance.BorderSize = 0;
            this.artists_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.artists_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artists_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artists_button.ForeColor = System.Drawing.Color.White;
            this.artists_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artists_button.ImageIndex = 8;
            this.artists_button.ImageList = this.menu_imgList;
            this.artists_button.Location = new System.Drawing.Point(12, 491);
            this.artists_button.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.artists_button.Name = "artists_button";
            this.artists_button.Size = new System.Drawing.Size(287, 55);
            this.artists_button.TabIndex = 17;
            this.artists_button.Tag = "Artists";
            this.artists_button.Text = "Artists";
            this.artists_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artists_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.artists_button.UseVisualStyleBackColor = true;
            this.artists_button.Click += new System.EventHandler(this.menu_button_Click);
            this.artists_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.artists_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // tracks_button
            // 
            this.tracks_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tracks_button.FlatAppearance.BorderSize = 0;
            this.tracks_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.tracks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tracks_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracks_button.ForeColor = System.Drawing.Color.White;
            this.tracks_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tracks_button.ImageIndex = 6;
            this.tracks_button.ImageList = this.menu_imgList;
            this.tracks_button.Location = new System.Drawing.Point(12, 430);
            this.tracks_button.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tracks_button.Name = "tracks_button";
            this.tracks_button.Size = new System.Drawing.Size(287, 55);
            this.tracks_button.TabIndex = 16;
            this.tracks_button.Tag = "Tracks";
            this.tracks_button.Text = "Tracks";
            this.tracks_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tracks_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tracks_button.UseVisualStyleBackColor = true;
            this.tracks_button.Click += new System.EventHandler(this.menu_button_Click);
            this.tracks_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.tracks_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // searchBar_panel
            // 
            this.searchBar_panel.BackColor = System.Drawing.Color.Black;
            this.searchBar_panel.Controls.Add(this.panel1);
            this.searchBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar_panel.Location = new System.Drawing.Point(320, 0);
            this.searchBar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar_panel.Name = "searchBar_panel";
            this.searchBar_panel.Size = new System.Drawing.Size(1143, 74);
            this.searchBar_panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.searchBar_textBox);
            this.panel1.Controls.Add(this.searchBar_icon);
            this.panel1.Location = new System.Drawing.Point(607, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 49);
            this.panel1.TabIndex = 0;
            // 
            // searchBar_textBox
            // 
            this.searchBar_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.searchBar_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.searchBar_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar_textBox.Font = new System.Drawing.Font("Nationale Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(162)))), ((int)(((byte)(166)))));
            this.searchBar_textBox.Location = new System.Drawing.Point(53, 0);
            this.searchBar_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar_textBox.Name = "searchBar_textBox";
            this.searchBar_textBox.Size = new System.Drawing.Size(467, 46);
            this.searchBar_textBox.TabIndex = 2;
            this.searchBar_textBox.Text = "Search";
            // 
            // searchBar_icon
            // 
            this.searchBar_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBar_icon.Image = ((System.Drawing.Image)(resources.GetObject("searchBar_icon.Image")));
            this.searchBar_icon.Location = new System.Drawing.Point(0, 0);
            this.searchBar_icon.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar_icon.Name = "searchBar_icon";
            this.searchBar_icon.Size = new System.Drawing.Size(53, 49);
            this.searchBar_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBar_icon.TabIndex = 1;
            this.searchBar_icon.TabStop = false;
            // 
            // childForm_panel
            // 
            this.childForm_panel.AutoScroll = true;
            this.childForm_panel.BackColor = System.Drawing.Color.Black;
            this.childForm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childForm_panel.ForeColor = System.Drawing.Color.Coral;
            this.childForm_panel.Location = new System.Drawing.Point(320, 74);
            this.childForm_panel.Margin = new System.Windows.Forms.Padding(4);
            this.childForm_panel.Name = "childForm_panel";
            this.childForm_panel.Size = new System.Drawing.Size(1143, 710);
            this.childForm_panel.TabIndex = 26;
            // 
            // player_imageList
            // 
            this.player_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("player_imageList.ImageStream")));
            this.player_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.player_imageList.Images.SetKeyName(0, "pause.png");
            this.player_imageList.Images.SetKeyName(1, "play.png");
            this.player_imageList.Images.SetKeyName(2, "volume.png");
            this.player_imageList.Images.SetKeyName(3, "mute.png");
            this.player_imageList.Images.SetKeyName(4, "shuffle_on.png");
            this.player_imageList.Images.SetKeyName(5, "shuffle_off.png");
            // 
            // myToolTip
            // 
            this.myToolTip.BackColor = System.Drawing.Color.Red;
            this.myToolTip.ForeColor = System.Drawing.Color.DimGray;
            // 
            // onesec
            // 
            this.onesec.Interval = 1000;
            this.onesec.Tick += new System.EventHandler(this.onesec_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 907);
            this.Controls.Add(this.childForm_panel);
            this.Controls.Add(this.searchBar_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.player_panel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1026, 435);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.player_panel.ResumeLayout(false);
            this.player_panel.PerformLayout();
            this.play_pause_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songImg_pictureBox)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).EndInit();
            this.searchBar_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button home_button;
        public System.Windows.Forms.Panel player_panel;
        public System.Windows.Forms.Panel menu_panel;
        public System.Windows.Forms.PictureBox songImg_pictureBox;
        public System.Windows.Forms.Label title_label;
        public System.Windows.Forms.Label artist_label;
        public System.Windows.Forms.Label playingFrom_label;
        public System.Windows.Forms.Label duration_label;
        public System.Windows.Forms.Label currentTime_label;
        public System.Windows.Forms.Button myMix_button;
        public System.Windows.Forms.Button playlist_button;
        public System.Windows.Forms.Button artists_button;
        public System.Windows.Forms.Button tracks_button;
        public System.Windows.Forms.Button albums_button;
        public System.Windows.Forms.ImageList menu_imgList;
        public System.Windows.Forms.Button account_button;
        public System.Windows.Forms.PictureBox home_pictureBox;
        public System.Windows.Forms.Panel play_pause_panel;
        public MediaSlider.MediaSlider volume_trackBar;
        public System.Windows.Forms.Button pause_button;
        public System.Windows.Forms.Button next_button;
        public System.Windows.Forms.Button previous_button;
        public System.Windows.Forms.Button shuffle_button;
        public System.Windows.Forms.Button volume_button;
        public System.Windows.Forms.Label myCollection_label;
        public System.Windows.Forms.Label myPlaylist_label;
        public System.Windows.Forms.Button createNewPlaylist_button;
        public System.Windows.Forms.ImageList createPlaylist_imgList;
        private System.Windows.Forms.Panel searchBar_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchBar_icon;
        private System.Windows.Forms.TextBox searchBar_textBox;
        public System.Windows.Forms.Panel childForm_panel;
        private System.Windows.Forms.ImageList player_imageList;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer onesec;
    }
}

