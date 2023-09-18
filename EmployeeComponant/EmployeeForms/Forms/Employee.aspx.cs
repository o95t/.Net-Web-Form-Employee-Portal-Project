using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;


namespace EmployeeForms.Forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DepartmentsCollection oDepartmentsCollection = new DepartmentsCollection();
                ddlDepartments.DataSource = oDepartmentsCollection;
                ddlDepartments.DataValueField = "Dno";
                ddlDepartments.DataTextField = "Name";
                ddlDepartments.DataBind();


                Employee_Collection oEmployee_Collection = new Employee_Collection();
                gvEmployees.DataSource = oEmployee_Collection;
                gvEmployees.DataBind();

            }
        }

        protected void btnInsertEmployee_Click(object sender, EventArgs e)
        {

            Employee oEmployee = new Employee();
            oEmployee.Name = txtEmaployeeName.Text;
            oEmployee.Salary = Convert.ToInt32(txtSallary.Text);
            oEmployee.Password = txtPassWord.Text;
            oEmployee.Dno = Convert.ToInt32(ddlDepartments.SelectedValue);
            oEmployee.UserName = txtUserNmae.Text;
            if (btnInsertEmployee.Text== "Insert")
            {
                oEmployee.insert();
            }
            else
            {
                oEmployee.Ssn = Convert.ToInt32( gvEmployees.SelectedDataKey.Value);
                oEmployee.Update();
                btnInsertEmployee.Text = "Insert";
                btnDelete.Visible = false; 
            }

            Employee_Collection oEmployee_Collection = new Employee_Collection();
            gvEmployees.DataSource = oEmployee_Collection;
            gvEmployees.DataBind();
        }
        protected void DeletClick(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();
            oEmployee.Ssn = Convert.ToInt32(gvEmployees.SelectedDataKey.Value);
            oEmployee.Delete();

            Employee_Collection oEmployee_Collection = new Employee_Collection();
            gvEmployees.DataSource = oEmployee_Collection;
            gvEmployees.DataBind();
            btnInsertEmployee.Text = "Insert";
            btnDelete.Visible = false;
        }

            //protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
            //{
            //    if (e.Row.RowType == DataControlRowType.DataRow)
            //    {
            //        e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvEmployees, "Select$" + e.Row.RowIndex);
            //        e.Row.ToolTip = "Click to select this row.";
            //    }
            //}
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_Collection oEmployee_Collection = new Employee_Collection();
            Employee oEmployee =   oEmployee_Collection.Where(e13=>e13.Ssn== Convert.ToInt32(gvEmployees.SelectedDataKey.Value)).FirstOrDefault();
            txtEmaployeeName.Text = oEmployee.Name;
            txtPassWord.Text = oEmployee.Password;
            txtPassWordConfirm.Text = oEmployee.Password;
            txtUserNmae.Text = oEmployee.UserName;
            txtSallary.Text = oEmployee.Salary.ToString();
            ddlDepartments.SelectedValue = oEmployee.Dno.ToString();
            btnInsertEmployee.Text = "Update";
            btnDelete.Visible = true;
        }
    }


  
}