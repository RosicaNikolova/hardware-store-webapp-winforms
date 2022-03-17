﻿using MediaBazaarProject.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Persistence
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

                string sql = "SELECT shifts.Id, shifts.EmployeeId, shifts.ShiftDate, shifts.ShiftNumber FROM shifts where @EmployeeId=EmployeeId and @ShiftDate = ShiftDate;";

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



    }
}
