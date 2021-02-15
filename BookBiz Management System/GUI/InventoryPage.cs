using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System.GUI
{
    public partial class InventoryPage : Form
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookPage bp = new BookPage();
            bp.Show();
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorPage ap = new AuthorPage();
            ap.Show();
        }
    }
}
