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
    public class BookDA
    {

        public static string filePath = Application.StartupPath + @"\Books.dat";
        private static string fileTemp = Application.StartupPath + @"\TempBook.dat";

        public static void Save(Book but)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(but.ISBN + "," + but.title + "," + but.AuthorId + "," + but.YearPublished + "," + but.QOH + "," + but.UnitPrice + "," + but.categoryId + "," + but.publisherId);
            sWriter.Close();
            MessageBox.Show("Book data stored.");

        }
        public static void ListBooks(ListView listViewBook)
        {
            StreamReader streamreader = new StreamReader(filePath);
            listViewBook.Items.Clear();
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
                listViewBook.Items.Add(item);
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
        }
        public static List<Book> ListBooks()
        {
            List<Book> listBooks = new List<Book>();
            StreamReader streamreader = new StreamReader(filePath);

            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                Book bk = new Book();
                bk.ISBN = Convert.ToInt32(arr[0]);
                bk.title = arr[1];
                bk.AuthorId = Convert.ToInt32(arr[2]);
                bk.YearPublished = Convert.ToInt32(arr[3]);
                bk.QOH = Convert.ToInt32(arr[4]);
                bk.UnitPrice = Convert.ToInt32(arr[4]);
                bk.categoryId = Convert.ToInt32(arr[6]);
                bk.publisherId = Convert.ToInt32(arr[7]);
                listBooks.Add(bk);
                newline = streamreader.ReadLine();
            }
            return listBooks;
        }
        public static Book Search(int butId)
        {
            Book bk = new Book();
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if (butId == Convert.ToInt32(arr[0]))
                {
                    bk.ISBN = Convert.ToInt32(arr[0]);
                    bk.title = arr[1];
                    bk.AuthorId = Convert.ToInt32(arr[2]);
                    bk.YearPublished = Convert.ToInt32(arr[3]);
                    bk.QOH = Convert.ToInt32(arr[4]);
                    bk.UnitPrice = Convert.ToInt32(arr[4]);
                    bk.categoryId = Convert.ToInt32(arr[6]);
                    bk.publisherId = Convert.ToInt32(arr[7]);
                    streamreader.Close();
                    return bk;
                }
                newline = streamreader.ReadLine();
            }
            streamreader.Close();
            return null;
        }
        public static void Delete(int butId)
        {
            StreamReader streamreader = new StreamReader(filePath);
            string newline = streamreader.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileTemp, true);
            while (newline != null)
            {
                string[] arr = newline.Split(',');
                if ((butId) != (Convert.ToInt32(arr[0])))
                {

                    streamwriter.WriteLine(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "," + arr[5] + "," + arr[6] + "," + arr[7]);

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
