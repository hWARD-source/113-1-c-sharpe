using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int getPoint;  // 宣告getPoint用來存放得到的點數
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            TmrGo.Interval = 50;  // 指定每50毫秒(即0.05秒)執行一次TmrGo_Tick事件
            Pic1.Image = ImgDice.Images[0];
        }
        // 按 [開始] 鈕執
        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrGo.Enabled = true;  //啟動TmrGo計時器
        }
        // 按 [停止] 鈕執行
        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrGo.Enabled = false; // 停止TmrGo計時器
            LblMsg.Text = $"你得到 {getPoint + 1} 點 !!";
        }
        // 每50毫秒(即0.05秒)執行一次TmrGo_Tick事件
        private void TmrGo_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            getPoint = rnd.Next(0, 6);
            Pic1.Image = ImgDice.Images[getPoint];
        }
    }
}



