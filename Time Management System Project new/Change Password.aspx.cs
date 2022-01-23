using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Time_Management_System_Project.DataConnection;

namespace Time_Management_System_Project
{
    public partial class Change_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Changing Employee Password
        protected void submit_Click(object sender, EventArgs e)
        {
            AdminDataConnection AdminDbObj = new AdminDataConnection();
            EmployeeDetails EmpObj = new EmployeeDetails();
            if(txtConfirmPassword.Text == txtNewPassword.Text)
            {
                EmpObj.password = txtConfirmPassword.Text;
                string msg = AdminDbObj.ChangePassword(EmpObj);
                lblChangePassword.Text = msg;
            }else
            {
                lblChangePassword.Text = "New Password and Confirm Password is Mismatched";
                lblChangePassword.ForeColor = System.Drawing.Color.Red;
            }
            

        }
    }
}