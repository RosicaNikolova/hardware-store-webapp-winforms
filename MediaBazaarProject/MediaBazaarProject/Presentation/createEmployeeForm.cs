using MediaBazaarLibrary;
using MediaBazaarLibrary.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarProject
{
    public partial class createEmployeeForm : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        LoginManager loginManager = new LoginManager();
        Employee employeeSelected = new Employee();
        EnumManager enumManager = new EnumManager();
        private string gender = "Male";
        private bool permanentContract = true;
        private bool isActive = true;
        private bool covidVaccinated = true;
        public createEmployeeForm(int buttonId)
        {
            InitializeComponent();
            btnUpdateEmployee.Enabled = false;
        }
        public createEmployeeForm(Employee employee, int buttonId)
        {
            InitializeComponent();
            employeeSelected = employee;
            idButton(employee, buttonId);
        }
        private void rBTNChecker()
        {
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
        }

        private void SendMail()
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName ="479958@student.fontys.nl",
                    Password = "Vligflatker4"
                }
            };

            MailAddress FromEmail = new MailAddress("479958@student.fontys.nl");
            MailAddress ToEmail = new MailAddress(txbEmail.Text);
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Welcome to MediaBazaar",
                Body = $"Welcome {txbFirstName.Text} to MediaBazaar" +
                        $"Your first time login password is {txbPassword.Text}"
            };
            Message.To.Add(ToEmail);
            
            try
            {
                Client.SendMailAsync(Message);
                MessageBox.Show("Employee successfully created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong \n" + ex.Message, "Error");
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                rBTNChecker();
                if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && tbAge.Text != string.Empty && txbEmail.Text != string.Empty && txbPassword.Text != string.Empty && txbAddress.Text != string.Empty && cbNationality.Text != string.Empty && txbHourlyWage.Text != string.Empty && txbPhone.Text != string.Empty && txbBsn.Text != string.Empty && cbPosition.Text != string.Empty)
                {
                    if (emailCheck(txbEmail.Text) == true)
                    {
                        employeeManager.CreateEmployee(txbFirstName.Text, txbLastName.Text, Convert.ToInt32(tbAge.Text), txbEmail.Text, txbPassword.Text, txbAddress.Text, cbNationality.Text, Convert.ToDouble(txbHourlyWage.Text), Convert.ToDouble(txbPhone.Text), gender, Convert.ToInt32(txbBsn.Text), permanentContract, cbPosition.SelectedIndex, isActive, covidVaccinated);
                        SendMail();

                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Email is  not in the right format");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            rBTNChecker();

            try
            {
                if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && tbAge.Text != string.Empty && txbEmail.Text != string.Empty && txbPassword.Text != string.Empty && txbAddress.Text != string.Empty && cbNationality.Text != string.Empty && txbHourlyWage.Text != string.Empty && txbPhone.Text != string.Empty && txbBsn.Text != string.Empty && cbPosition.Text != string.Empty)
                {
                    employeeSelected.FirstName = txbFirstName.Text;
                    employeeSelected.LastName = txbLastName.Text;
                    employeeSelected.Age = Convert.ToInt32(tbAge.Text);
                    if (emailCheck(txbEmail.Text) == true)
                    {
                        employeeSelected.Email = txbEmail.Text;
                    }
                    else
                    {
                        throw new Exception("Email is not in the right format");
                    }
                    employeeSelected.Password = txbPassword.Text;
                    employeeSelected.Address = txbAddress.Text;
                    employeeSelected.Nationality = cbNationality.Text;
                    employeeSelected.Salary = Convert.ToDouble(txbHourlyWage.Text);
                    employeeSelected.PhoneNumber = (long)Convert.ToDouble(txbPhone.Text);
                    employeeSelected.Gender = gender;
                    employeeSelected.Bsn1 = Convert.ToInt32(txbBsn.Text);
                    employeeSelected.PermanentContract = permanentContract;
                    employeeSelected.Position = enumManager.SetPosition(cbPosition.SelectedIndex);
                    employeeSelected.IsAccountActive = isActive;
                    employeeSelected.CovidVaccinated = covidVaccinated;
                    employeeManager.UpdateEmployee(employeeSelected);
                    MessageBox.Show("Employee updated succesfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fill in all boxes!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }
        private bool emailCheck(string email)
        {
            if (EmailValidation.IsValidEmail(txbEmail.Text) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //checks what for the form is and if for update, fills up the textboxes
        private void idButton(Employee employee, int buttonId)
        {
            if (buttonId == 1)
            {
                btnUpdateEmployee.Enabled = false;
            }
            if (buttonId == 2)
            {
                btnAddEmployee.Enabled = false;
                txbBsn.Text = employee.Bsn1.ToString();
                txbFirstName.Text = employee.FirstName;
                txbLastName.Text = employee.LastName;
                txbEmail.Text = employee.Email;
                txbPassword.Text = employee.Password;
                bool contract = employee.PermanentContract;
                if (contract == true)
                {
                    rBtnYesPermanent.Checked = true;
                }
                else
                {
                    rBtnNotPermanent.Checked = true;
                }
                txbAddress.Text = employee.Address;
                txbPhone.Text = employee.PhoneNumber.ToString();
                txbHourlyWage.Text = employee.Salary.ToString();
                cbPosition.Text = employee.Position.ToString();
                bool covidVaccinated = employee.CovidVaccinated;
                if (covidVaccinated == true)
                {
                    rBtnYes.Checked = true;
                }
                else
                {
                    rBtnNo.Checked = true;
                }
                tbAge.Text = employee.Age.ToString();
                cbNationality.Text = employee.Nationality;
                string gender = employee.Gender;
                if (gender == "Male")
                {
                    rBtnMale.Checked = true;
                }
                else { rBtnFemale.Checked = true; }
                bool isActive = employee.IsAccountActive;
                if (isActive == true)
                {
                    rBtnActive.Checked = true;
                }
                else
                {
                    rBtnNotActive.Checked = true;
                }
            }
        }
    }
}
