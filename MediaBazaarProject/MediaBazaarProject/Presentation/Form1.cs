using MediaBazaarProject.Business;
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
    public partial class Form1 : Form
    {

        LoginManager loginManager = new LoginManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text).Position == Position.ADMIN)
            {
                admin_managerForm adminManagerForm = new admin_managerForm("admin");
                adminManagerForm.Show();
            }
            else if (loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text).Position == Position.MANAGER)
            {
                admin_managerForm adminManagerForm = new admin_managerForm("manager");
                adminManagerForm.Show();
            }
            else if (loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text).Position == Position.WORKER)
            {
                createEmployeeForm employeeForm = new createEmployeeForm(1);
                employeeForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
