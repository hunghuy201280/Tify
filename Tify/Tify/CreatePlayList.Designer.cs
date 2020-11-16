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
            this.Title_TextBox = new System.Windows.Forms.TextBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.Text_PlayList_Count = new System.Windows.Forms.Label();
            this.CreatePlayList_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_CreatePlaylist
            // 
            this.Text_CreatePlaylist.AutoSize = true;
            this.Text_CreatePlaylist.Font = new System.Drawing.Font("Nationale Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.Text_CreatePlaylist.Location = new System.Drawing.Point(28, 19);
            this.Text_CreatePlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text_CreatePlaylist.Name = "Text_CreatePlaylist";
            this.Text_CreatePlaylist.Size = new System.Drawing.Size(218, 30);
            this.Text_CreatePlaylist.TabIndex = 0;
            this.Text_CreatePlaylist.Text = "Create new playlist";
            // 
            // Text_PlayList_Name
            // 
            this.Text_PlayList_Name.AutoSize = true;
            this.Text_PlayList_Name.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Name.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Name.Location = new System.Drawing.Point(30, 71);
            this.Text_PlayList_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text_PlayList_Name.Name = "Text_PlayList_Name";
            this.Text_PlayList_Name.Size = new System.Drawing.Size(46, 24);
            this.Text_PlayList_Name.TabIndex = 1;
            this.Text_PlayList_Name.Text = "Title";
            // 
            // Text_PlayList_Description
            // 
            this.Text_PlayList_Description.AutoSize = true;
            this.Text_PlayList_Description.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Description.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Description.Location = new System.Drawing.Point(30, 154);
            this.Text_PlayList_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text_PlayList_Description.Name = "Text_PlayList_Description";
            this.Text_PlayList_Description.Size = new System.Drawing.Size(171, 24);
            this.Text_PlayList_Description.TabIndex = 2;
            this.Text_PlayList_Description.Text = "Write a description";
            // 
            // Title_TextBox
            // 
            this.Title_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Title_TextBox.Location = new System.Drawing.Point(34, 105);
            this.Title_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(528, 23);
            this.Title_TextBox.TabIndex = 3;
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Description_TextBox.Location = new System.Drawing.Point(34, 195);
            this.Description_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(528, 105);
            this.Description_TextBox.TabIndex = 4;
            this.Description_TextBox.TextChanged += new System.EventHandler(this.Description_TextBox_TextChanged);
            // 
            // Text_PlayList_Count
            // 
            this.Text_PlayList_Count.AutoSize = true;
            this.Text_PlayList_Count.Font = new System.Drawing.Font("Nationale Light", 14.2F);
            this.Text_PlayList_Count.ForeColor = System.Drawing.Color.White;
            this.Text_PlayList_Count.Location = new System.Drawing.Point(518, 306);
            this.Text_PlayList_Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Text_PlayList_Count.Name = "Text_PlayList_Count";
            this.Text_PlayList_Count.Size = new System.Drawing.Size(44, 24);
            this.Text_PlayList_Count.TabIndex = 5;
            this.Text_PlayList_Count.Text = "Text";
            // 
            // CreatePlayList_Button
            // 
            this.CreatePlayList_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(98)))), ((int)(((byte)(105)))));
            this.CreatePlayList_Button.FlatAppearance.BorderSize = 0;
            this.CreatePlayList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePlayList_Button.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayList_Button.Location = new System.Drawing.Point(218, 341);
            this.CreatePlayList_Button.Name = "CreatePlayList_Button";
            this.CreatePlayList_Button.Size = new System.Drawing.Size(133, 50);
            this.CreatePlayList_Button.TabIndex = 6;
            this.CreatePlayList_Button.Text = "Create Play List";
            this.CreatePlayList_Button.UseVisualStyleBackColor = false;
            // 
            // CreatePlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 403);
            this.Controls.Add(this.CreatePlayList_Button);
            this.Controls.Add(this.Text_PlayList_Count);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.Title_TextBox);
            this.Controls.Add(this.Text_PlayList_Description);
            this.Controls.Add(this.Text_PlayList_Name);
            this.Controls.Add(this.Text_CreatePlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreatePlayList";
            this.Text = "CreatePlayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_CreatePlaylist;
        private System.Windows.Forms.Label Text_PlayList_Name;
        private System.Windows.Forms.Label Text_PlayList_Description;
        private System.Windows.Forms.TextBox Title_TextBox;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.Label Text_PlayList_Count;
        private System.Windows.Forms.Button CreatePlayList_Button;
    }
}