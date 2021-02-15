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
    public class AuthorDA
    {

        public static string filePath = Application.StartupPath + @"\Authors.dat";
        private static string fileTemp = Application.StartupPath + @"\TempAuthor.dat";

        public static void Save(Author aut)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(aut.AuthorId + "," + aut.firstName + "," + aut.lastName);
            sWriter.Close();
            MessageBox.Show("Author data stored.");

        }
        public static void ListAuthors(ListView listViewAuthor)
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
        public static List<Author> ListAuthors()
        {
            List<Author> listAuthors = new List<Author>();
            StreamReader streamreader = new StreamReader(filePath);

            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                Author at = new Author();
                at.AuthorId = Convert.ToInt32(arr[0]);
                at.firstName = arr[1];
                at.lastName = arr[2];
                listAuthors.Add(at);
                newline = streamreader.ReadLine();
            }
            return listAuthors;
        }
        public static Author Search(int autId)
        {
            Author at = new Author();
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if (autId == Convert.ToInt32(arr[0]))
                {
                    at.AuthorId = Convert.ToInt32(arr[0]);
                    at.firstName = arr[1];
                    at.lastName = arr[2];
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
