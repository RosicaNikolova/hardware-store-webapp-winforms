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

namespace MediaBazaarProject.Presentation
{
    public partial class employeeCard : Form
    {
        public employeeCard(Employee employee)
        {
            InitializeComponent();
            lblId.Text = $"Id: {employee.Id}";
            lblFirstName.Text = $"First name: {employee.FirstName}";
            lblLastName.Text = $"Last name: {employee.LastName}";
            lblAddress.Text = $"Address: {employee.Address}";
            lblEmail.Text = $"Email: {employee.Email}";
            lblContract.Text = $"Permanent contract: {employee.PermanentContract}";
            lblPhoneNumber.Text = $"Phone number: {employee.PhoneNumber}";
            lblHourlyWage.Text = $"Hourly wage: {employee.Salary}";
            lblPosition.Text = $"Position: {employee.Position}";
            lblCovidVaccinated.Text = $"Covid vaccinated: {employee.CovidVaccinated}";
            lblAge.Text = $"Age: {employee.Age}";
            lblNationality.Text = $"Nationality: {employee.Nationality}";
            lblGender.Text = $"Gender: {employee.Gender}";
            lblIsAccountActive.Text = $"Active: {employee.IsAccountActive}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
