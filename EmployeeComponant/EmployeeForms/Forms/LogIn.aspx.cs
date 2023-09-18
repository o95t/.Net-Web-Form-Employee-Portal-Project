using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;


namespace EmployeeForms.Forms
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            
                Employee oEmployee = new Employee();
                oEmployee.UserName = txtUserName.Text;
                oEmployee.Password = txtpass.Text;
                if (oEmployee.Logn())
                {
                    LogInValidation.IsValid = true;
                    Session["LogedInUserName"] = txtUserName.Text;
                    Response.Redirect(@"Employee.aspx");
                }
                else
                {
                    LogInValidation.IsValid = false;
                    LogInValidation.ErrorMessage = "User Name Or Password Is Incorrect!";
                    LogInValidation.ForeColor = System.Drawing.Color.Red;
                }
        }
    }
}