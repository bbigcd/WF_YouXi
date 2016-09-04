using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using WF_YouXi;

namespace WF_YouXi
{
    public partial class Form1 : Form
    {
        private youxiControl youxiControl = new youxiControl();
        private youxiNext youxiNext = new youxiNext();
        private youxiScore youxiScore = new youxiScore();
        public Form1()
        {
            InitializeComponent();
            youxiControl.Top = menuStrip1.Height + 2;
            youxiControl.Left = 2;
            youxiControl.Parent = this;
            youxiControl.imageList = imageList1;
            youxiNext.Parent = this;
            youxiNext.Top = youxiControl.Top;
            youxiNext.Left = youxiControl.Left + youxiControl.Width + 4;
            youxiControl.TetrisNext = youxiNext;
            youxiScore.Parent = this;
            youxiScore.Top = youxiNext.Top + youxiControl.Width + 4;
            youxiScore.Left = youxiNext.Left;
            youxiControl.TetrisScore = youxiScore;
            style1ToolStripMenuItem.Image = imageList1.Images[0];
            style2ToolStripMenuItem.Image = imageList2.Images[0];
            style3ToolStripMenuItem.Image = imageList3.Images[0];
            youxiControl.ProgressBar = progressBarReview;
            openFileDialog1.FileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\sample.trf";
            saveFileDialog1.FileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\sample.trf";
        }
        #region 顶部菜单栏
        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void replayExtendedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void style1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void style2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void style3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        //重新开始点击触发事件
        private void but_Replay_Click(object sender, EventArgs e)
        {
            youxiControl.Replay(true, false);
        }
        //保持点击触发事件
        private void but_Save_Click(object sender, EventArgs e)
        {

        }
        //载入点击触发事件
        private void but_Load_Click(object sender, EventArgs e)
        {

        }
        //Review点击触发事件
        private void but_Review_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Sroll(object sender, EventArgs e)
        {

        }

       

        

        
    }
}
