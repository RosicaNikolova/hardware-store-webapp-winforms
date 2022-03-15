using MediaBazaarProject.Business;
using MediaBazaarProject.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarProject
{
    public partial class admin_managerForm : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public admin_managerForm()
        {
            InitializeComponent();
        }

        private void admin_managerForm_Load(object sender, EventArgs e)
        {
            List<Employee> employees =  employeeManager.GetAllEmployees();
            foreach(Employee u in employees)
            {
                lbEmployeeList.Items.Add(u.FirstName + " " + u.LastName);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            createEmployeeForm addEmployeeForm = new createEmployeeForm();
            addEmployeeForm.Show();
        }

        private void btnDeactivateEmployee_Click(object sender, EventArgs e)
        {
            object selectedEmployee = lbEmployeeManagementList.SelectedItem;
            Employee employee = ((Employee)selectedEmployee);
            employeeManager.DeactivateEmployee((Employee)employee);
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabEmployeeManagement;
            List<Employee> employees = employeeManager.GetAllEmployees();
            lbEmployeeManagementList.Items.Clear();
            foreach (Employee em in employees)
            {
                lbEmployeeManagementList.Items.Add(em);
            }
        }
    }
}
