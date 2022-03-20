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
        public WorkerForm()
        {
            InitializeComponent();
        }

        public WorkerForm(User u)
        {
            InitializeComponent();
            user = u;
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
    }
}
