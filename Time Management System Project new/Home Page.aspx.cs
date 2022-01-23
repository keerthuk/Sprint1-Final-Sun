using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Time_Management_System_Project.DataConnection;

namespace Time_Management_System_Project
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Login Page 
        protected void Login_Click(object sender, EventArgs e)
        {
            AdminDataConnection AdminDbObj = new AdminDataConnection();
            EmployeeDetails EmpObj = new EmployeeDetails();
      
            EmpObj.emp_id = Convert.ToInt32(textUserId.Text);
            EmpObj.password = textPassword.Text;

            EmployeeDetails response = AdminDbObj.LoginPage(EmpObj);

           if (response == null)
           {
                title.Text = "Your username or password is incorrect";
                subTitle.ForeColor = System.Drawing.Color.Red;
           }
           else
           {
                if (response.is_admin.Equals("yes"))
                {
                    Response.Redirect("Admin.aspx");

                }
                else if (response.is_manager.Equals("yes"))
                {
                    Response.Redirect("Manager Master.aspx");
                }
                else
                {
                    Response.Redirect("Manager Master.aspx");
                }
           }
        }
    }
}