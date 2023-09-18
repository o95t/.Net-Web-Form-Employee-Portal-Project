using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;

namespace EmployeeForms.Forms
{
    public partial class InsertDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Employee_Collection oEmployee_Collection = new Employee_Collection();

                ddlmanger.DataSource = oEmployee_Collection;
                ddlmanger.DataValueField = "SSN";
                ddlmanger.DataTextField = "NAME";
                ddlmanger.DataBind();
            }


        }

        protected void btnInsertDepartment_Click(object sender, EventArgs e)
        {
            Departments oDepartments = new Departments();
            oDepartments.mgr_ssn = Convert.ToInt32( ddlmanger.SelectedValue);
            oDepartments.Name = txtDepName.Text;
            oDepartments.insert();


        }
    }
}