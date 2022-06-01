using MediaBazaarLibrary;
using MediaBazaarLibrary.Business;
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
    public partial class AutomatedSchedule : Form
    {
        ShiftManager shiftManager = new ShiftManager();
        public AutomatedSchedule()
        {
            InitializeComponent();
            importIntoListBoxes();
        }
        private DateTime getNextWeek1stDay() {
            DateTime nextWeekToday = DateTime.Now.AddDays(7);
            var startOfNextWeek = nextWeekToday.AddDays(-(int)nextWeekToday.DayOfWeek);
            return startOfNextWeek;
        }
        private DateTime getNextWeekLastDay() {
            DateTime nextWeekToday = DateTime.Now.AddDays(7);
            var startOfNextWeek = nextWeekToday.AddDays(-(int)nextWeekToday.DayOfWeek);
            DateTime lastDayOfWeek = startOfNextWeek.AddDays(7).AddSeconds(-1);
            return lastDayOfWeek;
        }
        private void importIntoListBoxes() {
            DateTime nextWeek1stDay = getNextWeek1stDay();
            DateTime nextWeekLastDay = getNextWeekLastDay();
            List<Shift> schedule = new List<Shift>();
            schedule = shiftManager.getAutomatedScheduleShiftsForSelectedWeek(nextWeek1stDay, nextWeekLastDay);

            foreach (Shift shift in schedule)
            {
                if (shift.Date.Day == nextWeek1stDay.Day+1)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 2)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 3)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 4)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 5)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 6)
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
                else if (shift.Date.Day == nextWeek1stDay.Day + 7)
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
    }
}
