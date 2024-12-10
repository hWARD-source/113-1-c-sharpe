using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
       private void turnLightOn()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }
        private void turnLightOff()
        {
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
           if(lightOnPictureBox.Visible == ture)
           {
                    //關燈
                    turnLightOff();
           }
           else
           {
                   //開燈
                   turnLightOn();
           }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Forml_load(object sender, EventArgs e)
        {
            lightOffPictureBox.Visible = false;
            lightOnPictureBox.Visible=true;
        }
    }
}
