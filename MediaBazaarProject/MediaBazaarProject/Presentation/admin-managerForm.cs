using MediaBazaarProject.Business;
using MediaBazaarProject.Persistence;
using MediaBazaarProject.Presentation;
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
        ShiftManager shiftManager = new ShiftManager();
        string role = string.Empty;

        public admin_managerForm()
        {
            InitializeComponent();
        }

        public admin_managerForm(string role)
        {
            InitializeComponent();
            this.role = role;
            if (role == "admin")
            {
                btnScheduleAdministration.Visible = true;
                btnEmployeeManagement.Visible = true;
            }
            else if (role == "manager")
            {
                btnScheduleAdministration.Visible = false;
                btnEmployeeManagement.Visible = false;
            }
        }

        private Employee selectedEmployee()
        {
            Employee employee;

            object selectedEmployee = lbEmployeeManagementList.SelectedItem;
            employee = ((Employee)selectedEmployee);
            return employee;

        }
        private void admin_managerForm_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeManager.GetAllEmployees();
            foreach (Employee u in employees)
            {
                lbEmployeeList.Items.Add(u);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            createEmployeeForm addEmployeeForm = new createEmployeeForm(1);
            addEmployeeForm.Show();
        }

        private void btnDeactivateEmployee_Click(object sender, EventArgs e)
        {
            if(lbEmployeeManagementList.SelectedItem != null)
            {
                object selectedEmployee = lbEmployeeManagementList.SelectedItem;
                Employee employee = ((Employee)selectedEmployee);
                employeeManager.DeactivateEmployee((Employee)employee);
                MessageBox.Show("Employee deactivated");
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
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

        private void btnScheduleAdministration_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabScheduleAdministration;
            lbEmployeeShiftList.Items.Clear();
            lbMorningShift.Items.Clear();
            lbMiddayShift.Items.Clear();
            lbEveningShift.Items.Clear();

            DateTime date = new DateTime();
            date = dtpDay.Value;
            List<Employee> workers = new List<Employee>();
            workers = employeeManager.GetAllWorkers();
            workers = shiftManager.GetAvailableWorkersForDate(workers, date);

            foreach (var w in workers)
            {
                lbEmployeeShiftList.Items.Add(w);
            }

            foreach (var shift in shiftManager.GetShiftsForDate(date))
            {
                if (shift.ShiftType == Shifts.MORNING)
                {
                    lbMorningShift.Items.Add(shift.Employee);
                }
                else if (shift.ShiftType == Shifts.MIDDAY)
                {
                    lbMiddayShift.Items.Add(shift.Employee);
                }
                else if (shift.ShiftType == Shifts.EVENING)
                {
                    lbEveningShift.Items.Add(shift.Employee);
                }
            }


        }

        private void btnAssignToShift_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = dtpDay.Value;

            if (cbShiftSelect.Text != "Select shift" && cbShiftSelect.Text != "" && lbEmployeeShiftList.SelectedItem != null)
            {
                object worker = lbEmployeeShiftList.SelectedItem;
                int shift = cbShiftSelect.SelectedIndex + 1;
                if (shiftManager.AssignShift((Employee)worker, date, (Shifts)shift))
                {
                    MessageBox.Show("Employee successfully assigned to a shift");

                    if (shift == 1)
                    {
                        lbMorningShift.Items.Add(worker);
                    }
                    else if (shift == 2)
                    {
                        lbMiddayShift.Items.Add(worker);
                    }
                    else if (shift == 3)
                    {
                        lbEveningShift.Items.Add(worker);
                    }
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            else
            {
                MessageBox.Show("Please, select an employee and a shift");
            }

            EmployeeManager employeeManager = new EmployeeManager();

            List<Employee> workers = new List<Employee>();

            workers = employeeManager.GetAllWorkers();
            workers = shiftManager.GetAvailableWorkersForDate(workers, date);

            lbEmployeeShiftList.Items.Clear();


            foreach (var w in workers)
            {
                lbEmployeeShiftList.Items.Add(w);
            }



        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            lbEmployeeShiftList.Items.Clear();
            lbMorningShift.Items.Clear();
            lbMiddayShift.Items.Clear();
            lbEveningShift.Items.Clear();

            EmployeeManager employeeManager = new EmployeeManager();
            List<Employee> workers = new List<Employee>();
            DateTime date = new DateTime();
            date = dtpDay.Value;
            workers = employeeManager.GetAllWorkers();
            workers = shiftManager.GetAvailableWorkersForDate(workers, date);

            foreach (var w in workers)
            {
                lbEmployeeShiftList.Items.Add(w);
            }

            foreach (Shift shift in shiftManager.GetShiftsForDate(date))
            {
                if (shift.ShiftType == Shifts.MORNING)
                {
                    lbMorningShift.Items.Add(shift.Employee.FirstName);
                }
                else if (shift.ShiftType == Shifts.MIDDAY)
                {
                    lbMiddayShift.Items.Add(shift.Employee.FirstName);
                }
                else if (shift.ShiftType == Shifts.EVENING)
                {
                    lbEveningShift.Items.Add(shift.Employee.FirstName);
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = selectedEmployee();
            if (employee != null)
            {
                Employee employeeFilled = employeeManager.GetEmployeeByID(employee);
                createEmployeeForm createEmployeeForm = new createEmployeeForm(employeeFilled, 2);
                createEmployeeForm.Show();
            }
            else
            {
                MessageBox.Show("Employee not selected");
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();

            List<Employee> employees = employeeManager.GetAllEmployees();
            string fullName;

            foreach (Employee u in employees)
            {
                fullName = "";
                fullName = $"{u.FirstName} {u.LastName}";

                if (fullName.Contains(tbFilterByName.Text))
                {
                    lbEmployeeList.Items.Add(fullName);
                }
            }
        }

        private void btnSearchEmpName_Click(object sender, EventArgs e)
        {
            lbEmployeeManagementList.Items.Clear();

            List<Employee> employees = employeeManager.GetAllEmployees();
            string fullName;

            foreach (Employee u in employees)
            {
                fullName = "";
                fullName = $"{u.FirstName} {u.LastName}";

                if (fullName.Contains(tbSearchEmployeeName.Text))
                {
                    lbEmployeeManagementList.Items.Add(fullName);
                }
            }
        }

        private void cbDisplayDeactivated_CheckedChanged(object sender, EventArgs e)
        {
            lbEmployeeManagementList.Items.Clear();
            if (cbDisplayDeactivated.Checked == true)
            {
                foreach (Employee employee in employeeManager.GetDeactivatedEmployees())
                {
                    lbEmployeeManagementList.Items.Add(employee);
                }
            }
            else if (cbDisplayDeactivated.Checked == false)
            {
                foreach (Employee employee in employeeManager.GetAllEmployees())
                {
                    lbEmployeeManagementList.Items.Add(employee);
                }
            }
        }

        private void lbEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (this.role == "manager")
            {
                Employee employee;
                object selectedEmployee = lbEmployeeList.SelectedItem;
                employee = ((Employee)selectedEmployee);
                Employee eInfo = employeeManager.GetEmployeeByID(employee);
                employeeCard employeeCard = new employeeCard(eInfo);
                employeeCard.Show();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if(lbEmployeeManagementList.SelectedItem != null )
            {
                object selectedEmployee = lbEmployeeManagementList.SelectedItem;
                Employee employee = ((Employee)selectedEmployee);
                employeeManager.DeleteEmployee(employee);
                MessageBox.Show("Employee Deleted");
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }
    }
}
