using MediaBazaarProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Shifts ShiftType { get; set; }

        public Employee Employee { get; set; }

        public Shift()
        {
            Employee = new Employee();
        }
    }
}
