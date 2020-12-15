

namespace Tify
{
    partial class Artist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artist));
            this.top_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.sort_button = new System.Windows.Forms.Button();
            this.bottom_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Controls.Add(this.sort_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 57);
            this.top_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(843, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formTitle_label
            // 
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle_label.ForeColor = System.Drawing.Color.White;
            this.formTitle_label.Location = new System.Drawing.Point(12, 16);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(106, 23);
            this.formTitle_label.TabIndex = 5;
            this.formTitle_label.Text = "My Artists";
            // 
            // sort_button
            // 
            this.sort_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sort_button.BackgroundImage")));
            this.sort_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sort_button.FlatAppearance.BorderSize = 0;
            this.sort_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_button.Location = new System.Drawing.Point(946, 12);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(32, 32);
            this.sort_button.TabIndex = 6;
            this.sort_button.UseVisualStyleBackColor = true;
            // 
            // bottom_flowPanel
            // 
            this.bottom_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_flowPanel.Location = new System.Drawing.Point(0, 57);
            this.bottom_flowPanel.Name = "bottom_flowPanel";
            this.bottom_flowPanel.Size = new System.Drawing.Size(887, 621);
            this.bottom_flowPanel.TabIndex = 2;
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 678);
            this.Controls.Add(this.bottom_flowPanel);
            this.Controls.Add(this.top_panel);
            this.Name = "Artist";
            this.Text = "Artist";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel bottom_flowPanel;
        
    }
}