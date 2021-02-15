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
    public partial class EmployeePage : Form
    {
        List<Employee> listEmployee = new List<Employee>();
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = EmployeeDA.Search(Convert.ToInt32(textBoxSearch.Text));
            if (employee != null)
            {
                textBoxEmployeeId.Text = (employee.EmployeeID).ToString();
                textBoxName.Text = employee.Name;
                textBoxJobTitle.Text = employee.JobTitle;

            }

            else
            {
                MessageBox.Show("Employee not Found!");
                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewEmployee.Items.Clear();
            EmployeeDA.ListEmployees(listViewEmployee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidID(textBoxEmployeeId))
            {
                Employee employee = new Employee();

                employee.EmployeeID = Convert.ToInt32(textBoxEmployeeId.Text);
                employee.Name = textBoxName.Text;
                employee.JobTitle = textBoxJobTitle.Text;
                listEmployee.Add(employee);
                EmployeeDA.Save(employee);
            }
        }
    }
}
