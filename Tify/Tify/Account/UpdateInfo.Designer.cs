namespace Tify
{
    partial class UpdateInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfo));
            this.Label_name = new System.Windows.Forms.Label();
            this.label_DOB = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_changepwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_name.ForeColor = System.Drawing.Color.White;
            this.Label_name.Location = new System.Drawing.Point(108, 155);
            this.Label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(55, 20);
            this.Label_name.TabIndex = 0;
            this.Label_name.Text = "Name:";
            // 
            // label_DOB
            // 
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOB.ForeColor = System.Drawing.Color.White;
            this.label_DOB.Location = new System.Drawing.Point(62, 238);
            this.label_DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(101, 20);
            this.label_DOB.TabIndex = 2;
            this.label_DOB.Text = "Date of birth:";
            // 
            // textbox_name
            // 
            this.textbox_name.BackColor = System.Drawing.Color.Black;
            this.textbox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_name.ForeColor = System.Drawing.Color.White;
            this.textbox_name.Location = new System.Drawing.Point(170, 151);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(291, 20);
            this.textbox_name.TabIndex = 5;
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phonenumber.ForeColor = System.Drawing.Color.White;
            this.label_phonenumber.Location = new System.Drawing.Point(44, 309);
            this.label_phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(119, 20);
            this.label_phonenumber.TabIndex = 8;
            this.label_phonenumber.Text = "Phone Number:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.BackColor = System.Drawing.Color.Black;
            this.textBox_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Phone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.ForeColor = System.Drawing.Color.White;
            this.textBox_Phone.Location = new System.Drawing.Point(168, 309);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(291, 20);
            this.textBox_Phone.TabIndex = 9;
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Gray;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(454, 401);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 43);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(170, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(170, 257);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(168, 332);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 1);
            this.panel4.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.button_changepwd);
            this.panel6.Controls.Add(this.button_logout);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.Label_name);
            this.panel6.Controls.Add(this.button_save);
            this.panel6.Controls.Add(this.label_DOB);
            this.panel6.Controls.Add(this.textbox_name);
            this.panel6.Controls.Add(this.label_phonenumber);
            this.panel6.Controls.Add(this.textBox_Phone);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(160, 41);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 460);
            this.panel6.TabIndex = 25;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Gray;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(36, 401);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(90, 43);
            this.button_logout.TabIndex = 26;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 229);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // button_changepwd
            // 
            this.button_changepwd.BackColor = System.Drawing.Color.Gray;
            this.button_changepwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_changepwd.FlatAppearance.BorderSize = 0;
            this.button_changepwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changepwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changepwd.ForeColor = System.Drawing.Color.White;
            this.button_changepwd.Location = new System.Drawing.Point(184, 401);
            this.button_changepwd.Margin = new System.Windows.Forms.Padding(2);
            this.button_changepwd.Name = "button_changepwd";
            this.button_changepwd.Size = new System.Drawing.Size(212, 43);
            this.button_changepwd.TabIndex = 27;
            this.button_changepwd.Text = "Change password";
            this.button_changepwd.UseVisualStyleBackColor = false;
            this.button_changepwd.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(874, 639);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInfo";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            this.Resize += new System.EventHandler(this.UpdateInfo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_changepwd;
    }
}