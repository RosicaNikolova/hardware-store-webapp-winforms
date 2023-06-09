﻿using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    class ScheduleRepository
    {
        EnumManager enumManager = new EnumManager();

        public List<Shift> GetAllShifts()
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "SELECT shifts.Id, shifts.EmployeeId, shifts.ShiftDate, shifts.ShiftNumber, employees.FirstName, employees.LastName FROM shifts INNER JOIN employees ON shifts.EmployeeId = employees.EmployeeId;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                Shift shift = null;
               

                while (dr.Read())
                {
                    shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    shift.Employee.Id = dr.GetInt32("EmployeeId");
                    shift.Employee.FirstName = dr.GetString("FirstName");
                    shift.Employee.LastName = dr.GetString("LastName");

                    schedule.Add(shift);
                }
            }

            return schedule;
        }

        public List<Shift> GetShiftsForWorkerForWeek(DateTime date, int id)
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM shifts WHERE EmployeeId = @EmployeeId AND ShiftDate BETWEEN @startDate AND @endDate;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                DateTime endDate;
                endDate = DateTime.Today.AddDays(6);
                cmd.Parameters.AddWithValue("EmployeeId", id);
                cmd.Parameters.AddWithValue("startDate", date);
                cmd.Parameters.AddWithValue("endDate", endDate);

                MySqlDataReader dr = cmd.ExecuteReader();

                Shift shift = null;

                while (dr.Read())
                {
                    shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        public List<Shift> GetAllShiftsForDate(DateTime date)
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT shifts.Id, shifts.EmployeeId, shifts.ShiftDate, shifts.ShiftNumber, employees.FirstName, employees.LastName FROM shifts INNER JOIN employees ON shifts.EmployeeId = employees.EmployeeId where ShiftDate= @date;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //string converetedDate = date.ToString("MM-dd-yy");
                cmd.Parameters.AddWithValue("date", date);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    
                    Shift shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    shift.Employee.Id = dr.GetInt32("EmployeeId");
                    shift.Employee.FirstName = dr.GetString("FirstName");
                    shift.Employee.LastName = dr.GetString("LastName");

                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        internal List<Shift> GetShiftsForEmployeeForMonth(int employeeId, int month)
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {

                string sql = "SELECT Id, ShiftNumber, ShiftDate FROM shifts where EmployeeId = @employeeId AND MONTH(shifts.ShiftDate) = @month;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //string converetedDate = date.ToString("MM-dd-yy");
                cmd.Parameters.AddWithValue("month", month);
                cmd.Parameters.AddWithValue("employeeId", employeeId);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Shift shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        public List<Shift> GetShiftsForAllWorekrsForWeek(DateTime date)
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM shifts as s INNER JOIN employees as e ON s.EmployeeId = e.EmployeeId WHERE s.ShiftDate BETWEEN @startDate AND @endDate;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                DateTime endDate;
                endDate = DateTime.Today.AddDays(6);
                cmd.Parameters.AddWithValue("startDate", date);
                cmd.Parameters.AddWithValue("endDate", endDate);

                MySqlDataReader dr = cmd.ExecuteReader();

                Shift shift = null;

                while (dr.Read())
                {
                    shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    shift.Employee.Id = dr.GetInt32("EmployeeId");
                    shift.Employee.FirstName = dr.GetString("FirstName");
                    shift.Employee.LastName = dr.GetString("LastName");
                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        public void CreateShift(Shift shift)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "insert into shifts (EmployeeId, ShiftDate, ShiftNumber) values (@EmployeeId,@ShiftDate,@ShiftNumber);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("EmployeeId", shift.Employee.Id);
                cmd.Parameters.AddWithValue("ShiftDate", shift.Date);
                cmd.Parameters.AddWithValue("ShiftNumber", shift.ShiftType.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Shift> GetShiftsForWorker(DateTime date, int id)
        {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT Id, EmployeeId, ShiftDate, ShiftNumber FROM shifts where EmployeeId=@EmployeeId and ShiftDate = @ShiftDate;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("EmployeeId", id);
                cmd.Parameters.AddWithValue("ShiftDate", date);

                MySqlDataReader dr = cmd.ExecuteReader();

                Shift shift = null;

                while (dr.Read())
                {
                    shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    shift.Employee.Id = dr.GetInt32("EmployeeId");
                 
                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        public bool RemoveShift(int id)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from shifts where Id=@Id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SaveAutomatedSchedule(List<Shift> shiftsList)
        {
            foreach (Shift shift in shiftsList)
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into shifts (EmployeeId, ShiftDate, ShiftNumber) values (@EmployeeId,@ShiftDate,@ShiftNumber);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("EmployeeId", shift.EmployeeId);
                    cmd.Parameters.AddWithValue("ShiftDate", shift.Date);
                    cmd.Parameters.AddWithValue("ShiftNumber", shift.ShiftType.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //we get a list of shifts for next week, this list is recycled into listboxes
        public List<Shift> getAutomatedScheduleShiftsForSelectedWeek(DateTime startDate, DateTime endDate) {
            List<Shift> schedule = new List<Shift>();

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT shifts.Id, shifts.EmployeeId, shifts.ShiftDate, shifts.ShiftNumber, employees.FirstName, employees.LastName FROM shifts INNER JOIN employees ON shifts.EmployeeId = employees.EmployeeId where ShiftDate BETWEEN @StartDate AND @EndDate;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("StartDate", startDate);
                cmd.Parameters.AddWithValue("EndDate", endDate);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Shift shift = new Shift();
                    shift.Id = dr.GetInt32("Id");
                    shift.Date = (DateTime)dr.GetMySqlDateTime("ShiftDate");
                    shift.ShiftType = enumManager.SetShiftType(dr.GetString("ShiftNumber"));
                    shift.Employee.Id = dr.GetInt32("EmployeeId");
                    shift.Employee.LastName = dr.GetString("LastName");

                    schedule.Add(shift);
                }
            }
            return schedule;
        }

        public bool ScheduleForWeekAlreadyGenerated(DateTime nextMonday)
        {

            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT startDate FROM automatedscheduleweeks where startDate=@startDate;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("startDate", nextMonday);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    return true;
                }

                return false;
            }
        }

        public void SaveWeekAsGenerated(DateTime startDate)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "insert into automatedscheduleweeks (startDate) values (@startDate);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("startDate", startDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SetWeekToNotGenerated(DateTime startDate)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "delete from automatedscheduleweeks where startDate=@startDate;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("startDate", startDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool DeleteScheduleForWeeek(DateTime nextMonday, DateTime nextSunday)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "Delete from shifts where ShiftDate between @nextMonday and @nextSunday";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("nextMonday", nextMonday);
                    cmd.Parameters.AddWithValue("nextSunday", nextSunday);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
