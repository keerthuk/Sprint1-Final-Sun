using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Time_Management_System_Project.DataConnection
{
    public class AdminDataConnection
    {
        string sqlConnectionStr = "Data Source=GOKUL-NOTEBOOK;Initial Catalog=TMS DB;Integrated Security=True";

        // SQL Connection for Login page 
        public EmployeeDetails LoginPage(EmployeeDetails empObj)
        {
            EmployeeDetails employeeResponse = null;

            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("SELECT emp_id,emp_name,is_manager,is_admin FROM employee WHERE emp_id =" + empObj.emp_id + "AND password ='" + empObj.password +"'", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                employeeResponse = new EmployeeDetails();
                while (sqlDataReader.Read())
                {
                    employeeResponse.emp_id = Convert.ToInt32(sqlDataReader["emp_id"]);
                    employeeResponse.emp_name = sqlDataReader["emp_name"].ToString();
                    employeeResponse.is_manager = sqlDataReader["is_manager"].ToString();
                    employeeResponse.is_admin = sqlDataReader["is_admin"].ToString();
                }
            }
            return employeeResponse;
        }
        public DataTable DisplayProjectDetails()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("SELECT * FROM project", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dtProject = new DataTable();
            dtProject.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dtProject;
        }

        // SQL Connection for Adding the new Project
        public string InsertProject(ProjectDetails projectDetailsObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Project values(" + projectDetailsObj.ProjectId + ",'" + projectDetailsObj.ProjectName + "','" + projectDetailsObj.StartDate + "','" + projectDetailsObj.EndDate + "','" + projectDetailsObj.is_active + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Project Details Added Successfully";
        }

        // SQL Connection for Admin TimeSheet (Project Details)
        public DataTable SelectAdminTimeSheet()
        {
             SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
             SqlCommand sqlCommandObj = new SqlCommand("select p.project_id, p.project_name, p.isactive, t.timesheet_id, h.Date, h.hours_logged FROM project p INNER JOIN emp_project_lookup ep ON p.project_id = ep.project_id INNER JOIN timesheet t ON ep.emp_project_id = t.emp_project_id INNER JOIN hours h ON t.timesheet_id = h.timesheet_id", sqlConnectionObj);
             sqlConnectionObj.Open();
             SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(sqlDataReader);
             sqlConnectionObj.Close();
             return dt;
        }
        // SQL Connection for Manager TimeSheet (Employee Details)
        public DataTable SelectManagerTimeSheet()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("SELECT e.emp_id,e.emp_name,p.project_id,h.date, h.hours_logged FROM employee e INNER JOIN emp_project_lookup ep ON e.emp_id = ep.emp_id INNER JOIN project p ON ep.project_id = p.project_id INNER JOIN timesheet t ON ep.emp_project_id = t.emp_project_id INNER JOIN hours h ON t.timesheet_id = h.timesheet_id", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader1 = sqlCommandObj.ExecuteReader();
            DataTable dtManager = new DataTable();
            dtManager.Load(sqlDataReader1);
            sqlConnectionObj.Close();
            return dtManager;
        }

        // SQL Connection for Allocating the Project to the Employee
        public string Allocate (EmployeeProjectLookUp empProObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into emp_project_lookup values(" + empProObj.emp_project_id + "," + empProObj.emp_id + "," + empProObj.project_id + ")",sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Project Allocated Successfully";
        }
        // SQL Connection for Updating the Employee Details
        public string UpdateEmployee(EmployeeDetails empObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("UPDATE employee SET mail_id ='"+ empObj.mail_id+"' WHERE emp_id ="+empObj.emp_id+ "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Employee Details Updated Successfully";
        }
        // Displaying the Updated Employee Table 
        public DataTable EmployeeDetails()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("SELECT * FROM employee", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dtEmployee = new DataTable();
            dtEmployee.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dtEmployee;
        }

        // SQL Connection for Changing the Password for Employee 
        public string ChangePassword(EmployeeDetails empObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("UPDATE employee SET password ='" + empObj.password + "' WHERE emp_id =" + empObj.emp_id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Password Changed Successfully";

        }

        // Releasing the Employee from the Project 
        public string DeleteEmployeeById(EmployeeProjectLookUp empProObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from emp_project_lookup  where emp_id=" + empProObj.emp_id+ "AND project_id="+ empProObj.project_id+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Employee Released";
        } 
    }
}