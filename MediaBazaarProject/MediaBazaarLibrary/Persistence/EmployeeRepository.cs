using MediaBazaarLibrary.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Persistence
{
    public class EmployeeRepository
        
    {
        EnumManager enumManager = new EnumManager();
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
                    employee.Email = dr.GetString("Email");
                    employee.IsAccountActive = dr.GetBoolean("IsAccountActive");
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public void SavePasswordForEmployee(string password, int employeeId)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "UPDATE employees SET Password=@Password, FirstLogin = @FirstLogin where EmployeeId=@EmployeeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("Password", password);
                cmd.Parameters.AddWithValue("FirstLogin", 1);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //for creating an employee, gets a user with BSN, if not null, user cant be created
        public Employee GetEmployeeByBSNProtected(int BSN, string email)
        {
            //database magic
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "SELECT * FROM employees where BSN=@BSN and Email=@Email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("BSN", BSN);
                cmd.Parameters.AddWithValue("Email", email);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                Employee employee = null;
                while (dr.Read())
                {
                    employee = new Employee();
                    employee.Id = dr.GetInt32("EmployeeId");
                    employee.FirstName = dr.GetString("FirstName");
                    employee.LastName = dr.GetString("LastName");
                    employee.Bsn1 = dr.GetInt32("BSN");
                }
                return employee;
            }
        }
        public Employee GetEmployeeByEmail(string email)
        {
            //database magic
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "SELECT * FROM employees where Email=@Email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Email", email);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                Employee employee = null;
                while (dr.Read())
                {
                    employee = new Employee();
                    employee.Id = dr.GetInt32("EmployeeId");
                    employee.FirstName = dr.GetString("FirstName");
                    employee.LastName = dr.GetString("LastName");
                    employee.Bsn1 = dr.GetInt32("BSN");
                }
                return employee;
            }
        }

       

        public void Create(string firstName, string lastName, int age, string email, string password, string address, string nationality, double salary, double phoneNumber, string gender, int BSN, bool permanentContract, int position, bool isAccountActive, bool covidVaccinated)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place   
            {
                string sql = "insert into employees (FirstName,LastName,Age,Email,Password,Address,Nationality,Salary,PhoneNumber,Gender,BSN,PermanentContract,Position,IsAccountActive,CovidVaccinated, FirstLogin) values (@FirstName,@LastName,@Age,@Email,@Password,@Address,@Nationality,@Salary,@PhoneNumber,@Gender,@BSN,@PermanentContract,@Position,@IsAccountActive,@CovidVaccinated, 0)";
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
                cmd.Parameters.AddWithValue("Position", enumManager.SetPosition(position));
                cmd.Parameters.AddWithValue("IsAccountActive", isAccountActive);
                cmd.Parameters.AddWithValue("CovidVaccinated", covidVaccinated);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Deactivation(Employee e) {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "update employees SET IsAccountActive=@IsAccountActive where EmployeeId=@EmployeeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IsAccountActive", e.IsAccountActive);
                cmd.Parameters.AddWithValue("EmployeeId", e.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteEmployee(Employee e)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "Delete from employees where EmployeeId=@EmployeeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", e.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Used in log in
        public User FindUser(string email, string password)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select FirstName, Email, Password, Position, EmployeeId, FirstLogin from employees where Email=@Email and Password=@Password;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Password", password);


                    conn.Open();
                    User user = null;
                    MySqlDataReader dateReader = cmd.ExecuteReader();

                    while (dateReader.Read())
                    {
                        user = new User();
                        user.FirstName = dateReader.GetString("FirstName");
                        user.Position = user.SetPosition(dateReader.GetString("Position").ToUpper());
                        user.Id = dateReader.GetInt32("EmployeeId");
                        user.FirstLogin = dateReader.GetInt32("FirstLogin");
                    }
                    return user;
                }
            }
            catch (Exception) {
                throw new Exception();
            }  
        }
        //used in updating employee, we store ID
        public Employee GetEmployeeByID(int Id)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "select * from employees where EmployeeId=@EmployeeId;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", Id);


                conn.Open();
                Employee employee = new Employee();
                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    employee.Id = dateReader.GetInt32("EmployeeId");
                    employee.Bsn1 = dateReader.GetInt32("BSN");
                    employee.FirstName = dateReader.GetString("FirstName");
                    employee.LastName = dateReader.GetString("LastName");
                    employee.Email = dateReader.GetString("Email");
                    employee.Password = dateReader.GetString("Password");
                    employee.PermanentContract = dateReader.GetBoolean("PermanentContract");
                    employee.Address = dateReader.GetString("Address");
                    employee.PhoneNumber = ((long)dateReader.GetDouble("PhoneNumber"));
                    employee.Salary = dateReader.GetDouble("Salary");
                    employee.Position = enumManager.GetPosition(dateReader.GetString("Position"));
                    employee.CovidVaccinated = dateReader.GetBoolean("CovidVaccinated");
                    employee.Age = dateReader.GetInt32("Age");
                    employee.Nationality = dateReader.GetString("Nationality");
                    employee.Gender = dateReader.GetString("Gender");
                    employee.IsAccountActive = dateReader.GetBoolean("IsAccountActive");
                }
                return employee;
            }
        }
        public List<Employee> DeactivatedEmployees()
        {
            //database magic
            List<Employee> deactivatedEmployees = new List<Employee>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM employees WHERE IsAccountActive=@IsAccountActive";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("IsAccountActive", false);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                Employee employee = null;
                while (dateReader.Read())
                {
                    employee = new Employee();
                    employee.Id = dateReader.GetInt32("EmployeeId");
                    employee.Bsn1 = dateReader.GetInt32("BSN");
                    employee.FirstName = dateReader.GetString("FirstName");
                    employee.LastName = dateReader.GetString("LastName");
                    employee.Email = dateReader.GetString("Email");
                    employee.Password = dateReader.GetString("Password");
                    employee.PermanentContract = dateReader.GetBoolean("PermanentContract");
                    employee.Address = dateReader.GetString("Address");
                    employee.PhoneNumber = ((long)dateReader.GetDouble("PhoneNumber"));
                    employee.Salary = dateReader.GetDouble("Salary");
                    employee.Position = enumManager.GetPosition(dateReader.GetString("Position"));
                    employee.CovidVaccinated = dateReader.GetBoolean("CovidVaccinated");
                    employee.Age = dateReader.GetInt32("Age");
                    employee.Nationality = dateReader.GetString("Nationality");
                    employee.Gender = dateReader.GetString("Gender");
                    employee.IsAccountActive = dateReader.GetBoolean("IsAccountActive");
                    deactivatedEmployees.Add(employee);
                }
            }

            return deactivatedEmployees;
        }
        public List<Employee> FilterEmployeesByNationality(string nationality)
        {
            //database magic
            List<Employee> filteredEmployees = new List<Employee>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM employees WHERE Nationality=@Nationality";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Nationality", nationality);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                Employee employee = null;
                while (dateReader.Read())
                {
                    employee = new Employee();
                    employee.Id = dateReader.GetInt32("EmployeeId");
                    employee.Bsn1 = dateReader.GetInt32("BSN");
                    employee.FirstName = dateReader.GetString("FirstName");
                    employee.LastName = dateReader.GetString("LastName");
                    employee.Email = dateReader.GetString("Email");
                    employee.Password = dateReader.GetString("Password");
                    employee.PermanentContract = dateReader.GetBoolean("PermanentContract");
                    employee.Address = dateReader.GetString("Address");
                    employee.PhoneNumber = ((long)dateReader.GetDouble("PhoneNumber"));
                    employee.Salary = dateReader.GetDouble("Salary");
                    employee.Position = enumManager.GetPosition(dateReader.GetString("Position"));
                    employee.CovidVaccinated = dateReader.GetBoolean("CovidVaccinated");
                    employee.Age = dateReader.GetInt32("Age");
                    employee.Nationality = dateReader.GetString("Nationality");
                    employee.Gender = dateReader.GetString("Gender");
                    employee.IsAccountActive = dateReader.GetBoolean("IsAccountActive");
                    filteredEmployees.Add(employee);
                }
            }

            return filteredEmployees;
        }
        public List<Employee> FilterEmployeesByPermanentContract()
        {
            //database magic
            List<Employee> filteredEmployees = new List<Employee>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM employees WHERE PermanentContract=@PermanentContract";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("PermanentContract", true);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                Employee employee = null;
                while (dateReader.Read())
                {
                    employee = new Employee();
                    employee.Id = dateReader.GetInt32("EmployeeId");
                    employee.Bsn1 = dateReader.GetInt32("BSN");
                    employee.FirstName = dateReader.GetString("FirstName");
                    employee.LastName = dateReader.GetString("LastName");
                    employee.Email = dateReader.GetString("Email");
                    employee.Password = dateReader.GetString("Password");
                    employee.PermanentContract = dateReader.GetBoolean("PermanentContract");
                    employee.Address = dateReader.GetString("Address");
                    employee.PhoneNumber = ((long)dateReader.GetDouble("PhoneNumber"));
                    employee.Salary = dateReader.GetDouble("Salary");
                    employee.Position = enumManager.GetPosition(dateReader.GetString("Position"));
                    employee.CovidVaccinated = dateReader.GetBoolean("CovidVaccinated");
                    employee.Age = dateReader.GetInt32("Age");
                    employee.Nationality = dateReader.GetString("Nationality");
                    employee.Gender = dateReader.GetString("Gender");
                    employee.IsAccountActive = dateReader.GetBoolean("IsAccountActive");
                    filteredEmployees.Add(employee);
                }
            }

            return filteredEmployees;
        }
        public List<Employee> FilterEmployeesByTemporaryContract()
        {
            //database magic
            List<Employee> filteredEmployees = new List<Employee>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM employees WHERE PermanentContract=@PermanentContract";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("PermanentContract", false);
                conn.Open();

                MySqlDataReader dateReader = cmd.ExecuteReader();

                Employee employee = null;
                while (dateReader.Read())
                {
                    employee = new Employee();
                    employee.Id = dateReader.GetInt32("EmployeeId");
                    employee.Bsn1 = dateReader.GetInt32("BSN");
                    employee.FirstName = dateReader.GetString("FirstName");
                    employee.LastName = dateReader.GetString("LastName");
                    employee.Email = dateReader.GetString("Email");
                    employee.Password = dateReader.GetString("Password");
                    employee.PermanentContract = dateReader.GetBoolean("PermanentContract");
                    employee.Address = dateReader.GetString("Address");
                    employee.PhoneNumber = ((long)dateReader.GetDouble("PhoneNumber"));
                    employee.Salary = dateReader.GetDouble("Salary");
                    employee.Position = enumManager.GetPosition(dateReader.GetString("Position"));
                    employee.CovidVaccinated = dateReader.GetBoolean("CovidVaccinated");
                    employee.Age = dateReader.GetInt32("Age");
                    employee.Nationality = dateReader.GetString("Nationality");
                    employee.Gender = dateReader.GetString("Gender");
                    employee.IsAccountActive = dateReader.GetBoolean("IsAccountActive");
                    filteredEmployees.Add(employee);
                }
            }

            return filteredEmployees;
        }
        public void Update(Employee employee)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "UPDATE employees SET FirstName=@FirstName, LastName=@LastName,Age=@Age,Email=@Email,Password=@Password,Address=@Address,Nationality=@Nationality,Salary=@Salary,PhoneNumber=@PhoneNumber,Gender=@Gender,BSN=@BSN,PermanentContract=@PermanentContract,Position=@Position,IsAccountActive=@IsAccountActive,CovidVaccinated=@CovidVaccinated where EmployeeId=@EmployeeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("LastName", employee.LastName);
                cmd.Parameters.AddWithValue("Age", employee.Age);
                cmd.Parameters.AddWithValue("Email", employee.Email);
                cmd.Parameters.AddWithValue("Password", employee.Password);
                cmd.Parameters.AddWithValue("Address", employee.Address);
                cmd.Parameters.AddWithValue("Nationality", employee.Nationality);
                cmd.Parameters.AddWithValue("Salary", employee.Salary);
                cmd.Parameters.AddWithValue("PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("Gender", employee.Gender);
                cmd.Parameters.AddWithValue("BSN", employee.Bsn1);
                cmd.Parameters.AddWithValue("PermanentContract", employee.PermanentContract);
                cmd.Parameters.AddWithValue("Position", employee.Position);
                cmd.Parameters.AddWithValue("IsAccountActive", employee.IsAccountActive);
                cmd.Parameters.AddWithValue("CovidVaccinated", employee.CovidVaccinated);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetWorkers()
        {
            //database magic
            List<Employee> employees = new List<Employee>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {

                string sql = "SELECT * FROM employees WHERE Position IN (@sales, @warehouse) ORDER BY EmployeeId;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sales", "Sales");
                cmd.Parameters.AddWithValue("warehouse", "Warehouse");


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

        public List<NationalityStatistics> GetNationalityStatistics()
        {
            List<NationalityStatistics> nationalityStatisticsList = new List<NationalityStatistics>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "Select Nationality, count(Nationality) as Count from employees group by Nationality";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                NationalityStatistics nationalityStatistics = null;
                while (dr.Read())
                {
                    nationalityStatistics = new NationalityStatistics();
                    nationalityStatistics.Nationality = dr.GetString("Nationality");
                    nationalityStatistics.Count = dr.GetInt32("Count");
                    nationalityStatisticsList.Add(nationalityStatistics);
                }
            }

            return nationalityStatisticsList;
        }

        public List<ContractStatistics> GetContractStatistics()
        {
            List<ContractStatistics> contractStatisticsList = new List<ContractStatistics>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "Select PermanentContract, count(PermanentContract) as Count from employees group by PermanentContract";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                ContractStatistics contractStatistics = null;
                while (dr.Read())
                {
                    contractStatistics = new ContractStatistics();
                    contractStatistics.ContractType = dr.GetString("PermanentContract");
                    contractStatistics.Count = dr.GetInt32("Count");
                    contractStatisticsList.Add(contractStatistics);
                }
            }

            return contractStatisticsList;
        }

        public double GetAverageSalary()
        {
            double averageSalary = 0;
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "select avg(Salary) as AverageSalary from employees";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    averageSalary = dr.GetDouble("AverageSalary");
                }
            }

            return averageSalary;
        }

        public string GetPassword(int employeeId)
        {
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())
            {
                string sql = "select Password from employees where EmployeeId=@EmployeeId;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("EmployeeId", employeeId);
                conn.Open();
                string password = string.Empty;
                MySqlDataReader dateReader = cmd.ExecuteReader();

                while (dateReader.Read())
                {
                    password = dateReader.GetString("Password");
                }
                return password;
            }

        }

        public List<int> GetAllEmployeesIds()
        {
            List<int> employeesIds = new List<int>();
            using (MySqlConnection conn = DatabaseConnection.CreateConnection())//guys, here go to definition and change the string, any other time we will use connection, u change it just on one place 
            {
                string sql = "SELECT EmployeeId FROM employees WHERE Position IN (@sales, @warehouse) ORDER BY EmployeeId;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("sales", "Sales");
                cmd.Parameters.AddWithValue("warehouse", "Warehouse");

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {             
                    employeesIds.Add(dr.GetInt32("EmployeeId"));                 
                }
            }

            return employeesIds;
        }
    }
}
