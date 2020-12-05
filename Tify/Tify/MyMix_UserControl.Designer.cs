namespace Tify
{
    partial class MyMix_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMix_UserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyMix_Name = new System.Windows.Forms.Label();
            this.MyMix_Artist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MyMix_Name
            // 
            this.MyMix_Name.AutoSize = true;
            this.MyMix_Name.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMix_Name.ForeColor = System.Drawing.Color.White;
            this.MyMix_Name.Location = new System.Drawing.Point(18, 145);
            this.MyMix_Name.Name = "MyMix_Name";
            this.MyMix_Name.Size = new System.Drawing.Size(139, 23);
            this.MyMix_Name.TabIndex = 1;
            this.MyMix_Name.Text = "MyMix_Name";
            // 
            // MyMix_Artist
            // 
            this.MyMix_Artist.AutoSize = true;
            this.MyMix_Artist.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMix_Artist.ForeColor = System.Drawing.Color.White;
            this.MyMix_Artist.Location = new System.Drawing.Point(19, 175);
            this.MyMix_Artist.Name = "MyMix_Artist";
            this.MyMix_Artist.Size = new System.Drawing.Size(83, 16);
            this.MyMix_Artist.TabIndex = 2;
            this.MyMix_Artist.Text = "MyMix_Artist";
            // 
            // MyMix_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MyMix_Artist);
            this.Controls.Add(this.MyMix_Name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MyMix_UserControl";
            this.Size = new System.Drawing.Size(180, 201);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MyMix_Name;
        private System.Windows.Forms.Label MyMix_Artist;
    }
}
