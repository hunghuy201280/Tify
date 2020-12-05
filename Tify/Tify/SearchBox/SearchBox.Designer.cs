namespace Tify
{
    partial class SearchBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            this.top_panel = new System.Windows.Forms.Panel();
            this.SearchBox_PlayLists = new System.Windows.Forms.Button();
            this.SearchBox_Album = new System.Windows.Forms.Button();
            this.SearchBox_Artists = new System.Windows.Forms.Button();
            this.SearchBox_Tracks = new System.Windows.Forms.Button();
            this.rightIconImgList = new System.Windows.Forms.ImageList(this.components);
            this.ChildForm_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.SearchBox_PlayLists);
            this.top_panel.Controls.Add(this.SearchBox_Album);
            this.top_panel.Controls.Add(this.SearchBox_Artists);
            this.top_panel.Controls.Add(this.SearchBox_Tracks);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(871, 59);
            this.top_panel.TabIndex = 3;
            // 
            // SearchBox_PlayLists
            // 
            this.SearchBox_PlayLists.FlatAppearance.BorderSize = 0;
            this.SearchBox_PlayLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_PlayLists.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_PlayLists.ForeColor = System.Drawing.Color.White;
            this.SearchBox_PlayLists.Location = new System.Drawing.Point(327, 12);
            this.SearchBox_PlayLists.Name = "SearchBox_PlayLists";
            this.SearchBox_PlayLists.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_PlayLists.TabIndex = 9;
            this.SearchBox_PlayLists.Text = "PlayLists";
            this.SearchBox_PlayLists.UseVisualStyleBackColor = true;
            // 
            // SearchBox_Album
            // 
            this.SearchBox_Album.FlatAppearance.BorderSize = 0;
            this.SearchBox_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Album.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Album.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Album.Location = new System.Drawing.Point(222, 12);
            this.SearchBox_Album.Name = "SearchBox_Album";
            this.SearchBox_Album.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Album.TabIndex = 8;
            this.SearchBox_Album.Text = "Album";
            this.SearchBox_Album.UseVisualStyleBackColor = true;
            // 
            // SearchBox_Artists
            // 
            this.SearchBox_Artists.FlatAppearance.BorderSize = 0;
            this.SearchBox_Artists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Artists.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Artists.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Artists.Location = new System.Drawing.Point(117, 12);
            this.SearchBox_Artists.Name = "SearchBox_Artists";
            this.SearchBox_Artists.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Artists.TabIndex = 7;
            this.SearchBox_Artists.Text = "Artists";
            this.SearchBox_Artists.UseVisualStyleBackColor = true;
            // 
            // SearchBox_Tracks
            // 
            this.SearchBox_Tracks.FlatAppearance.BorderSize = 0;
            this.SearchBox_Tracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox_Tracks.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_Tracks.ForeColor = System.Drawing.Color.White;
            this.SearchBox_Tracks.Location = new System.Drawing.Point(12, 12);
            this.SearchBox_Tracks.Name = "SearchBox_Tracks";
            this.SearchBox_Tracks.Size = new System.Drawing.Size(90, 30);
            this.SearchBox_Tracks.TabIndex = 6;
            this.SearchBox_Tracks.Text = "Tracks";
            this.SearchBox_Tracks.UseVisualStyleBackColor = true;
            // 
            // rightIconImgList
            // 
            this.rightIconImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightIconImgList.ImageStream")));
            this.rightIconImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightIconImgList.Images.SetKeyName(0, "add.png");
            this.rightIconImgList.Images.SetKeyName(1, "like.png");
            this.rightIconImgList.Images.SetKeyName(2, "liked.png");
            // 
            // ChildForm_panel
            // 
            this.ChildForm_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildForm_panel.Location = new System.Drawing.Point(0, 59);
            this.ChildForm_panel.Name = "ChildForm_panel";
            this.ChildForm_panel.Size = new System.Drawing.Size(871, 472);
            this.ChildForm_panel.TabIndex = 4;
            // 
            // SearchBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(871, 531);
            this.Controls.Add(this.ChildForm_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBox1";
            this.Text = "SearchBox";
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.ImageList rightIconImgList;
        private System.Windows.Forms.Panel ChildForm_panel;
        private System.Windows.Forms.Button SearchBox_Tracks;
        private System.Windows.Forms.Button SearchBox_PlayLists;
        private System.Windows.Forms.Button SearchBox_Album;
        private System.Windows.Forms.Button SearchBox_Artists;
    }
}