namespace Tify
{
    partial class SearchBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_panel = new System.Windows.Forms.Panel();
            this.separator_panel = new System.Windows.Forms.Panel();
            this.SearchBox_PlayLists = new System.Windows.Forms.Button();
            this.SearchBox_Album = new System.Windows.Forms.Button();
            this.SearchBox_Artists = new System.Windows.Forms.Button();
            this.SearchBox_Tracks = new System.Windows.Forms.Button();
            this.rightIconImgList = new System.Windows.Forms.ImageList(this.components);
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.playlistResult_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.albumResult_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.track_gridView = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.artistResult_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.search_worker = new System.ComponentModel.BackgroundWorker();
            this.artist_worker = new System.ComponentModel.BackgroundWorker();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.separator_panel);
            this.top_panel.Controls.Add(this.SearchBox_PlayLists);
            this.top_panel.Controls.Add(this.SearchBox_Album);
            this.top_panel.Controls.Add(this.SearchBox_Artists);
            this.top_panel.Controls.Add(this.SearchBox_Tracks);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(871, 59);
            this.top_panel.TabIndex = 3;
            // 
            // separator_panel
            // 
            this.separator_panel.BackColor = System.Drawing.Color.Gray;
            this.separator_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separator_panel.Location = new System.Drawing.Point(0, 58);
            this.separator_panel.Name = "separator_panel";
            this.separator_panel.Size = new System.Drawing.Size(871, 1);
            this.separator_panel.TabIndex = 0;
            // 
            // SearchBox_PlayLists
            // 
            this.SearchBox_PlayLists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox_PlayLists.FlatAppearance.BorderSize = 0;
            this.SearchBox_PlayLists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SearchBox_PlayLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_PlayLists.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_PlayLists.ForeColor = System.Drawing.Color.White;
            this.SearchBox_PlayLists.Location = new System.Drawing.Point(327, 12);
            this.SearchBox_PlayLists.Name = "SearchBox_PlayLists";
            this.SearchBox_PlayLists.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_PlayLists.TabIndex = 9;
            this.SearchBox_PlayLists.Tag = "playlist_button";
            this.SearchBox_PlayLists.Text = "PlayLists";
            this.SearchBox_PlayLists.UseVisualStyleBackColor = true;
            this.SearchBox_PlayLists.Click += new System.EventHandler(this.SearchBox_Button_Click);
            // 
            // SearchBox_Album
            // 
            this.SearchBox_Album.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox_Album.FlatAppearance.BorderSize = 0;
            this.SearchBox_Album.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SearchBox_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Album.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Album.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Album.Location = new System.Drawing.Point(222, 12);
            this.SearchBox_Album.Name = "SearchBox_Album";
            this.SearchBox_Album.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Album.TabIndex = 8;
            this.SearchBox_Album.Tag = "album_button";
            this.SearchBox_Album.Text = "Album";
            this.SearchBox_Album.UseVisualStyleBackColor = true;
            this.SearchBox_Album.Click += new System.EventHandler(this.SearchBox_Button_Click);
            // 
            // SearchBox_Artists
            // 
            this.SearchBox_Artists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox_Artists.FlatAppearance.BorderSize = 0;
            this.SearchBox_Artists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SearchBox_Artists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Artists.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Artists.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Artists.Location = new System.Drawing.Point(117, 12);
            this.SearchBox_Artists.Name = "SearchBox_Artists";
            this.SearchBox_Artists.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Artists.TabIndex = 7;
            this.SearchBox_Artists.Tag = "artist_button";
            this.SearchBox_Artists.Text = "Artists";
            this.SearchBox_Artists.UseVisualStyleBackColor = true;
            this.SearchBox_Artists.Click += new System.EventHandler(this.SearchBox_Button_Click);
            // 
            // SearchBox_Tracks
            // 
            this.SearchBox_Tracks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBox_Tracks.FlatAppearance.BorderSize = 0;
            this.SearchBox_Tracks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SearchBox_Tracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Tracks.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Tracks.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Tracks.Location = new System.Drawing.Point(12, 12);
            this.SearchBox_Tracks.Name = "SearchBox_Tracks";
            this.SearchBox_Tracks.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Tracks.TabIndex = 6;
            this.SearchBox_Tracks.Tag = "track_button";
            this.SearchBox_Tracks.Text = "Tracks";
            this.SearchBox_Tracks.UseVisualStyleBackColor = true;
            this.SearchBox_Tracks.Click += new System.EventHandler(this.SearchBox_Button_Click);
            // 
            // rightIconImgList
            // 
            this.rightIconImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightIconImgList.ImageStream")));
            this.rightIconImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightIconImgList.Images.SetKeyName(0, "add.png");
            this.rightIconImgList.Images.SetKeyName(1, "like.png");
            this.rightIconImgList.Images.SetKeyName(2, "liked.png");
            // 
            // bottom_panel
            // 
            this.bottom_panel.Controls.Add(this.playlistResult_flowPanel);
            this.bottom_panel.Controls.Add(this.albumResult_flowPanel);
            this.bottom_panel.Controls.Add(this.track_gridView);
            this.bottom_panel.Controls.Add(this.artistResult_flowPanel);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel.Location = new System.Drawing.Point(0, 59);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(871, 472);
            this.bottom_panel.TabIndex = 4;
            // 
            // playlistResult_flowPanel
            // 
            this.playlistResult_flowPanel.AutoScroll = true;
            this.playlistResult_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistResult_flowPanel.Location = new System.Drawing.Point(0, 0);
            this.playlistResult_flowPanel.Name = "playlistResult_flowPanel";
            this.playlistResult_flowPanel.Size = new System.Drawing.Size(871, 472);
            this.playlistResult_flowPanel.TabIndex = 4;
            // 
            // albumResult_flowPanel
            // 
            this.albumResult_flowPanel.AutoScroll = true;
            this.albumResult_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumResult_flowPanel.Location = new System.Drawing.Point(0, 0);
            this.albumResult_flowPanel.Name = "albumResult_flowPanel";
            this.albumResult_flowPanel.Size = new System.Drawing.Size(871, 472);
            this.albumResult_flowPanel.TabIndex = 3;
            // 
            // track_gridView
            // 
            this.track_gridView.AllowUserToAddRows = false;
            this.track_gridView.AllowUserToDeleteRows = false;
            this.track_gridView.AllowUserToResizeRows = false;
            this.track_gridView.BackgroundColor = System.Drawing.Color.Black;
            this.track_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.track_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.track_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.track_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.track_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.title,
            this.artist,
            this.time,
            this.addToPlaylist,
            this.remove});
            this.track_gridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.track_gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.track_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_gridView.EnableHeadersVisualStyles = false;
            this.track_gridView.GridColor = System.Drawing.Color.Black;
            this.track_gridView.Location = new System.Drawing.Point(0, 0);
            this.track_gridView.MultiSelect = false;
            this.track_gridView.Name = "track_gridView";
            this.track_gridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.track_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.track_gridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.track_gridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.track_gridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.track_gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.track_gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_gridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.track_gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.track_gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.track_gridView.RowTemplate.Height = 42;
            this.track_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.track_gridView.Size = new System.Drawing.Size(871, 472);
            this.track_gridView.TabIndex = 1;
            this.track_gridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.track_gridView_CellMouseDoubleClick);
            this.track_gridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackGridView_CellMouseEnter);
            this.track_gridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackGridView_CellMouseLeave);
            // 
            // img
            // 
            this.img.HeaderText = "";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.img.MinimumWidth = 42;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 42;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "TITLE";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // artist
            // 
            this.artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artist.HeaderText = "ARTIST";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // addToPlaylist
            // 
            this.addToPlaylist.HeaderText = "";
            this.addToPlaylist.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.addToPlaylist.MinimumWidth = 20;
            this.addToPlaylist.Name = "addToPlaylist";
            this.addToPlaylist.ReadOnly = true;
            this.addToPlaylist.Width = 20;
            // 
            // remove
            // 
            this.remove.HeaderText = "";
            this.remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.remove.MinimumWidth = 20;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Width = 20;
            // 
            // artistResult_flowPanel
            // 
            this.artistResult_flowPanel.AutoScroll = true;
            this.artistResult_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistResult_flowPanel.Location = new System.Drawing.Point(0, 0);
            this.artistResult_flowPanel.Name = "artistResult_flowPanel";
            this.artistResult_flowPanel.Size = new System.Drawing.Size(871, 472);
            this.artistResult_flowPanel.TabIndex = 2;
            // 
            // search_worker
            // 
            this.search_worker.WorkerReportsProgress = true;
            this.search_worker.WorkerSupportsCancellation = true;
            this.search_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.search_worker_DoWork);
            this.search_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.search_worker_RunWorkerCompleted);
            // 
            // artist_worker
            // 
            this.artist_worker.WorkerReportsProgress = true;
            this.artist_worker.WorkerSupportsCancellation = true;
            this.artist_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.artist_worker_DoWork);
            this.artist_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.artist_worker_RunWorkerCompleted);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(871, 531);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBox";
            this.Text = "SearchBox";
            this.top_panel.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.track_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList rightIconImgList;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button SearchBox_Tracks;
        private System.Windows.Forms.Button SearchBox_PlayLists;
        private System.Windows.Forms.Button SearchBox_Album;
        private System.Windows.Forms.Button SearchBox_Artists;
        public System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel separator_panel;
        private System.Windows.Forms.DataGridView track_gridView;
        private System.Windows.Forms.FlowLayoutPanel artistResult_flowPanel;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.ComponentModel.BackgroundWorker search_worker;
        private System.Windows.Forms.FlowLayoutPanel albumResult_flowPanel;
        private System.Windows.Forms.FlowLayoutPanel playlistResult_flowPanel;
        private System.ComponentModel.BackgroundWorker artist_worker;
    }
}