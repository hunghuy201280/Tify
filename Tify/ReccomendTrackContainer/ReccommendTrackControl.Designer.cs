namespace ReccomendTrackContainer
{
    partial class ReccommendTrackControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReccommendTrackControl));
            this.songCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.artist_label = new System.Windows.Forms.Label();
            this.songCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // songCover_panel
            // 
            this.songCover_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songCover_panel.BackgroundImage")));
            this.songCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.songCover_panel.Controls.Add(this.opacity_panel);
            this.songCover_panel.Location = new System.Drawing.Point(8, 8);
            this.songCover_panel.Margin = new System.Windows.Forms.Padding(8);
            this.songCover_panel.Name = "songCover_panel";
            this.songCover_panel.Size = new System.Drawing.Size(43, 43);
            this.songCover_panel.TabIndex = 0;
            this.songCover_panel.MouseHover += new System.EventHandler(this.songCover_panel_MouseHover);
            // 
            // opacity_panel
            // 
            this.opacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opacity_panel.BackgroundImage")));
            this.opacity_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.opacity_panel.Location = new System.Drawing.Point(0, 0);
            this.opacity_panel.Margin = new System.Windows.Forms.Padding(8);
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(43, 43);
            this.opacity_panel.TabIndex = 3;
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(59, 8);
            this.title_label.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(118, 17);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Hana ni bourei";
            // 
            // artist_label
            // 
            this.artist_label.AutoSize = true;
            this.artist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artist_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(128)))), ((int)(((byte)(137)))));
            this.artist_label.Location = new System.Drawing.Point(62, 33);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(43, 16);
            this.artist_label.TabIndex = 2;
            this.artist_label.Text = "label1";
            // 
            // ReccommendTrackControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.artist_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.songCover_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ReccommendTrackControl";
            this.Size = new System.Drawing.Size(630, 59);
            this.songCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel songCover_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label artist_label;
        private System.Windows.Forms.Panel opacity_panel;
    }
}
