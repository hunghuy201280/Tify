namespace Playlist
{
    partial class PlaylistContainer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistContainer));
            this.numberOfTracks_label = new System.Windows.Forms.Label();
            this.playlistName_label = new System.Windows.Forms.Label();
            this.playListCover_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playListCover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfTracks_label
            // 
            this.numberOfTracks_label.AutoSize = true;
            this.numberOfTracks_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTracks_label.ForeColor = System.Drawing.Color.White;
            this.numberOfTracks_label.Location = new System.Drawing.Point(21, 180);
            this.numberOfTracks_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.numberOfTracks_label.Name = "numberOfTracks_label";
            this.numberOfTracks_label.Size = new System.Drawing.Size(48, 16);
            this.numberOfTracks_label.TabIndex = 5;
            this.numberOfTracks_label.Text = "Playlist";
            // 
            // playlistName_label
            // 
            this.playlistName_label.AutoSize = true;
            this.playlistName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName_label.ForeColor = System.Drawing.Color.White;
            this.playlistName_label.Location = new System.Drawing.Point(21, 158);
            this.playlistName_label.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.playlistName_label.Name = "playlistName_label";
            this.playlistName_label.Size = new System.Drawing.Size(109, 17);
            this.playlistName_label.TabIndex = 4;
            this.playlistName_label.Text = "Japan Top 50";
            // 
            // playListCover_pictureBox
            // 
            this.playListCover_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playListCover_pictureBox.Image")));
            this.playListCover_pictureBox.Location = new System.Drawing.Point(24, 5);
            this.playListCover_pictureBox.Name = "playListCover_pictureBox";
            this.playListCover_pictureBox.Size = new System.Drawing.Size(135, 135);
            this.playListCover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playListCover_pictureBox.TabIndex = 3;
            this.playListCover_pictureBox.TabStop = false;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.numberOfTracks_label);
            this.Controls.Add(this.playlistName_label);
            this.Controls.Add(this.playListCover_pictureBox);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(180, 201);
            ((System.ComponentModel.ISupportInitialize)(this.playListCover_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfTracks_label;
        private System.Windows.Forms.Label playlistName_label;
        private System.Windows.Forms.PictureBox playListCover_pictureBox;
    }
}
