namespace Tify
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Register_Panel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Register_Phone = new System.Windows.Forms.Label();
            this.Register_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Register_Pwd = new System.Windows.Forms.Label();
            this.Register_UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Register_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_Panel
            // 
            this.Register_Panel.Controls.Add(this.trackBar1);
            this.Register_Panel.Controls.Add(this.textBox2);
            this.Register_Panel.Controls.Add(this.maskedTextBox2);
            this.Register_Panel.Controls.Add(this.Register_Phone);
            this.Register_Panel.Controls.Add(this.Register_Button);
            this.Register_Panel.Controls.Add(this.textBox1);
            this.Register_Panel.Controls.Add(this.Register_Pwd);
            this.Register_Panel.Controls.Add(this.Register_UserName);
            this.Register_Panel.Controls.Add(this.pictureBox1);
            this.Register_Panel.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Panel.Location = new System.Drawing.Point(80, 35);
            this.Register_Panel.Name = "Register_Panel";
            this.Register_Panel.Size = new System.Drawing.Size(360, 301);
            this.Register_Panel.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 206);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(143, 167);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '*';
            this.maskedTextBox2.Size = new System.Drawing.Size(165, 26);
            this.maskedTextBox2.TabIndex = 8;
            // 
            // Register_Phone
            // 
            this.Register_Phone.AutoSize = true;
            this.Register_Phone.ForeColor = System.Drawing.Color.White;
            this.Register_Phone.Location = new System.Drawing.Point(12, 208);
            this.Register_Phone.Name = "Register_Phone";
            this.Register_Phone.Size = new System.Drawing.Size(122, 19);
            this.Register_Phone.TabIndex = 6;
            this.Register_Phone.Text = "Phone Number :";
            // 
            // Register_Button
            // 
            this.Register_Button.FlatAppearance.BorderSize = 0;
            this.Register_Button.Location = new System.Drawing.Point(158, 251);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(76, 30);
            this.Register_Button.TabIndex = 5;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Register_Pwd
            // 
            this.Register_Pwd.AutoSize = true;
            this.Register_Pwd.ForeColor = System.Drawing.Color.White;
            this.Register_Pwd.Location = new System.Drawing.Point(52, 170);
            this.Register_Pwd.Name = "Register_Pwd";
            this.Register_Pwd.Size = new System.Drawing.Size(82, 19);
            this.Register_Pwd.TabIndex = 2;
            this.Register_Pwd.Text = "Password :";
            // 
            // Register_UserName
            // 
            this.Register_UserName.AutoSize = true;
            this.Register_UserName.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_UserName.ForeColor = System.Drawing.Color.White;
            this.Register_UserName.Location = new System.Drawing.Point(37, 126);
            this.Register_UserName.Name = "Register_UserName";
            this.Register_UserName.Size = new System.Drawing.Size(97, 20);
            this.Register_UserName.TabIndex = 1;
            this.Register_UserName.Text = "User name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(16, 40);
            this.trackBar1.Maximum = 999999999;
            this.trackBar1.Minimum = 111111111;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 999999999;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(540, 358);
            this.Controls.Add(this.Register_Panel);
            this.Name = "Register";
            this.Text = "Register";
            this.Register_Panel.ResumeLayout(false);
            this.Register_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Register_Panel;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Register_Pwd;
        private System.Windows.Forms.Label Register_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Register_Phone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}