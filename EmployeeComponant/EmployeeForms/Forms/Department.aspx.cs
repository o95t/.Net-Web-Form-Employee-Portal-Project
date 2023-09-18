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

                DepartmentsCollection oDepartmentsCollection = new DepartmentsCollection();
                gvDepartment.DataSource = oDepartmentsCollection;
                gvDepartment.DataBind();

              

            }


        }

        protected void btnInsertDepartment_Click(object sender, EventArgs e)
        {
            Departments oDepartments = new Departments();
            oDepartments.mgr_ssn = Convert.ToInt32( ddlmanger.SelectedValue);
            oDepartments.Name = txtDepName.Text;
            

            if (btnInsertDepartment.Text == "Insert")
            {
                oDepartments.insert();
            }
            else
            {
                oDepartments.mgr_ssn = Convert.ToInt32(gvDepartment.SelectedDataKey.Value);
                oDepartments.Update();
                btnInsertDepartment.Text = "Insert";
                btnDelete.Visible = false;
            }

            DepartmentsCollection oDepartmentsCollection = new DepartmentsCollection();
            gvDepartment.DataSource = oDepartmentsCollection;
            gvDepartment.DataBind();


        }
        protected void DeletDept(object sender, EventArgs e)
        {
            Departments oDepartments = new Departments();
            oDepartments.mgr_ssn = Convert.ToInt32(gvDepartment.SelectedDataKey.Value);
            oDepartments.Delete();

            DepartmentsCollection oDepartmentsCollection = new DepartmentsCollection();
            gvDepartment.DataSource = oDepartmentsCollection;
            gvDepartment.DataBind();
            btnInsertDepartment.Text = "Insert";
            btnDelete.Visible = false;
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            DepartmentsCollection oDepartmentsCollection = new DepartmentsCollection();
            Departments oDepartments = oDepartmentsCollection.Where(e12 =>e12.Dno == Convert.ToInt32(gvDepartment.SelectedDataKey.Value)).FirstOrDefault();
            txtDepName.Text = oDepartments.Name.ToString();
            ddlmanger.SelectedValue = oDepartments.mgr_ssn.ToString();
            btnInsertDepartment.Text = "Update";
            btnDelete.Visible = true;
            
        }

        
    }
}