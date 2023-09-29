using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace adrian_grillo_jeanty
{
    public partial class Form_Entry : Form
    {
        public Form_Entry()
        {
            InitializeComponent();
        }

        private void ticker_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void period_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_load_stock(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Whatever the first line of each .csv file is, used for validation
                string referenceString = '';
                String fn = openFileDialog.FileName;
                Text = fn;

                // Try multiselect 
                string[] filenames = openFileDialog.FileNames;

                using (StreamReader sr = new StreamReader(fn))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        aCandlestick cs = new aCandlestick(line);
                    }
                }
            }
        }

        private void button_submit(object sender, EventArgs e)
        {
            // Using our custom default constructor
            aCandlestick cs = new aCandlestick(DateTime.Now, 1, 2, 3, 1, 10);

            // Using our other default constructor
            // Highlight aCandlestick and see that it says "+2 Overloads" - These are extra constructors
            // What arguments you pass aCandlestick() determines what constructor is called
            // close: 15 specifies a param to define, the others use their default values
            aCandlestick cs2 = new aCandlestick(DateTime.Now, close: 15);
        }
    }
}