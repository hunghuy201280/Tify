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
            this.numberOfTracks_label = new System.Windows.Forms.Label();
            this.playlistName_label = new System.Windows.Forms.Label();
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
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // numberOfTracks_label
            // 
            this.numberOfTracks_label.AutoSize = true;
            this.numberOfTracks_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTracks_label.ForeColor = System.Drawing.Color.White;
            this.numberOfTracks_label.Location = new System.Drawing.Point(13, 207);
            this.numberOfTracks_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.numberOfTracks_label.Name = "numberOfTracks_label";
            this.numberOfTracks_label.Size = new System.Drawing.Size(48, 16);
            this.numberOfTracks_label.TabIndex = 11;
            this.numberOfTracks_label.Text = "Playlist";
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
            // MyMixContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.myMixCover_panel);
            this.Controls.Add(this.numberOfTracks_label);
            this.Controls.Add(this.playlistName_label);
            this.Name = "MyMixContainer";
            this.Size = new System.Drawing.Size(172, 230);
            this.Load += new System.EventHandler(this.MyMixContainer_Load);
            this.myMixCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel myMixCover_panel;
        private System.Windows.Forms.Panel opacity_panel;
        private System.Windows.Forms.Label numberOfTracks_label;
        private System.Windows.Forms.Label playlistName_label;
    }
}
