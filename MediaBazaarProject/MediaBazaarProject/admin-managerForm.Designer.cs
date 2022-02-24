
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnScheduleAdministration = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lblListOfEmployees = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbNationality);
            this.tabPage1.Controls.Add(this.lblListOfEmployees);
            this.tabPage1.Controls.Add(this.btnStatistics);
            this.tabPage1.Controls.Add(this.btnScheduleAdministration);
            this.tabPage1.Controls.Add(this.btnEmployeeManagement);
            this.tabPage1.Controls.Add(this.lblRole);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(17, 62);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(110, 99);
            this.btnEmployeeManagement.TabIndex = 1;
            this.btnEmployeeManagement.Text = "Employee management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
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
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(17, 205);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(114, 99);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
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
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(358, 85);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(151, 28);
            this.cbNationality.TabIndex = 5;
            this.cbNationality.Text = "Nationality...";
            // 
            // admin_managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "admin_managerForm";
            this.Text = "admin_managerForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblListOfEmployees;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnScheduleAdministration;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Label lblRole;
    }
}