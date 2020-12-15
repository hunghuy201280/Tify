namespace Tify
{
    partial class ArtistContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistContainer));
            this.artistCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.artistName_Label = new System.Windows.Forms.Label();
            this.info_worker = new System.ComponentModel.BackgroundWorker();
            this.detail_worker = new System.ComponentModel.BackgroundWorker();
            this.artistCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // artistCover_panel
            // 
            this.artistCover_panel.BackgroundImage = global::Tify.Properties.Resources.dummy_artist;
            this.artistCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.artistCover_panel.Controls.Add(this.opacity_panel);
            this.artistCover_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.artistCover_panel.Location = new System.Drawing.Point(0, 0);
            this.artistCover_panel.Name = "artistCover_panel";
            this.artistCover_panel.Size = new System.Drawing.Size(170, 170);
            this.artistCover_panel.TabIndex = 0;
            this.artistCover_panel.MouseHover += new System.EventHandler(this.artistCover_panel_MouseHover);
            // 
            // opacity_panel
            // 
            this.opacity_panel.BackColor = System.Drawing.Color.Transparent;
            this.opacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opacity_panel.BackgroundImage")));
            this.opacity_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.opacity_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opacity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opacity_panel.Location = new System.Drawing.Point(0, 0);
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(170, 170);
            this.opacity_panel.TabIndex = 0;
            this.opacity_panel.Visible = false;
            this.opacity_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opacity_panel_MouseClick);
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // artistName_Label
            // 
            this.artistName_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistName_Label.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistName_Label.ForeColor = System.Drawing.Color.White;
            this.artistName_Label.Location = new System.Drawing.Point(0, 170);
            this.artistName_Label.Name = "artistName_Label";
            this.artistName_Label.Size = new System.Drawing.Size(170, 33);
            this.artistName_Label.TabIndex = 2;
            this.artistName_Label.Text = "Uru";
            this.artistName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_worker
            // 
            this.info_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.info_worker_DoWork);
            this.info_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.info_worker_RunWorkerCompleted);
            // 
            // detail_worker
            // 
            this.detail_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.detail_worker_DoWork);
            this.detail_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.detail_worker_RunWorkerCompleted);
            // 
            // ArtistContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.artistName_Label);
            this.Controls.Add(this.artistCover_panel);
            this.Margin = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.Name = "ArtistContainer";
            this.Size = new System.Drawing.Size(170, 203);
            this.artistCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel opacity_panel;
        private System.ComponentModel.BackgroundWorker info_worker;
        private System.ComponentModel.BackgroundWorker detail_worker;
        public System.Windows.Forms.Panel artistCover_panel;
        public System.Windows.Forms.Label artistName_Label;
    }
}
