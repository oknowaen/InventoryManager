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
    public partial class NewItem : Form
    {
        public string filename;
        public NewItem(string aFilename)
        {
            InitializeComponent();
            filename = aFilename;
        }

        private void NewItem_Load(object? sender, EventArgs? e)
        {
            Random rm = new Random();
            textBox2.Text = Convert.ToString(rm.Next(10000000, 99999999));

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                int number = int.Parse(parts[1]);
                try
                {
                    if (number == int.Parse(textBox2.Text))
                    {
                        NewItem_Load(null, null);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string final = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "\n";

            File.AppendAllText(filename, final);

            MessageBox.Show("Item added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
