using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeComponant;

namespace EmployeeForms.Forms
{
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Projcts_Collection oProjcts_Collection = new Projcts_Collection();
                gvProj.DataSource = oProjcts_Collection;
                gvProj.DataBind();

               
            }


        }

        protected void btnInsertProj_Click(object sender, EventArgs e)
        {
            Projcts oProjcts = new Projcts();
            oProjcts.PROJ_NAME = txtProjName.Text;
            oProjcts.LOCATION = txtProjLoc.Text;
            if(btnInsertProj.Text== "Insert")
            {
                oProjcts.insert();
            }
            else
            {
                oProjcts.PNO = Convert.ToInt32(gvProj.SelectedDataKey.Value);
                oProjcts.Update();
                btnInsertProj.Text = "Insert";
                btnDel.Visible = false;
            }

            Projcts_Collection oProjcts_Collection = new Projcts_Collection();
            gvProj.DataSource = oProjcts_Collection;
            gvProj.DataBind();

        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            Projcts oProjcts = new Projcts();
            oProjcts.PNO = Convert.ToInt32(gvProj.SelectedPersistedDataKey.Value);
            oProjcts.Delete();

            Projcts_Collection oProjcts_Collection = new Projcts_Collection();
            gvProj.DataSource = oProjcts_Collection;
            gvProj.DataBind();
            btnInsertProj.Text = "Insert";
            btnDel.Visible = false;


        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            Projcts_Collection oProjcts_Collection = new Projcts_Collection();
            Projcts oProjcts = oProjcts_Collection.Where(e12 => e12.PNO == Convert.ToInt32(gvProj.SelectedDataKey.Value)).FirstOrDefault();
            txtProjLoc.Text = oProjcts.LOCATION.ToString();
            txtProjName.Text = oProjcts.PROJ_NAME.ToString();
            btnInsertProj.Text = "Update";
            btnDel.Visible = true;


        }
    }
}