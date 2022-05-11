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
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using MediaBazaarLibrary;
using MediaBazaarLibrary.Business;
using MediaBazaarProject.Presentation;

namespace MediaBazaarProject
{
    public partial class admin_managerForm : Form
    {
        EmployeeManager employeeManager = new EmployeeManager();
        ShiftManager shiftManager = new ShiftManager();
        ProductManager productManager = new ProductManager();
        LeaveRequestManager leaveRequestManager = new LeaveRequestManager();
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

            DateTime maxDate;
            maxDate = DateTime.Today.AddDays(7);
            dtpDay.MaxDate = maxDate;
            dtpDay.MinDate = DateTime.Today;
        }

        public Action<object, object> FormClosing()
        {
            throw new NotImplementedException();
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
            if (lbEmployeeManagementList.SelectedItem != null)
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
                try
                {
                    object worker = lbEmployeeShiftList.SelectedItem;
                    int shiftType = cbShiftSelect.SelectedIndex + 1;
                    Shift shift = shiftManager.AssignShift((Employee)worker, date, (Shifts)shiftType);
                    if (shift != null)
                    {
                        MessageBox.Show("Employee successfully assigned to a shift");

                        if (shiftType == 1)
                        {
                            lbMorningShift.Items.Add(worker);
                        }
                        else if (shiftType == 2)
                        {
                            lbMiddayShift.Items.Add(worker);
                        }
                        else if (shiftType == 3)
                        {
                            lbEveningShift.Items.Add(worker);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operation is unsuccessful");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, select employee or shift type");
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
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            DisplayShiftsForDay();

        }

        private void DisplayShiftsForDay()
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
            tEmployeeLbRefresh.Enabled = false;
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

        private void lbEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (this.role == "manager")
            {
                Employee employee;
                object selectedEmployee = lbEmployeeList.SelectedItem;
                employee = ((Employee)selectedEmployee);
                Employee eInfo = employeeManager.GetEmployeeByID(employee);
                employeeCard empCard = new employeeCard(eInfo);
                empCard.Show();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbEmployeeManagementList.SelectedItem != null)
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

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();
            if (cbNationality.Text != "Show all")
            {
                foreach (Employee employee in employeeManager.GetNationalityFilteredEmployees(cbNationality.Text))
                {
                    lbEmployeeList.Items.Add($"{employee.FirstName} {employee.LastName}");
                }
            }
            else
            {
                foreach (Employee employee in employeeManager.GetAllEmployees())
                {
                    lbEmployeeList.Items.Add(employee);
                }
            }
        }

        private void rbTemporary_CheckedChanged(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();
            if (rbTemporary.Checked == true)
            {
                foreach (Employee employee in employeeManager.GetTemporaryContractEmployees())
                {
                    lbEmployeeList.Items.Add(employee);
                }
            }
        }

        private void rbPermanent_CheckedChanged(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();
            if (rbPermanent.Checked == true)
            {
                foreach (Employee employee in employeeManager.GetPermanentContractEmployees())
                {
                    lbEmployeeList.Items.Add(employee);
                }
            }
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cbNationality.SelectedIndex = 0;
            lbEmployeeList.Items.Clear();
            rbTemporary.Checked = false;
            rbPermanent.Checked = false;

            foreach (Employee employee in employeeManager.GetAllEmployees())
            {
                lbEmployeeList.Items.Add(employee);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbEmployeeManagementList.Items.Clear();

            foreach (Employee employee in employeeManager.GetAllEmployees())
            {
                lbEmployeeManagementList.Items.Add(employee);
            }
        }

        private void btnResetEmpManList_Click(object sender, EventArgs e)
        {
            tEmployeeLbRefresh.Enabled = true;
            tbSearchEmployeeName.Text = "";
            rbDisplayDeactivated.Checked = false;
            lbEmployeeManagementList.Items.Clear();

            foreach (Employee employee in employeeManager.GetAllEmployees())
            {
                lbEmployeeManagementList.Items.Add(employee);
            }
        }

        private void rbDisplayDeactivated_CheckedChanged(object sender, EventArgs e)
        {
            lbEmployeeManagementList.Items.Clear();

            if (rbDisplayDeactivated.Checked == true)
            {
                tEmployeeLbRefresh.Enabled = false;
                foreach (Employee employee in employeeManager.GetDeactivatedEmployees())
                {
                    lbEmployeeManagementList.Items.Add(employee);
                }
            }
        }

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabAdmin.SelectedTab == tabStatistics)
            {
                NationalityPieViewModel nationalityPieViewModel = new NationalityPieViewModel();
                this.plotView1.Model = nationalityPieViewModel.Model1;

                ContractPieViewModel contractPieViewModel = new ContractPieViewModel();
                this.plotView2.Model = contractPieViewModel.Model2;

                RequestedItemsPieViewModel requestedItemsPieViewModel = new RequestedItemsPieViewModel();
                this.plotView3.Model = requestedItemsPieViewModel.Model3;

                RequestedCategoriesPieViewModel requestedCategoriesPieViewModel = new RequestedCategoriesPieViewModel();
                this.plotView4.Model = requestedCategoriesPieViewModel.Model4;

                lblAverageSalary.Text = $"Average salary: ${employeeManager.GetAverageSalary():f2}";
                lblNumberOfEmployees.Text = $"Number of employees: {employeeManager.GetAllEmployees().Count}";
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabStatistics;
        }

        private void btnRemoveFromShift_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = dtpDay.Value;
            object selectedEmployee;
            string shift = "";
            Employee employee = new Employee();

            if (lbMorningShift.SelectedIndex != -1)
            {
                selectedEmployee = lbMorningShift.SelectedItem;
                employee = ((Employee)selectedEmployee);
                shift = "MORNING";
            }
            else if (lbMiddayShift.SelectedIndex != -1)
            {
                selectedEmployee = lbMiddayShift.SelectedItem;
                employee = ((Employee)selectedEmployee);
                shift = "MIDDAY";
            }
            else if (lbEveningShift.SelectedIndex != -1)
            {
                selectedEmployee = lbEveningShift.SelectedItem;
                employee = ((Employee)selectedEmployee);
                shift = "EVENING";
            }

            if (shiftManager.RemoveShift(date, shift, employee))
            {
                MessageBox.Show("Employee successfully removed");
            }
            else
            {
                MessageBox.Show("Operation was not successful. Try again");
            }

            DisplayShiftsForDay();
        }

