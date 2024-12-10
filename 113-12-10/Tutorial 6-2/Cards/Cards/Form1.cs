using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        private void showTenHearts()
        {
            aeSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;

        }
        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
            
            
        private void showCard(string cardNaeme)
        {
            switch (cardNaeme)
            {
                case "黑桃A":
                    aceSpadesPictureBox.Visible = true;
                    tenHeartsPictureBox.Visible = false;
                    kingClubsPictureBox.Visible = false;
                case: "紅心石"
                    aceSpadesPictureBox.Visible = false
                    tenHeartsPictureBox.Visible = true
                    kingClubsPictureBox.Visible = false;
                case "梅花K"
                    aceSpadesPictureBox.Visible = false;
                    tenHeartsPictureBox.Visible = false;
                    kingClubsPictureBox.Visible = true; 
                    break;
            }
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showCardButton(cardListBox.SelectItem.ToString());
            }
            else
            {
                MessaeBox.Show("選擇一張牌")
            }
                  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
