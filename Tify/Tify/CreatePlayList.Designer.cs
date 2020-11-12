namespace Tify
{
    partial class CreatePlayList
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
            this.Text_CreatePlaylist = new System.Windows.Forms.Label();
            this.Text_PlayList_Name = new System.Windows.Forms.Label();
            this.Text_PlayList_Description = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Text_PlayList_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_CreatePlaylist
            // 
            this.Text_CreatePlaylist.AutoSize = true;
            this.Text_CreatePlaylist.Font = new System.Drawing.Font("Nationale Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.Text_CreatePlaylist.Location = new System.Drawing.Point(38, 23);
            this.Text_CreatePlaylist.Name = "Text_CreatePlaylist";
            this.Text_CreatePlaylist.Size = new System.Drawing.Size(274, 37);
            this.Text_CreatePlaylist.TabIndex = 0;
            this.Text_CreatePlaylist.Text = "Create new playlist";
            // 
            // Text_PlayList_Name
            // 
            this.Text_PlayList_Name.AutoSize = true;
            this.Text_PlayList_Name.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Name.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Name.Location = new System.Drawing.Point(40, 87);
            this.Text_PlayList_Name.Name = "Text_PlayList_Name";
            this.Text_PlayList_Name.Size = new System.Drawing.Size(59, 30);
            this.Text_PlayList_Name.TabIndex = 1;
            this.Text_PlayList_Name.Text = "Title";
            // 
            // Text_PlayList_Description
            // 
            this.Text_PlayList_Description.AutoSize = true;
            this.Text_PlayList_Description.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Description.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Description.Location = new System.Drawing.Point(40, 190);
            this.Text_PlayList_Description.Name = "Text_PlayList_Description";
            this.Text_PlayList_Description.Size = new System.Drawing.Size(219, 30);
            this.Text_PlayList_Description.TabIndex = 2;
            this.Text_PlayList_Description.Text = "Write a description";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(45, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(704, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(45, 240);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(704, 129);
            this.textBox2.TabIndex = 4;
            // 
            // Text_PlayList_Count
            // 
            this.Text_PlayList_Count.AutoSize = true;
            this.Text_PlayList_Count.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Count.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Count.Location = new System.Drawing.Point(690, 376);
            this.Text_PlayList_Count.Name = "Text_PlayList_Count";
            this.Text_PlayList_Count.Size = new System.Drawing.Size(56, 30);
            this.Text_PlayList_Count.TabIndex = 5;
            this.Text_PlayList_Count.Text = "Text";
            // 
            // CreatePlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.Text_PlayList_Count);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Text_PlayList_Description);
            this.Controls.Add(this.Text_PlayList_Name);
            this.Controls.Add(this.Text_CreatePlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreatePlayList";
            this.Text = "CreatePlayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_CreatePlaylist;
        private System.Windows.Forms.Label Text_PlayList_Name;
        private System.Windows.Forms.Label Text_PlayList_Description;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Text_PlayList_Count;
    }
}