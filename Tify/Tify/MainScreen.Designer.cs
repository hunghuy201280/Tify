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
            this.volume_trackBar = new MediaSlider.MediaSlider();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.play_pause_panel = new System.Windows.Forms.Panel();
            this.currentTime_label = new System.Windows.Forms.Label();
            this.duration_label = new System.Windows.Forms.Label();
            this.playingFrom_label = new System.Windows.Forms.Label();
            this.artist_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.createPlaylist_imgList = new System.Windows.Forms.ImageList(this.components);
            this.myPlaylist_label = new System.Windows.Forms.Label();
            this.menu_imgList = new System.Windows.Forms.ImageList(this.components);
            this.myCollection_label = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Button();
            this.CreatePlayList_FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBar_panel = new System.Windows.Forms.Panel();
            this.searchbarContainer_panel = new System.Windows.Forms.Panel();
            this.searchBar_textBox = new System.Windows.Forms.TextBox();
            this.childForm_panel = new System.Windows.Forms.Panel();
            this.player_imageList = new System.Windows.Forms.ImageList(this.components);
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.onesec = new System.Windows.Forms.Timer(this.components);
            this.songDetail_panel = new System.Windows.Forms.Panel();
            this.searchBar_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.playlist_PopupContainer = new DevExpress.XtraEditors.PopupContainerControl();
            this.searchBar_PopupContainer = new DevExpress.XtraEditors.PopupContainerControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchNoResult_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightClickCreatePlayList1 = new RightClickCreatePlayList.RightClickCreatePlayList();
            this.add_like_panel = new System.Windows.Forms.Panel();
            this.searchBar_icon = new System.Windows.Forms.PictureBox();
            this.createNewPlaylist_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.home_pictureBox = new System.Windows.Forms.PictureBox();
            this.myMix_button = new System.Windows.Forms.Button();
            this.albums_button = new System.Windows.Forms.Button();
            this.playlist_button = new System.Windows.Forms.Button();
            this.artists_button = new System.Windows.Forms.Button();
            this.tracks_button = new System.Windows.Forms.Button();
            this.addToPlaylist_Player_Button = new System.Windows.Forms.Button();
            this.songCover_panel = new System.Windows.Forms.Panel();
            this.songImgOpacity_panel = new System.Windows.Forms.Panel();
            this.volume_button = new System.Windows.Forms.Button();
            this.shuffle_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.like_Player_Button = new System.Windows.Forms.Button();
            this.player_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.play_pause_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.searchBar_panel.SuspendLayout();
            this.searchbarContainer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlist_PopupContainer)).BeginInit();
            this.playlist_PopupContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_PopupContainer)).BeginInit();
            this.searchBar_PopupContainer.SuspendLayout();
            this.searchNoResult_panel.SuspendLayout();
            this.add_like_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).BeginInit();
            this.songCover_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.player_panel.Controls.Add(this.add_like_panel);
            this.player_panel.Controls.Add(this.volume_trackBar);
            this.player_panel.Controls.Add(this.progressBar);
            this.player_panel.Controls.Add(this.songCover_panel);
            this.player_panel.Controls.Add(this.volume_button);
            this.player_panel.Controls.Add(this.play_pause_panel);
            this.player_panel.Controls.Add(this.currentTime_label);
            this.player_panel.Controls.Add(this.duration_label);
            this.player_panel.Controls.Add(this.playingFrom_label);
            this.player_panel.Controls.Add(this.artist_label);
            this.player_panel.Controls.Add(this.title_label);
            this.player_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.player_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player_panel.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_panel.Location = new System.Drawing.Point(0, 738);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(1127, 100);
            this.player_panel.TabIndex = 1;
            this.player_panel.Click += new System.EventHandler(this.ShowSongDetailWhenClickPlayerPanel);
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Animated = true;
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
            this.volume_trackBar.ButtonSize = new System.Drawing.Size(12, 12);
            this.volume_trackBar.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.volume_trackBar.ContextMenuStrip = null;
            this.volume_trackBar.LargeChange = 2;
            this.volume_trackBar.Location = new System.Drawing.Point(981, 43);
            this.volume_trackBar.Margin = new System.Windows.Forms.Padding(0);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Minimum = 0;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volume_trackBar.ShowButtonOnHover = false;
            this.volume_trackBar.Size = new System.Drawing.Size(130, 13);
            this.volume_trackBar.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.volume_trackBar.SmallChange = 1;
            this.volume_trackBar.SmoothScrolling = true;
            this.volume_trackBar.TabIndex = 15;
            this.volume_trackBar.TickColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume_trackBar.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.volume_trackBar.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volume_trackBar.TrackDepth = 4;
            this.volume_trackBar.TrackFillColor = System.Drawing.Color.White;
            this.volume_trackBar.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.volume_trackBar.TrackShadow = false;
            this.volume_trackBar.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.volume_trackBar.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.volume_trackBar.Value = 50;
            this.volume_trackBar.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.volume_trackBar_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.progressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressBar.Properties.EndColor = System.Drawing.Color.Empty;
            this.progressBar.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.progressBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBar.Properties.StartColor = System.Drawing.Color.Empty;
            this.progressBar.Size = new System.Drawing.Size(1127, 5);
            this.progressBar.TabIndex = 0;
            this.progressBar.EditValueChanged += new System.EventHandler(this.progressBar_EditValueChanged);
            this.progressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseClick);
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            this.progressBar.MouseLeave += new System.EventHandler(this.progressBar_MouseLeave);
            this.progressBar.MouseHover += new System.EventHandler(this.progressBar_MouseHover);
            this.progressBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseMove);
            this.progressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseUp);
            // 
            // play_pause_panel
            // 
            this.play_pause_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.play_pause_panel.Controls.Add(this.shuffle_button);
            this.play_pause_panel.Controls.Add(this.previous_button);
            this.play_pause_panel.Controls.Add(this.next_button);
            this.play_pause_panel.Controls.Add(this.pause_button);
            this.play_pause_panel.Location = new System.Drawing.Point(446, 0);
            this.play_pause_panel.Name = "play_pause_panel";
            this.play_pause_panel.Size = new System.Drawing.Size(235, 100);
            this.play_pause_panel.TabIndex = 12;
            // 
            // currentTime_label
            // 
            this.currentTime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime_label.AutoSize = true;
            this.currentTime_label.BackColor = System.Drawing.Color.Transparent;
            this.currentTime_label.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.currentTime_label.Location = new System.Drawing.Point(818, 40);
            this.currentTime_label.Margin = new System.Windows.Forms.Padding(0);
            this.currentTime_label.Name = "currentTime_label";
            this.currentTime_label.Size = new System.Drawing.Size(50, 19);
            this.currentTime_label.TabIndex = 11;
            this.currentTime_label.Text = "0:14 /";
            this.currentTime_label.TextChanged += new System.EventHandler(this.currentTime_label_TextChanged);
            // 
            // duration_label
            // 
            this.duration_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duration_label.AutoSize = true;
            this.duration_label.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.duration_label.Location = new System.Drawing.Point(859, 40);
            this.duration_label.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(44, 19);
            this.duration_label.TabIndex = 10;
            this.duration_label.Text = " 3:23";
            this.duration_label.TextChanged += new System.EventHandler(this.duration_label_TextChanged);
            // 
            // playingFrom_label
            // 
            this.playingFrom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playingFrom_label.AutoSize = true;
            this.playingFrom_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingFrom_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(137)))));
            this.playingFrom_label.Location = new System.Drawing.Point(104, 61);
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
            this.artist_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(137)))));
            this.artist_label.Location = new System.Drawing.Point(104, 40);
            this.artist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(64, 16);
            this.artist_label.TabIndex = 3;
            this.artist_label.Text = "Yorushika";
            this.artist_label.TextChanged += new System.EventHandler(this.artist_label_TextChanged);
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(104, 23);
            this.title_label.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(140, 17);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Hole In The Heart";
            this.title_label.TextChanged += new System.EventHandler(this.title_label_TextChanged);
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
            this.menu_panel.Controls.Add(this.CreatePlayList_FlowPanel);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(240, 738);
            this.menu_panel.TabIndex = 2;
            this.menu_panel.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.menu_panel.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
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
            this.myPlaylist_label.Location = new System.Drawing.Point(15, 479);
            this.myPlaylist_label.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.myPlaylist_label.Name = "myPlaylist_label";
            this.myPlaylist_label.Size = new System.Drawing.Size(105, 17);
            this.myPlaylist_label.TabIndex = 22;
            this.myPlaylist_label.Tag = "MY PLAYLIST";
            this.myPlaylist_label.Text = "MY PLAYLIST";
            this.myPlaylist_label.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.myPlaylist_label.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
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
            this.myCollection_label.Location = new System.Drawing.Point(15, 160);
            this.myCollection_label.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.myCollection_label.Name = "myCollection_label";
            this.myCollection_label.Size = new System.Drawing.Size(135, 17);
            this.myCollection_label.TabIndex = 21;
            this.myCollection_label.Tag = "MY COLLECTION";
            this.myCollection_label.Text = "MY COLLECTION";
            this.myCollection_label.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.myCollection_label.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // home_button
            // 
            this.home_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.Color.White;
            this.home_button.Location = new System.Drawing.Point(9, 80);
            this.home_button.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(215, 45);
            this.home_button.TabIndex = 12;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // CreatePlayList_FlowPanel
            // 
            this.CreatePlayList_FlowPanel.AutoSize = true;
            this.CreatePlayList_FlowPanel.Location = new System.Drawing.Point(0, 556);
            this.CreatePlayList_FlowPanel.Name = "CreatePlayList_FlowPanel";
            this.CreatePlayList_FlowPanel.Size = new System.Drawing.Size(240, 42);
            this.CreatePlayList_FlowPanel.TabIndex = 24;
            this.CreatePlayList_FlowPanel.WrapContents = false;
            this.CreatePlayList_FlowPanel.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.CreatePlayList_FlowPanel.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // searchBar_panel
            // 
            this.searchBar_panel.BackColor = System.Drawing.Color.Black;
            this.searchBar_panel.Controls.Add(this.searchbarContainer_panel);
            this.searchBar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar_panel.Location = new System.Drawing.Point(240, 0);
            this.searchBar_panel.Name = "searchBar_panel";
            this.searchBar_panel.Size = new System.Drawing.Size(887, 60);
            this.searchBar_panel.TabIndex = 1;
            // 
            // searchbarContainer_panel
            // 
            this.searchbarContainer_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbarContainer_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.searchbarContainer_panel.Controls.Add(this.searchBar_textBox);
            this.searchbarContainer_panel.Controls.Add(this.searchBar_icon);
            this.searchbarContainer_panel.Location = new System.Drawing.Point(485, 14);
            this.searchbarContainer_panel.Name = "searchbarContainer_panel";
            this.searchbarContainer_panel.Size = new System.Drawing.Size(390, 40);
            this.searchbarContainer_panel.TabIndex = 0;
            // 
            // searchBar_textBox
            // 
            this.searchBar_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.searchBar_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.searchBar_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBar_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar_textBox.Font = new System.Drawing.Font("Nationale Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(162)))), ((int)(((byte)(166)))));
            this.searchBar_textBox.Location = new System.Drawing.Point(40, 0);
            this.searchBar_textBox.Name = "searchBar_textBox";
            this.searchBar_textBox.Size = new System.Drawing.Size(350, 37);
            this.searchBar_textBox.TabIndex = 2;
            this.searchBar_textBox.Text = "Search";
            this.searchBar_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBar_textBox_KeyPress);
            // 
            // childForm_panel
            // 
            this.childForm_panel.AutoScroll = true;
            this.childForm_panel.BackColor = System.Drawing.Color.Black;
            this.childForm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childForm_panel.ForeColor = System.Drawing.Color.Coral;
            this.childForm_panel.Location = new System.Drawing.Point(240, 60);
            this.childForm_panel.Name = "childForm_panel";
            this.childForm_panel.Size = new System.Drawing.Size(887, 678);
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
            this.player_imageList.Images.SetKeyName(6, "like.png");
            this.player_imageList.Images.SetKeyName(7, "liked.png");
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
            // songDetail_panel
            // 
            this.songDetail_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songDetail_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.songDetail_panel.Location = new System.Drawing.Point(0, 0);
            this.songDetail_panel.Name = "songDetail_panel";
            this.songDetail_panel.Size = new System.Drawing.Size(1127, 838);
            this.songDetail_panel.TabIndex = 0;
            // 
            // searchBar_backgroundWorker
            // 
            this.searchBar_backgroundWorker.WorkerReportsProgress = true;
            this.searchBar_backgroundWorker.WorkerSupportsCancellation = true;
            this.searchBar_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchBar_backgroundWorker_DoWork);
            this.searchBar_backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.searchBar_backgroundWorker_ProgressChanged);
            this.searchBar_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchBar_backgroundWorker_RunWorkerCompleted);
            // 
            // playlist_PopupContainer
            // 
            this.playlist_PopupContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playlist_PopupContainer.Controls.Add(this.rightClickCreatePlayList1);
            this.playlist_PopupContainer.Location = new System.Drawing.Point(58, 30);
            this.playlist_PopupContainer.Name = "playlist_PopupContainer";
            this.playlist_PopupContainer.Size = new System.Drawing.Size(238, 432);
            this.playlist_PopupContainer.TabIndex = 25;
            // 
            // searchBar_PopupContainer
            // 
            this.searchBar_PopupContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.searchBar_PopupContainer.Appearance.Options.UseBackColor = true;
            this.searchBar_PopupContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBar_PopupContainer.Controls.Add(this.listBox1);
            this.searchBar_PopupContainer.Controls.Add(this.searchNoResult_panel);
            this.searchBar_PopupContainer.Location = new System.Drawing.Point(725, 60);
            this.searchBar_PopupContainer.Name = "searchBar_PopupContainer";
            this.searchBar_PopupContainer.Size = new System.Drawing.Size(390, 220);
            this.searchBar_PopupContainer.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 220);
            this.listBox1.TabIndex = 0;
            // 
            // searchNoResult_panel
            // 
            this.searchNoResult_panel.Controls.Add(this.label1);
            this.searchNoResult_panel.Controls.Add(this.pictureBox1);
            this.searchNoResult_panel.Location = new System.Drawing.Point(96, 46);
            this.searchNoResult_panel.Name = "searchNoResult_panel";
            this.searchNoResult_panel.Size = new System.Drawing.Size(200, 128);
            this.searchNoResult_panel.TabIndex = 0;
            this.searchNoResult_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Result found";
            // 
            // rightClickCreatePlayList1
            // 
            this.rightClickCreatePlayList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.rightClickCreatePlayList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightClickCreatePlayList1.Location = new System.Drawing.Point(0, 0);
            this.rightClickCreatePlayList1.Name = "rightClickCreatePlayList1";
            this.rightClickCreatePlayList1.Size = new System.Drawing.Size(238, 432);
            this.rightClickCreatePlayList1.TabIndex = 0;
            // 
            // add_like_panel
            // 
            this.add_like_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_like_panel.Controls.Add(this.like_Player_Button);
            this.add_like_panel.Controls.Add(this.addToPlaylist_Player_Button);
            this.add_like_panel.Location = new System.Drawing.Point(255, 40);
            this.add_like_panel.Name = "add_like_panel";
            this.add_like_panel.Size = new System.Drawing.Size(62, 24);
            this.add_like_panel.TabIndex = 16;
            // 
            // searchBar_icon
            // 
            this.searchBar_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBar_icon.Image = ((System.Drawing.Image)(resources.GetObject("searchBar_icon.Image")));
            this.searchBar_icon.Location = new System.Drawing.Point(0, 0);
            this.searchBar_icon.Name = "searchBar_icon";
            this.searchBar_icon.Size = new System.Drawing.Size(40, 40);
            this.searchBar_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchBar_icon.TabIndex = 1;
            this.searchBar_icon.TabStop = false;
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
            this.createNewPlaylist_button.Location = new System.Drawing.Point(9, 506);
            this.createNewPlaylist_button.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.createNewPlaylist_button.Name = "createNewPlaylist_button";
            this.createNewPlaylist_button.Size = new System.Drawing.Size(215, 47);
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
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.Transparent;
            this.account_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(128)))), ((int)(((byte)(137)))));
            this.account_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_button.ForeColor = System.Drawing.Color.White;
            this.account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.ImageIndex = 10;
            this.account_button.ImageList = this.menu_imgList;
            this.account_button.Location = new System.Drawing.Point(9, 14);
            this.account_button.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(215, 45);
            this.account_button.TabIndex = 18;
            this.account_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            this.account_button.MouseLeave += new System.EventHandler(this.menu_panel_MouseLeave);
            this.account_button.MouseHover += new System.EventHandler(this.menu_panel_MouseHover);
            // 
            // home_pictureBox
            // 
            this.home_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("home_pictureBox.Image")));
            this.home_pictureBox.Location = new System.Drawing.Point(15, 85);
            this.home_pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.home_pictureBox.Name = "home_pictureBox";
            this.home_pictureBox.Size = new System.Drawing.Size(40, 40);
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
            this.myMix_button.Location = new System.Drawing.Point(9, 197);
            this.myMix_button.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.myMix_button.Name = "myMix_button";
            this.myMix_button.Size = new System.Drawing.Size(215, 47);
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
            this.albums_button.Location = new System.Drawing.Point(9, 299);
            this.albums_button.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albums_button.Name = "albums_button";
            this.albums_button.Size = new System.Drawing.Size(215, 45);
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
            this.playlist_button.Location = new System.Drawing.Point(9, 249);
            this.playlist_button.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.playlist_button.Name = "playlist_button";
            this.playlist_button.Size = new System.Drawing.Size(215, 45);
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
            this.artists_button.Location = new System.Drawing.Point(9, 399);
            this.artists_button.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artists_button.Name = "artists_button";
            this.artists_button.Size = new System.Drawing.Size(215, 45);
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
            this.tracks_button.Location = new System.Drawing.Point(9, 349);
            this.tracks_button.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tracks_button.Name = "tracks_button";
            this.tracks_button.Size = new System.Drawing.Size(215, 45);
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
            // addToPlaylist_Player_Button
            // 
            this.addToPlaylist_Player_Button.BackgroundImage = global::Tify.Properties.Resources.add;
            this.addToPlaylist_Player_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addToPlaylist_Player_Button.FlatAppearance.BorderSize = 0;
            this.addToPlaylist_Player_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylist_Player_Button.Location = new System.Drawing.Point(3, 0);
            this.addToPlaylist_Player_Button.Name = "addToPlaylist_Player_Button";
            this.addToPlaylist_Player_Button.Size = new System.Drawing.Size(24, 24);
            this.addToPlaylist_Player_Button.TabIndex = 0;
            this.addToPlaylist_Player_Button.UseVisualStyleBackColor = true;
            // 
            // songCover_panel
            // 
            this.songCover_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songCover_panel.BackgroundImage")));
            this.songCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.songCover_panel.Controls.Add(this.songImgOpacity_panel);
            this.songCover_panel.Location = new System.Drawing.Point(12, 20);
            this.songCover_panel.Name = "songCover_panel";
            this.songCover_panel.Size = new System.Drawing.Size(65, 65);
            this.songCover_panel.TabIndex = 0;
            this.songCover_panel.BackgroundImageChanged += new System.EventHandler(this.songCover_panel_BackgroundImageChanged);
            this.songCover_panel.MouseHover += new System.EventHandler(this.songCover_panel_MouseHover);
            // 
            // songImgOpacity_panel
            // 
            this.songImgOpacity_panel.BackColor = System.Drawing.Color.Transparent;
            this.songImgOpacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songImgOpacity_panel.BackgroundImage")));
            this.songImgOpacity_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songImgOpacity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songImgOpacity_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.songImgOpacity_panel.Location = new System.Drawing.Point(0, 0);
            this.songImgOpacity_panel.Name = "songImgOpacity_panel";
            this.songImgOpacity_panel.Size = new System.Drawing.Size(65, 65);
            this.songImgOpacity_panel.TabIndex = 16;
            this.songImgOpacity_panel.Visible = false;
            this.songImgOpacity_panel.Click += new System.EventHandler(this.ShowSongDetailWhenClickPlayerPanel);
            this.songImgOpacity_panel.MouseLeave += new System.EventHandler(this.songCover_panel_MouseLeave);
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
            this.volume_button.Location = new System.Drawing.Point(927, 30);
            this.volume_button.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.volume_button.Name = "volume_button";
            this.volume_button.Size = new System.Drawing.Size(44, 40);
            this.volume_button.TabIndex = 14;
            this.volume_button.Tag = "on";
            this.myToolTip.SetToolTip(this.volume_button, "Volume");
            this.volume_button.UseVisualStyleBackColor = false;
            this.volume_button.Click += new System.EventHandler(this.volume_button_Click);
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
            this.shuffle_button.Tag = "off";
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
            this.previous_button.Location = new System.Drawing.Point(69, 32);
            this.previous_button.Margin = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(28, 32);
            this.previous_button.TabIndex = 10;
            this.myToolTip.SetToolTip(this.previous_button, "Previous");
            this.previous_button.UseVisualStyleBackColor = false;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
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
            this.myToolTip.SetToolTip(this.next_button, "Next");
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
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
            this.myToolTip.SetToolTip(this.pause_button, "Pause");
            this.pause_button.UseVisualStyleBackColor = false;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // like_Player_Button
            // 
            this.like_Player_Button.BackgroundImage = global::Tify.Properties.Resources.like;
            this.like_Player_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.like_Player_Button.FlatAppearance.BorderSize = 0;
            this.like_Player_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like_Player_Button.Location = new System.Drawing.Point(34, 1);
            this.like_Player_Button.Name = "like_Player_Button";
            this.like_Player_Button.Size = new System.Drawing.Size(24, 24);
            this.like_Player_Button.TabIndex = 1;
            this.like_Player_Button.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 838);
            this.Controls.Add(this.childForm_panel);
            this.Controls.Add(this.searchBar_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.player_panel);
            this.Controls.Add(this.songDetail_panel);
            this.Controls.Add(this.playlist_PopupContainer);
            this.Controls.Add(this.searchBar_PopupContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(774, 361);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tify";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.player_panel.ResumeLayout(false);
            this.player_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.play_pause_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.searchBar_panel.ResumeLayout(false);
            this.searchbarContainer_panel.ResumeLayout(false);
            this.searchbarContainer_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlist_PopupContainer)).EndInit();
            this.playlist_PopupContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_PopupContainer)).EndInit();
            this.searchBar_PopupContainer.ResumeLayout(false);
            this.searchNoResult_panel.ResumeLayout(false);
            this.searchNoResult_panel.PerformLayout();
            this.add_like_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBar_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).EndInit();
            this.songCover_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button home_button;
        public System.Windows.Forms.Panel player_panel;
        public System.Windows.Forms.Panel menu_panel;
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
        private System.Windows.Forms.Panel searchbarContainer_panel;
        private System.Windows.Forms.PictureBox searchBar_icon;
        private System.Windows.Forms.TextBox searchBar_textBox;
        public System.Windows.Forms.Panel childForm_panel;
        private System.Windows.Forms.ImageList player_imageList;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Timer onesec;
        private System.Windows.Forms.Panel songImgOpacity_panel;
        private System.Windows.Forms.Panel songCover_panel;
        private System.Windows.Forms.Panel songDetail_panel;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private System.Windows.Forms.FlowLayoutPanel CreatePlayList_FlowPanel;
        public MediaSlider.MediaSlider volume_trackBar;
        private System.ComponentModel.BackgroundWorker searchBar_backgroundWorker;
        private DevExpress.XtraEditors.PopupContainerControl playlist_PopupContainer;
        private RightClickCreatePlayList.RightClickCreatePlayList rightClickCreatePlayList1;
        private DevExpress.XtraEditors.PopupContainerControl searchBar_PopupContainer;
        private System.Windows.Forms.Panel searchNoResult_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel add_like_panel;
        private System.Windows.Forms.Button addToPlaylist_Player_Button;
        private System.Windows.Forms.Button like_Player_Button;
    }
}

