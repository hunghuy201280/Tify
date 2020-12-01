namespace Tify
{
    partial class Tracks
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.format_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.track_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.track_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.format_label);
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 61);
            this.top_panel.TabIndex = 1;
            // 
            // format_label
            // 
            this.format_label.AutoSize = true;
            this.format_label.BackColor = System.Drawing.Color.White;
            this.format_label.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.format_label.Location = new System.Drawing.Point(805, 9);
            this.format_label.Name = "format_label";
            this.format_label.Size = new System.Drawing.Size(119, 24);
            this.format_label.TabIndex = 7;
            this.format_label.Text = "format_label";
            this.format_label.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "add_test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formTitle_label
            // 
            this.formTitle_label.AutoSize = true;
            this.formTitle_label.Font = new System.Drawing.Font("Nationale", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle_label.ForeColor = System.Drawing.Color.White;
            this.formTitle_label.Location = new System.Drawing.Point(12, 17);
            this.formTitle_label.Name = "formTitle_label";
            this.formTitle_label.Size = new System.Drawing.Size(103, 23);
            this.formTitle_label.TabIndex = 5;
            this.formTitle_label.Text = "My Tracks";
            // 
            // bottom_panel
            // 
            this.bottom_panel.AutoScroll = true;
            this.bottom_panel.Controls.Add(this.track_tableLayoutPanel);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel.Location = new System.Drawing.Point(0, 61);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(887, 617);
            this.bottom_panel.TabIndex = 2;
            // 
            // track_tableLayoutPanel
            // 
            this.track_tableLayoutPanel.AutoSize = true;
            this.track_tableLayoutPanel.ColumnCount = 5;
            this.track_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.69919F));
            this.track_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.30081F));
            this.track_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.track_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.track_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.track_tableLayoutPanel.Controls.Add(this.label3, 2, 0);
            this.track_tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.track_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.track_tableLayoutPanel.Controls.Add(this.label4, 3, 0);
            this.track_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.track_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.track_tableLayoutPanel.Name = "track_tableLayoutPanel";
            this.track_tableLayoutPanel.RowCount = 1;
            this.track_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.280193F));
            this.track_tableLayoutPanel.Size = new System.Drawing.Size(887, 38);
            this.track_tableLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(143)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(495, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATE ADDED";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(143)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(341, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "ARTIST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(143)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "TITLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Nationale Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(143)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(686, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 678);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tracks";
            this.Text = "Tracks";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.track_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.TableLayoutPanel track_tableLayoutPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label format_label;
    }
}