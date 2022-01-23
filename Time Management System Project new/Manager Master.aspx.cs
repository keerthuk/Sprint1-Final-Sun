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
    public partial class Manager_Master : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        // View Employee TimeSheet
        protected void ViewingTimeSheet_Click(object sender, EventArgs e)
        {
            AdminDataConnection adminDataObj = new AdminDataConnection();
            DataTable dtResult1 = adminDataObj.SelectManagerTimeSheet();
            GridViewManagerTimeSheet.DataSource = dtResult1;
            GridViewManagerTimeSheet.DataBind();
        }

        protected void ReleaseEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Release.aspx");
        }

        protected void AllocateProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("Allocate.aspx");

        }

        protected void update_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateEmployeeDetails.aspx");

        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("Change Password.aspx");

        }
    }
}