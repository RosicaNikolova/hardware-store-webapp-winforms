﻿using MediaBazaarProject.Persistence;
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
            return employeeRepository.GetEmployeeByBSNProtected(e.Bsn1);
        }
        public Employee GetEmployeeByID(Employee e)
        {
            return employeeRepository.GetEmployeeByID(e.Id);
        }
        public void CreateEmployee(string firstName, string lastName, int age, string email, string password, string address, string nationality, double salary, double phoneNumber, string gender, int BSN, bool permanentContract, int position, bool isAccountActive, bool covidVaccinated) {
            Employee employee = employeeRepository.GetEmployeeByBSNProtected(BSN);
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
            
        }

        public List<Employee> GetAllWorkers()
        {
            return employeeRepository.GetWorkers();
        }


    }
}
