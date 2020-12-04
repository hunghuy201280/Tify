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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.format_label = new System.Windows.Forms.Label();
            this.formTitle_label = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.textBox1);
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.format_label);
            this.top_panel.Controls.Add(this.formTitle_label);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 61);
            this.top_panel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(529, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "trackID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bottom_panel.Controls.Add(this.dataGridView1);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel.Location = new System.Drawing.Point(0, 61);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(887, 617);
            this.bottom_panel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.title,
            this.artist,
            this.dateAdded,
            this.time,
            this.addToPlaylist,
            this.remove});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nationale Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.Size = new System.Drawing.Size(887, 617);
            this.dataGridView1.TabIndex = 0;
            // 
            // img
            // 
            this.img.HeaderText = "";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.img.MinimumWidth = 42;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 42;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "TITLE";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // artist
            // 
            this.artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artist.HeaderText = "ARTIST";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            // 
            // dateAdded
            // 
            this.dateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateAdded.HeaderText = "DATE ADDED";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // addToPlaylist
            // 
            this.addToPlaylist.HeaderText = "";
            this.addToPlaylist.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.addToPlaylist.MinimumWidth = 20;
            this.addToPlaylist.Name = "addToPlaylist";
            this.addToPlaylist.ReadOnly = true;
            this.addToPlaylist.Width = 20;
            // 
            // remove
            // 
            this.remove.HeaderText = "";
            this.remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.remove.MinimumWidth = 20;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Width = 20;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label formTitle_label;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Label format_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.Windows.Forms.TextBox textBox1;
    }
}