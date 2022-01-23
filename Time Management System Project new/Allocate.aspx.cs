using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Time_Management_System_Project.DataConnection;

namespace Time_Management_System_Project
{
    public partial class Allocate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Allocating Employee to the Project
        protected void AllocateEmp_Click(object sender, EventArgs e)
        {
            AdminDataConnection AdminDBObj = new AdminDataConnection();
            EmployeeProjectLookUp EmpProObj = new EmployeeProjectLookUp();

            EmpProObj.emp_project_id = Convert.ToInt32(txtEmpProjectId.Text);
            EmpProObj.emp_id = Convert.ToInt32(txtEmployeeId.Text);
            EmpProObj.project_id = Convert.ToInt32(txtProjectId.Text);

            string msg = AdminDBObj.Allocate(EmpProObj);
            lblAllocate.Text = msg;
        }
    }
}