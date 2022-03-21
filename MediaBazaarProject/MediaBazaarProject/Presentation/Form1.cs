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
            User user = new User();
            try
            {
                user = loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text);

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
                    else if (user.Position == Position.WORKER)

                    {
                        WorkerForm employeeForm = new WorkerForm(user);
                        employeeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }

            }
            catch
            {
                MessageBox.Show("Invalid credentials");
            }

        }

        
    }
}
