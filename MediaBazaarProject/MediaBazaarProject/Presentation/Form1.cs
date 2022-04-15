//using MediaBazaarProject.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarLibrary.Business;
using MediaBazaarLibrary;
using Position = MediaBazaarLibrary.Position;

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
            User user = new User();
            try
            {
                if (EmailValidation.IsValidEmail(tbEmailLogin.Text) == true)
                {
                    user = loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text);
                }
                else {
                    user = null;
                    throw new Exception("Email is in the wrong format!");
                }
                if (user != null)
                {
                    if (user.Position == Position.ADMIN)
                    {
                        admin_managerForm adminManagerForm = new admin_managerForm("admin");
                        adminManagerForm.Show();
                    }
                    else if (user.Position == Position.MANAGER)
                    {
                        admin_managerForm adminManagerForm = new admin_managerForm("manager");
                        adminManagerForm.Show();
                    }
                    else if (user.Position == MediaBazaarLibrary.Position.SALES)
                    {
                        WorkerForm employeeForm = new WorkerForm(user, "sales");
                        employeeForm.Show();
                    }
                    else if(user.Position == Position.WAREHOUSE)
                    {
                        WorkerForm employeeForm = new WorkerForm(user, "warehouse");
                        employeeForm.Show();
                    }
                    else
                    {
                        //MessageBox.Show("Invalid credentials");
                        //throw new Exception("Invalid credentials!");
                    }
                }
                else {
                    throw new Exception("Invalid credentials!");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                
            }

        }
    }
}
