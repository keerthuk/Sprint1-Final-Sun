using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Time_Management_System_Project.DataConnection;

namespace Time_Management_System_Project
{
    public partial class UpdateEmployeeDetails : System.Web.UI.Page
    {
        // Displaying Employee Details
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminDataConnection adminDataObj = new AdminDataConnection();
            DataTable dtResult = adminDataObj.EmployeeDetails();
            GridViewUpdate.DataSource = dtResult;
            GridViewUpdate.DataBind();
        }

        // Updating the Employee Details
        protected void update_Click(object sender, EventArgs e)
        {
            AdminDataConnection adminDbObj = new AdminDataConnection();
            EmployeeDetails empObj = new EmployeeDetails();

            empObj.emp_id = Convert.ToInt32(txtEmpid.Text);
            empObj.mail_id = txtMailId.Text;

            string msg = adminDbObj.UpdateEmployee(empObj);
            lblUpdate.Text = msg;

            
        }
    }
}