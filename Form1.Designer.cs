
namespace 番茄钟
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CM1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主题颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.休息时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.主题颜色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinimizeBox = new System.Windows.Forms.PictureBox();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pannel_Min_Close = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CM1.SuspendLayout();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.Pannel_Min_Close.SuspendLayout();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("JetBrains Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Aqua;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(21, 73);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 25;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 15;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(250, 250);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // CM1
            // 
            this.CM1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.CM1.Name = "CM1";
            this.CM1.Size = new System.Drawing.Size(181, 76);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.休息时间ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.系统语言ToolStripMenuItem,
            this.主题颜色ToolStripMenuItem,
            this.主题颜色ToolStripMenuItem1});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 主题颜色ToolStripMenuItem
            // 
            this.主题颜色ToolStripMenuItem.Name = "主题颜色ToolStripMenuItem";
            this.主题颜色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.主题颜色ToolStripMenuItem.Text = "工作时间";
            // 
            // 休息时间ToolStripMenuItem
            // 
            this.休息时间ToolStripMenuItem.Name = "休息时间ToolStripMenuItem";
            this.休息时间ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.休息时间ToolStripMenuItem.Text = "休息时间";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 主题颜色ToolStripMenuItem1
            // 
            this.主题颜色ToolStripMenuItem1.Name = "主题颜色ToolStripMenuItem1";
            this.主题颜色ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.主题颜色ToolStripMenuItem1.Text = "主题颜色";
            this.主题颜色ToolStripMenuItem1.Click += new System.EventHandler(this.主题颜色ToolStripMenuItem1_Click);
            // 
            // 系统语言ToolStripMenuItem
            // 
            this.系统语言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简体中文ToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.系统语言ToolStripMenuItem.Name = "系统语言ToolStripMenuItem";
            this.系统语言ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.系统语言ToolStripMenuItem.Text = "系统语言";
            // 
            // 简体中文ToolStripMenuItem
            // 
            this.简体中文ToolStripMenuItem.Name = "简体中文ToolStripMenuItem";
            this.简体中文ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.简体中文ToolStripMenuItem.Text = "简体中文";
            this.简体中文ToolStripMenuItem.Click += new System.EventHandler(this.简体中文ToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // title
            // 
            this.title.Controls.Add(this.panel3);
            this.title.Controls.Add(this.MinimizeBox);
            this.title.Controls.Add(this.CloseBox);
            this.title.Controls.Add(this.panel1);
            this.title.Controls.Add(this.Pannel_Min_Close);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 24);
            this.title.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 24);
            this.panel3.TabIndex = 12;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBox.Image = global::番茄钟.Properties.Resources.Smaller_Default;
            this.MinimizeBox.Location = new System.Drawing.Point(246, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(24, 24);
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBox.TabIndex = 11;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.Click += new System.EventHandler(this.MinimizeBox_Click);
            this.MinimizeBox.MouseEnter += new System.EventHandler(this.MinimizeBox_MouseEnter);
            this.MinimizeBox.MouseLeave += new System.EventHandler(this.MinimizeBox_MouseLeave);
            // 
            // CloseBox
            // 
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.Image = global::番茄钟.Properties.Resources.Close_Default;
            this.CloseBox.Location = new System.Drawing.Point(270, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(24, 24);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBox.TabIndex = 10;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseEnter += new System.EventHandler(this.CloseBox_MouseEnter);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 24);
            this.panel1.TabIndex = 8;
            // 
            // Pannel_Min_Close
            // 
            this.Pannel_Min_Close.Controls.Add(this.panel2);
            this.Pannel_Min_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pannel_Min_Close.Location = new System.Drawing.Point(296, 0);
            this.Pannel_Min_Close.Name = "Pannel_Min_Close";
            this.Pannel_Min_Close.Size = new System.Drawing.Size(4, 24);
            this.Pannel_Min_Close.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 24);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.title);
            this.Controls.Add(this.circularProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CM1.ResumeLayout(false);
            this.title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.Pannel_Min_Close.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip CM1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主题颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 休息时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 主题颜色ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 系统语言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private new System.Windows.Forms.PictureBox MinimizeBox;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.Panel Pannel_Min_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

