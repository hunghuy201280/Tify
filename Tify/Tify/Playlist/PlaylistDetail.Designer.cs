namespace Tify
{
    partial class PlaylistDetail
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
            this.Cover4_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cover3_pictureBox = new System.Windows.Forms.PictureBox();
            this.playShuffle_Button = new System.Windows.Forms.Button();
            this.Cover2_pictureBox = new System.Windows.Forms.PictureBox();
            this.Cover1_pictureBox = new System.Windows.Forms.PictureBox();
            this.addToPlaylist_Button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playlistCover_pictureBox = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.createdBy_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Cover4_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover3_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover1_pictureBox)).BeginInit();
            this.playlistCover_pictureBox.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cover4_pictureBox
            // 
            this.Cover4_pictureBox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.Cover4_pictureBox.Location = new System.Drawing.Point(100, 100);
            this.Cover4_pictureBox.Name = "Cover4_pictureBox";
            this.Cover4_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.Cover4_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover4_pictureBox.TabIndex = 3;
            this.Cover4_pictureBox.TabStop = false;
            // 
            // Cover3_pictureBox
            // 
            this.Cover3_pictureBox.Image = global::Tify.Properties.Resources.dummy_artist1;
            this.Cover3_pictureBox.Location = new System.Drawing.Point(3, 100);
            this.Cover3_pictureBox.Name = "Cover3_pictureBox";
            this.Cover3_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.Cover3_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover3_pictureBox.TabIndex = 2;
            this.Cover3_pictureBox.TabStop = false;
            // 
            // playShuffle_Button
            // 
            this.playShuffle_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
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
            // 
            // Cover2_pictureBox
            // 
            this.Cover2_pictureBox.Image = global::Tify.Properties.Resources.dummy_artist;
            this.Cover2_pictureBox.Location = new System.Drawing.Point(100, 3);
            this.Cover2_pictureBox.Name = "Cover2_pictureBox";
            this.Cover2_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.Cover2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover2_pictureBox.TabIndex = 1;
            this.Cover2_pictureBox.TabStop = false;
            // 
            // Cover1_pictureBox
            // 
            this.Cover1_pictureBox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.Cover1_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.Cover1_pictureBox.Name = "Cover1_pictureBox";
            this.Cover1_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.Cover1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover1_pictureBox.TabIndex = 0;
            this.Cover1_pictureBox.TabStop = false;
            // 
            // addToPlaylist_Button
            // 
            this.addToPlaylist_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
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
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist Name";
            // 
            // playlistCover_pictureBox
            // 
            this.playlistCover_pictureBox.Controls.Add(this.Cover4_pictureBox);
            this.playlistCover_pictureBox.Controls.Add(this.Cover3_pictureBox);
            this.playlistCover_pictureBox.Controls.Add(this.Cover2_pictureBox);
            this.playlistCover_pictureBox.Controls.Add(this.Cover1_pictureBox);
            this.playlistCover_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.playlistCover_pictureBox.Name = "playlistCover_pictureBox";
            this.playlistCover_pictureBox.Size = new System.Drawing.Size(200, 200);
            this.playlistCover_pictureBox.TabIndex = 0;
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.addToPlaylist_Button);
            this.top_panel.Controls.Add(this.playShuffle_Button);
            this.top_panel.Controls.Add(this.play_button);
            this.top_panel.Controls.Add(this.createdBy_label);
            this.top_panel.Controls.Add(this.label2);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.playlistCover_pictureBox);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 270);
            this.top_panel.TabIndex = 2;
            // 
            // createdBy_label
            // 
            this.createdBy_label.AutoSize = true;
            this.createdBy_label.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdBy_label.ForeColor = System.Drawing.Color.Gray;
            this.createdBy_label.Location = new System.Drawing.Point(222, 124);
            this.createdBy_label.Name = "createdBy_label";
            this.createdBy_label.Size = new System.Drawing.Size(263, 20);
            this.createdBy_label.TabIndex = 2;
            this.createdBy_label.Text = "Created by me - 10 Tracks - 1:24:00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.title,
            this.artist,
            this.dateAdded,
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
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 300);
            this.dataGridView1.TabIndex = 3;
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
            // dateAdded
            // 
            this.dateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAdded.HeaderText = "DATE ADDED";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
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
            // PlaylistDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaylistDetail";
            this.Text = "PlaylistDetail";
            ((System.ComponentModel.ISupportInitialize)(this.Cover4_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover3_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover1_pictureBox)).EndInit();
            this.playlistCover_pictureBox.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Cover4_pictureBox;
        private System.Windows.Forms.PictureBox Cover3_pictureBox;
        private System.Windows.Forms.Button playShuffle_Button;
        private System.Windows.Forms.PictureBox Cover2_pictureBox;
        private System.Windows.Forms.PictureBox Cover1_pictureBox;
        private System.Windows.Forms.Button addToPlaylist_Button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel playlistCover_pictureBox;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.Windows.Forms.Label createdBy_label;
    }
}