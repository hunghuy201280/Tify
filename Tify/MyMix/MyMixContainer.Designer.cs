namespace MyMix
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
            this.MyMixArtist_label = new System.Windows.Forms.Label();
            this.MyMixName_label = new System.Windows.Forms.Label();
            this.MyMixCover_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyMixCover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MyMixArtist_label
            // 
            this.MyMixArtist_label.AutoSize = true;
            this.MyMixArtist_label.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMixArtist_label.ForeColor = System.Drawing.Color.White;
            this.MyMixArtist_label.Location = new System.Drawing.Point(21, 180);
            this.MyMixArtist_label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MyMixArtist_label.Name = "MyMixArtist_label";
            this.MyMixArtist_label.Size = new System.Drawing.Size(48, 16);
            this.MyMixArtist_label.TabIndex = 8;
            this.MyMixArtist_label.Text = "Playlist";
            // 
            // MyMixName_label
            // 
            this.MyMixName_label.AutoSize = true;
            this.MyMixName_label.Font = new System.Drawing.Font("Nationale", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMixName_label.ForeColor = System.Drawing.Color.White;
            this.MyMixName_label.Location = new System.Drawing.Point(21, 158);
            this.MyMixName_label.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.MyMixName_label.Name = "MyMixName_label";
            this.MyMixName_label.Size = new System.Drawing.Size(109, 17);
            this.MyMixName_label.TabIndex = 7;
            this.MyMixName_label.Text = "Japan Top 50";
            // 
            // MyMixCover_pictureBox
            // 
            this.MyMixCover_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MyMixCover_pictureBox.Image")));
            this.MyMixCover_pictureBox.Location = new System.Drawing.Point(24, 5);
            this.MyMixCover_pictureBox.Name = "MyMixCover_pictureBox";
            this.MyMixCover_pictureBox.Size = new System.Drawing.Size(135, 135);
            this.MyMixCover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyMixCover_pictureBox.TabIndex = 6;
            this.MyMixCover_pictureBox.TabStop = false;
            // 
            // MyMixContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MyMixArtist_label);
            this.Controls.Add(this.MyMixName_label);
            this.Controls.Add(this.MyMixCover_pictureBox);
            this.Name = "MyMixContainer";
            this.Size = new System.Drawing.Size(180, 201);
            ((System.ComponentModel.ISupportInitialize)(this.MyMixCover_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyMixArtist_label;
        private System.Windows.Forms.Label MyMixName_label;
        private System.Windows.Forms.PictureBox MyMixCover_pictureBox;
    }
}
