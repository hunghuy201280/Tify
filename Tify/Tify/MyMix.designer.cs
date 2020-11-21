namespace Tify
{
    partial class MyMix
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
            this.MyMix_GroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MyMix_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyMix_GroupBox
            // 
            this.MyMix_GroupBox.Controls.Add(this.flowLayoutPanel1);
            this.MyMix_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyMix_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMix_GroupBox.ForeColor = System.Drawing.Color.White;
            this.MyMix_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.MyMix_GroupBox.Name = "MyMix_GroupBox";
            this.MyMix_GroupBox.Size = new System.Drawing.Size(1052, 533);
            this.MyMix_GroupBox.TabIndex = 2;
            this.MyMix_GroupBox.TabStop = false;
            this.MyMix_GroupBox.Text = "Check out these album:";
            this.MyMix_GroupBox.Visible = false;
            this.MyMix_GroupBox.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1046, 494);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MyMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.MyMix_GroupBox);
            this.Name = "MyMix";
            this.Text = "MyMix";
            this.Load += new System.EventHandler(this.MyMix_Load);
            this.MyMix_GroupBox.ResumeLayout(false);
            this.MyMix_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox MyMix_GroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}