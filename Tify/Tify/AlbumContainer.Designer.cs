﻿namespace Tify
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
            this.albumCover_panel.Name = "albumCover_panel";
            this.albumCover_panel.Size = new System.Drawing.Size(172, 172);
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
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(172, 172);
            this.opacity_panel.TabIndex = 0;
            this.opacity_panel.Visible = false;
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // albumArtist_label
            // 
            this.albumArtist_label.AutoSize = true;
            this.albumArtist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtist_label.ForeColor = System.Drawing.Color.White;
            this.albumArtist_label.Location = new System.Drawing.Point(0, 202);
            this.albumArtist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albumArtist_label.Name = "albumArtist_label";
            this.albumArtist_label.Size = new System.Drawing.Size(64, 16);
            this.albumArtist_label.TabIndex = 12;
            this.albumArtist_label.Text = "Yorushika";
            // 
            // albumName_label
            // 
            this.albumName_label.AutoSize = true;
            this.albumName_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName_label.ForeColor = System.Drawing.Color.White;
            this.albumName_label.Location = new System.Drawing.Point(0, 180);
            this.albumName_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albumName_label.Name = "albumName_label";
            this.albumName_label.Size = new System.Drawing.Size(143, 17);
            this.albumName_label.TabIndex = 11;
            this.albumName_label.Text = "Ghost In A Flower";
            // 
            // AlbumContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.albumArtist_label);
            this.Controls.Add(this.albumName_label);
            this.Controls.Add(this.albumCover_panel);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Name = "AlbumContainer";
            this.Size = new System.Drawing.Size(172, 226);
            this.Load += new System.EventHandler(this.AlbumContainer_Load);
            this.albumCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel albumCover_panel;
        private System.Windows.Forms.Panel opacity_panel;
        private System.Windows.Forms.Label albumArtist_label;
        private System.Windows.Forms.Label albumName_label;
    }
}