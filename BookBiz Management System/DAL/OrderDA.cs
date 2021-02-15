using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz_Management_System.BLL;

namespace BookBiz_Management_System.DAL
{
    public class OrderDA
    {

        public static string filePath = Application.StartupPath + @"\Orders.dat";
        private static string fileTemp = Application.StartupPath + @"\TempOrder.dat";

        public static void Save(Order ord)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(ord.orderId + "," + ord.orderDate + "," + ord.clientId + "," + ord.orderTakenBy + "," + ord.ISBN);
            sWriter.Close();
            MessageBox.Show("Order data stored.");

        }
        public static void ListOrders(ListView listViewOrder)
        {
            StreamReader streamreader = new StreamReader(filePath);
            listViewOrder.Items.Clear();
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                ListViewItem item = new ListViewItem(arr[0]);
                item.SubItems.Add(arr[1]);
                item.SubItems.Add(arr[2]);
                item.SubItems.Add(arr[3]);
                item.SubItems.Add(arr[4]);
                listViewOrder.Items.Add(item);
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
        }
        public static List<Order> ListOrders()
        {
            List<Order> listOrders = new List<Order>();
            StreamReader streamreader = new StreamReader(filePath);

            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                Order at = new Order();
                at.orderId = Convert.ToInt32(arr[0]);
                at.orderDate = arr[1];
                at.clientId = Convert.ToInt32(arr[2]);
                at.orderTakenBy = arr[3];
                at.ISBN = Convert.ToInt32(arr[4]);
                listOrders.Add(at);
                newline = streamreader.ReadLine();
            }
            return listOrders;
        }
        public static Order Search(int autId)
        {
            Order at = new Order();
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if (autId == Convert.ToInt32(arr[0]))
                {
                    at.orderId = Convert.ToInt32(arr[0]);
                    at.orderDate = arr[1];
                    at.clientId = Convert.ToInt32(arr[2]);
                    at.orderTakenBy = arr[3];
                    at.ISBN = Convert.ToInt32(arr[4]);
                    streamreader.Close();
                    return at;
                }
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
            return null;
        }
        public static void Delete(int autId)
        {
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileTemp, true);
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if ((autId) != (Convert.ToInt32(arr[0])))
                {

                    streamwriter.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4]);


                }
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
            streamwriter.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);

        }
    }
}
