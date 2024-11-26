using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST RATE = 0.005m;
            decimal balance;
            int months;

            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        dertailListBox.Utems.Add("第" + count + "個月的餘額" + balance.ToString("c"));  
                        count += 1;
                    }while (count <= months) ;


                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("輸入[月份數量]資料格式錯誤");
                }
            }
            else
            {
                MessageBox.Show"輸入[起始餘額]資料格式錯誤");
            }
        }
            
            
        

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
