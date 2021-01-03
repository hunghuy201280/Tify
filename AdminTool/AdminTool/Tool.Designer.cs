namespace AdminTool
{
    partial class Tool
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
            this.VietNamChart_worker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.USUKChart_worker = new System.ComponentModel.BackgroundWorker();
            this.ChineseChart_worker = new System.ComponentModel.BackgroundWorker();
            this.KoreaChart_worker = new System.ComponentModel.BackgroundWorker();
            this.JapaneseChart_worker = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.createMix_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addArtist_button = new System.Windows.Forms.Button();
            this.artistLink_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // VietNamChart_worker
            // 
            this.VietNamChart_worker.WorkerReportsProgress = true;
            this.VietNamChart_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VietNamChart_worker_DoWork);
            this.VietNamChart_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.VietNamChart_worker_ProgressChanged);
            this.VietNamChart_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.VietNamChart_worker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(70, 409);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(778, 18);
            this.progressBar.TabIndex = 0;
            // 
            // USUKChart_worker
            // 
            this.USUKChart_worker.WorkerReportsProgress = true;
            this.USUKChart_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.USUKChart_worker_DoWork);
            this.USUKChart_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.VietNamChart_worker_ProgressChanged);
            this.USUKChart_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.USUKChart_worker_RunWorkerCompleted);
            // 
            // ChineseChart_worker
            // 
            this.ChineseChart_worker.WorkerReportsProgress = true;
            this.ChineseChart_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ChineseChart_worker_DoWork);
            this.ChineseChart_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.VietNamChart_worker_ProgressChanged);
            this.ChineseChart_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ChineseChart_worker_RunWorkerCompleted);
            // 
            // KoreaChart_worker
            // 
            this.KoreaChart_worker.WorkerReportsProgress = true;
            this.KoreaChart_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.KoreaChart_worker_DoWork);
            this.KoreaChart_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.VietNamChart_worker_ProgressChanged);
            this.KoreaChart_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.KoreaChart_worker_RunWorkerCompleted);
            // 
            // JapaneseChart_worker
            // 
            this.JapaneseChart_worker.WorkerReportsProgress = true;
            this.JapaneseChart_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.JapaneseChart_worker_DoWork);
            this.JapaneseChart_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.VietNamChart_worker_ProgressChanged);
            this.JapaneseChart_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.JapaneseChart_worker_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(70, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createMix_button
            // 
            this.createMix_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createMix_button.Location = new System.Drawing.Point(702, 304);
            this.createMix_button.Name = "createMix_button";
            this.createMix_button.Size = new System.Drawing.Size(146, 77);
            this.createMix_button.TabIndex = 1;
            this.createMix_button.Text = "Create Mix";
            this.createMix_button.UseVisualStyleBackColor = true;
            this.createMix_button.Click += new System.EventHandler(this.createMix_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(70, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(778, 266);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // addArtist_button
            // 
            this.addArtist_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addArtist_button.Location = new System.Drawing.Point(483, 445);
            this.addArtist_button.Name = "addArtist_button";
            this.addArtist_button.Size = new System.Drawing.Size(146, 77);
            this.addArtist_button.TabIndex = 1;
            this.addArtist_button.Text = "Add Artist";
            this.addArtist_button.UseVisualStyleBackColor = true;
            this.addArtist_button.Click += new System.EventHandler(this.addArtist_button_Click);
            // 
            // artistLink_textBox
            // 
            this.artistLink_textBox.Location = new System.Drawing.Point(70, 474);
            this.artistLink_textBox.Name = "artistLink_textBox";
            this.artistLink_textBox.Size = new System.Drawing.Size(407, 20);
            this.artistLink_textBox.TabIndex = 3;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 528);
            this.Controls.Add(this.artistLink_textBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.addArtist_button);
            this.Controls.Add(this.createMix_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.MaximumSize = new System.Drawing.Size(928, 567);
            this.MinimumSize = new System.Drawing.Size(928, 567);
            this.Name = "Tool";
            this.Text = "Admin Tool";
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker VietNamChart_worker;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private System.ComponentModel.BackgroundWorker USUKChart_worker;
        private System.ComponentModel.BackgroundWorker ChineseChart_worker;
        private System.ComponentModel.BackgroundWorker KoreaChart_worker;
        private System.ComponentModel.BackgroundWorker JapaneseChart_worker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createMix_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addArtist_button;
        private System.Windows.Forms.TextBox artistLink_textBox;
    }
}

