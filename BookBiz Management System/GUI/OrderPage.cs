using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.Validation;
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
    public partial class OrderPage : Form
    {
        List<Order> listOrder = new List<Order>();
        public OrderPage()
        {
            InitializeComponent();
        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            OrderDA.ListOrders(listViewOrder);
        }

        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            Order order = OrderDA.Search(Convert.ToInt32(buttonSearchOrder.Text));
            if (order != null)
            {
                textBoxOrderId.Text = (order.orderId).ToString();
                textBoxOrderDate.Text = order.orderDate;
                textBoxClientId.Text = (order.clientId).ToString();
                textBoxTakenBy.Text = order.orderTakenBy;
                textBoxIsbn.Text = (order.ISBN).ToString();

            }

            else
            {
                MessageBox.Show("Order not Found!");
                textBoxSearch.Clear();
                buttonSearchOrder.Focus();
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if ((Validator.IsValidID(textBoxOrderId)) && (Validator.IsValidID(textBoxIsbn)) && (Validator.IsValidID(textBoxClientId)))
            {
                Order order = new Order();

                order.orderId = Convert.ToInt32(textBoxOrderId.Text);
                order.orderDate = textBoxOrderDate.Text;
                order.clientId = Convert.ToInt32(textBoxClientId.Text);
                order.orderTakenBy = textBoxTakenBy.Text;
                order.ISBN = Convert.ToInt32(textBoxIsbn.Text);

                listOrder.Add(order);
                OrderDA.Save(order);
                buttonListOrder.Enabled = true;
            }
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            OrderDA.Delete(Convert.ToInt32(textBoxOrderId.Text));
            MessageBox.Show("Order has been Cancelled Successfully", "Confirmation");
        }
    }
}
