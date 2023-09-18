using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;


namespace EmployeeForms.Forms
{
    public partial class Hours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                HoursCollection oHoursCollection = new HoursCollection();
                gvHours.DataSource = oHoursCollection;
                gvHours.DataBind();

                Employee_Collection oEmployee_Collection = new Employee_Collection();
                ddlEmployee.DataSource = oEmployee_Collection;
                ddlEmployee.DataValueField = "SSN";
                ddlEmployee.DataTextField = "NAME";
                ddlEmployee.DataBind();

                Projcts_Collection oProjcts_Collection = new Projcts_Collection();
                ddlProj.DataSource = oProjcts_Collection;
                ddlProj.DataValueField = "PNO";
                ddlProj.DataTextField = "PROJ_NAME";
                ddlProj.DataBind();

            }
        }

        protected void btnInsertHours_Click(object sender, EventArgs e)
        {
            HoursLog oHours = new HoursLog();
            oHours.SSN = Convert.ToInt32(ddlEmployee.SelectedValue);
            oHours.PNO = Convert.ToInt32(ddlProj.SelectedValue);
            oHours.HOURS = Convert.ToInt32(txtHours.Text);

            if (btnInsertHours.Text == "Insert")
            {
                oHours.insert();
            }
            else
            {
                oHours.PNO = Convert.ToInt32(gvHours.SelectedDataKey.Value);
                oHours.SSN = Convert.ToInt32(ddlEmployee.SelectedValue);
                oHours.PNO = Convert.ToInt32(ddlProj.SelectedValue);
                oHours.Update();
                btnInsertHours.Text = "Insert";
                btnDel.Visible = false;
            }

            HoursCollection oHoursCollection = new HoursCollection();
            gvHours.DataSource = oHoursCollection;
            gvHours.DataBind();




        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            HoursLog oHours = new HoursLog();
            oHours.SSN = Convert.ToInt32(ddlEmployee.SelectedValue);
            oHours.PNO = Convert.ToInt32(ddlProj.SelectedValue);
            oHours.Delete();
            btnInsertHours.Text = "Insert";
            btnDel.Visible = false;

            HoursCollection oHoursCollection = new HoursCollection();
            gvHours.DataSource = oHoursCollection;
            gvHours.DataBind();

        }

        protected void gvHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoursCollection oHoursCollection = new HoursCollection();

            
            HoursLog oHours = oHoursCollection.Where(e12 => e12.PNO == Convert.ToInt32(gvHours.SelectedDataKey.Value)  && e12.SSN== Convert.ToInt32( gvHours.Rows[gvHours.SelectedIndex].Cells[1].Text)).FirstOrDefault();
            ddlProj.SelectedValue = oHours.PNO.ToString();
            ddlEmployee.SelectedValue = oHours.SSN.ToString();
            txtHours.Text = oHours.HOURS.ToString();
            btnInsertHours.Text= "Update";
            btnDel.Visible = true;

           
        }
    }
}