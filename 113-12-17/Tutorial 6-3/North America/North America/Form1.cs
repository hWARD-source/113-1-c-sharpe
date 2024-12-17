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
using System.Windows.Forms.VisualStyles;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        
        private void GetFileName(out string fileName)
        {
            if (openFile.ShowDialog() ==DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            else
            {
                fileName = "";
            }

        }
        
      private void Getcountries(string fileName)
        {

            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText9(fileName);

                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    string countryNmme = inputFile.ReadLine();
                    countruesListBox.Items.Add(countryNmme);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;

            GetFileName(fileName);

            MessageBox.Show("檔案名稱" + fileName);

            Getcountrues(fileName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

    }
}
