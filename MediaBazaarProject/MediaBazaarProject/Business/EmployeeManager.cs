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

        /*public Employee CreateEmployee(string email, string password) {
            
        }
        public void UpdateEmployee(Employee e) {
            
        }
        public void DeactivateEmployee(Employee e)
        {

        }
        public void DeleteEmployee(Employee e) {
            
        }*/
    }
}
