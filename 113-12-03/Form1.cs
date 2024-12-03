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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamingReader inputFile;
                string countryName
                inputFile = File.OpenText("countries.txt");
                countruesListBox.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                inputFile.Close();
            }
            catch ( Exception ex)
            {
                Message.Show(exitButton.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
