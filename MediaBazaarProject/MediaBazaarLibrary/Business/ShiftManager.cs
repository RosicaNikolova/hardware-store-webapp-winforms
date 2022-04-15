using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class ShiftManager
    {
        ScheduleRepository scheduleRepository = new ScheduleRepository();

      
        public ShiftManager()
        {
           
        }

        public List<Shift> GetShiftsForWorkerForWeek(DateTime date, int id)
        {

            List<Shift> shiftForWorker = new List<Shift>();
            shiftForWorker = scheduleRepository.GetShiftsForWorkerForWeek(date, id);
            return shiftForWorker;
        }

        public List<Shift> GetShiftsForDate(DateTime date)
        {
            List<Shift> shiftForDate = scheduleRepository.GetAllShiftsForDate(date);
            return shiftForDate;
            
        }

        
        public Shift AssignShift(Employee worker, DateTime date, Shifts selectedShift)
        {
            Shift shift = new Shift();
            shift.Employee = worker;
            shift.Date = date;
            shift.ShiftType = selectedShift;

            if (IsLessThanTenEmployees(shift) && HasTheSameShift(shift))
            {
                scheduleRepository.CreateShift(shift);
                return shift;
            }
            else
            {
                return null;
            }
        }

        private bool HasTheSameShift(Shift shift)
        {
            List<Shift> schedule = new List<Shift>();
            schedule = scheduleRepository.GetAllShifts();
            foreach (Shift sh in schedule)
            {
                if (sh.Date == shift.Date)
                {
                    if (sh.ShiftType == shift.ShiftType)
                    {
                        if(shift.Employee.Id == sh.Employee.Id)
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }


        public bool IsLessThanTenEmployees(Shift shift)
        {
            List<Employee> availableWorkers = new List<Employee>();
            List<Shift> schedule = new List<Shift>();
            schedule = scheduleRepository.GetAllShifts();
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

        public List<Shift> GetShiftsForMonthForEmployee(int employeeId, int month)
        {
            List<Shift> shifts = new List<Shift>();
            shifts = scheduleRepository.GetShiftsForEmployeeForMonth(employeeId, month);
            return shifts;

        }

        public List<Employee> GetAvailableWorkersForDate(List<Employee> workers, DateTime date)
        {
            List<Employee> availableWorkers = new List<Employee>();
            List <Shift> schedule = new List<Shift>();
            schedule = scheduleRepository.GetAllShifts();

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

        public List<Shift> GetShiftsForWorker(DateTime date, int id)
        {
            List<Shift> shifts = new List<Shift>();

            shifts = scheduleRepository.GetShiftsForWorker(date, id);

            return shifts;
        }

        public bool RemoveShift(DateTime date, string shift, Employee employee)
        {
            List<Shift> schedule = new List<Shift>(); 
            schedule = scheduleRepository.GetAllShifts();
            int id = 0;
            foreach (Shift shif in schedule)
            {
                if (shif.Date == date)
                {
                    if (shif.ShiftType.ToString() == shift)
                    {
                        if (shif.Employee.Id == employee.Id)
                        {
                            id = shif.Id;
                        }
                    }
                }
            }

            if (scheduleRepository.RemoveShift(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Shift> GetAllShifts()
        {
            List<Shift> shifts = scheduleRepository.GetAllShifts();
            return shifts;
            
        }
    }
}
