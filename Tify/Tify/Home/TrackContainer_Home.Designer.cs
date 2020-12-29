namespace Tify
{
    partial class TrackContainer_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackContainer_Home));
            this.trackDuration_label = new System.Windows.Forms.Label();
            this.trackArtist_label = new System.Windows.Forms.Label();
            this.trackName_label = new System.Windows.Forms.Label();
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.track_worker = new System.ComponentModel.BackgroundWorker();
            this.trackCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.trackCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackDuration_label
            // 
            this.trackDuration_label.AutoSize = true;
            this.trackDuration_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackDuration_label.ForeColor = System.Drawing.Color.White;
            this.trackDuration_label.Location = new System.Drawing.Point(0, 220);
            this.trackDuration_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trackDuration_label.Name = "trackDuration_label";
            this.trackDuration_label.Size = new System.Drawing.Size(40, 16);
            this.trackDuration_label.TabIndex = 15;
            this.trackDuration_label.Text = "03:40";
            // 
            // trackArtist_label
            // 
            this.trackArtist_label.AutoSize = true;
            this.trackArtist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackArtist_label.ForeColor = System.Drawing.Color.White;
            this.trackArtist_label.Location = new System.Drawing.Point(0, 202);
            this.trackArtist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trackArtist_label.Name = "trackArtist_label";
            this.trackArtist_label.Size = new System.Drawing.Size(64, 16);
            this.trackArtist_label.TabIndex = 16;
            this.trackArtist_label.Text = "Yorushika";
            // 
            // trackName_label
            // 
            this.trackName_label.AutoSize = true;
            this.trackName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackName_label.ForeColor = System.Drawing.Color.White;
            this.trackName_label.Location = new System.Drawing.Point(0, 180);
            this.trackName_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trackName_label.Name = "trackName_label";
            this.trackName_label.Size = new System.Drawing.Size(143, 17);
            this.trackName_label.TabIndex = 14;
            this.trackName_label.Text = "Ghost In A Flower";
            // 
            // load_worker
            // 
            this.load_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_worker_DoWork);
            this.load_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_worker_RunWorkerCompleted);
            // 
            // trackCover_panel
            // 
            this.trackCover_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackCover_panel.BackgroundImage")));
            this.trackCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trackCover_panel.Controls.Add(this.opacity_panel);
            this.trackCover_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackCover_panel.Location = new System.Drawing.Point(0, 0);
            this.trackCover_panel.Name = "trackCover_panel";
            this.trackCover_panel.Size = new System.Drawing.Size(172, 172);
            this.trackCover_panel.TabIndex = 13;
            this.trackCover_panel.MouseHover += new System.EventHandler(this.TrackCover_panel_MouseHover);
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
            // TrackContainer_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.trackDuration_label);
            this.Controls.Add(this.trackArtist_label);
            this.Controls.Add(this.trackName_label);
            this.Controls.Add(this.trackCover_panel);
            this.Name = "TrackContainer_Home";
            this.Size = new System.Drawing.Size(172, 236);
            this.Load += new System.EventHandler(this.TrackContainer_Home_Load);
            this.trackCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label trackDuration_label;
        public System.Windows.Forms.Label trackArtist_label;
        public System.Windows.Forms.Label trackName_label;
        public System.Windows.Forms.Panel trackCover_panel;
        public System.Windows.Forms.Panel opacity_panel;
        public System.ComponentModel.BackgroundWorker load_worker;
        public System.ComponentModel.BackgroundWorker track_worker;
    }
}
