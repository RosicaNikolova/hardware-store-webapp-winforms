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

                    if (user == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return user;
                    }            
        }

        public Position SetPosition(int position)
        {
            Position setPosition = Position.WORKER;

            switch (position)
            {
                case 0: setPosition = Position.ADMIN;
                    break;

                case 1: setPosition = Position.MANAGER;
                    break;

                case 2: setPosition = Position.WORKER;
                    break;
                

            }
            return setPosition;
                
        }
    }
}
