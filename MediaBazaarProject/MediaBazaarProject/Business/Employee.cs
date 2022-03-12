using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject.Business
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string address;
        private string nationality;
        private string password;
        private double wage;
        private long phoneNumber;
        private string gender;
        private int BSN;
        private bool permanentContract;
        private Position position;
        private bool isAccountActive;
        private bool covidVaccinated;
        static int id = 0;

        public Employee(string firstName, string lastName, int age, string email, string address, string nationality, string password, double wage, long phoneNumber, string gender, int BSN, bool permanentContract, Position position, bool isAccountActive, bool covidVaccinated)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            this.address = address;
            this.nationality = nationality;
            this.password = password;
            this.wage = wage;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.BSN = BSN;
            this.permanentContract = permanentContract;
            this.position = position;
            this.isAccountActive = isAccountActive;
            this.covidVaccinated = covidVaccinated;
            id++;
        }

        public Employee()
        {

        }

        public Employee(int e, string v)
        {
            
        }

        public int Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
    }
}
