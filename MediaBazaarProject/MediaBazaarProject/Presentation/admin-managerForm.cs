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
        ShiftManager shiftManager = new ShiftManager();

        public admin_managerForm()
        {
            InitializeComponent();
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
                lbEmployeeList.Items.Add(u.FirstName + " " + u.LastName);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            createEmployeeForm addEmployeeForm = new createEmployeeForm(1);
            addEmployeeForm.Show();
        }

        private void btnDeactivateEmployee_Click(object sender, EventArgs e)
        {
            object selectedEmployee = lbEmployeeManagementList.SelectedItem;
            Employee employee = ((Employee)selectedEmployee);
            employeeManager.DeactivateEmployee((Employee)employee);
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
            EmployeeManager employeeManager = new EmployeeManager();
            List<Employee> workers = new List<Employee>();

            DateTime date = new DateTime();
            date = dtpDay.Value;
            workers = employeeManager.GetAllWorkers();
            //workers = shiftManager.GetAvailableWorkersForDate(workers, date);

            foreach (var w in workers)
            {
                lbEmployeeShiftList.Items.Add(w);
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
    }
}
