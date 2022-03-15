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
    public partial class createEmployeeForm : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        LoginManager loginManager = new LoginManager();
        public createEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string gender = "Male";
            bool permanentContract = true;
            bool isActive = true;
            bool covidVaccinated = true;
            if (!rBtnYes.Checked)
            {
                covidVaccinated = false;
            }
            if (!rBtnActive.Checked)
            {
                isActive = false;
            }
            if (!rBtnYesPermanent.Checked)
            {
                permanentContract = false;
            }
            if (!rBtnMale.Checked)
            {
                gender = "Female";
            }
            if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && tbAge.Text != string.Empty && txbEmail.Text != string.Empty && txbPassword.Text != string.Empty && txbAddress.Text != string.Empty && cbNationality.Text != string.Empty && txbHourlyWage.Text != string.Empty && txbPhone.Text != string.Empty && txbBsn.Text != string.Empty && cbPosition.Text != string.Empty)
            {

                employeeManager.CreateEmployee(txbFirstName.Text, txbLastName.Text, Convert.ToInt32(tbAge.Text), txbEmail.Text, txbPassword.Text, txbAddress.Text, cbNationality.Text, Convert.ToDouble(txbHourlyWage.Text), Convert.ToDouble(txbPhone.Text), gender, Convert.ToInt32(txbBsn.Text), permanentContract, cbPosition.SelectedIndex, isActive, covidVaccinated);

            }
        }
    }
}
