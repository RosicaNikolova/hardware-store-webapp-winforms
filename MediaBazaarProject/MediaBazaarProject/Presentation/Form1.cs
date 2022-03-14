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
            if (loginManager.Login(tbEmailLogin.Text, tbPasswordLogin.Text) != null)

            {
                MessageBox.Show("Login successful");
                WorkerForm workerForm = new WorkerForm();
                workerForm.Show();

            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            
           
            
        }
    }
}
