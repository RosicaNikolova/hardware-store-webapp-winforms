
namespace MediaBazaarProject
{
    partial class admin_managerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAdminHome = new System.Windows.Forms.TabPage();
            this.lbEmployeeList = new System.Windows.Forms.ListBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.tbFilterByName = new System.Windows.Forms.TextBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.rbPermanent = new System.Windows.Forms.RadioButton();
            this.rbTemporary = new System.Windows.Forms.RadioButton();
            this.lblTypeOfContract = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.lblListOfEmployees = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnScheduleAdministration = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabEmployeeManagement = new System.Windows.Forms.TabPage();
            this.btnSearchEmpName = new System.Windows.Forms.Button();
            this.tbSearchEmployeeName = new System.Windows.Forms.TextBox();
            this.lblListOfEmployeesManagement = new System.Windows.Forms.Label();
            this.lbEmployeeManagementList = new System.Windows.Forms.ListBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblSelectEmployee = new System.Windows.Forms.Label();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeactivateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblAdminEmpManagement = new System.Windows.Forms.Label();
            this.tabScheduleAdministration = new System.Windows.Forms.TabPage();
            this.gbAssignToShift = new System.Windows.Forms.GroupBox();
            this.btnAssignToShift = new System.Windows.Forms.Button();
            this.lbEmployeeShiftList = new System.Windows.Forms.ListBox();
            this.cbShiftSelect = new System.Windows.Forms.ComboBox();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveFromShift = new System.Windows.Forms.Button();
            this.lbEveningShift = new System.Windows.Forms.ListBox();
            this.lbMiddayShift = new System.Windows.Forms.ListBox();
            this.lbMorningShift = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMiddayShift = new System.Windows.Forms.Label();
            this.lblMorning = new System.Windows.Forms.Label();
            this.lblAdministrationSchedule = new System.Windows.Forms.Label();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.lblAdministrationStatistics = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabAdminHome.SuspendLayout();
            this.tabEmployeeManagement.SuspendLayout();
            this.tabScheduleAdministration.SuspendLayout();
            this.gbAssignToShift.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabAdminHome);
            this.tabAdmin.Controls.Add(this.tabEmployeeManagement);
            this.tabAdmin.Controls.Add(this.tabScheduleAdministration);
            this.tabAdmin.Controls.Add(this.tabStatistics);
            this.tabAdmin.Location = new System.Drawing.Point(0, 1);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(830, 334);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabAdminHome
            // 
            this.tabAdminHome.Controls.Add(this.lbEmployeeList);
            this.tabAdminHome.Controls.Add(this.btnSearchByName);
            this.tabAdminHome.Controls.Add(this.tbFilterByName);
            this.tabAdminHome.Controls.Add(this.btnResetFilters);
            this.tabAdminHome.Controls.Add(this.btnFilter);
            this.tabAdminHome.Controls.Add(this.rbPermanent);
            this.tabAdminHome.Controls.Add(this.rbTemporary);
            this.tabAdminHome.Controls.Add(this.lblTypeOfContract);
            this.tabAdminHome.Controls.Add(this.cbNationality);
            this.tabAdminHome.Controls.Add(this.lblListOfEmployees);
            this.tabAdminHome.Controls.Add(this.btnStatistics);
            this.tabAdminHome.Controls.Add(this.btnScheduleAdministration);
            this.tabAdminHome.Controls.Add(this.btnEmployeeManagement);
            this.tabAdminHome.Controls.Add(this.lblRole);
            this.tabAdminHome.Location = new System.Drawing.Point(4, 24);
            this.tabAdminHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminHome.Name = "tabAdminHome";
            this.tabAdminHome.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminHome.Size = new System.Drawing.Size(822, 306);
            this.tabAdminHome.TabIndex = 0;
            this.tabAdminHome.Text = "adminHome";
            this.tabAdminHome.UseVisualStyleBackColor = true;
            // 
            // lbEmployeeList
            // 
            this.lbEmployeeList.FormattingEnabled = true;
            this.lbEmployeeList.ItemHeight = 15;
            this.lbEmployeeList.Location = new System.Drawing.Point(313, 141);
            this.lbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployeeList.Name = "lbEmployeeList";
            this.lbEmployeeList.Size = new System.Drawing.Size(494, 154);
            this.lbEmployeeList.TabIndex = 13;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(442, 114);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(82, 22);
            this.btnSearchByName.TabIndex = 12;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            // 
            // tbFilterByName
            // 
            this.tbFilterByName.Location = new System.Drawing.Point(313, 116);
            this.tbFilterByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFilterByName.Name = "tbFilterByName";
            this.tbFilterByName.Size = new System.Drawing.Size(110, 23);
            this.tbFilterByName.TabIndex = 11;
            this.tbFilterByName.Text = "Search by name...";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(419, 89);
            this.btnResetFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(82, 22);
            this.btnResetFilters.TabIndex = 10;
            this.btnResetFilters.Text = "Reset";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(313, 89);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(82, 22);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // rbPermanent
            // 
            this.rbPermanent.AutoSize = true;
            this.rbPermanent.Location = new System.Drawing.Point(654, 67);
            this.rbPermanent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPermanent.Name = "rbPermanent";
            this.rbPermanent.Size = new System.Drawing.Size(83, 19);
            this.rbPermanent.TabIndex = 8;
            this.rbPermanent.TabStop = true;
            this.rbPermanent.Text = "Permanent";
            this.rbPermanent.UseVisualStyleBackColor = true;
            // 
            // rbTemporary
            // 
            this.rbTemporary.AutoSize = true;
            this.rbTemporary.Location = new System.Drawing.Point(561, 66);
            this.rbTemporary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTemporary.Name = "rbTemporary";
            this.rbTemporary.Size = new System.Drawing.Size(81, 19);
            this.rbTemporary.TabIndex = 7;
            this.rbTemporary.TabStop = true;
            this.rbTemporary.Text = "Temporary";
            this.rbTemporary.UseVisualStyleBackColor = true;
            // 
            // lblTypeOfContract
            // 
            this.lblTypeOfContract.AutoSize = true;
            this.lblTypeOfContract.Location = new System.Drawing.Point(451, 66);
            this.lblTypeOfContract.Name = "lblTypeOfContract";
            this.lblTypeOfContract.Size = new System.Drawing.Size(95, 15);
            this.lblTypeOfContract.TabIndex = 6;
            this.lblTypeOfContract.Text = "Type of contract:";
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(313, 64);
            this.cbNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(133, 23);
            this.cbNationality.TabIndex = 5;
            this.cbNationality.Text = "Nationality...";
            // 
            // lblListOfEmployees
            // 
            this.lblListOfEmployees.AutoSize = true;
            this.lblListOfEmployees.Location = new System.Drawing.Point(313, 46);
            this.lblListOfEmployees.Name = "lblListOfEmployees";
            this.lblListOfEmployees.Size = new System.Drawing.Size(102, 15);
            this.lblListOfEmployees.TabIndex = 4;
            this.lblListOfEmployees.Text = "List of employees:";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(15, 154);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(100, 74);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnScheduleAdministration
            // 
            this.btnScheduleAdministration.Location = new System.Drawing.Point(156, 46);
            this.btnScheduleAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScheduleAdministration.Name = "btnScheduleAdministration";
            this.btnScheduleAdministration.Size = new System.Drawing.Size(100, 74);
            this.btnScheduleAdministration.TabIndex = 2;
            this.btnScheduleAdministration.Text = "Schedule administration";
            this.btnScheduleAdministration.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(15, 46);
            this.btnEmployeeManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(96, 74);
            this.btnEmployeeManagement.TabIndex = 1;
            this.btnEmployeeManagement.Text = "Employee management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(15, 10);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(132, 15);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Administrator/Manager";
            // 
            // tabEmployeeManagement
            // 
            this.tabEmployeeManagement.Controls.Add(this.btnSearchEmpName);
            this.tabEmployeeManagement.Controls.Add(this.tbSearchEmployeeName);
            this.tabEmployeeManagement.Controls.Add(this.lblListOfEmployeesManagement);
            this.tabEmployeeManagement.Controls.Add(this.lbEmployeeManagementList);
            this.tabEmployeeManagement.Controls.Add(this.btnDeleteEmployee);
            this.tabEmployeeManagement.Controls.Add(this.lblSelectEmployee);
            this.tabEmployeeManagement.Controls.Add(this.btnEditEmployee);
            this.tabEmployeeManagement.Controls.Add(this.btnDeactivateEmployee);
            this.tabEmployeeManagement.Controls.Add(this.btnAddEmployee);
            this.tabEmployeeManagement.Controls.Add(this.lblAdminEmpManagement);
            this.tabEmployeeManagement.Location = new System.Drawing.Point(4, 24);
            this.tabEmployeeManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployeeManagement.Name = "tabEmployeeManagement";
            this.tabEmployeeManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployeeManagement.Size = new System.Drawing.Size(822, 306);
            this.tabEmployeeManagement.TabIndex = 1;
            this.tabEmployeeManagement.Text = "employeeManagement";
            this.tabEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmpName
            // 
            this.btnSearchEmpName.Location = new System.Drawing.Point(661, 42);
            this.btnSearchEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchEmpName.Name = "btnSearchEmpName";
            this.btnSearchEmpName.Size = new System.Drawing.Size(142, 22);
            this.btnSearchEmpName.TabIndex = 9;
            this.btnSearchEmpName.Text = "Search for employee";
            this.btnSearchEmpName.UseVisualStyleBackColor = true;
            // 
            // tbSearchEmployeeName
            // 
            this.tbSearchEmployeeName.Location = new System.Drawing.Point(546, 42);
            this.tbSearchEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchEmployeeName.Name = "tbSearchEmployeeName";
            this.tbSearchEmployeeName.Size = new System.Drawing.Size(110, 23);
            this.tbSearchEmployeeName.TabIndex = 8;
            this.tbSearchEmployeeName.Text = "Employee name...";
            // 
            // lblListOfEmployeesManagement
            // 
            this.lblListOfEmployeesManagement.AutoSize = true;
            this.lblListOfEmployeesManagement.Location = new System.Drawing.Point(215, 44);
            this.lblListOfEmployeesManagement.Name = "lblListOfEmployeesManagement";
            this.lblListOfEmployeesManagement.Size = new System.Drawing.Size(102, 15);
            this.lblListOfEmployeesManagement.TabIndex = 7;
            this.lblListOfEmployeesManagement.Text = "List of employees:";
            // 
            // lbEmployeeManagementList
            // 
            this.lbEmployeeManagementList.FormattingEnabled = true;
            this.lbEmployeeManagementList.ItemHeight = 15;
            this.lbEmployeeManagementList.Location = new System.Drawing.Point(215, 62);
            this.lbEmployeeManagementList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployeeManagementList.Name = "lbEmployeeManagementList";
            this.lbEmployeeManagementList.Size = new System.Drawing.Size(588, 229);
            this.lbEmployeeManagementList.TabIndex = 6;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(7, 242);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(121, 58);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Location = new System.Drawing.Point(8, 100);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(116, 15);
            this.lblSelectEmployee.TabIndex = 4;
            this.lblSelectEmployee.Text = "Select employee to...";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(7, 180);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(121, 58);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "Edit employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeactivateEmployee
            // 
            this.btnDeactivateEmployee.Location = new System.Drawing.Point(7, 118);
            this.btnDeactivateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeactivateEmployee.Name = "btnDeactivateEmployee";
            this.btnDeactivateEmployee.Size = new System.Drawing.Size(121, 58);
            this.btnDeactivateEmployee.TabIndex = 2;
            this.btnDeactivateEmployee.Text = "Deactivate employee";
            this.btnDeactivateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(8, 32);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(121, 58);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lblAdminEmpManagement
            // 
            this.lblAdminEmpManagement.AutoSize = true;
            this.lblAdminEmpManagement.Location = new System.Drawing.Point(8, 5);
            this.lblAdminEmpManagement.Name = "lblAdminEmpManagement";
            this.lblAdminEmpManagement.Size = new System.Drawing.Size(214, 15);
            this.lblAdminEmpManagement.TabIndex = 0;
            this.lblAdminEmpManagement.Text = "Administrator- Employee management";
            // 
            // tabScheduleAdministration
            // 
            this.tabScheduleAdministration.Controls.Add(this.gbAssignToShift);
            this.tabScheduleAdministration.Controls.Add(this.btnRemoveFromShift);
            this.tabScheduleAdministration.Controls.Add(this.lbEveningShift);
            this.tabScheduleAdministration.Controls.Add(this.lbMiddayShift);
            this.tabScheduleAdministration.Controls.Add(this.lbMorningShift);
            this.tabScheduleAdministration.Controls.Add(this.label3);
            this.tabScheduleAdministration.Controls.Add(this.lblMiddayShift);
            this.tabScheduleAdministration.Controls.Add(this.lblMorning);
            this.tabScheduleAdministration.Controls.Add(this.lblAdministrationSchedule);
            this.tabScheduleAdministration.Location = new System.Drawing.Point(4, 24);
            this.tabScheduleAdministration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabScheduleAdministration.Name = "tabScheduleAdministration";
            this.tabScheduleAdministration.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabScheduleAdministration.Size = new System.Drawing.Size(822, 306);
            this.tabScheduleAdministration.TabIndex = 2;
            this.tabScheduleAdministration.Text = "scheduleAdministration";
            this.tabScheduleAdministration.UseVisualStyleBackColor = true;
            // 
            // gbAssignToShift
            // 
            this.gbAssignToShift.Controls.Add(this.btnAssignToShift);
            this.gbAssignToShift.Controls.Add(this.lbEmployeeShiftList);
            this.gbAssignToShift.Controls.Add(this.cbShiftSelect);
            this.gbAssignToShift.Controls.Add(this.dtpDay);
            this.gbAssignToShift.Location = new System.Drawing.Point(33, 46);
            this.gbAssignToShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAssignToShift.Name = "gbAssignToShift";
            this.gbAssignToShift.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAssignToShift.Size = new System.Drawing.Size(291, 219);
            this.gbAssignToShift.TabIndex = 9;
            this.gbAssignToShift.TabStop = false;
            this.gbAssignToShift.Text = "Assign to shift";
            // 
            // btnAssignToShift
            // 
            this.btnAssignToShift.Location = new System.Drawing.Point(102, 184);
            this.btnAssignToShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignToShift.Name = "btnAssignToShift";
            this.btnAssignToShift.Size = new System.Drawing.Size(82, 22);
            this.btnAssignToShift.TabIndex = 13;
            this.btnAssignToShift.Text = "Assign";
            this.btnAssignToShift.UseVisualStyleBackColor = true;
            // 
            // lbEmployeeShiftList
            // 
            this.lbEmployeeShiftList.FormattingEnabled = true;
            this.lbEmployeeShiftList.ItemHeight = 15;
            this.lbEmployeeShiftList.Location = new System.Drawing.Point(34, 80);
            this.lbEmployeeShiftList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEmployeeShiftList.Name = "lbEmployeeShiftList";
            this.lbEmployeeShiftList.Size = new System.Drawing.Size(219, 94);
            this.lbEmployeeShiftList.TabIndex = 12;
            // 
            // cbShiftSelect
            // 
            this.cbShiftSelect.FormattingEnabled = true;
            this.cbShiftSelect.Items.AddRange(new object[] {
            "Morning",
            "Mid-day",
            "Evening"});
            this.cbShiftSelect.Location = new System.Drawing.Point(76, 44);
            this.cbShiftSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShiftSelect.Name = "cbShiftSelect";
            this.cbShiftSelect.Size = new System.Drawing.Size(133, 23);
            this.cbShiftSelect.TabIndex = 11;
            // 
            // dtpDay
            // 
            this.dtpDay.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.dtpDay.Location = new System.Drawing.Point(34, 20);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDay.MaxDate = new System.DateTime(2022, 3, 11, 0, 0, 0, 0);
            this.dtpDay.MinDate = new System.DateTime(2022, 3, 7, 0, 0, 0, 0);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(229, 23);
            this.dtpDay.TabIndex = 10;
            this.dtpDay.Value = new System.DateTime(2022, 3, 7, 0, 0, 0, 0);
            // 
            // btnRemoveFromShift
            // 
            this.btnRemoveFromShift.Location = new System.Drawing.Point(481, 197);
            this.btnRemoveFromShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFromShift.Name = "btnRemoveFromShift";
            this.btnRemoveFromShift.Size = new System.Drawing.Size(247, 22);
            this.btnRemoveFromShift.TabIndex = 8;
            this.btnRemoveFromShift.Text = "Remove selected employee from shift";
            this.btnRemoveFromShift.UseVisualStyleBackColor = true;
            // 
            // lbEveningShift
            // 
            this.lbEveningShift.FormattingEnabled = true;
            this.lbEveningShift.ItemHeight = 15;
            this.lbEveningShift.Location = new System.Drawing.Point(659, 106);
            this.lbEveningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEveningShift.Name = "lbEveningShift";
            this.lbEveningShift.Size = new System.Drawing.Size(70, 79);
            this.lbEveningShift.TabIndex = 7;
            // 
            // lbMiddayShift
            // 
            this.lbMiddayShift.FormattingEnabled = true;
            this.lbMiddayShift.ItemHeight = 15;
            this.lbMiddayShift.Location = new System.Drawing.Point(567, 106);
            this.lbMiddayShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMiddayShift.Name = "lbMiddayShift";
            this.lbMiddayShift.Size = new System.Drawing.Size(70, 79);
            this.lbMiddayShift.TabIndex = 6;
            // 
            // lbMorningShift
            // 
            this.lbMorningShift.FormattingEnabled = true;
            this.lbMorningShift.ItemHeight = 15;
            this.lbMorningShift.Location = new System.Drawing.Point(481, 106);
            this.lbMorningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMorningShift.Name = "lbMorningShift";
            this.lbMorningShift.Size = new System.Drawing.Size(70, 79);
            this.lbMorningShift.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evening";
            // 
            // lblMiddayShift
            // 
            this.lblMiddayShift.AutoSize = true;
            this.lblMiddayShift.Location = new System.Drawing.Point(581, 89);
            this.lblMiddayShift.Name = "lblMiddayShift";
            this.lblMiddayShift.Size = new System.Drawing.Size(52, 15);
            this.lblMiddayShift.TabIndex = 3;
            this.lblMiddayShift.Text = "Mid-day";
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Location = new System.Drawing.Point(492, 89);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(53, 15);
            this.lblMorning.TabIndex = 2;
            this.lblMorning.Text = "Morning";
            // 
            // lblAdministrationSchedule
            // 
            this.lblAdministrationSchedule.AutoSize = true;
            this.lblAdministrationSchedule.Location = new System.Drawing.Point(8, 5);
            this.lblAdministrationSchedule.Name = "lblAdministrationSchedule";
            this.lblAdministrationSchedule.Size = new System.Drawing.Size(142, 15);
            this.lblAdministrationSchedule.TabIndex = 0;
            this.lblAdministrationSchedule.Text = "Administration- Schedule";
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.lblAdministrationStatistics);
            this.tabStatistics.Location = new System.Drawing.Point(4, 24);
            this.tabStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStatistics.Size = new System.Drawing.Size(822, 306);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // lblAdministrationStatistics
            // 
            this.lblAdministrationStatistics.AutoSize = true;
            this.lblAdministrationStatistics.Location = new System.Drawing.Point(7, 2);
            this.lblAdministrationStatistics.Name = "lblAdministrationStatistics";
            this.lblAdministrationStatistics.Size = new System.Drawing.Size(139, 15);
            this.lblAdministrationStatistics.TabIndex = 0;
            this.lblAdministrationStatistics.Text = "Administration- statistics";
            // 
            // admin_managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 338);
            this.Controls.Add(this.tabAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "admin_managerForm";
            this.Text = "admin_managerForm";
            this.Load += new System.EventHandler(this.admin_managerForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdminHome.ResumeLayout(false);
            this.tabAdminHome.PerformLayout();
            this.tabEmployeeManagement.ResumeLayout(false);
            this.tabEmployeeManagement.PerformLayout();
            this.tabScheduleAdministration.ResumeLayout(false);
            this.tabScheduleAdministration.PerformLayout();
            this.gbAssignToShift.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabAdminHome;
        private System.Windows.Forms.TabPage tabEmployeeManagement;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblListOfEmployees;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnScheduleAdministration;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ListBox lbEmployeeList;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox tbFilterByName;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.RadioButton rbPermanent;
        private System.Windows.Forms.RadioButton rbTemporary;
        private System.Windows.Forms.Label lblTypeOfContract;
        private System.Windows.Forms.Button btnSearchEmpName;
        private System.Windows.Forms.TextBox tbSearchEmployeeName;
        private System.Windows.Forms.Label lblListOfEmployeesManagement;
        private System.Windows.Forms.ListBox lbEmployeeManagementList;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lblSelectEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeactivateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblAdminEmpManagement;
        private System.Windows.Forms.TabPage tabScheduleAdministration;
        private System.Windows.Forms.Label lblAdministrationSchedule;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.Label lblAdministrationStatistics;
        private System.Windows.Forms.ListBox lbEveningShift;
        private System.Windows.Forms.ListBox lbMiddayShift;
        private System.Windows.Forms.ListBox lbMorningShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMiddayShift;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.GroupBox gbAssignToShift;
        private System.Windows.Forms.Button btnAssignToShift;
        private System.Windows.Forms.ListBox lbEmployeeShiftList;
        private System.Windows.Forms.ComboBox cbShiftSelect;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Button btnRemoveFromShift;
    }
}