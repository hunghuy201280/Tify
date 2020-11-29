namespace Tify
{
    partial class trackContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trackContainer));
            this.label1 = new System.Windows.Forms.Label();
            this.trackCover_panel = new System.Windows.Forms.Panel();
            this.opacity_panel = new System.Windows.Forms.Panel();
            this.trackCover_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghost In A Flower";
            // 
            // trackCover_panel
            // 
            this.trackCover_panel.BackgroundImage = global::Tify.Properties.Resources.dummy_cover;
            this.trackCover_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trackCover_panel.Controls.Add(this.opacity_panel);
            this.trackCover_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackCover_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackCover_panel.Location = new System.Drawing.Point(0, 0);
            this.trackCover_panel.Name = "trackCover_panel";
            this.trackCover_panel.Size = new System.Drawing.Size(40, 40);
            this.trackCover_panel.TabIndex = 0;
            this.trackCover_panel.MouseHover += new System.EventHandler(this.Cover_panel_MouseHover);
            // 
            // opacity_panel
            // 
            this.opacity_panel.BackColor = System.Drawing.Color.Transparent;
            this.opacity_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opacity_panel.BackgroundImage")));
            this.opacity_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.opacity_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opacity_panel.Location = new System.Drawing.Point(0, 0);
            this.opacity_panel.Name = "opacity_panel";
            this.opacity_panel.Size = new System.Drawing.Size(40, 40);
            this.opacity_panel.TabIndex = 0;
            this.opacity_panel.Visible = false;
            this.opacity_panel.MouseLeave += new System.EventHandler(this.opacity_panel_MouseLeave);
            // 
            // trackContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackCover_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "trackContainer";
            this.Size = new System.Drawing.Size(284, 40);
            this.trackCover_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel trackCover_panel;
        private System.Windows.Forms.Panel opacity_panel;
        private System.Windows.Forms.Label label1;
    }
}
