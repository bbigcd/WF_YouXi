using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace WF_YouXi
{
    public class youxiControl : Control                                                   // 需要using System.Windows.Forms
    {
        private const int rowCount = 21;                                                  // 行数
        private const int colCount = 11;                                                  // 烈数
        private int brickWidth = 16;                                                      // 小块宽度
        private int brickHeight = 16;                                                     // 小块高度
        public ImageList imageList;                                                      // 方块素材
        private Bitmap backBitmap;                                                        // 背景图片  Bitmap need to  using System.Drawing
        private List<List<List<Point>>> brickTemplets = new List<List<List<Point>>>();    // Point need to  using System.Drawing
        private byte[,] points = new byte[colCount, rowCount];                            // 点阵
        private byte brickIndex = 0;                                                      // 模板序号
        private byte facingIndex = 0;                                                     // 当前变化号
        private Point brickPoint = new Point();                                           // 方块的位置
        private byte afterBrickIndex = 0;                                                 // 下一个模板序号
        private byte afterFacingIndex = 0;                                                // 下一个变化号
        private System.Windows.Forms.Timer timer;                                         // 控制下落的定时器
        private int lines;                                                                // 消行数
        private Random random = new Random();                                             // 随机数
        private int level = 0;                                                            // 当前速度
        private int score = 0;                                                            // 成绩
        // 下落速度,数值表示每次下落的时间差，以毫秒为单位
        private int[] speeds = new int[] { 700, 500, 400, 300, 220, 120, 100, 80, 70, 60, 50 };
        // 每次消除行所增加的积分
        private int[] scores = new int[] { 0001, 0100, 0300, 0500, 1000, 3200};
        private bool playing = false;                                                     // 玩家是否正在玩游戏
        private youxiNext youxiNext;                                                      // 下一个方块的显示控件
        private youxiScore youxiScore;                                                    // 积分显示控件
        private int stepIndex = -1;                                                       // 当前回放的步数
        private bool reviewing = false;                                                   // 是否正在回放
        private Thread threadReview = null;                                               // 回放使用的线程
        private int reviewSpeed = 1;                                                      // 回放的速度，数值表示倍数
        private List<StepInfo> StepInfos = new List<StepInfo>();                          // 记录玩家的每一步操作
        private int lastRecordTime = 0;                                                   // 最后记录的时间
        private bool recordMode = false;                                                  // 是否采用记录模式
        private ProgressBar progressBar;                                                  // 回放进度条
        private bool extended = false;                                                    // 扩展方块
        // 消除行数
        public int Lines { get { return lines; } }
        // 当前积分
        public int Score { get { return score; } }
        // 当前关数
        public int Level { get { return level; } }
        // 方块的操作
        public enum BrickOperates
        {
            boMoveLeft = 0,                                                               // 左移
            boMoveRight = 1,                                                              // 右移
            boMoveDown = 2,                                                               // 下移
            boMoveBottom = 3,                                                             // 直下
            boTurnLeft = 4,                                                               // 左旋
            boTurnRight = 5,                                                              // 右旋
        }



        public void Replay(bool ARecordModel,bool AExtended)
        {
            if(threadReview != null)
            {
                threadReview.Abort();
                threadReview = null;
            }

            if(AExtended != extended)
            {
                NewTemplets(AExtended);
            }
            reviewing = false;
            playing = true;
            recordMode = ARecordModel;
            Clear();
            StepInfos.Clear();
            afterBrickIndex = (byte)random.Next(brickTemplets.Count);
            afterFacingIndex = (byte)random.Next(brickTemplets[afterBrickIndex].Count);
            if (youxiNext != null) youxiNext.Update(this);
            if(recordMode && !reviewing)
            {
                StepInfos.Add(new StepInfo(0, 0, afterBrickIndex, afterFacingIndex));
                lastRecordTime = Environment.TickCount;
            }

            level = 0;
            score = 0;
            lines = 0;
            stepIndex = -1;
            if (progressBar != null) progressBar.Value = 0;
            NextBrick();

        }

        private void Clear()
        {
            throw new NotImplementedException();
        }

        private void NextBrick()
        {
            throw new NotImplementedException();
        }

        private void NewTemplets(bool AExtended)
        {
            throw new NotImplementedException();
        }

    }

    
}
