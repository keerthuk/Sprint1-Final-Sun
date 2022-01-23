using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Time_Management_System_Project.DataConnection;

namespace Time_Management_System_Project
{
    public partial class Release : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Releasing the Employee From the Project
        protected void releaseEmployee_Click(object sender, EventArgs e)
        {
           AdminDataConnection AdminDBObj = new AdminDataConnection();
           EmployeeProjectLookUp EmpProObj = new EmployeeProjectLookUp();

            EmpProObj.emp_id = Convert.ToInt32(txtEmpid.Text);
            EmpProObj.project_id = Convert.ToInt32(txtProjid.Text);

           string msg = AdminDBObj.DeleteEmployeeById(EmpProObj);
           LabelRelease.Text = msg;

        }
    }
}