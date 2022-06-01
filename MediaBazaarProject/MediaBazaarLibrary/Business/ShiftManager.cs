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
                        if (shift.Employee.Id == sh.Employee.Id)
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
                        if (counter > 10)
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
            List<Shift> schedule = new List<Shift>();
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

                if (counter < 2)
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

        public List<Shift> GetShiftsForAllWorkersForWeek(DateTime date)
        {
            List<Shift> shifts = new List<Shift>();
            shifts = scheduleRepository.GetShiftsForAllWorekrsForWeek(date);
            return shifts;
        }

        public List<Shift> GenerateSchedule(int employeesPerShift, List<int> employeesIds, List<PreferedShift> preferences)
        {
            Dictionary<string, Dictionary<Shifts, List<Shift>>> schedule = new Dictionary<string, Dictionary<Shifts, List<Shift>>>();
            schedule.Add("Monday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Tuesday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Wednesday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Thusday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Friday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Saturday", new Dictionary<Shifts, List<Shift>>());
            schedule.Add("Sunday", new Dictionary<Shifts, List<Shift>>());

            Dictionary<string, Dictionary<int, int>> countOfAssignedShifts = new Dictionary<string, Dictionary<int, int>>();

            countOfAssignedShifts.Add("Monday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Tuesday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Wednesday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Thusday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Friday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Saturday", new Dictionary<int, int>());
            countOfAssignedShifts.Add("Sunday", new Dictionary<int, int>());

            foreach (var weekday in schedule)
            {
                schedule[weekday.Key].Add(Shifts.MORNING, new List<Shift>());
                schedule[weekday.Key].Add(Shifts.MIDDAY, new List<Shift>());
                schedule[weekday.Key].Add(Shifts.EVENING, new List<Shift>());
            }

            if (preferences.Count != 0)
            {

                foreach (PreferedShift preferedShift in preferences)
                {
                    if (schedule.ContainsKey(preferedShift.RequestedDateDay))
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (schedule[preferedShift.RequestedDateDay][Shifts.MORNING].Count <= schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Count && schedule[preferedShift.RequestedDateDay][Shifts.MORNING].Count != employeesPerShift)
                            {
                                if (schedule[preferedShift.RequestedDateDay][Shifts.MORNING].Count < employeesPerShift)
                                {
                                    if (countOfAssignedShifts[preferedShift.RequestedDateDay].ContainsKey(preferedShift.EmployeeID))
                                    {
                                        if (countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID] < 2)
                                        {
                                            schedule[preferedShift.RequestedDateDay][Shifts.MORNING].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                            countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID]++;
                                        }
                                    }
                                    else
                                    {
                                        schedule[preferedShift.RequestedDateDay][Shifts.MORNING].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                        countOfAssignedShifts[preferedShift.RequestedDateDay].Add(preferedShift.EmployeeID, 1);
                                    }
                                }
                            }
                            else if (schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Count <= schedule[preferedShift.RequestedDateDay][Shifts.EVENING].Count && schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Count != employeesPerShift)
                            {
                                if (schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Count < employeesPerShift)
                                {
                                    if (countOfAssignedShifts[preferedShift.RequestedDateDay].ContainsKey(preferedShift.EmployeeID))
                                    {
                                        if (countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID] < 2)
                                        {
                                            schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                            countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID]++;
                                        }
                                    }
                                    else
                                    {
                                        schedule[preferedShift.RequestedDateDay][Shifts.MIDDAY].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                        countOfAssignedShifts[preferedShift.RequestedDateDay].Add(preferedShift.EmployeeID, 1);
                                    }
                                }
                            }
                            else
                            {
                                if (schedule[preferedShift.RequestedDateDay][Shifts.EVENING].Count < employeesPerShift)
                                {
                                    if (countOfAssignedShifts[preferedShift.RequestedDateDay].ContainsKey(preferedShift.EmployeeID))
                                    {
                                        if (countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID] < 2)
                                        {
                                            schedule[preferedShift.RequestedDateDay][Shifts.EVENING].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                            countOfAssignedShifts[preferedShift.RequestedDateDay][preferedShift.EmployeeID]++;
                                        }
                                    }
                                    else
                                    {
                                        schedule[preferedShift.RequestedDateDay][Shifts.EVENING].Add(new Shift { EmployeeId = preferedShift.EmployeeID });
                                        countOfAssignedShifts[preferedShift.RequestedDateDay].Add(preferedShift.EmployeeID, 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var weekday in schedule)
            {
                foreach (int employee in employeesIds)
                {
                    //check if this employee has 2 shifts for the day
                    if (countOfAssignedShifts[weekday.Key].ContainsKey(employee))
                    {
                        if (countOfAssignedShifts[weekday.Key][employee] == 2)
                        {
                            continue;
                        }
                    }

                    for (int i = 0; i < 2; i++)
                    {
                        //check which is the shift with least employees
                        if (schedule[weekday.Key][Shifts.MORNING].Count <= schedule[weekday.Key][Shifts.MIDDAY].Count && schedule[weekday.Key][Shifts.MORNING].Count != employeesPerShift)
                        {
                            //check if max number of employees is reached
                            if (schedule[weekday.Key][Shifts.MORNING].Count < employeesPerShift)
                            {
                                schedule[weekday.Key][Shifts.MORNING].Add(new Shift { EmployeeId = employee });
                                if (countOfAssignedShifts[weekday.Key].ContainsKey(employee))
                                {
                                    countOfAssignedShifts[weekday.Key][employee]++;
                                }
                                else
                                {
                                    countOfAssignedShifts[weekday.Key].Add(employee, 1);
                                }
                            }
                        }
                        else if (schedule[weekday.Key][Shifts.MIDDAY].Count <= schedule[weekday.Key][Shifts.EVENING].Count && schedule[weekday.Key][Shifts.MIDDAY].Count != employeesPerShift)
                        {
                            if (schedule[weekday.Key][Shifts.MIDDAY].Count < employeesPerShift)
                            {
                                schedule[weekday.Key][Shifts.MIDDAY].Add(new Shift { EmployeeId = employee });
                                if (countOfAssignedShifts[weekday.Key].ContainsKey(employee))
                                {
                                    countOfAssignedShifts[weekday.Key][employee]++;
                                }
                                else
                                {
                                    countOfAssignedShifts[weekday.Key].Add(employee, 1);
                                }
                            }
                        }
                        else
                        {
                            if (schedule[weekday.Key][Shifts.EVENING].Count < employeesPerShift)
                            {
                                schedule[weekday.Key][Shifts.EVENING].Add(new Shift { EmployeeId = employee });
                                if (countOfAssignedShifts[weekday.Key].ContainsKey(employee))
                                {
                                    countOfAssignedShifts[weekday.Key][employee]++;
                                }
                                else
                                {
                                    countOfAssignedShifts[weekday.Key].Add(employee, 1);
                                }

                            }
                           
                        }
                    }
                }
            }

             List <Shift> shiftsList = CreateShiftListFromDictionary(schedule);
             scheduleRepository.SaveAutomatedSchedule(shiftsList);
             return shiftsList;
        }

        private List<Shift> CreateShiftListFromDictionary(Dictionary<string, Dictionary<Shifts, List<Shift>>> schedule)
        {
            DateTime startDate = GetNextMonday();
           // DateTime endDate = GetNextSunday();
            List<Shift> schedulefShifts = new List<Shift>();

            foreach (var weekDay in schedule)
            {
                foreach (var shiftType in schedule[weekDay.Key])
                {
                    foreach (Shift shift in schedule[weekDay.Key][shiftType.Key])
                    {
                        Shift newShift = new Shift();
                        newShift.Date = startDate;
                        newShift.ShiftType = shiftType.Key;
                        newShift.EmployeeId = shift.EmployeeId;
                        schedulefShifts.Add(newShift);
                    }
                }
                startDate = startDate.AddDays(1);
            }
            DateTime firstDay = GetNextMonday();
            scheduleRepository.SaveWeekAsGenerated(firstDay);
            return schedulefShifts;

        }

        private DateTime GetNextMonday()
        {
            DateTime today = DateTime.Today;
            DateTime nextMonday;
            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                int daysUntilMonday = 7;
                nextMonday = today.AddDays(daysUntilMonday);
            }
            else
            {
                int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
                nextMonday = today.AddDays(daysUntilMonday);
            }
            return nextMonday;
            
        }

        public bool ScheduleForWeekAlreadyGenerated(DateTime nextMonday)
        {
            return scheduleRepository.ScheduleForWeekAlreadyGenerated(nextMonday);
        }
        public List<Shift> getAutomatedScheduleShiftsForSelectedWeek(DateTime startDate, DateTime endDate) {
            return scheduleRepository.getAutomatedScheduleShiftsForSelectedWeek(startDate, endDate);
        }



    }
}

