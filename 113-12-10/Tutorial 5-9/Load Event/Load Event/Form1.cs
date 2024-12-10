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

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exitButton.Text = "離開";
            try
            {
                StreamReader inputfile;
                string countryName;
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputfile = File.OpenText(OpenFileDialog.FileName);
                    countriesListBox.Items.Clear();
                    while (!inputfile.EmdOfStream)
                    {
                        countryName = inputfile.ReadLine();
                        countriesListBox.Items.Add(countryName);
                    }
                    inputfile.Close();
                }
                else
                {
                    MessageBox.Show("未選擇檔案")
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
            private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
