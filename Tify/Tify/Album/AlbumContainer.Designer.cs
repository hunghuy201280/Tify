namespace Tify
{
    partial class AlbumContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumContainer));
            this.albumCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.albumArtist_label = new System.Windows.Forms.Label();
            this.albumName_label = new System.Windows.Forms.Label();
            this.albumYear_label = new System.Windows.Forms.Label();
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.track_worker = new System.ComponentModel.BackgroundWorker();
            this.albumCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // albumCover_panel
            // 
            this.albumCover_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("albumCover_panel.BackgroundImage")));
            this.albumCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.albumCover_panel.Controls.Add(this.opacity_panel);
            this.albumCover_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumCover_panel.Location = new System.Drawing.Point(0, 0);
            this.albumCover_panel.Margin = new System.Windows.Forms.Padding(4);
            this.albumCover_panel.Name = "albumCover_panel";
            this.albumCover_panel.Size = new System.Drawing.Size(229, 212);
            this.albumCover_panel.TabIndex = 10;
            this.albumCover_panel.MouseHover += new System.EventHandler(this.albumCover_panel_MouseHover);
            // 
            // opacity_panel
            // 
            this.opacity_panel.BackColor = System.Drawing.Color.Transparent;
            this.opacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opacity_panel.BackgroundImage")));
            this.opacity_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.opacity_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opacity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opacity_panel.Location = new System.Drawing.Point(0, 0);
            this.opacity_panel.Margin = new System.Windows.Forms.Padding(4);
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(229, 212);
            this.opacity_panel.TabIndex = 0;
            this.opacity_panel.Visible = false;
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // albumArtist_label
            // 
            this.albumArtist_label.AutoSize = true;
            this.albumArtist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtist_label.ForeColor = System.Drawing.Color.White;
            this.albumArtist_label.Location = new System.Drawing.Point(0, 249);
            this.albumArtist_label.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.albumArtist_label.Name = "albumArtist_label";
            this.albumArtist_label.Size = new System.Drawing.Size(83, 22);
            this.albumArtist_label.TabIndex = 12;
            this.albumArtist_label.Text = "Yorushika";
            // 
            // albumName_label
            // 
            this.albumName_label.AutoSize = true;
            this.albumName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName_label.ForeColor = System.Drawing.Color.White;
            this.albumName_label.Location = new System.Drawing.Point(0, 222);
            this.albumName_label.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.albumName_label.Name = "albumName_label";
            this.albumName_label.Size = new System.Drawing.Size(179, 23);
            this.albumName_label.TabIndex = 11;
            this.albumName_label.Text = "Ghost In A Flower";
            // 
            // albumYear_label
            // 
            this.albumYear_label.AutoSize = true;
            this.albumYear_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumYear_label.ForeColor = System.Drawing.Color.White;
            this.albumYear_label.Location = new System.Drawing.Point(0, 271);
            this.albumYear_label.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.albumYear_label.Name = "albumYear_label";
            this.albumYear_label.Size = new System.Drawing.Size(50, 22);
            this.albumYear_label.TabIndex = 12;
            this.albumYear_label.Text = "2020";
            // 
            // track_worker
            // 
            this.track_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.track_worker_DoWork);
            this.track_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.track_worker_RunWorkerCompleted);
            // 
            // AlbumContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.albumYear_label);
            this.Controls.Add(this.albumArtist_label);
            this.Controls.Add(this.albumName_label);
            this.Controls.Add(this.albumCover_panel);
            this.Margin = new System.Windows.Forms.Padding(7, 0, 7, 6);
            this.Name = "AlbumContainer";
            this.Size = new System.Drawing.Size(229, 290);
            this.Load += new System.EventHandler(this.AlbumContainer_Load);
            this.albumCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel opacity_panel;
        public System.Windows.Forms.Panel albumCover_panel;
        public System.Windows.Forms.Label albumArtist_label;
        public System.Windows.Forms.Label albumName_label;
        public System.Windows.Forms.Label albumYear_label;
        private System.ComponentModel.BackgroundWorker load_worker;
        private System.ComponentModel.BackgroundWorker track_worker;
    }
}
