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
            string gender = "Female";
            bool permanentContract = false;
            bool isActive = false;
            bool covidVaccinated = false;
            if (rBtnYes.Checked) {
                covidVaccinated = true;
            }
            if (rBtnActive.Checked) {
                isActive = true;
            }
            if (rBtnYesPermanent.Checked) {
                permanentContract = true;
            }
            if (rBtnMale.Checked) {
                gender = "Male";
            }
            if (txbBsn.Text != string.Empty && txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && txbEmail.Text != string.Empty && txbPassword.Text != string.Empty && cbTypeOfContract.Text != string.Empty && txbAddress.Text != string.Empty && txbPhone.Text != string.Empty && txbHourlyWage.Text != string.Empty && cbPosition.Text != string.Empty)
            { 
                employeeManager.CreateEmployee(txbFirstName.Text, txbLastName.Text, Convert.ToInt32(tbAge.Text),txbEmail.Text,txbPassword.Text,txbAddress.Text, cbNationality.Text, Convert.ToDouble(txbHourlyWage.Text), Convert.ToDouble(txbPhone.Text), gender, Convert.ToInt32(txbBsn.Text), permanentContract, loginManager.SetPosition(cbPosition.SelectedIndex), isActive, covidVaccinated); 
            }
        }
    }
}
