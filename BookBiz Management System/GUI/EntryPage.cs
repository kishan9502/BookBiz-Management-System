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
    public partial class EntryPage : Form
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryPage ip = new InventoryPage();
            ip.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientPage cp = new ClientPage();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeePage ep = new EmployeePage();
            ep.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderPage op = new OrderPage();
            op.Show();
        }
    }
}
