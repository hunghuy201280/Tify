namespace Tify
{
    partial class Home
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
            this.home_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.homeItemContainer1 = new Tify.HomeItemContainer();
            this.home_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_flowLayoutPanel
            // 
            this.home_flowLayoutPanel.Controls.Add(this.button1);
            this.home_flowLayoutPanel.Controls.Add(this.homeItemContainer1);
            this.home_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.home_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.home_flowLayoutPanel.Name = "home_flowLayoutPanel";
            this.home_flowLayoutPanel.Size = new System.Drawing.Size(1191, 718);
            this.home_flowLayoutPanel.TabIndex = 1;
            this.home_flowLayoutPanel.WrapContents = false;
            this.home_flowLayoutPanel.Resize += new System.EventHandler(this.home_flowLayoutPanel_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeItemContainer1
            // 
            this.homeItemContainer1.BackColor = System.Drawing.Color.Black;
            this.homeItemContainer1.Location = new System.Drawing.Point(3, 32);
            this.homeItemContainer1.Name = "homeItemContainer1";
            this.homeItemContainer1.Size = new System.Drawing.Size(1045, 285);
            this.homeItemContainer1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1191, 718);
            this.Controls.Add(this.home_flowLayoutPanel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.home_flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel home_flowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private HomeItemContainer homeItemContainer1;
    }
}