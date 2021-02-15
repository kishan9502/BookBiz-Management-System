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
    public partial class AuthorPage : Form
    {
        List<Author> listAuthor = new List<Author>();
        public AuthorPage()
        {
            InitializeComponent();
        }

        private void AuthorPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {
            Author author = AuthorDA.Search(Convert.ToInt32(textBoxSearch.Text));
            if (author != null)
            {
                textBoxAuthorId.Text = (author.AuthorId).ToString();
                textBoxFirstName.Text = author.firstName;
                textBoxLastName.Text = author.lastName;

            }

            else
            {
                MessageBox.Show("Author not Found!");
                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
        }

        private void buttonListAuthor_Click(object sender, EventArgs e)
        {
            listViewAuthor.Items.Clear();
            AuthorDA.ListAuthors(listViewAuthor);
        }

        private void ClearAll()
        {
            textBoxAuthorId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAuthorId.Focus();

        }


        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidID(textBoxAuthorId))
            {
                Author author = new Author();

                author.AuthorId = Convert.ToInt32(textBoxAuthorId.Text);
                author.firstName = textBoxFirstName.Text;
                author.lastName = textBoxLastName.Text;
                listAuthor.Add(author);
                AuthorDA.Save(author);
                buttonListAuthor.Enabled = true;
                ClearAll();
            }
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            AuthorDA.Delete(Convert.ToInt32(textBoxAuthorId.Text));
            MessageBox.Show("Author has been deleted successfully from the database", "Confirmation");

        }
    }
}
