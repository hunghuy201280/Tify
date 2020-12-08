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
            this.CreatePlayList_Button = new System.Windows.Forms.Button();
            this.panel_title_underline = new System.Windows.Forms.Panel();
            this.panel_description_underline = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_CreatePlaylist
            // 
            this.Text_CreatePlaylist.AutoSize = true;
            this.Text_CreatePlaylist.Font = new System.Drawing.Font("Nationale Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.Text_CreatePlaylist.Location = new System.Drawing.Point(37, 23);
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
            // Title_TextBox
            // 
            this.Title_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Title_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Title_TextBox.ForeColor = System.Drawing.Color.White;
            this.Title_TextBox.Location = new System.Drawing.Point(45, 129);
            this.Title_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(704, 29);
            this.Title_TextBox.TabIndex = 3;
            this.Title_TextBox.TextChanged += new System.EventHandler(this.Title_TextBox_TextChanged);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.Description_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Description_TextBox.ForeColor = System.Drawing.Color.White;
            this.Description_TextBox.Location = new System.Drawing.Point(45, 240);
            this.Description_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(704, 129);
            this.Description_TextBox.TabIndex = 4;
            this.Description_TextBox.TextChanged += new System.EventHandler(this.Description_TextBox_TextChanged);
            // 
            // CreatePlayList_Button
            // 
            this.CreatePlayList_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(98)))), ((int)(((byte)(105)))));
            this.CreatePlayList_Button.FlatAppearance.BorderSize = 0;
            this.CreatePlayList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePlayList_Button.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayList_Button.ForeColor = System.Drawing.Color.Cyan;
            this.CreatePlayList_Button.Location = new System.Drawing.Point(572, 398);
            this.CreatePlayList_Button.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePlayList_Button.Name = "CreatePlayList_Button";
            this.CreatePlayList_Button.Size = new System.Drawing.Size(177, 62);
            this.CreatePlayList_Button.TabIndex = 6;
            this.CreatePlayList_Button.Text = "Create Play List";
            this.CreatePlayList_Button.UseVisualStyleBackColor = false;
            this.CreatePlayList_Button.Click += new System.EventHandler(this.CreatePlayList_Button_Click);
            // 
            // panel_title_underline
            // 
            this.panel_title_underline.Location = new System.Drawing.Point(44, 163);
            this.panel_title_underline.Name = "panel_title_underline";
            this.panel_title_underline.Size = new System.Drawing.Size(705, 1);
            this.panel_title_underline.TabIndex = 7;
            // 
            // panel_description_underline
            // 
            this.panel_description_underline.Location = new System.Drawing.Point(44, 374);
            this.panel_description_underline.Name = "panel_description_underline";
            this.panel_description_underline.Size = new System.Drawing.Size(705, 1);
            this.panel_description_underline.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nationale", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(769, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatePlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_description_underline);
            this.Controls.Add(this.panel_title_underline);
            this.Controls.Add(this.CreatePlayList_Button);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.Title_TextBox);
            this.Controls.Add(this.Text_PlayList_Description);
            this.Controls.Add(this.Text_PlayList_Name);
            this.Controls.Add(this.Text_CreatePlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatePlayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlayList";
            this.Load += new System.EventHandler(this.CreatePlayList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_CreatePlaylist;
        private System.Windows.Forms.Label Text_PlayList_Name;
        private System.Windows.Forms.Label Text_PlayList_Description;
        private System.Windows.Forms.TextBox Title_TextBox;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.Button CreatePlayList_Button;
        private System.Windows.Forms.Panel panel_title_underline;
        private System.Windows.Forms.Panel panel_description_underline;
        private System.Windows.Forms.Button button1;
    }
}