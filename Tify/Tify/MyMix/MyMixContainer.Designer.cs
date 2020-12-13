namespace Tify
{
    partial class MyMixContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMixContainer));
            this.myMixCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.artist_label = new System.Windows.Forms.Label();
            this.playlistName_label = new System.Windows.Forms.Label();
            this.cover_worker = new System.ComponentModel.BackgroundWorker();
            this.artist_worker = new System.ComponentModel.BackgroundWorker();
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.reload_worker = new System.ComponentModel.BackgroundWorker();
            this.myMixCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMixCover_panel
            // 
            this.myMixCover_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myMixCover_panel.BackgroundImage")));
            this.myMixCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.myMixCover_panel.Controls.Add(this.opacity_panel);
            this.myMixCover_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.myMixCover_panel.Location = new System.Drawing.Point(0, 0);
            this.myMixCover_panel.Name = "myMixCover_panel";
            this.myMixCover_panel.Size = new System.Drawing.Size(172, 172);
            this.myMixCover_panel.TabIndex = 12;
            this.myMixCover_panel.MouseHover += new System.EventHandler(this.myMixCover_panel_MouseHover);
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
            // artist_label
            // 
            this.artist_label.AutoSize = true;
            this.artist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_label.ForeColor = System.Drawing.Color.White;
            this.artist_label.Location = new System.Drawing.Point(13, 207);
            this.artist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artist_label.MaximumSize = new System.Drawing.Size(148, 0);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(38, 16);
            this.artist_label.TabIndex = 11;
            this.artist_label.Text = "Artist";
            // 
            // playlistName_label
            // 
            this.playlistName_label.AutoSize = true;
            this.playlistName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName_label.ForeColor = System.Drawing.Color.White;
            this.playlistName_label.Location = new System.Drawing.Point(13, 185);
            this.playlistName_label.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.playlistName_label.Name = "playlistName_label";
            this.playlistName_label.Size = new System.Drawing.Size(109, 17);
            this.playlistName_label.TabIndex = 10;
            this.playlistName_label.Text = "Japan Top 50";
            // 
            // cover_worker
            // 
            this.cover_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cover_worker_DoWork);
            this.cover_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.cover_worker_RunWorkerCompleted);
            // 
            // artist_worker
            // 
            this.artist_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.artist_worker_DoWork);
            this.artist_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.artist_worker_RunWorkerCompleted);
            // 
            // load_worker
            // 
            this.load_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_worker_DoWork);
            this.load_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_worker_RunWorkerCompleted);
            // 
            // reload_worker
            // 
            this.reload_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.reload_worker_DoWork);
            this.reload_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.reload_worker_RunWorkerCompleted);
            // 
            // MyMixContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.myMixCover_panel);
            this.Controls.Add(this.artist_label);
            this.Controls.Add(this.playlistName_label);
            this.Name = "MyMixContainer";
            this.Size = new System.Drawing.Size(172, 246);
            this.Load += new System.EventHandler(this.MyMixContainer_Load);
            this.myMixCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel myMixCover_panel;
        private System.Windows.Forms.Panel opacity_panel;
        private System.ComponentModel.BackgroundWorker cover_worker;
        private System.ComponentModel.BackgroundWorker artist_worker;
        private System.ComponentModel.BackgroundWorker load_worker;
        private System.ComponentModel.BackgroundWorker reload_worker;
        public System.Windows.Forms.Label playlistName_label;
        public System.Windows.Forms.Label artist_label;
    }
}
