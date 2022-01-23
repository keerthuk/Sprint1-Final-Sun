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
    public partial class New_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Adding Project Details
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            AdminDataConnection AdminDBObj = new AdminDataConnection();
            ProjectDetails ProjectDetailsObj = new ProjectDetails();

            ProjectDetailsObj.ProjectId = Convert.ToInt32(txtProjectId.Text);
            ProjectDetailsObj.ProjectName = txtProjectName.Text;
            ProjectDetailsObj.StartDate = Convert.ToDateTime(txtStartDate.Text);
            ProjectDetailsObj.EndDate = Convert.ToDateTime(txtenddate.Text);
            ProjectDetailsObj.is_active = txtIsActive.Text;


            string msg = AdminDBObj.InsertProject(ProjectDetailsObj);
            Label1.Text = msg;

            AdminDataConnection AdminDbObj = new AdminDataConnection();
            DataTable dtResult = AdminDbObj.DisplayProjectDetails();
            GridViewProject.DataSource = dtResult;
            GridViewProject.DataBind();


        }
    }
}