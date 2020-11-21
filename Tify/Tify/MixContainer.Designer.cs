namespace Tify
{
    partial class MixContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MixContainer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mix_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mix_Artist = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mix_Artist);
            this.panel1.Controls.Add(this.Mix_Name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 201);
            this.panel1.TabIndex = 0;
            // 
            // Mix_Name
            // 
            this.Mix_Name.AutoSize = true;
            this.Mix_Name.Font = new System.Drawing.Font("Nationale", 10F, System.Drawing.FontStyle.Bold);
            this.Mix_Name.ForeColor = System.Drawing.Color.White;
            this.Mix_Name.Location = new System.Drawing.Point(20, 141);
            this.Mix_Name.Name = "Mix_Name";
            this.Mix_Name.Size = new System.Drawing.Size(81, 17);
            this.Mix_Name.TabIndex = 3;
            this.Mix_Name.Text = "Mix_Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Mix_Artist
            // 
            this.Mix_Artist.AutoSize = true;
            this.Mix_Artist.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mix_Artist.ForeColor = System.Drawing.Color.Gray;
            this.Mix_Artist.Location = new System.Drawing.Point(20, 158);
            this.Mix_Artist.Name = "Mix_Artist";
            this.Mix_Artist.Size = new System.Drawing.Size(65, 16);
            this.Mix_Artist.TabIndex = 4;
            this.Mix_Artist.Text = "Mix_Artist";
            // 
            // MixContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(180, 201);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MixContainer";
            this.Text = "MixContainer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Mix_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Mix_Artist;
    }
}