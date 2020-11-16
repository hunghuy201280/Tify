namespace Tify
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.Login_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login_Pwd = new System.Windows.Forms.Label();
            this.Login_UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Panel
            // 
            this.Login_Panel.Controls.Add(this.Login_Button);
            this.Login_Panel.Controls.Add(this.textBox2);
            this.Login_Panel.Controls.Add(this.textBox1);
            this.Login_Panel.Controls.Add(this.Login_Pwd);
            this.Login_Panel.Controls.Add(this.Login_UserName);
            this.Login_Panel.Controls.Add(this.pictureBox1);
            this.Login_Panel.Font = new System.Drawing.Font("Nationale Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Panel.Location = new System.Drawing.Point(238, 97);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(365, 301);
            this.Login_Panel.TabIndex = 0;
            // 
            // Login_Button
            // 
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.Location = new System.Drawing.Point(157, 236);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 30);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Login_Pwd
            // 
            this.Login_Pwd.AutoSize = true;
            this.Login_Pwd.ForeColor = System.Drawing.Color.White;
            this.Login_Pwd.Location = new System.Drawing.Point(42, 161);
            this.Login_Pwd.Name = "Login_Pwd";
            this.Login_Pwd.Size = new System.Drawing.Size(82, 19);
            this.Login_Pwd.TabIndex = 2;
            this.Login_Pwd.Text = "Password :";
            // 
            // Login_UserName
            // 
            this.Login_UserName.AutoSize = true;
            this.Login_UserName.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UserName.ForeColor = System.Drawing.Color.White;
            this.Login_UserName.Location = new System.Drawing.Point(30, 115);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(101, 20);
            this.Login_UserName.TabIndex = 1;
            this.Login_UserName.Text = "User name : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.Login_Panel);
            this.Name = "Login";
            this.Text = "Login";
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Login_Pwd;
        private System.Windows.Forms.Label Login_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login_Button;
    }
}