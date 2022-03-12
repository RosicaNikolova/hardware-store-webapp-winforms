using MediaBazaarProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class EmployeeManager
    {
        public EmployeeRepository employeeRepository = new EmployeeRepository();

        

        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetEmployees();
        }
        public Employee GetEmployee(Employee e) {
            return GetEmployee(e);
        }
        public void CreateEmployee(string firstName, string lastName, int age, string email, string password, string address, string nationality, double salary, double phoneNumber, string gender, int BSN, bool permanentContract, Position position, bool isAccountActive, bool covidVaccinated) {
            employeeRepository.Create(firstName, lastName, age, email, password, address, nationality, salary, phoneNumber, gender, BSN, permanentContract, position, isAccountActive, covidVaccinated);
        }
        public void UpdateEmployee(Employee e) {
            
        }
        public void DeactivateEmployee(Employee e)
        {
            Employee employee = employeeRepository.GetEmployee(e.Id);
            employee.IsAccountActive = false;
            employeeRepository.Deactivation(employee);
        }
        public void DeleteEmployee(Employee e) {
            
        }
    }
}
