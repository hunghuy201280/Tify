namespace Tify
{
    partial class MixDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mixCover1_pictureBox = new System.Windows.Forms.PictureBox();
            this.mixCover2_pictureBox = new System.Windows.Forms.PictureBox();
            this.mixCover3_pictureBox = new System.Windows.Forms.PictureBox();
            this.mixCover4_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover3_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover4_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 270);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mixCover4_pictureBox);
            this.panel2.Controls.Add(this.mixCover3_pictureBox);
            this.panel2.Controls.Add(this.mixCover2_pictureBox);
            this.panel2.Controls.Add(this.mixCover1_pictureBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 0;
            // 
            // mixCover1_pictureBox
            // 
            this.mixCover1_pictureBox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.mixCover1_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.mixCover1_pictureBox.Name = "mixCover1_pictureBox";
            this.mixCover1_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.mixCover1_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixCover1_pictureBox.TabIndex = 0;
            this.mixCover1_pictureBox.TabStop = false;
            // 
            // mixCover2_pictureBox
            // 
            this.mixCover2_pictureBox.Image = global::Tify.Properties.Resources.dummy_artist;
            this.mixCover2_pictureBox.Location = new System.Drawing.Point(100, 3);
            this.mixCover2_pictureBox.Name = "mixCover2_pictureBox";
            this.mixCover2_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.mixCover2_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixCover2_pictureBox.TabIndex = 1;
            this.mixCover2_pictureBox.TabStop = false;
            // 
            // mixCover3_pictureBox
            // 
            this.mixCover3_pictureBox.Image = global::Tify.Properties.Resources.dummy_artist1;
            this.mixCover3_pictureBox.Location = new System.Drawing.Point(3, 100);
            this.mixCover3_pictureBox.Name = "mixCover3_pictureBox";
            this.mixCover3_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.mixCover3_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixCover3_pictureBox.TabIndex = 2;
            this.mixCover3_pictureBox.TabStop = false;
            // 
            // mixCover4_pictureBox
            // 
            this.mixCover4_pictureBox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.mixCover4_pictureBox.Location = new System.Drawing.Point(100, 100);
            this.mixCover4_pictureBox.Name = "mixCover4_pictureBox";
            this.mixCover4_pictureBox.Size = new System.Drawing.Size(100, 100);
            this.mixCover4_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mixCover4_pictureBox.TabIndex = 3;
            this.mixCover4_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Mix 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(222, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist 1, Artist 2, Artist 3 and more";
            // 
            // MixDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MixDetail";
            this.Text = "MixDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mixCover1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover3_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mixCover4_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox mixCover1_pictureBox;
        private System.Windows.Forms.PictureBox mixCover4_pictureBox;
        private System.Windows.Forms.PictureBox mixCover3_pictureBox;
        private System.Windows.Forms.PictureBox mixCover2_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}