using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // 這裡是寫入名字的按鈕點擊事件處理程式
            try
            {
                StreamWriter outputFile; //StreamWriter物件
                outputFile = File.AppendText(C: \Users\shu\Desktop\113 - 1 - c - sharpe\113 - 11 - 26\Tutorial 5 - 4\Friend File);
                outputFile.WriteLine(nameTextBox.Text);
                outputFile.Close();
                MessegeBox.Show("名字已經寫入檔案。");
            }
            catch(Exception ex) 
            {
                MessageBox(ex.Message);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
