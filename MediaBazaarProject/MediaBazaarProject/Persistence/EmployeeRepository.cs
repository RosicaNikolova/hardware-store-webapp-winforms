using MediaBazaarProject.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Persistence
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            //database magic
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = new MySqlConnection("server=localhost;database=mediabazaar;uid=root;password=''");

            string sql = "SELECT * FROM employees ORDER BY EmployeeId";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cmd.ExecuteReader();

            
            Employee employee = null;
            while (dr.Read())
            {
                employee = new Employee();
                employee.Id = dr.GetInt32("EmployeeId");
                employee.FirstName = dr.GetString("FirstName");
                employee.LastName = dr.GetString("LastName");
                employees.Add(employee);
            }

            conn.Close();

            return employees;
        }

        //public List<Employee> FindEmployee()
        //{
        //    List<Employee> employees = new List<Employee>();


        //    MySqlConnection conn = new MySqlConnection("server=localhost;database=mediabazaar;uid=root;password=''");

        //    string sql = "SELECT * FROM employees ORDER BY EmployeeId";
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);

        //    conn.Open();

        //    MySqlDataReader dr = cmd.ExecuteReader();


        //    Employee employee = null;
           

        //    conn.Close();

        //    return employees;
        //}
    }
}
