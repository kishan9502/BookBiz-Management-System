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
    public class ClientDA
    {
        public static string filePath = Application.StartupPath + @"\Clients.dat";
        private static string fileTemp = Application.StartupPath + @"\TempClient.dat";

        public static void Save(Client cli)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(cli.clientId + "," + cli.name + "," + cli.phoneNumber + "," + cli.faxNumber + "," + cli.address + "," + cli.city + "," + cli.postalCode + "," + cli.bankNumber + "," + cli.branchNumber + "," + cli.bankAccount);
            sWriter.Close();
            MessageBox.Show("Client data stored.");

        }
        public static void ListClients(ListView listViewClient)
        {
            StreamReader streamreader = new StreamReader(filePath);
            listViewClient.Items.Clear();
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                ListViewItem item = new ListViewItem(arr[0]);
                item.SubItems.Add(arr[1]);
                item.SubItems.Add(arr[2]);
                item.SubItems.Add(arr[3]);
                item.SubItems.Add(arr[4]);
                item.SubItems.Add(arr[5]);
                item.SubItems.Add(arr[6]);
                item.SubItems.Add(arr[7]);
                item.SubItems.Add(arr[8]);
                item.SubItems.Add(arr[9]);
                listViewClient.Items.Add(item);
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
        }
        public static List<Client> ListClients()
        {
            List<Client> listClients = new List<Client>();
            StreamReader streamreader = new StreamReader(filePath);

            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                Client cl = new Client();
                cl.clientId = Convert.ToInt32(arr[0]);
                cl.name = arr[1];
                cl.phoneNumber = arr[2];
                cl.faxNumber = arr[3];
                cl.address = arr[4];
                cl.city = arr[5];
                cl.postalCode = arr[6];
                cl.bankNumber = Convert.ToInt32(arr[7]);
                cl.branchNumber = Convert.ToInt32(arr[8]);
                cl.bankAccount = arr[9];
                listClients.Add(cl);
                newline = streamreader.ReadLine();
            }
            return listClients;
        }
        public static Client Search(int cliId)
        {
            Client cl = new Client();
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if (cliId == Convert.ToInt32(arr[0]))
                {
                    cl.clientId = Convert.ToInt32(arr[0]);
                    cl.name = arr[1];
                    cl.phoneNumber = arr[2];
                    cl.faxNumber = arr[3];
                    cl.address = arr[4];
                    cl.city = arr[5];
                    cl.postalCode = arr[6];
                    cl.bankNumber = Convert.ToInt32(arr[7]);
                    cl.branchNumber = Convert.ToInt32(arr[8]);
                    cl.bankAccount = arr[9];
                    streamreader.Close();
                    return cl;
                }
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
            return null;
        }
        public static void Delete(int cliId)
        {
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileTemp, true);
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if ((cliId) != (Convert.ToInt32(arr[0])))
                {

                    streamwriter.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7] + "," + arr[8] + "," + arr[9]);

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
