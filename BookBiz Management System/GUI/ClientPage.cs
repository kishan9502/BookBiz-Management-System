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
    public partial class ClientPage : Form
    {
        List<Client> listClient = new List<Client>();
        public ClientPage()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidID(textBoxClientId))
            {
                Client client = new Client();
                client.clientId = Convert.ToInt32(textBoxClientId.Text);
                client.name = textBoxName.Text;
                client.phoneNumber = maskedTextBoxPhone.Text;
                client.faxNumber = textBoxFax.Text;
                client.address = textBoxAddress.Text;
                client.city = textBoxCity.Text;
                client.postalCode = textBoxPostalCode.Text;
                client.bankNumber = Convert.ToInt32(textBoxBankNumber.Text);
                client.branchNumber = Convert.ToInt32(textBoxBranch.Text);
                client.bankAccount = textBoxAccountType.Text;
                listClient.Add(client);
                ClientDA.Save(client);
                buttonListBook.Enabled = true;
                ClearAll();
            }
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            ClientDA.Delete(Convert.ToInt32(textBoxClientId.Text));
            MessageBox.Show("Client has been deleted successfully from the database", "Confirmation");
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            {
                listViewClient.Items.Clear();
                ClientDA.ListClients(listViewClient);
            }

        }
        private void ClearAll()
        {
            textBoxClientId.Clear();
            textBoxName.Clear();
            maskedTextBoxPhone.Clear();
            textBoxFax.Clear();
            textBoxAddress.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            textBoxBankNumber.Clear();
            textBoxBranch.Clear();
            textBoxAccountType.Clear();
            textBoxClientId.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = ClientDA.Search(Convert.ToInt32(textBoxSearch.Text));
            if (client != null)
            {
                textBoxClientId.Text = (client.clientId).ToString();
                textBoxName.Text = client.name;
                maskedTextBoxPhone.Text = client.phoneNumber;
                textBoxFax.Text = client.faxNumber;
                textBoxAddress.Text = client.address;
                textBoxCity.Text = client.city;
                textBoxPostalCode.Text = client.postalCode;
                textBoxBankNumber.Text = client.bankNumber.ToString();
                textBoxBranch.Text = client.branchNumber.ToString();
                textBoxAccountType.Text = client.bankAccount;

            }

            else
            {
                MessageBox.Show("Client not Found!");
                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
        }
    }
}
