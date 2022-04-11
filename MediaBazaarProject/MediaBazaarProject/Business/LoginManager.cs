using MediaBazaarProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    class LoginManager
    {
        private EmployeeRepository employeeRepository = new EmployeeRepository();

        public User Login(string email, string password)
        {
            User user = employeeRepository.FindUser(email, password);
            return user;
        }


    }
}
