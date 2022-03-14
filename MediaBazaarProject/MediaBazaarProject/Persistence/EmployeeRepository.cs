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
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            { 

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
            }

            return employees;
        }
        public Employee GetEmployee(int id)
        {
            //database magic
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "SELECT * FROM employees where EmployeeId=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", id);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                Employee employee = null;
                while (dr.Read())
                {
                    employee = new Employee();
                    employee.Id = dr.GetInt32("EmployeeId");
                    employee.FirstName = dr.GetString("FirstName");
                    employee.LastName = dr.GetString("LastName");
                }
                return employee;
            }
        }
        public void Create(string firstName, string lastName, int age, string email, string password, string address, string nationality, double salary, double phoneNumber, string gender, int BSN, bool permanentContract, Position position, bool isAccountActive, bool covidVaccinated)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "insert into users (FirstName,LastName,Age,Email,Password,Address,Nationality,Salary,PhoneNumber,Gender,BSN,PermanentContract,Position,IsAccountActive,CovidVaccinates) values (@FirstName,@LastName,@Age,@Email,@Password,@Address,@Nationality,@Salary,@PhoneNumber,@Gender,@BSN,@PermanentContract,@Position,@IsAccountActive,@CovidVaccinates)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("FirstName", firstName);
                cmd.Parameters.AddWithValue("LastName", lastName);
                cmd.Parameters.AddWithValue("Age", age);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Password", password);
                cmd.Parameters.AddWithValue("Address", address);
                cmd.Parameters.AddWithValue("Nationality", nationality);
                cmd.Parameters.AddWithValue("Salary", salary);
                cmd.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("Gender", gender);
                cmd.Parameters.AddWithValue("BSN", BSN);
                cmd.Parameters.AddWithValue("PermanentContract", permanentContract);
                cmd.Parameters.AddWithValue("Position", position);
                cmd.Parameters.AddWithValue("IsAccountActive", isAccountActive);
                cmd.Parameters.AddWithValue("CovidVaccinated", covidVaccinated);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Deactivation(Employee e) {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "update users SET IsAccountActive=@IsAccountActive where EmployeeId=@Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Email", e.IsAccountActive);
                cmd.Parameters.AddWithValue("EmployeeId", e.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public User FindUser(string email, string password)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "select name, position from user where @email=email and @password=password;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);


                conn.Open();
                User user = null;
                MySqlDataReader dateReader = cmd.ExecuteReader();
                if (dateReader.Read())
                {
                    user = new User();
                    user.Name = dateReader.GetString("name");
                    //user.Position = dateReader.GetString("position");
                }
                return user;
            }


            

            

            
           
        }
    }
}
