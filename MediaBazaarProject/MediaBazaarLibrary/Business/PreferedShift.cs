﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary.Business
{
    public class PreferedShift
    {
        string status;
        public int EmployeeID { get; set; }
        public string RequestedDateDay { get; set; }
        public string Status 
        { 
            get { return status; } 
            set { status = "Pending"; } 
        }
    }
}
