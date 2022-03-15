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
        private double salary;
        private long phoneNumber;
        private string gender;
        private int Bsn;
        private bool permanentContract;
        private Position position;
        private bool isAccountActive;
        private bool covidVaccinated;
        static int id = 0;

        public Employee(string firstName, string lastName, int age, string email, string address, string nationality, string password, double wage, long phoneNumber, string gender, int BSN, bool permanentContract, Position position, bool isAccountActive, bool covidVaccinated)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = age;
            this.Email = email;
            this.Address = address;
            this.Nationality = nationality;
            this.Password = password;
            this.Salary = wage;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
            this.Bsn1 = BSN;
            this.PermanentContract = permanentContract;
            this.Position = position;
            this.IsAccountActive = isAccountActive;
            this.CovidVaccinated = covidVaccinated;
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
        public bool IsAccountActive { get; set; }
        public int Age { get; set ; }
        public string Email { get; set; }
        public string Address { get; set ; }
        public string Nationality { get; set ; }
        public string Password { get; set; }
        public double Salary { get ; set ; }
        public long PhoneNumber { get ; set ; }
        public string Gender { get ; set ; }
        public bool PermanentContract { get ; set; }
        public Position Position { get ; set; }
        public bool CovidVaccinated { get ; set; }
        public int Bsn1 { get => Bsn; set => Bsn = value; }

        public override string ToString()
        {
            string s = $"{this.FirstName} {this.LastName}";
            return s;
        }
    }
    
}
