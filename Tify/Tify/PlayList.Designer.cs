namespace Tify
{
    partial class PlayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayList_button = new System.Windows.Forms.Button();
            this.Playlist_label = new System.Windows.Forms.Label();
            this.panel_default_playlist = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_default_playlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PlayList_button
            // 
            this.PlayList_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.PlayList_button.FlatAppearance.BorderSize = 0;
            this.PlayList_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayList_button.ForeColor = System.Drawing.Color.White;
            this.PlayList_button.Location = new System.Drawing.Point(288, 328);
            this.PlayList_button.Name = "PlayList_button";
            this.PlayList_button.Size = new System.Drawing.Size(202, 63);
            this.PlayList_button.TabIndex = 0;
            this.PlayList_button.Text = "View Tiffy\'s top play lists";
            this.PlayList_button.UseVisualStyleBackColor = false;
            // 
            // Playlist_label
            // 
            this.Playlist_label.AutoSize = true;
            this.Playlist_label.Font = new System.Drawing.Font("Nationale Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist_label.ForeColor = System.Drawing.Color.White;
            this.Playlist_label.Location = new System.Drawing.Point(3, 218);
            this.Playlist_label.Name = "Playlist_label";
            this.Playlist_label.Size = new System.Drawing.Size(764, 42);
            this.Playlist_label.TabIndex = 2;
            this.Playlist_label.Text = "You don\'t have any playlist, but you will soon do.";
            // 
            // panel_default_playlist
            // 
            this.panel_default_playlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_default_playlist.Controls.Add(this.pictureBox1);
            this.panel_default_playlist.Controls.Add(this.PlayList_button);
            this.panel_default_playlist.Controls.Add(this.Playlist_label);
            this.panel_default_playlist.Location = new System.Drawing.Point(47, 12);
            this.panel_default_playlist.Name = "panel_default_playlist";
            this.panel_default_playlist.Size = new System.Drawing.Size(814, 426);
            this.panel_default_playlist.TabIndex = 3;
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.panel_default_playlist);
            this.Name = "PlayList";
            this.Text = "PlayList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_default_playlist.ResumeLayout(false);
            this.panel_default_playlist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayList_button;
        private System.Windows.Forms.Label Playlist_label;
        private System.Windows.Forms.Panel panel_default_playlist;
    }
}