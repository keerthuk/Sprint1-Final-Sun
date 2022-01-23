using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_Management_System_Project.DataConnection
{
    public class ProjectDetails
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string is_active { get; set; }

    }
}