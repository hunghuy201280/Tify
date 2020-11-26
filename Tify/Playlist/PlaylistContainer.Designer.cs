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
            this.numberOfTracks_label = new System.Windows.Forms.Label();
            this.playlistName_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // numberOfTracks_label
            // 
            this.numberOfTracks_label.AutoSize = true;
            this.numberOfTracks_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTracks_label.ForeColor = System.Drawing.Color.White;
            this.numberOfTracks_label.Location = new System.Drawing.Point(16, 195);
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
            this.playlistName_label.Location = new System.Drawing.Point(16, 173);
            this.playlistName_label.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.playlistName_label.Name = "playlistName_label";
            this.playlistName_label.Size = new System.Drawing.Size(109, 17);
            this.playlistName_label.TabIndex = 4;
            this.playlistName_label.Text = "Japan Top 50";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 172);
            this.panel1.TabIndex = 6;
            // 
            // PlaylistContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numberOfTracks_label);
            this.Controls.Add(this.playlistName_label);
            this.Margin = new System.Windows.Forms.Padding(5, 30, 5, 0);
            this.Name = "PlaylistContainer";
            this.Size = new System.Drawing.Size(180, 252);
            this.Load += new System.EventHandler(this.PlaylistContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfTracks_label;
        private System.Windows.Forms.Label playlistName_label;
        private System.Windows.Forms.Panel panel1;
    }
}
