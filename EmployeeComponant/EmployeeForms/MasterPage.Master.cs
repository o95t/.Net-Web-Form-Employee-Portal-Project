using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;
namespace EmployeeForms
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LogedInUserName"]==null)
            {
                Response.Redirect(@"LogIn.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["LogedInUserName"] = null;
            Response.Redirect(@"LogIn.aspx");
        }
    }
}