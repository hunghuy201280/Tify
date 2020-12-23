namespace Tify
{
    partial class AlbumDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_loading = new System.Windows.Forms.Panel();
            this.album_gridView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.top_panel = new System.Windows.Forms.Panel();
            this.addToAlbum_button = new System.Windows.Forms.Button();
            this.albumCover_pictureBox = new System.Windows.Forms.PictureBox();
            this.addToPlaylist_Button = new System.Windows.Forms.Button();
            this.playShuffle_Button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.releaseYear_label = new System.Windows.Forms.Label();
            this.artist_track_time__label = new System.Windows.Forms.Label();
            this.albumName_label = new System.Windows.Forms.Label();
            this.loading_SplashScreen1 = new Tify.Loading_SplashScreen();
            this.panel_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.album_gridView)).BeginInit();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_loading
            // 
            this.panel_loading.Controls.Add(this.album_gridView);
            this.panel_loading.Controls.Add(this.top_panel);
            this.panel_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_loading.Location = new System.Drawing.Point(0, 0);
            this.panel_loading.Margin = new System.Windows.Forms.Padding(2);
            this.panel_loading.Name = "panel_loading";
            this.panel_loading.Size = new System.Drawing.Size(887, 570);
            this.panel_loading.TabIndex = 0;
            // 
            // album_gridView
            // 
            this.album_gridView.AllowUserToAddRows = false;
            this.album_gridView.AllowUserToDeleteRows = false;
            this.album_gridView.AllowUserToResizeRows = false;
            this.album_gridView.BackgroundColor = System.Drawing.Color.Black;
            this.album_gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.album_gridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.album_gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.album_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.album_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.album_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.title,
            this.artist,
            this.time,
            this.addToPlaylist,
            this.remove});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.album_gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.album_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.album_gridView.EnableHeadersVisualStyles = false;
            this.album_gridView.GridColor = System.Drawing.Color.Black;
            this.album_gridView.Location = new System.Drawing.Point(0, 270);
            this.album_gridView.Name = "album_gridView";
            this.album_gridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.album_gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.album_gridView.RowHeadersVisible = false;
            this.album_gridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.album_gridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.album_gridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.album_gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.album_gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album_gridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.album_gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.album_gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.album_gridView.RowTemplate.Height = 42;
            this.album_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.album_gridView.Size = new System.Drawing.Size(887, 300);
            this.album_gridView.TabIndex = 7;
            this.album_gridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.album_gridView_CellMouseClick);
            this.album_gridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.track_dataGridView_CellMouseDoubleClick);
            this.album_gridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackGridView_CellMouseEnter);
            this.album_gridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackGridView_CellMouseLeave);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.No.FillWeight = 10F;
            this.No.HeaderText = "#";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "TITLE";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // artist
            // 
            this.artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artist.HeaderText = "ARTIST";
            this.artist.MinimumWidth = 6;
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "TIME";
            this.time.MinimumWidth = 6;
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
            // top_panel
            // 
            this.top_panel.Controls.Add(this.addToAlbum_button);
            this.top_panel.Controls.Add(this.albumCover_pictureBox);
            this.top_panel.Controls.Add(this.addToPlaylist_Button);
            this.top_panel.Controls.Add(this.playShuffle_Button);
            this.top_panel.Controls.Add(this.play_button);
            this.top_panel.Controls.Add(this.releaseYear_label);
            this.top_panel.Controls.Add(this.artist_track_time__label);
            this.top_panel.Controls.Add(this.albumName_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 270);
            this.top_panel.TabIndex = 6;
            // 
            // addToAlbum_button
            // 
            this.addToAlbum_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.addToAlbum_button.BackgroundImage = global::Tify.Properties.Resources.like;
            this.addToAlbum_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addToAlbum_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToAlbum_button.FlatAppearance.BorderSize = 0;
            this.addToAlbum_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.addToAlbum_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToAlbum_button.ForeColor = System.Drawing.Color.White;
            this.addToAlbum_button.Location = new System.Drawing.Point(627, 162);
            this.addToAlbum_button.Name = "addToAlbum_button";
            this.addToAlbum_button.Size = new System.Drawing.Size(57, 50);
            this.addToAlbum_button.TabIndex = 4;
            this.addToAlbum_button.UseVisualStyleBackColor = false;
            this.addToAlbum_button.Click += new System.EventHandler(this.addToAlbum_button_Click);
            // 
            // albumCover_pictureBox
            // 
            this.albumCover_pictureBox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.albumCover_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.albumCover_pictureBox.Name = "albumCover_pictureBox";
            this.albumCover_pictureBox.Size = new System.Drawing.Size(200, 200);
            this.albumCover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumCover_pictureBox.TabIndex = 0;
            this.albumCover_pictureBox.TabStop = false;
            // 
            // addToPlaylist_Button
            // 
            this.addToPlaylist_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.addToPlaylist_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToPlaylist_Button.FlatAppearance.BorderSize = 0;
            this.addToPlaylist_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.addToPlaylist_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylist_Button.ForeColor = System.Drawing.Color.White;
            this.addToPlaylist_Button.Image = global::Tify.Properties.Resources.add_white;
            this.addToPlaylist_Button.Location = new System.Drawing.Point(554, 162);
            this.addToPlaylist_Button.Name = "addToPlaylist_Button";
            this.addToPlaylist_Button.Size = new System.Drawing.Size(57, 50);
            this.addToPlaylist_Button.TabIndex = 3;
            this.addToPlaylist_Button.UseVisualStyleBackColor = false;
            this.addToPlaylist_Button.Click += new System.EventHandler(this.addToPlaylist_Button_Click);
            // 
            // playShuffle_Button
            // 
            this.playShuffle_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.playShuffle_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playShuffle_Button.FlatAppearance.BorderSize = 0;
            this.playShuffle_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.playShuffle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playShuffle_Button.ForeColor = System.Drawing.Color.White;
            this.playShuffle_Button.Image = global::Tify.Properties.Resources.shuffle_white;
            this.playShuffle_Button.Location = new System.Drawing.Point(390, 162);
            this.playShuffle_Button.Name = "playShuffle_Button";
            this.playShuffle_Button.Size = new System.Drawing.Size(145, 50);
            this.playShuffle_Button.TabIndex = 3;
            this.playShuffle_Button.UseVisualStyleBackColor = false;
            this.playShuffle_Button.Click += new System.EventHandler(this.playShuffle_Button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.ForeColor = System.Drawing.Color.White;
            this.play_button.Image = global::Tify.Properties.Resources.play;
            this.play_button.Location = new System.Drawing.Point(226, 162);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(145, 50);
            this.play_button.TabIndex = 3;
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // releaseYear_label
            // 
            this.releaseYear_label.AutoSize = true;
            this.releaseYear_label.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYear_label.ForeColor = System.Drawing.Color.Gray;
            this.releaseYear_label.Location = new System.Drawing.Point(222, 124);
            this.releaseYear_label.Name = "releaseYear_label";
            this.releaseYear_label.Size = new System.Drawing.Size(146, 25);
            this.releaseYear_label.TabIndex = 2;
            this.releaseYear_label.Text = "Released 2020";
            // 
            // artist_track_time__label
            // 
            this.artist_track_time__label.AutoSize = true;
            this.artist_track_time__label.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_track_time__label.ForeColor = System.Drawing.Color.White;
            this.artist_track_time__label.Location = new System.Drawing.Point(222, 95);
            this.artist_track_time__label.Name = "artist_track_time__label";
            this.artist_track_time__label.Size = new System.Drawing.Size(259, 25);
            this.artist_track_time__label.TabIndex = 2;
            this.artist_track_time__label.Text = "by Artist— 14 Tracks — 57:55";
            // 
            // albumName_label
            // 
            this.albumName_label.AutoSize = true;
            this.albumName_label.Font = new System.Drawing.Font("Nationale", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName_label.ForeColor = System.Drawing.Color.White;
            this.albumName_label.Location = new System.Drawing.Point(218, 41);
            this.albumName_label.Name = "albumName_label";
            this.albumName_label.Size = new System.Drawing.Size(306, 53);
            this.albumName_label.TabIndex = 1;
            this.albumName_label.Text = "Album Name";
            // 
            // loading_SplashScreen1
            // 
            this.loading_SplashScreen1.BackColor = System.Drawing.Color.Black;
            this.loading_SplashScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading_SplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.loading_SplashScreen1.Name = "loading_SplashScreen1";
            this.loading_SplashScreen1.Size = new System.Drawing.Size(887, 570);
            this.loading_SplashScreen1.TabIndex = 5;
            // 
            // AlbumDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.panel_loading);
            this.Controls.Add(this.loading_SplashScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumDetail";
            this.Text = "AlbumDetail";
            this.panel_loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.album_gridView)).EndInit();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_loading;
        private System.Windows.Forms.DataGridView album_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button addToAlbum_button;
        private System.Windows.Forms.PictureBox albumCover_pictureBox;
        private System.Windows.Forms.Button addToPlaylist_Button;
        private System.Windows.Forms.Button playShuffle_Button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Label releaseYear_label;
        private System.Windows.Forms.Label artist_track_time__label;
        private System.Windows.Forms.Label albumName_label;
        private Loading_SplashScreen loading_SplashScreen1;
    }
}