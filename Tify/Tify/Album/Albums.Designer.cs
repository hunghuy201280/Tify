namespace Tify
{
    partial class Albums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Albums));
            this.bottom_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Playlist_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.sort_button = new System.Windows.Forms.Button();
            this.panel_default_playlist = new System.Windows.Forms.Panel();
            this.albumContainer1 = new Tify.AlbumContainer();
            this.albumContainer2 = new Tify.AlbumContainer();
            this.albumContainer3 = new Tify.AlbumContainer();
            this.albumContainer4 = new Tify.AlbumContainer();
            this.bottom_flowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.panel_default_playlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottom_flowPanel
            // 
            this.bottom_flowPanel.Controls.Add(this.albumContainer1);
            this.bottom_flowPanel.Controls.Add(this.albumContainer2);
            this.bottom_flowPanel.Controls.Add(this.albumContainer3);
            this.bottom_flowPanel.Controls.Add(this.albumContainer4);
            this.bottom_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_flowPanel.Location = new System.Drawing.Point(0, 57);
            this.bottom_flowPanel.Name = "bottom_flowPanel";
            this.bottom_flowPanel.Size = new System.Drawing.Size(887, 621);
            this.bottom_flowPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Playlist_label
            // 
            this.Playlist_label.AutoSize = true;
            this.Playlist_label.Font = new System.Drawing.Font("Nationale Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist_label.ForeColor = System.Drawing.Color.White;
            this.Playlist_label.Location = new System.Drawing.Point(2, 177);
            this.Playlist_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Playlist_label.Name = "Playlist_label";
            this.Playlist_label.Size = new System.Drawing.Size(598, 33);
            this.Playlist_label.TabIndex = 2;
            this.Playlist_label.Text = "You don\'t have any playlist, but you will soon do.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bottom_flowPanel);
            this.panel1.Controls.Add(this.top_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 678);
            this.panel1.TabIndex = 6;
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Controls.Add(this.sort_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 57);
            this.top_panel.TabIndex = 0;
            // 
            // formTitle_label
            // 
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle_label.ForeColor = System.Drawing.Color.White;
            this.formTitle_label.Location = new System.Drawing.Point(12, 16);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(117, 23);
            this.formTitle_label.TabIndex = 5;
            this.formTitle_label.Text = "My Albums";
            // 
            // sort_button
            // 
            this.sort_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sort_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sort_button.BackgroundImage")));
            this.sort_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sort_button.FlatAppearance.BorderSize = 0;
            this.sort_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_button.Location = new System.Drawing.Point(843, 12);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(32, 32);
            this.sort_button.TabIndex = 6;
            this.sort_button.UseVisualStyleBackColor = true;
            // 
            // panel_default_playlist
            // 
            this.panel_default_playlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_default_playlist.Controls.Add(this.pictureBox1);
            this.panel_default_playlist.Controls.Add(this.Playlist_label);
            this.panel_default_playlist.Location = new System.Drawing.Point(35, 10);
            this.panel_default_playlist.Margin = new System.Windows.Forms.Padding(2);
            this.panel_default_playlist.Name = "panel_default_playlist";
            this.panel_default_playlist.Size = new System.Drawing.Size(610, 346);
            this.panel_default_playlist.TabIndex = 5;
            // 
            // albumContainer1
            // 
            this.albumContainer1.BackColor = System.Drawing.Color.Black;
            this.albumContainer1.Location = new System.Drawing.Point(5, 0);
            this.albumContainer1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.albumContainer1.Name = "albumContainer1";
            this.albumContainer1.Size = new System.Drawing.Size(172, 226);
            this.albumContainer1.TabIndex = 0;
            // 
            // albumContainer2
            // 
            this.albumContainer2.BackColor = System.Drawing.Color.Black;
            this.albumContainer2.Location = new System.Drawing.Point(187, 0);
            this.albumContainer2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.albumContainer2.Name = "albumContainer2";
            this.albumContainer2.Size = new System.Drawing.Size(172, 226);
            this.albumContainer2.TabIndex = 1;
            // 
            // albumContainer3
            // 
            this.albumContainer3.BackColor = System.Drawing.Color.Black;
            this.albumContainer3.Location = new System.Drawing.Point(369, 0);
            this.albumContainer3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.albumContainer3.Name = "albumContainer3";
            this.albumContainer3.Size = new System.Drawing.Size(172, 226);
            this.albumContainer3.TabIndex = 2;
            // 
            // albumContainer4
            // 
            this.albumContainer4.BackColor = System.Drawing.Color.Black;
            this.albumContainer4.Location = new System.Drawing.Point(551, 0);
            this.albumContainer4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.albumContainer4.Name = "albumContainer4";
            this.albumContainer4.Size = new System.Drawing.Size(172, 226);
            this.albumContainer4.TabIndex = 3;
            // 
            // Albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_default_playlist);
            this.Name = "Albums";
            this.Text = "Albums";
            this.bottom_flowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel_default_playlist.ResumeLayout(false);
            this.panel_default_playlist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bottom_flowPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Playlist_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Panel panel_default_playlist;
        private AlbumContainer albumContainer1;
        private AlbumContainer albumContainer2;
        private AlbumContainer albumContainer3;
        private AlbumContainer albumContainer4;
    }
}