using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.
     

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups, ounces;

            if (double.TryParse(cupsTextBox.Text,out cups))               
            {
                ounces = Cups _To_Ounces(cups);
                ouncesLabel.Text = ounces + "盎司";

            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }
      
        private double Cups_To_Ounces(double cups)
        {
            return cups * 8.0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
