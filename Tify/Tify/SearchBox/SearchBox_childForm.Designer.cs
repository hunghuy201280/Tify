namespace Tify
{
    partial class SearchBox_childForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBox_dataGridView = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALBUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox_dataGridView
            // 
            this.SearchBox_dataGridView.AllowUserToAddRows = false;
            this.SearchBox_dataGridView.AllowUserToDeleteRows = false;
            this.SearchBox_dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.SearchBox_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SearchBox_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchBox_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchBox_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBox_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.title,
            this.artist,
            this.time,
            this.ALBUM,
            this.addToPlaylist,
            this.remove});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchBox_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SearchBox_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox_dataGridView.EnableHeadersVisualStyles = false;
            this.SearchBox_dataGridView.GridColor = System.Drawing.Color.Black;
            this.SearchBox_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.SearchBox_dataGridView.Name = "SearchBox_dataGridView";
            this.SearchBox_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchBox_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SearchBox_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.SearchBox_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.SearchBox_dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.SearchBox_dataGridView.RowTemplate.Height = 42;
            this.SearchBox_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchBox_dataGridView.Size = new System.Drawing.Size(827, 450);
            this.SearchBox_dataGridView.TabIndex = 1;
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
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // ALBUM
            // 
            this.ALBUM.HeaderText = "ALBUM";
            this.ALBUM.Name = "ALBUM";
            this.ALBUM.ReadOnly = true;
            // 
            // addToPlaylist
            // 
            this.addToPlaylist.HeaderText = "";
            this.addToPlaylist.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.addToPlaylist.MinimumWidth = 20;
            this.addToPlaylist.Name = "addToPlaylist";
            this.addToPlaylist.ReadOnly = true;
            this.addToPlaylist.Width = 20;
            // 
            // remove
            // 
            this.remove.HeaderText = "";
            this.remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.remove.MinimumWidth = 20;
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Width = 20;
            // 
            // SearchBox_childForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.SearchBox_dataGridView);
            this.Name = "SearchBox_childForm";
            this.Text = "SearchBox_childForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchBox_dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALBUM;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
    }
}