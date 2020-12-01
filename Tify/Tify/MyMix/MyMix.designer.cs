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
            this.myMixContainer1 = new Tify.MyMixContainer();
            this.myMixContainer2 = new Tify.MyMixContainer();
            this.myMixContainer3 = new Tify.MyMixContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.playlistDetail_panel = new System.Windows.Forms.Panel();
            this.MyMix_GroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyMix_GroupBox
            // 
            this.MyMix_GroupBox.Controls.Add(this.flowLayoutPanel1);
            this.MyMix_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyMix_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyMix_GroupBox.ForeColor = System.Drawing.Color.White;
            this.MyMix_GroupBox.Location = new System.Drawing.Point(10, 10);
            this.MyMix_GroupBox.Name = "MyMix_GroupBox";
            this.MyMix_GroupBox.Size = new System.Drawing.Size(1128, 688);
            this.MyMix_GroupBox.TabIndex = 2;
            this.MyMix_GroupBox.TabStop = false;
            this.MyMix_GroupBox.Text = "Check out these mix";
            this.MyMix_GroupBox.Visible = false;
            this.MyMix_GroupBox.Resize += new System.EventHandler(this.groupBox1_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.myMixContainer1);
            this.flowLayoutPanel1.Controls.Add(this.myMixContainer2);
            this.flowLayoutPanel1.Controls.Add(this.myMixContainer3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1122, 649);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // myMixContainer1
            // 
            this.myMixContainer1.BackColor = System.Drawing.Color.Black;
            this.myMixContainer1.Location = new System.Drawing.Point(139, 3);
            this.myMixContainer1.Name = "myMixContainer1";
            this.myMixContainer1.Size = new System.Drawing.Size(172, 230);
            this.myMixContainer1.TabIndex = 20;
            // 
            // myMixContainer2
            // 
            this.myMixContainer2.BackColor = System.Drawing.Color.Black;
            this.myMixContainer2.Location = new System.Drawing.Point(317, 3);
            this.myMixContainer2.Name = "myMixContainer2";
            this.myMixContainer2.Size = new System.Drawing.Size(172, 230);
            this.myMixContainer2.TabIndex = 21;
            // 
            // myMixContainer3
            // 
            this.myMixContainer3.BackColor = System.Drawing.Color.Black;
            this.myMixContainer3.Location = new System.Drawing.Point(495, 3);
            this.myMixContainer3.Name = "myMixContainer3";
            this.myMixContainer3.Size = new System.Drawing.Size(172, 230);
            this.myMixContainer3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Mix";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playlistDetail_panel
            // 
            this.playlistDetail_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistDetail_panel.Location = new System.Drawing.Point(10, 10);
            this.playlistDetail_panel.Name = "playlistDetail_panel";
            this.playlistDetail_panel.Size = new System.Drawing.Size(1128, 688);
            this.playlistDetail_panel.TabIndex = 19;
            // 
            // MyMix
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1148, 708);
            this.Controls.Add(this.MyMix_GroupBox);
            this.Controls.Add(this.playlistDetail_panel);
            this.Name = "MyMix";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "MyMix";
            this.Load += new System.EventHandler(this.MyMix_Load);
            this.MyMix_GroupBox.ResumeLayout(false);
            this.MyMix_GroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox MyMix_GroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel playlistDetail_panel;
        private System.Windows.Forms.Button button1;
        private MyMixContainer myMixContainer1;
        private MyMixContainer myMixContainer2;
        private MyMixContainer myMixContainer3;
    }
}