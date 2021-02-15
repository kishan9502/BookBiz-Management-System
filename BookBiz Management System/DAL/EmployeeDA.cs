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
    public class EmployeeDA
    {
        public static string filePath = Application.StartupPath + @"\Employees.dat";
        private static string fileTemp = Application.StartupPath + @"\TempAuthor.dat";

        public static void Save(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.EmployeeID + "," + emp.Name + "," + emp.JobTitle);
            sWriter.Close();
            MessageBox.Show("Employee data stored.");

        }
        public static void ListEmployees(ListView listViewAuthor)
        {
            StreamReader streamreader = new StreamReader(filePath);
            listViewAuthor.Items.Clear();
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                ListViewItem item = new ListViewItem(arr[0]);
                item.SubItems.Add(arr[1]);
                item.SubItems.Add(arr[2]);
                listViewAuthor.Items.Add(item);
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
        }
        public static List<Employee> ListEmployees()
        {
            List<Employee> listAuthors = new List<Employee>();
            StreamReader streamreader = new StreamReader(filePath);

            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                Employee at = new Employee();
                at.EmployeeID = Convert.ToInt32(arr[0]);
                at.Name = arr[1];
                at.JobTitle = arr[2];
                listAuthors.Add(at);
                newline = streamreader.ReadLine();
            }
            return listAuthors;
        }
        public static Employee Search(int empId)
        {
            Employee at = new Employee();
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if (empId == Convert.ToInt32(arr[0]))
                {
                    at.EmployeeID = Convert.ToInt32(arr[0]);
                    at.Name = arr[1];
                    at.JobTitle = arr[2];
                    streamreader.Close();
                    return at;
                }
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
            return null;
        }
        public static void Delete(int empId)
        {
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileTemp, true);
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if ((empId) != (Convert.ToInt32(arr[0])))
                {

                    streamwriter.WriteLine(arr[0] + "," + arr[1] + "," + arr[2]);


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
