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
    public partial class WorkerForm : Form
    {
        User user;
        ShiftManager shiftManager = new ShiftManager();
        string role = string.Empty;
        public WorkerForm()
        {
            InitializeComponent();
        }

        public WorkerForm(User u,string role)
        {
            InitializeComponent();
            this.role = role;
            user = u;
            if(role == "sales")
            {
                btnWarehouse.Visible = false;
            }
            else if(role == "warehouse")
            {
                btnSales.Visible = false;
            }
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            lbxShiftEmployeeDay.Items.Clear();

             DateTime date=dateWorker.Value;

            foreach (Shift shift in shiftManager.GetShiftsForWorker(date, user.Id))
            {
                lbxShiftEmployeeDay.Items.Add(shift.ShiftType.ToString());
            }
        }

        private void dateWorker_ValueChanged(object sender, EventArgs e)
        {
            lbxShiftEmployeeDay.Items.Clear();

            DateTime date = new DateTime();
            date = dateWorker.Value;

            foreach (Shift shift in shiftManager.GetShiftsForWorker(date, user.Id))
            {
                lbxShiftEmployeeDay.Items.Add(shift.ShiftType.ToString());
            }
        }

        private void btnHomeWarehouse_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }

        private void btnHomeSales_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWorkerHome;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabSales;
            //TODO add data to list
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            TabWorker.SelectedTab = tabWarehouse;
            //TODO add data to list
        }
    }
}
