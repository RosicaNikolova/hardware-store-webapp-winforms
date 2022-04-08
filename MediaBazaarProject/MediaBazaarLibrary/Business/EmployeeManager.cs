using MediaBazaarLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class EmployeeManager
    {
        public EmployeeRepository employeeRepository = new EmployeeRepository();


        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetEmployees();
        }
        public List<Employee> GetDeactivatedEmployees()
        {
            return employeeRepository.DeactivatedEmployees();
        }
        public List<Employee> GetNationalityFilteredEmployees(string nationality)
        {
            return employeeRepository.FilterEmployeesByNationality(nationality);
        }
        public List<Employee> GetPermanentContractEmployees()
        {
            return employeeRepository.FilterEmployeesByPermanentContract();
        }
        public List<Employee> GetTemporaryContractEmployees()
        {
            return employeeRepository.FilterEmployeesByTemporaryContract();
        }
        public Employee GetEmployee(Employee e) {
            return employeeRepository.GetEmployeeByBSNProtected(e.Bsn1, e.Email);
        }
        public Employee GetEmployeeByID(Employee e)
        {
            return employeeRepository.GetEmployeeByID(e.Id);
        }
        public void CreateEmployee(string firstName, string lastName, int age, string email, string password, string address, string nationality, double salary, double phoneNumber, string gender, int BSN, bool permanentContract, int position, bool isAccountActive, bool covidVaccinated) {
            Employee employee = employeeRepository.GetEmployeeByBSNProtected(BSN, email);
            if (employee == null)
            {
                employeeRepository.Create(firstName, lastName, age, email, password, address, nationality, salary, phoneNumber, gender, BSN, permanentContract, position, isAccountActive, covidVaccinated);
            }
            else {
                throw new Exception("Employee with such BSN exists");
            }
        }
        public void UpdateEmployee(Employee employee) {
            employeeRepository.Update(employee);
        }
        public void DeactivateEmployee(Employee e)
        {
           
           //Employee employee = employeeRepository.GetEmployee(e.Id);
            e.IsAccountActive = false;
            employeeRepository.Deactivation(e);
        }
        public void DeleteEmployee(Employee e) {
            employeeRepository.DeleteEmployee(e);
        }

        public List<Employee> GetAllWorkers()
        {
            return employeeRepository.GetWorkers();
        }

        public List<NationalityStatistics> GetNationalityStatistics()
        {
            return employeeRepository.GetNationalityStatistics();
        }

        public List<ContractStatistics> GetContractStatistics()
        {
            return employeeRepository.GetContractStatistics();
        }

        public double GetAverageSalary()
        {
            return employeeRepository.GetAverageSalary();
        }
    }
}
