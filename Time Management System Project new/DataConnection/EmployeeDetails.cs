using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_Management_System_Project.DataConnection
{
    public class EmployeeDetails
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string mail_id { get; set; }
        public string joining_date { get; set; }
        public string is_manager { get; set; } 
        public string is_admin{ get; set; }
        public string password{ get; set; }

    }
}