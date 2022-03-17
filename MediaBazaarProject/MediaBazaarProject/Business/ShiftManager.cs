using MediaBazaarProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    class ShiftManager
    {
        ScheduleRepository scheduleRepository = new ScheduleRepository();
        List<Shift> schedule;

        public ShiftManager()
        {
            schedule = new List<Shift>();
            schedule = scheduleRepository.GetAllShifts();
        }


        public List<Shift> GetShiftsForDate(DateTime date)
        {
            List<Shift> shiftForDate = new List<Shift>();
            foreach (Shift shift in schedule)
            {
                if(shift.Date == date)
                {
                    shiftForDate.Add(shift);
                }
            }
            return shiftForDate;
        }

        //public ShiftRepository shiftRepo = new ShiftRepository();

        /*User(string name, emun role)
        {

        }

        public void AssignShift(Employee e)
        {

        }

        public void RemoveShift(Employee e)
        {
        
        }
        */
        public bool AssignShift(Employee worker, DateTime date, Shifts selectedShift)
        {
            Shift shift = new Shift();
            shift.Employee = worker;
            shift.Date = date;
            shift.ShiftType = selectedShift;

            if (IsLessThanTenEmployees(shift))
            {
                scheduleRepository.CreateShift(shift);
                schedule.Add(shift);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsLessThanTenEmployees(Shift shift)
        {
            int counter = 0;
            foreach (var record in schedule)
            {
                if (record.Date == shift.Date)
                {
                    if (record.ShiftType == shift.ShiftType)
                    {
                        counter++;
                        if(counter > 10)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public List<Employee> GetAvailableWorkersForDate(List<Employee> workers, DateTime date)
        {
            List<Employee> availableWorkers = new List<Employee>();

            int counter = 0;

            foreach (Employee worker in workers)
            {
                foreach (Shift shift in schedule)
                {
                    if (shift.Date == date && worker.Id == shift.Employee.Id)
                    {
                        counter++;
                    }
                }

                if(counter < 2)
                {
                    availableWorkers.Add(worker);
                }
                counter = 0;
            }
           
            return availableWorkers;
        }
    }
}
