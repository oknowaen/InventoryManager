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
    public partial class ItemList : Form
    {
        public string[] lines;
        public string filename;
        public ItemList(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            lines = File.ReadAllLines(filename);
        }

        private void Redraw()
        {
            richTextBox1.Text = "";
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = "";
            }

            lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                richTextBox1.Text = richTextBox1.Text + "\nName: " + parts[0] + "    Item No.: " + parts[1] + "    Notes: " + parts[2] + "\n";
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            Redraw();
        }
    }
}
