﻿namespace Tify
{
    partial class HomeItemContainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeItemContainer));
            this.forward_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.recentlyPlayed_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.containerTitle_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // forward_Button
            // 
            this.forward_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forward_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forward_Button.BackgroundImage")));
            this.forward_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward_Button.FlatAppearance.BorderSize = 0;
            this.forward_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_Button.Location = new System.Drawing.Point(1007, 9);
            this.forward_Button.Name = "forward_Button";
            this.forward_Button.Size = new System.Drawing.Size(32, 32);
            this.forward_Button.TabIndex = 2;
            this.forward_Button.UseVisualStyleBackColor = true;
            this.forward_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseDown);
            this.forward_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseUp);
            // 
            // back_Button
            // 
            this.back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_Button.BackgroundImage")));
            this.back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_Button.FlatAppearance.BorderSize = 0;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_Button.Location = new System.Drawing.Point(969, 9);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(32, 32);
            this.back_Button.TabIndex = 3;
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseDown);
            this.back_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseUp);
            // 
            // recentlyPlayed_flowLayoutPanel
            // 
            this.recentlyPlayed_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recentlyPlayed_flowLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.recentlyPlayed_flowLayoutPanel.Location = new System.Drawing.Point(0, 47);
            this.recentlyPlayed_flowLayoutPanel.Name = "recentlyPlayed_flowLayoutPanel";
            this.recentlyPlayed_flowLayoutPanel.Size = new System.Drawing.Size(1045, 273);
            this.recentlyPlayed_flowLayoutPanel.TabIndex = 4;
            this.recentlyPlayed_flowLayoutPanel.WrapContents = false;
            // 
            // containerTitle_label
            // 
            this.containerTitle_label.AutoSize = true;
            this.containerTitle_label.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerTitle_label.ForeColor = System.Drawing.Color.White;
            this.containerTitle_label.Location = new System.Drawing.Point(8, 13);
            this.containerTitle_label.Name = "containerTitle_label";
            this.containerTitle_label.Size = new System.Drawing.Size(160, 23);
            this.containerTitle_label.TabIndex = 5;
            this.containerTitle_label.Text = "Recently Played";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeItemContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.containerTitle_label);
            this.Controls.Add(this.recentlyPlayed_flowLayoutPanel);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.forward_Button);
            this.MinimumSize = new System.Drawing.Size(0, 320);
            this.Name = "HomeItemContainer";
            this.Size = new System.Drawing.Size(1045, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forward_Button;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Label containerTitle_label;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.FlowLayoutPanel recentlyPlayed_flowLayoutPanel;
    }
}
