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
    public partial class MainWindow : Form
    {
        public string filename;
        public MainWindow(string aFilename)
        {
            InitializeComponent();
            filename = aFilename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewItem nw = new NewItem(filename);
            nw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemList il = new ItemList(filename);
            il.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search s = new Search(filename);
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
