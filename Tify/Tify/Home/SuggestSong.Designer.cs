namespace Tify
{
    partial class SuggestSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuggestSong));
            this.top_panel = new System.Windows.Forms.Panel();
            this.songName_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songCover_picturebox = new System.Windows.Forms.PictureBox();
            this.back_Button = new System.Windows.Forms.Button();
            this.forward_Button = new System.Windows.Forms.Button();
            this.suggested_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.suggestedSong_worker = new System.ComponentModel.BackgroundWorker();
            this.loading_SplashScreen1 = new Tify.Loading_SplashScreen();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover_picturebox)).BeginInit();
            this.bottom_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.songName_label);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.songCover_picturebox);
            this.top_panel.Controls.Add(this.back_Button);
            this.top_panel.Controls.Add(this.forward_Button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1045, 65);
            this.top_panel.TabIndex = 0;
            // 
            // songName_label
            // 
            this.songName_label.AutoSize = true;
            this.songName_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName_label.ForeColor = System.Drawing.Color.White;
            this.songName_label.Location = new System.Drawing.Point(74, 29);
            this.songName_label.Name = "songName_label";
            this.songName_label.Size = new System.Drawing.Size(118, 30);
            this.songName_label.TabIndex = 8;
            this.songName_label.Text = "Song name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "BECAUSE YOU LISTENED TO";
            // 
            // songCover_picturebox
            // 
            this.songCover_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songCover_picturebox.Image = global::Tify.Properties.Resources.dummy_cover;
            this.songCover_picturebox.Location = new System.Drawing.Point(3, 3);
            this.songCover_picturebox.Name = "songCover_picturebox";
            this.songCover_picturebox.Size = new System.Drawing.Size(65, 65);
            this.songCover_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songCover_picturebox.TabIndex = 6;
            this.songCover_picturebox.TabStop = false;
            // 
            // back_Button
            // 
            this.back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_Button.BackgroundImage")));
            this.back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_Button.FlatAppearance.BorderSize = 0;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_Button.Location = new System.Drawing.Point(970, 25);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(32, 32);
            this.back_Button.TabIndex = 5;
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseDown);
            this.back_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseUp);
            // 
            // forward_Button
            // 
            this.forward_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forward_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forward_Button.BackgroundImage")));
            this.forward_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward_Button.FlatAppearance.BorderSize = 0;
            this.forward_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_Button.Location = new System.Drawing.Point(1008, 25);
            this.forward_Button.Name = "forward_Button";
            this.forward_Button.Size = new System.Drawing.Size(32, 32);
            this.forward_Button.TabIndex = 4;
            this.forward_Button.UseVisualStyleBackColor = true;
            this.forward_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseDown);
            this.forward_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scroll_Button_MouseUp);
            // 
            // suggested_flowLayoutPanel
            // 
            this.suggested_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggested_flowLayoutPanel.ForeColor = System.Drawing.Color.White;
            this.suggested_flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.suggested_flowLayoutPanel.Name = "suggested_flowLayoutPanel";
            this.suggested_flowLayoutPanel.Size = new System.Drawing.Size(1045, 275);
            this.suggested_flowLayoutPanel.TabIndex = 5;
            this.suggested_flowLayoutPanel.WrapContents = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // suggestedSong_worker
            // 
            this.suggestedSong_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.suggestedSong_worker_DoWork);
            this.suggestedSong_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.suggestedSong_worker_RunWorkerCompleted);
            // 
            // loading_SplashScreen1
            // 
            this.loading_SplashScreen1.BackColor = System.Drawing.Color.Black;
            this.loading_SplashScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading_SplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.loading_SplashScreen1.Name = "loading_SplashScreen1";
            this.loading_SplashScreen1.Size = new System.Drawing.Size(1045, 275);
            this.loading_SplashScreen1.TabIndex = 0;
            // 
            // bottom_panel
            // 
            this.bottom_panel.Controls.Add(this.suggested_flowLayoutPanel);
            this.bottom_panel.Controls.Add(this.loading_SplashScreen1);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel.Location = new System.Drawing.Point(0, 65);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1045, 275);
            this.bottom_panel.TabIndex = 6;
            // 
            // SuggestSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "SuggestSong";
            this.Size = new System.Drawing.Size(1045, 340);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songCover_picturebox)).EndInit();
            this.bottom_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel top_panel;
        public System.Windows.Forms.Button back_Button;
        public System.Windows.Forms.Button forward_Button;
        public System.Windows.Forms.PictureBox songCover_picturebox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label songName_label;
        public System.Windows.Forms.FlowLayoutPanel suggested_flowLayoutPanel;
        public System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker suggestedSong_worker;
        private Loading_SplashScreen loading_SplashScreen1;
        private System.Windows.Forms.Panel bottom_panel;
    }
}