        private void btnWeeklyScheduleDisplay_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabWeeklySchedule;
            DateTime date = DateTime.Today;
            DateTime fisrtDayOfWeek;
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = date.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            fisrtDayOfWeek = date.AddDays(-diff).Date;
            DateTime lastDayOfWeek = new DateTime(fisrtDayOfWeek.Year, fisrtDayOfWeek.Month, fisrtDayOfWeek.Day + 6);

            lblWeekDays.Text = $"{fisrtDayOfWeek.Day}/{fisrtDayOfWeek.Month}/{fisrtDayOfWeek.Year} - {lastDayOfWeek.Day}/{lastDayOfWeek.Month}/{lastDayOfWeek.Year}";

            List<Shift> schedule = new List<Shift>();
            schedule = shiftManager.GetShiftsForAllWorkersForWeek(date);

            ClearListBoxesSchedule();

            foreach (Shift shift in schedule)
            {
                if (shift.Date.Day == fisrtDayOfWeek.Day)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbMondayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbMondayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbMondayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 1)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbTuesdayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbTuesdayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbTuesdayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 2)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbWednesdayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbWednesdayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbWednesdayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 3)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbThursdayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbThursdayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbThursdayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 4)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbFridayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbFridayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbFridayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 5)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbSaturdayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbSaturdayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbSaturdayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
                else if (shift.Date.Day == fisrtDayOfWeek.Day + 6)
                {
                    switch (shift.ShiftType)
                    {
                        case Shifts.MORNING:
                            lbSundayMorning.Items.Add(shift.Employee);
                            break;
                        case Shifts.MIDDAY:
                            lbSundayMidday.Items.Add(shift.Employee);
                            break;
                        case Shifts.EVENING:
                            lbSundayEvening.Items.Add(shift.Employee);
                            break;
                    }
                }
            }
        }
        private void ClearListBoxesSchedule()
        {
            lbMondayMorning.Items.Clear();
            lbMondayMidday.Items.Clear();
            lbMondayEvening.Items.Clear();
            lbTuesdayMorning.Items.Clear();
            lbTuesdayMidday.Items.Clear();
            lbTuesdayEvening.Items.Clear();
            lbWednesdayMorning.Items.Clear();
            lbWednesdayMidday.Items.Clear();
            lbWednesdayEvening.Items.Clear();
            lbThursdayMorning.Items.Clear();
            lbThursdayMidday.Items.Clear();
            lbThursdayEvening.Items.Clear();
            lbFridayMorning.Items.Clear();
            lbFridayMidday.Items.Clear();
            lbFridayEvening.Items.Clear();
            lbSaturdayMorning.Items.Clear();
            lbSaturdayMidday.Items.Clear();
            lbSaturdayEvening.Items.Clear();
            lbSundayMorning.Items.Clear();
            lbSundayMidday.Items.Clear();
            lbSundayEvening.Items.Clear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int option = 1;
            AddEditProduct addEditProduct = new AddEditProduct(option);
            addEditProduct.Show();
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            object selectedProduct = lbAllProducts.SelectedItem;
            if (selectedProduct != null)
            {
                Product product = ((Product)selectedProduct);
                int option = 2;
                AddEditProduct addEditProduct = new AddEditProduct(option, product);
                addEditProduct.Show();
            }
            else
            {
                MessageBox.Show("You have to select an item first!!");
            }
        }
        private void btnStockManagment_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabProductManagement;
            lbAllProducts.Items.Clear();
            foreach (Product p in productManager.GetAllProductsList())
            {
                lbAllProducts.Items.Add(p);
            }

        }
        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            reloadProductList();
        }

        private void btnHomeStMngmnt_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAllProducts.SelectedItem != null)
                {
                    DialogResult dialogYesNo = MessageBox.Show("You are about to remove the product, are you sure?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogYesNo == DialogResult.Yes)
                    {
                        productManager.Remove((Product)lbAllProducts.SelectedItem);
                        MessageBox.Show("Product removed!");
                        reloadProductList();
                    }
                }
                else
                {
                    throw new Exception("First, select product!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void reloadProductList()
        {
            lbAllProducts.Items.Clear();
            foreach (Product p in productManager.GetAllProductsList())
            {
                lbAllProducts.Items.Add(p);
            }
        }

        private void btnProductCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
        }

        private void btnLeaveRequests_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabLeaveRequests;
            dgAllLeaveRequests.DataSource = leaveRequestManager.GetLeaveRequestsTable();
        }

        private void dgAllLeaveRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAllLeaveRequests.Columns[e.ColumnIndex].Name == "Approve")
            {
                DataGridViewRow row = dgAllLeaveRequests.Rows[e.RowIndex];
                int requestID = Convert.ToInt32(row.Cells[3].Value);
                leaveRequestManager.approveRequest(requestID);
                dgAllLeaveRequests.DataSource = leaveRequestManager.GetLeaveRequestsTable();
            }
            else if (dgAllLeaveRequests.Columns[e.ColumnIndex].Name == "Disapprove")
            {
                DataGridViewRow row = dgAllLeaveRequests.Rows[e.RowIndex];
                int requestID = Convert.ToInt32(row.Cells[3].Value);
                leaveRequestManager.disapproveRequest(requestID);
                dgAllLeaveRequests.DataSource = leaveRequestManager.GetLeaveRequestsTable();
            }
        }

        private void btnFilterProducts_Click(object sender, EventArgs e)
        {
            if (tbFilterProductsInput.Text == "")
            {
                MessageBox.Show("Please provide input to filter by");
            }
            else
            {
                if (rbFilterByName.Checked)
                {
                    lbAllProducts.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductName.Contains(tbFilterProductsInput.Text))
                        {
                            lbAllProducts.Items.Add(product);
                        }
                    }
                }
                else if (rbFilterByCategory.Checked)
                {
                    lbAllProducts.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductCategory.Contains(tbFilterProductsInput.Text))
                        {
                            lbAllProducts.Items.Add(product);
                        }
                    }
                }
                else if (rbFilterByBrand.Checked)
                {
                    lbAllProducts.Items.Clear();
                    foreach (Product product in productManager.GetAllProductsList())
                    {
                        if (product.ProductManufacturer.Contains(tbFilterProductsInput.Text))
                        {
                            lbAllProducts.Items.Add(product);
                        }
                    }
                }
            }
        }

        private void btnResetProductFilters_Click(object sender, EventArgs e)
        {
            rbFilterByName.Checked = false;
            rbFilterByCategory.Checked = false;
            rbFilterByBrand.Checked = false;
            tbFilterProductsInput.Text = "";
            lbAllProducts.Items.Clear();

            foreach (Product product in productManager.GetAllProductsList())
            {
                lbAllProducts.Items.Add(product);
            }
        }

        private void btnHomeLeaveRequest_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabAdminHome;
        }
    }
}
