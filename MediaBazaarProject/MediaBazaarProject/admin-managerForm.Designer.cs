
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAdministrationSchedule = new System.Windows.Forms.Label();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.lblAdministrationStatistics = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabAdminHome.SuspendLayout();
            this.tabEmployeeManagement.SuspendLayout();
            this.tabScheduleAdministration.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabAdminHome);
            this.tabAdmin.Controls.Add(this.tabEmployeeManagement);
            this.tabAdmin.Controls.Add(this.tabScheduleAdministration);
            this.tabAdmin.Controls.Add(this.tabStatistics);
            this.tabAdmin.Location = new System.Drawing.Point(0, 1);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(949, 445);
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
            this.tabAdminHome.Location = new System.Drawing.Point(4, 29);
            this.tabAdminHome.Name = "tabAdminHome";
            this.tabAdminHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminHome.Size = new System.Drawing.Size(941, 412);
            this.tabAdminHome.TabIndex = 0;
            this.tabAdminHome.Text = "adminHome";
            this.tabAdminHome.UseVisualStyleBackColor = true;
            // 
            // lbEmployeeList
            // 
            this.lbEmployeeList.FormattingEnabled = true;
            this.lbEmployeeList.ItemHeight = 20;
            this.lbEmployeeList.Location = new System.Drawing.Point(358, 188);
            this.lbEmployeeList.Name = "lbEmployeeList";
            this.lbEmployeeList.Size = new System.Drawing.Size(564, 204);
            this.lbEmployeeList.TabIndex = 13;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(505, 152);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(94, 29);
            this.btnSearchByName.TabIndex = 12;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            // 
            // tbFilterByName
            // 
            this.tbFilterByName.Location = new System.Drawing.Point(358, 154);
            this.tbFilterByName.Name = "tbFilterByName";
            this.tbFilterByName.Size = new System.Drawing.Size(125, 27);
            this.tbFilterByName.TabIndex = 11;
            this.tbFilterByName.Text = "Search by name...";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(479, 119);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(94, 29);
            this.btnResetFilters.TabIndex = 10;
            this.btnResetFilters.Text = "Reset";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(358, 119);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(94, 29);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // rbPermanent
            // 
            this.rbPermanent.AutoSize = true;
            this.rbPermanent.Location = new System.Drawing.Point(748, 89);
            this.rbPermanent.Name = "rbPermanent";
            this.rbPermanent.Size = new System.Drawing.Size(100, 24);
            this.rbPermanent.TabIndex = 8;
            this.rbPermanent.TabStop = true;
            this.rbPermanent.Text = "Permanent";
            this.rbPermanent.UseVisualStyleBackColor = true;
            // 
            // rbTemporary
            // 
            this.rbTemporary.AutoSize = true;
            this.rbTemporary.Location = new System.Drawing.Point(641, 88);
            this.rbTemporary.Name = "rbTemporary";
            this.rbTemporary.Size = new System.Drawing.Size(101, 24);
            this.rbTemporary.TabIndex = 7;
            this.rbTemporary.TabStop = true;
            this.rbTemporary.Text = "Temporary";
            this.rbTemporary.UseVisualStyleBackColor = true;
            // 
            // lblTypeOfContract
            // 
            this.lblTypeOfContract.AutoSize = true;
            this.lblTypeOfContract.Location = new System.Drawing.Point(515, 88);
            this.lblTypeOfContract.Name = "lblTypeOfContract";
            this.lblTypeOfContract.Size = new System.Drawing.Size(119, 20);
            this.lblTypeOfContract.TabIndex = 6;
            this.lblTypeOfContract.Text = "Type of contract:";
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(358, 85);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(151, 28);
            this.cbNationality.TabIndex = 5;
            this.cbNationality.Text = "Nationality...";
            // 
            // lblListOfEmployees
            // 
            this.lblListOfEmployees.AutoSize = true;
            this.lblListOfEmployees.Location = new System.Drawing.Point(358, 62);
            this.lblListOfEmployees.Name = "lblListOfEmployees";
            this.lblListOfEmployees.Size = new System.Drawing.Size(128, 20);
            this.lblListOfEmployees.TabIndex = 4;
            this.lblListOfEmployees.Text = "List of employees:";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(17, 205);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(114, 99);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnScheduleAdministration
            // 
            this.btnScheduleAdministration.Location = new System.Drawing.Point(178, 62);
            this.btnScheduleAdministration.Name = "btnScheduleAdministration";
            this.btnScheduleAdministration.Size = new System.Drawing.Size(114, 99);
            this.btnScheduleAdministration.TabIndex = 2;
            this.btnScheduleAdministration.Text = "Schedule administration";
            this.btnScheduleAdministration.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(17, 62);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(110, 99);
            this.btnEmployeeManagement.TabIndex = 1;
            this.btnEmployeeManagement.Text = "Employee management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(17, 13);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(165, 20);
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
            this.tabEmployeeManagement.Location = new System.Drawing.Point(4, 29);
            this.tabEmployeeManagement.Name = "tabEmployeeManagement";
            this.tabEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeManagement.Size = new System.Drawing.Size(941, 412);
            this.tabEmployeeManagement.TabIndex = 1;
            this.tabEmployeeManagement.Text = "employeeManagement";
            this.tabEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmpName
            // 
            this.btnSearchEmpName.Location = new System.Drawing.Point(755, 56);
            this.btnSearchEmpName.Name = "btnSearchEmpName";
            this.btnSearchEmpName.Size = new System.Drawing.Size(162, 29);
            this.btnSearchEmpName.TabIndex = 9;
            this.btnSearchEmpName.Text = "Search for employee";
            this.btnSearchEmpName.UseVisualStyleBackColor = true;
            // 
            // tbSearchEmployeeName
            // 
            this.tbSearchEmployeeName.Location = new System.Drawing.Point(624, 56);
            this.tbSearchEmployeeName.Name = "tbSearchEmployeeName";
            this.tbSearchEmployeeName.Size = new System.Drawing.Size(125, 27);
            this.tbSearchEmployeeName.TabIndex = 8;
            this.tbSearchEmployeeName.Text = "Employee name...";
            // 
            // lblListOfEmployeesManagement
            // 
            this.lblListOfEmployeesManagement.AutoSize = true;
            this.lblListOfEmployeesManagement.Location = new System.Drawing.Point(246, 59);
            this.lblListOfEmployeesManagement.Name = "lblListOfEmployeesManagement";
            this.lblListOfEmployeesManagement.Size = new System.Drawing.Size(128, 20);
            this.lblListOfEmployeesManagement.TabIndex = 7;
            this.lblListOfEmployeesManagement.Text = "List of employees:";
            // 
            // lbEmployeeManagementList
            // 
            this.lbEmployeeManagementList.FormattingEnabled = true;
            this.lbEmployeeManagementList.ItemHeight = 20;
            this.lbEmployeeManagementList.Location = new System.Drawing.Point(246, 82);
            this.lbEmployeeManagementList.Name = "lbEmployeeManagementList";
            this.lbEmployeeManagementList.Size = new System.Drawing.Size(671, 304);
            this.lbEmployeeManagementList.TabIndex = 6;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(8, 323);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(138, 77);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Delete employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // lblSelectEmployee
            // 
            this.lblSelectEmployee.AutoSize = true;
            this.lblSelectEmployee.Location = new System.Drawing.Point(9, 134);
            this.lblSelectEmployee.Name = "lblSelectEmployee";
            this.lblSelectEmployee.Size = new System.Drawing.Size(146, 20);
            this.lblSelectEmployee.TabIndex = 4;
            this.lblSelectEmployee.Text = "Select employee to...";
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(8, 240);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(138, 77);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "Edit employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeactivateEmployee
            // 
            this.btnDeactivateEmployee.Location = new System.Drawing.Point(8, 157);
            this.btnDeactivateEmployee.Name = "btnDeactivateEmployee";
            this.btnDeactivateEmployee.Size = new System.Drawing.Size(138, 77);
            this.btnDeactivateEmployee.TabIndex = 2;
            this.btnDeactivateEmployee.Text = "Deactivate employee";
            this.btnDeactivateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(9, 42);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(138, 77);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lblAdminEmpManagement
            // 
            this.lblAdminEmpManagement.AutoSize = true;
            this.lblAdminEmpManagement.Location = new System.Drawing.Point(9, 7);
            this.lblAdminEmpManagement.Name = "lblAdminEmpManagement";
            this.lblAdminEmpManagement.Size = new System.Drawing.Size(268, 20);
            this.lblAdminEmpManagement.TabIndex = 0;
            this.lblAdminEmpManagement.Text = "Administrator- Employee management";
            // 
            // tabScheduleAdministration
            // 
            this.tabScheduleAdministration.Controls.Add(this.groupBox1);
            this.tabScheduleAdministration.Controls.Add(this.button1);
            this.tabScheduleAdministration.Controls.Add(this.listBox3);
            this.tabScheduleAdministration.Controls.Add(this.listBox2);
            this.tabScheduleAdministration.Controls.Add(this.listBox1);
            this.tabScheduleAdministration.Controls.Add(this.label3);
            this.tabScheduleAdministration.Controls.Add(this.label2);
            this.tabScheduleAdministration.Controls.Add(this.label1);
            this.tabScheduleAdministration.Controls.Add(this.dateTimePicker1);
            this.tabScheduleAdministration.Controls.Add(this.lblAdministrationSchedule);
            this.tabScheduleAdministration.Location = new System.Drawing.Point(4, 29);
            this.tabScheduleAdministration.Name = "tabScheduleAdministration";
            this.tabScheduleAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.tabScheduleAdministration.Size = new System.Drawing.Size(941, 412);
            this.tabScheduleAdministration.TabIndex = 2;
            this.tabScheduleAdministration.Text = "scheduleAdministration";
            this.tabScheduleAdministration.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(753, 142);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(79, 104);
            this.listBox3.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(648, 142);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(79, 104);
            this.listBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(550, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 104);
            this.listBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblAdministrationSchedule
            // 
            this.lblAdministrationSchedule.AutoSize = true;
            this.lblAdministrationSchedule.Location = new System.Drawing.Point(9, 7);
            this.lblAdministrationSchedule.Name = "lblAdministrationSchedule";
            this.lblAdministrationSchedule.Size = new System.Drawing.Size(177, 20);
            this.lblAdministrationSchedule.TabIndex = 0;
            this.lblAdministrationSchedule.Text = "Administration- Schedule";
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.lblAdministrationStatistics);
            this.tabStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(941, 412);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // lblAdministrationStatistics
            // 
            this.lblAdministrationStatistics.AutoSize = true;
            this.lblAdministrationStatistics.Location = new System.Drawing.Point(8, 3);
            this.lblAdministrationStatistics.Name = "lblAdministrationStatistics";
            this.lblAdministrationStatistics.Size = new System.Drawing.Size(173, 20);
            this.lblAdministrationStatistics.TabIndex = 0;
            this.lblAdministrationStatistics.Text = "Administration- statistics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(38, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(39, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(39, 107);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(250, 124);
            this.listBox4.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // admin_managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.tabAdmin);
            this.Name = "admin_managerForm";
            this.Text = "admin_managerForm";
            this.tabAdmin.ResumeLayout(false);
            this.tabAdminHome.ResumeLayout(false);
            this.tabAdminHome.PerformLayout();
            this.tabEmployeeManagement.ResumeLayout(false);
            this.tabEmployeeManagement.PerformLayout();
            this.tabScheduleAdministration.ResumeLayout(false);
            this.tabScheduleAdministration.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}