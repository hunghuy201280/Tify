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
            this.panel_default_playlist = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.panel_default_playlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottom_flowPanel
            // 
            this.bottom_flowPanel.AutoScroll = true;
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
        private System.Windows.Forms.Panel panel_default_playlist;
    }
}