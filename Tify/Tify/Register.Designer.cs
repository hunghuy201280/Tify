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
            this.Register_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Register_Pwd = new System.Windows.Forms.Label();
            this.Register_UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Register_Phone = new System.Windows.Forms.Label();
            this.Register_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_Panel
            // 
            this.Register_Panel.Controls.Add(this.textBox3);
            this.Register_Panel.Controls.Add(this.Register_Phone);
            this.Register_Panel.Controls.Add(this.Register_Button);
            this.Register_Panel.Controls.Add(this.textBox2);
            this.Register_Panel.Controls.Add(this.textBox1);
            this.Register_Panel.Controls.Add(this.Register_Pwd);
            this.Register_Panel.Controls.Add(this.Register_UserName);
            this.Register_Panel.Controls.Add(this.pictureBox1);
            this.Register_Panel.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Panel.Location = new System.Drawing.Point(235, 62);
            this.Register_Panel.Name = "Register_Panel";
            this.Register_Panel.Size = new System.Drawing.Size(333, 301);
            this.Register_Panel.TabIndex = 1;
            // 
            // Register_Button
            // 
            this.Register_Button.FlatAppearance.BorderSize = 0;
            this.Register_Button.Location = new System.Drawing.Point(121, 255);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(75, 30);
            this.Register_Button.TabIndex = 5;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Register_Pwd
            // 
            this.Register_Pwd.AutoSize = true;
            this.Register_Pwd.ForeColor = System.Drawing.Color.White;
            this.Register_Pwd.Location = new System.Drawing.Point(55, 170);
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
            this.Register_UserName.Location = new System.Drawing.Point(40, 126);
            this.Register_UserName.Name = "Register_UserName";
            this.Register_UserName.Size = new System.Drawing.Size(97, 20);
            this.Register_UserName.TabIndex = 1;
            this.Register_UserName.Text = "User name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 26);
            this.textBox3.TabIndex = 7;
            // 
            // Register_Phone
            // 
            this.Register_Phone.AutoSize = true;
            this.Register_Phone.ForeColor = System.Drawing.Color.White;
            this.Register_Phone.Location = new System.Drawing.Point(15, 208);
            this.Register_Phone.Name = "Register_Phone";
            this.Register_Phone.Size = new System.Drawing.Size(122, 19);
            this.Register_Phone.TabIndex = 6;
            this.Register_Phone.Text = "Phone Number :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register_Panel);
            this.Name = "Register";
            this.Text = "Register";
            this.Register_Panel.ResumeLayout(false);
            this.Register_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Register_Panel;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Register_Pwd;
        private System.Windows.Forms.Label Register_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Register_Phone;
    }
}