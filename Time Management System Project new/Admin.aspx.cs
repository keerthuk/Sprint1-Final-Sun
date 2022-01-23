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
    public partial class Admin : System.Web.UI.Page
    {
        // After Admin logged In, Page_Load function will display the Admin Timesheet
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminDataConnection AdminDbObj = new AdminDataConnection();
            DataTable dtResult = AdminDbObj.SelectAdminTimeSheet();
            GridViewAdmin.DataSource = dtResult;
            GridViewAdmin.DataBind();
        }

        // NewProject_Click will Redirect to the Project.aspx file
        protected void NewProject_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("New Project.aspx");
        }
    }
}