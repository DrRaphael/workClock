using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using 番茄钟.ClassRes;
namespace 番茄钟
{
    public partial class Form1 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        

        private static extern IntPtr CreateRoundRectRgn         //在Form类声明
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));//在窗体加载事件中引用
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon1.ContextMenuStrip = CM1;
            
        }
        int timeClock = 0;
        bool flag = false;
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            flag = !flag;
            timeClock = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Per = 0;
            timeClock++;
            
            if (flag == false)
            {
                Per = timeClock / 30;
                
                circularProgressBar1.Text = "学习中";
            }
            else
            {
                Per = timeClock / 6;
                circularProgressBar1.Text = "休息中";
            }
            if (Per >= 100)
            {
                Per = 0;
                flag = !flag;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            
            notifyIcon1.ShowBalloonTip(20, "提示", "番茄钟", ToolTipIcon.None);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 简体中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你现在不就是中文吗！\n" +
                            "    切换个寂寞！", 
                            "关心智障的提示",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("想啥勒，俺不会英文！\nSorry,I don't speak English!",
                "Don't Dream Any More",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseBox_MouseEnter(object sender, EventArgs e)
        {
            this.CloseBox.Image = global::番茄钟.Properties.Resources.Close_On;

        }

        private void CloseBox_MouseLeave(object sender, EventArgs e)
        {
            this.CloseBox.Image = global::番茄钟.Properties.Resources.Close_Default;
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = MessageBox.Show("确定离开?：", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void MinimizeBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBox.Image = Properties.Resources.Smaller_On_;
        }

        private void MinimizeBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBox.Image = Properties.Resources.Smaller_Default;
        }

       

        private void SettingBox_Click(object sender, EventArgs e)
        {
            
        }

        private void 主题颜色ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                Color themeColor = colorDialog1.Color;
                Color tColor;

                this.BackColor = themeColor;
                int cRed, cGreen, cBlue;
                cRed = 255- themeColor.G;
                cBlue = 255- themeColor.R;
                cGreen = 255- themeColor.B;
                circularProgressBar1.OuterColor = Color.FromArgb(cRed, (int)(cGreen*0.6), (int)(cBlue*0.5));
                circularProgressBar1.ProgressColor = Color.FromArgb(cRed,cGreen,cBlue );
                circularProgressBar1.InnerColor = themeColor;
                circularProgressBar1.Value = 50;
                circularProgressBar1.ForeColor = circularProgressBar1.ProgressColor;
            }
        }

        private void MinimizeBox_Click(object sender, EventArgs e)
        {
            Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);
            int width1 = ScreenArea.Width; //屏幕宽度
            int height1 = ScreenArea.Height; //屏幕高度
            this.Location = new System.Drawing.Point(width1 - this.Width, height1 - this.Height); //指定窗体显示在右下角
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
