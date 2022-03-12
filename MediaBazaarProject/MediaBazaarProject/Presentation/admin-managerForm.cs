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
    }
}
