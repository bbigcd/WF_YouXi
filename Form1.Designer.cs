namespace WF_YouXi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.but_Replay = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_Load = new System.Windows.Forms.Button();
            this.but_Review = new System.Windows.Forms.Button();
            this.trackBarReviewSpeed = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayExtendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.style3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBarReview = new System.Windows.Forms.ProgressBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReviewSpeed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Replay
            // 
            this.but_Replay.Location = new System.Drawing.Point(297, 339);
            this.but_Replay.Name = "but_Replay";
            this.but_Replay.Size = new System.Drawing.Size(75, 23);
            this.but_Replay.TabIndex = 0;
            this.but_Replay.Text = "重新开始";
            this.but_Replay.UseVisualStyleBackColor = true;
            this.but_Replay.Click += new System.EventHandler(this.but_Replay_Click);
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(297, 368);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 1;
            this.but_Save.Text = "保存";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_Load
            // 
            this.but_Load.Location = new System.Drawing.Point(297, 397);
            this.but_Load.Name = "but_Load";
            this.but_Load.Size = new System.Drawing.Size(75, 23);
            this.but_Load.TabIndex = 2;
            this.but_Load.Text = "载入";
            this.but_Load.UseVisualStyleBackColor = true;
            this.but_Load.Click += new System.EventHandler(this.but_Load_Click);
            // 
            // but_Review
            // 
            this.but_Review.Location = new System.Drawing.Point(297, 477);
            this.but_Review.Name = "but_Review";
            this.but_Review.Size = new System.Drawing.Size(75, 23);
            this.but_Review.TabIndex = 3;
            this.but_Review.Text = "Re&view";
            this.but_Review.UseVisualStyleBackColor = true;
            this.but_Review.Click += new System.EventHandler(this.but_Review_Click);
            // 
            // trackBarReviewSpeed
            // 
            this.trackBarReviewSpeed.Location = new System.Drawing.Point(297, 426);
            this.trackBarReviewSpeed.Maximum = 15;
            this.trackBarReviewSpeed.Minimum = 1;
            this.trackBarReviewSpeed.Name = "trackBarReviewSpeed";
            this.trackBarReviewSpeed.Size = new System.Drawing.Size(75, 45);
            this.trackBarReviewSpeed.TabIndex = 4;
            this.trackBarReviewSpeed.Value = 1;
            this.trackBarReviewSpeed.Scroll += new System.EventHandler(this.trackBar1_Sroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replayToolStripMenuItem,
            this.replayExtendedToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.reviewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.style1ToolStripMenuItem,
            this.style2ToolStripMenuItem,
            this.style3ToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.optionToolStripMenuItem.Text = "设置选项";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controKeyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.helpToolStripMenuItem.Text = "游戏帮助";
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.replayToolStripMenuItem.Text = "重新&开始";
            this.replayToolStripMenuItem.Click += new System.EventHandler(this.replayToolStripMenuItem_Click);
            // 
            // replayExtendedToolStripMenuItem
            // 
            this.replayExtendedToolStripMenuItem.Name = "replayExtendedToolStripMenuItem";
            this.replayExtendedToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.replayExtendedToolStripMenuItem.Text = "Replay(Extended)";
            this.replayExtendedToolStripMenuItem.Click += new System.EventHandler(this.replayExtendedToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.reviewToolStripMenuItem.Text = "Re&view";
            this.reviewToolStripMenuItem.Click += new System.EventHandler(this.reviewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // style1ToolStripMenuItem
            // 
            this.style1ToolStripMenuItem.Name = "style1ToolStripMenuItem";
            this.style1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.style1ToolStripMenuItem.Text = "style1";
            this.style1ToolStripMenuItem.Click += new System.EventHandler(this.style1ToolStripMenuItem_Click);
            // 
            // style2ToolStripMenuItem
            // 
            this.style2ToolStripMenuItem.Name = "style2ToolStripMenuItem";
            this.style2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.style2ToolStripMenuItem.Text = "style2";
            this.style2ToolStripMenuItem.Click += new System.EventHandler(this.style2ToolStripMenuItem_Click);
            // 
            // style3ToolStripMenuItem
            // 
            this.style3ToolStripMenuItem.Name = "style3ToolStripMenuItem";
            this.style3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.style3ToolStripMenuItem.Text = "style3";
            this.style3ToolStripMenuItem.Click += new System.EventHandler(this.style3ToolStripMenuItem_Click);
            // 
            // controKeyToolStripMenuItem
            // 
            this.controKeyToolStripMenuItem.Name = "controKeyToolStripMenuItem";
            this.controKeyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.controKeyToolStripMenuItem.Text = "操&作键";
            this.controKeyToolStripMenuItem.Click += new System.EventHandler(this.controKeyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "关&于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBarReview
            // 
            this.progressBarReview.Location = new System.Drawing.Point(12, 606);
            this.progressBarReview.Name = "progressBarReview";
            this.progressBarReview.Size = new System.Drawing.Size(360, 23);
            this.progressBarReview.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.progressBarReview);
            this.Controls.Add(this.trackBarReviewSpeed);
            this.Controls.Add(this.but_Review);
            this.Controls.Add(this.but_Load);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.but_Replay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReviewSpeed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Replay;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_Load;
        private System.Windows.Forms.Button but_Review;
        private System.Windows.Forms.TrackBar trackBarReviewSpeed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayExtendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem style3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBarReview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
    }
}

