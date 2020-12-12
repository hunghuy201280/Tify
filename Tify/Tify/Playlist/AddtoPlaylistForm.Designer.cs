namespace Tify
{
    partial class AddtoPlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddtoPlaylistForm));
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_showPL = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_createnewPL = new System.Windows.Forms.Button();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nationale", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(270, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel_showPL
            // 
            this.flowLayoutPanel_showPL.AutoScroll = true;
            this.flowLayoutPanel_showPL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_showPL.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_showPL.Location = new System.Drawing.Point(0, 139);
            this.flowLayoutPanel_showPL.Name = "flowLayoutPanel_showPL";
            this.flowLayoutPanel_showPL.Size = new System.Drawing.Size(310, 267);
            this.flowLayoutPanel_showPL.TabIndex = 1;
            this.flowLayoutPanel_showPL.WrapContents = false;
            // 
            // Btn_createnewPL
            // 
            this.Btn_createnewPL.FlatAppearance.BorderSize = 0;
            this.Btn_createnewPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_createnewPL.Font = new System.Drawing.Font("Nationale Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_createnewPL.ForeColor = System.Drawing.Color.White;
            this.Btn_createnewPL.Image = ((System.Drawing.Image)(resources.GetObject("Btn_createnewPL.Image")));
            this.Btn_createnewPL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_createnewPL.Location = new System.Drawing.Point(0, 35);
            this.Btn_createnewPL.Name = "Btn_createnewPL";
            this.Btn_createnewPL.Size = new System.Drawing.Size(310, 57);
            this.Btn_createnewPL.TabIndex = 3;
            this.Btn_createnewPL.Text = "Create new playlist";
            this.Btn_createnewPL.UseVisualStyleBackColor = true;
            this.Btn_createnewPL.Click += new System.EventHandler(this.Btn_createnewPL_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 110);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(310, 23);
            this.separatorControl1.TabIndex = 4;
            // 
            // AddtoPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(310, 406);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.Btn_createnewPL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel_showPL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddtoPlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddtoPlaylistForm";
            this.Load += new System.EventHandler(this.AddtoPlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_showPL;
        private System.Windows.Forms.Button Btn_createnewPL;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}