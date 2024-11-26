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
        try
        {
        StreamWriter outputFile;
        outputFile = File.CreateText(@"C:\Users\shu\Desktop\113-1-c-sharpe\113-11-26\Tutorial 5-4\Friend FileFriend.txt);
        outputFile.Writel.ine(nameTextBox.Text);
        outputFile.Close();
        MesageBox.Show("名字已經寫入檔案。");
        }
        catch(Exception ex)
        {
          MessageBox.Show(Exception.Message);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
