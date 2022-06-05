using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Search : Form
    {

        private string filename;
        public Search(string filename)
        {
            InitializeComponent();
            this.filename = filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filename);
            int numToSearch;

            try
            {
                numToSearch = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInput only 8 digit numbers.");
                return;
            }
            

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int number = Convert.ToInt32(parts[1]);
                
                if (number == numToSearch)
                {
                    textBox1.Text = parts[0];
                    textBox2.Text = parts[1];
                    textBox3.Text = parts[2];

                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
