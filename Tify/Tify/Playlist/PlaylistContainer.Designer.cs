namespace Tify
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
            this.playlistCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.createdBy_label = new System.Windows.Forms.Label();
            this.trackTable_woker = new System.ComponentModel.BackgroundWorker();
            this.playlistCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberOfTracks_label
            // 
            this.numberOfTracks_label.AutoSize = true;
            this.numberOfTracks_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTracks_label.ForeColor = System.Drawing.Color.White;
            this.numberOfTracks_label.Location = new System.Drawing.Point(11, 202);
            this.numberOfTracks_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.numberOfTracks_label.Name = "numberOfTracks_label";
            this.numberOfTracks_label.Size = new System.Drawing.Size(51, 16);
            this.numberOfTracks_label.TabIndex = 8;
            this.numberOfTracks_label.Text = "0 tracks";
            // 
            // playlistName_label
            // 
            this.playlistName_label.AutoSize = true;
            this.playlistName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName_label.ForeColor = System.Drawing.Color.White;
            this.playlistName_label.Location = new System.Drawing.Point(11, 180);
            this.playlistName_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.playlistName_label.Name = "playlistName_label";
            this.playlistName_label.Size = new System.Drawing.Size(78, 17);
            this.playlistName_label.TabIndex = 7;
            this.playlistName_label.Text = "Playlist 1";
            // 
            // playlistCover_panel
            // 
            this.playlistCover_panel.BackgroundImage = global::Tify.Properties.Resources.emptyplaylist;
            this.playlistCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistCover_panel.Controls.Add(this.opacity_panel);
            this.playlistCover_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistCover_panel.Location = new System.Drawing.Point(0, 0);
            this.playlistCover_panel.Name = "playlistCover_panel";
            this.playlistCover_panel.Size = new System.Drawing.Size(172, 172);
            this.playlistCover_panel.TabIndex = 9;
            this.playlistCover_panel.MouseHover += new System.EventHandler(this.playlistCover_panel_MouseHover);
            // 
            // opacity_panel
            // 
            this.opacity_panel.BackColor = System.Drawing.Color.Transparent;
            this.opacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opacity_panel.BackgroundImage")));
            this.opacity_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.opacity_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opacity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opacity_panel.Location = new System.Drawing.Point(0, 0);
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(172, 172);
            this.opacity_panel.TabIndex = 0;
            this.opacity_panel.Visible = false;
            this.opacity_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opacity_panel_MouseClick);
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // load_worker
            // 
            this.load_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_worker_DoWork);
            this.load_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_worker_RunWorkerCompleted);
            // 
            // createdBy_label
            // 
            this.createdBy_label.AutoSize = true;
            this.createdBy_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdBy_label.ForeColor = System.Drawing.Color.White;
            this.createdBy_label.Location = new System.Drawing.Point(11, 223);
            this.createdBy_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.createdBy_label.Name = "createdBy_label";
            this.createdBy_label.Size = new System.Drawing.Size(51, 16);
            this.createdBy_label.TabIndex = 8;
            this.createdBy_label.Text = "0 tracks";
            // 
            // trackTable_woker
            // 
            this.trackTable_woker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.trackTable_woker_DoWork);
            this.trackTable_woker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.trackTable_woker_RunWorkerCompleted);
            // 
            // PlaylistContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.playlistCover_panel);
            this.Controls.Add(this.createdBy_label);
            this.Controls.Add(this.numberOfTracks_label);
            this.Controls.Add(this.playlistName_label);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Name = "PlaylistContainer";
            this.Size = new System.Drawing.Size(172, 248);
            this.Load += new System.EventHandler(this.PlaylistContainer_Load);
            this.playlistCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel playlistCover_panel;
        private System.Windows.Forms.Panel opacity_panel;
        private System.ComponentModel.BackgroundWorker load_worker;
        public System.Windows.Forms.Label numberOfTracks_label;
        public System.Windows.Forms.Label playlistName_label;
        public System.Windows.Forms.Label createdBy_label;
        private System.ComponentModel.BackgroundWorker trackTable_woker;
    }
}
