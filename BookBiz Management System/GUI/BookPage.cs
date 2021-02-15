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
    public partial class BookPage : Form
    {
        List<Book> listBook = new List<Book>();
        public BookPage()
        {
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidID(textBoxIsbn) && Validator.IsValidID(textBoxAuthorId) && Validator.IsValidID(textBoxCategoryId) && Validator.IsValidID(textBoxPublisherId))
            {
                Book book = new Book();

                book.ISBN = Convert.ToInt32(textBoxIsbn.Text);
                book.title = textBoxTitle.Text;
                book.AuthorId = Convert.ToInt32(textBoxAuthorId.Text);
                book.YearPublished = Convert.ToInt32(textBoxYear.Text);
                book.QOH = Convert.ToInt32(textBoxQuantity.Text);
                book.UnitPrice = Convert.ToInt32(textBoxPrice.Text);
                book.categoryId = Convert.ToInt32(textBoxCategoryId.Text);
                book.publisherId = Convert.ToInt32(textBoxPublisherId.Text);
                listBook.Add(book);
                BookDA.Save(book);
                buttonListBook.Enabled = true;
                ClearAll();
            }
        }

        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            Book book = BookDA.Search(Convert.ToInt32(textBoxSearch.Text));
            if (book != null)
            {
                textBoxIsbn.Text = (book.ISBN).ToString();
                textBoxTitle.Text = book.title;
                textBoxAuthorId.Text = (book.AuthorId).ToString();
                textBoxYear.Text = (book.YearPublished).ToString();
                textBoxQuantity.Text = (book.QOH).ToString();
                textBoxPrice.Text = (book.UnitPrice).ToString();
                textBoxCategoryId.Text = (book.categoryId).ToString();
                textBoxPublisherId.Text = (book.publisherId).ToString();

            }

            else
            {
                MessageBox.Show("Book not Found!");
                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            listViewBook.Items.Clear();
            BookDA.ListBooks(listViewBook);
        }
        private void ClearAll()
        {
            textBoxIsbn.Clear();
            textBoxTitle.Clear();
            textBoxAuthorId.Clear();
            textBoxYear.Clear();
            textBoxQuantity.Clear();
            textBoxPrice.Clear();
            textBoxCategoryId.Clear();
            textBoxPublisherId.Clear();
            textBoxIsbn.Focus();

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            BookDA.Delete(Convert.ToInt32(textBoxIsbn.Text));
            MessageBox.Show("Book has been deleted successfully from the database", "Confirmation");

        }
    }
}
