﻿namespace Tify
{
    partial class Tracks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracks));
            this.top_panel = new System.Windows.Forms.Panel();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.panel_loading = new System.Windows.Forms.Panel();
            this.loading_SplashScreen1 = new Tify.Loading_SplashScreen();
            this.track_gridView = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.rightIconImgList = new System.Windows.Forms.ImageList(this.components);
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.check_worker = new System.ComponentModel.BackgroundWorker();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.panel_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 61);
            this.top_panel.TabIndex = 1;
            // 
            // formTitle_label
            // 
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle_label.ForeColor = System.Drawing.Color.White;
            this.formTitle_label.Location = new System.Drawing.Point(12, 17);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(103, 23);
            this.formTitle_label.TabIndex = 5;
            this.formTitle_label.Text = "My Tracks";
            // 
            // bottom_panel
            // 
            this.bottom_panel.AutoScroll = true;
            this.bottom_panel.Controls.Add(this.track_gridView);
            this.bottom_panel.Controls.Add(this.panel_loading);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel.Location = new System.Drawing.Point(0, 61);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(887, 509);
            this.bottom_panel.TabIndex = 2;
            // 
            // panel_loading
            // 
            this.panel_loading.Controls.Add(this.loading_SplashScreen1);
            this.panel_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_loading.Location = new System.Drawing.Point(0, 0);
            this.panel_loading.Name = "panel_loading";
            this.panel_loading.Size = new System.Drawing.Size(887, 509);
            this.panel_loading.TabIndex = 1;
            // 
            // loading_SplashScreen1
            // 
            this.loading_SplashScreen1.BackColor = System.Drawing.Color.Black;
            this.loading_SplashScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading_SplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.loading_SplashScreen1.Name = "loading_SplashScreen1";
            this.loading_SplashScreen1.Size = new System.Drawing.Size(887, 509);
            this.loading_SplashScreen1.TabIndex = 0;
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
            this.dateAdded,
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
            this.track_gridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.track_gridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.track_gridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.track_gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.track_gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_gridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.track_gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.track_gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.track_gridView.RowTemplate.Height = 42;
            this.track_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.track_gridView.Size = new System.Drawing.Size(887, 509);
            this.track_gridView.TabIndex = 0;
            this.track_gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackGridView_CellClick);
            this.track_gridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.track_gridView_CellDoubleClick);
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
            // dateAdded
            // 
            this.dateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAdded.HeaderText = "DATE ADDED";
            this.dateAdded.MinimumWidth = 6;
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
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
            // rightIconImgList
            // 
            this.rightIconImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightIconImgList.ImageStream")));
            this.rightIconImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightIconImgList.Images.SetKeyName(0, "add.png");
            this.rightIconImgList.Images.SetKeyName(1, "like.png");
            this.rightIconImgList.Images.SetKeyName(2, "liked.png");
            // 
            // load_worker
            // 
            this.load_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_worker_DoWork);
            this.load_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_worker_RunWorkerCompleted);
            // 
            // check_worker
            // 
            this.check_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.check_worker_DoWork);
            // 
            // Tracks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tracks";
            this.Text = "Tracks";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.panel_loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.track_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.DataGridView track_gridView;
        private System.Windows.Forms.ImageList rightIconImgList;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.ComponentModel.BackgroundWorker load_worker;
        private System.ComponentModel.BackgroundWorker check_worker;
        private System.Windows.Forms.Panel panel_loading;
        private Loading_SplashScreen loading_SplashScreen1;
    }
}