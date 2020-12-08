namespace Tify
{
    partial class MixDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.top_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.track_dataGridView = new System.Windows.Forms.DataGridView();
            this.addToPlaylist_Button = new System.Windows.Forms.Button();
            this.playShuffle_Button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.cover_pictureBox = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToPlaylist = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.load_worker = new System.ComponentModel.BackgroundWorker();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.cover_pictureBox);
            this.top_panel.Controls.Add(this.addToPlaylist_Button);
            this.top_panel.Controls.Add(this.playShuffle_Button);
            this.top_panel.Controls.Add(this.play_button);
            this.top_panel.Controls.Add(this.label2);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(887, 270);
            this.top_panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(222, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist 1, Artist 2, Artist 3 and more";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nationale", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Mix 1";
            // 
            // track_dataGridView
            // 
            this.track_dataGridView.AllowUserToAddRows = false;
            this.track_dataGridView.AllowUserToDeleteRows = false;
            this.track_dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.track_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.track_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.track_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.track_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.track_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.artist,
            this.time,
            this.addToPlaylist,
            this.remove});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.track_dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.track_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_dataGridView.EnableHeadersVisualStyles = false;
            this.track_dataGridView.GridColor = System.Drawing.Color.Black;
            this.track_dataGridView.Location = new System.Drawing.Point(0, 270);
            this.track_dataGridView.Name = "track_dataGridView";
            this.track_dataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.track_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.track_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nationale Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.track_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.track_dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.track_dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.track_dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.track_dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.track_dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.track_dataGridView.RowTemplate.Height = 42;
            this.track_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.track_dataGridView.Size = new System.Drawing.Size(887, 300);
            this.track_dataGridView.TabIndex = 1;
            // 
            // addToPlaylist_Button
            // 
            this.addToPlaylist_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.addToPlaylist_Button.FlatAppearance.BorderSize = 0;
            this.addToPlaylist_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.addToPlaylist_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylist_Button.ForeColor = System.Drawing.Color.White;
            this.addToPlaylist_Button.Image = global::Tify.Properties.Resources.add_white;
            this.addToPlaylist_Button.Location = new System.Drawing.Point(554, 133);
            this.addToPlaylist_Button.Name = "addToPlaylist_Button";
            this.addToPlaylist_Button.Size = new System.Drawing.Size(57, 50);
            this.addToPlaylist_Button.TabIndex = 3;
            this.addToPlaylist_Button.UseVisualStyleBackColor = false;
            // 
            // playShuffle_Button
            // 
            this.playShuffle_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.playShuffle_Button.FlatAppearance.BorderSize = 0;
            this.playShuffle_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.playShuffle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playShuffle_Button.ForeColor = System.Drawing.Color.White;
            this.playShuffle_Button.Image = global::Tify.Properties.Resources.shuffle_white;
            this.playShuffle_Button.Location = new System.Drawing.Point(390, 133);
            this.playShuffle_Button.Name = "playShuffle_Button";
            this.playShuffle_Button.Size = new System.Drawing.Size(145, 50);
            this.playShuffle_Button.TabIndex = 3;
            this.playShuffle_Button.UseVisualStyleBackColor = false;
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(87)))), ((int)(((byte)(99)))));
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.ForeColor = System.Drawing.Color.White;
            this.play_button.Image = global::Tify.Properties.Resources.play;
            this.play_button.Location = new System.Drawing.Point(226, 133);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(145, 50);
            this.play_button.TabIndex = 3;
            this.play_button.UseVisualStyleBackColor = false;
            // 
            // cover_pictureBox
            // 
            this.cover_pictureBox.Image = global::Tify.Properties.Resources.mymix1;
            this.cover_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.cover_pictureBox.Name = "cover_pictureBox";
            this.cover_pictureBox.Size = new System.Drawing.Size(200, 200);
            this.cover_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover_pictureBox.TabIndex = 4;
            this.cover_pictureBox.TabStop = false;
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
            // load_worker
            // 
            this.load_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_worker_DoWork);
            this.load_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_worker_RunWorkerCompleted);
            // 
            // MixDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 570);
            this.Controls.Add(this.track_dataGridView);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Nationale Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MixDetail";
            this.Text = "MixDetail";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button playShuffle_Button;
        private System.Windows.Forms.Button addToPlaylist_Button;
        private System.Windows.Forms.DataGridView track_dataGridView;
        private System.Windows.Forms.PictureBox cover_pictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewImageColumn addToPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn remove;
        private System.ComponentModel.BackgroundWorker load_worker;
    }
}