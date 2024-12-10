using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int tose = random.Next(2);//random.Next(6) + 1
            if (tossButton == 0)
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
