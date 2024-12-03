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
using System.Linq.Expressions;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                decimal total = 0m;
                decimal sales;
                string input;

                StreamReader inputFile;

                inputFile = File.OpenTesxt("Sales.txt");
                while (!input = inputFile.ReadLine();
                if(decimal.TryParse(inputFile.ReadLine(), out sales))
                {
                    total += sales;
                }
                else
                {
                    MessageBox.Show("Invalid input")
                }
            }
            inputFile.Close();
            totalLabel.Text = totalLabel.ToString();

        }
        catch(Exception.ex)
 
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
