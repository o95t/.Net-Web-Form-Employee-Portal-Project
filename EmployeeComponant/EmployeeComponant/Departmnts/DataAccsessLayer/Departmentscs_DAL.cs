using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
  public  class Departmentscs_DAL
    {


        #region  Propritis
        string scon = ConfigurationManager.ConnectionStrings["TASKEntities"].ConnectionString;
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader oSqlDataReader;

        #endregion


        public void insert(Departments oDepartments)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("insert_DEPARTMNTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@p_DEPT_name", oDepartments.Name);
            com.Parameters.AddWithValue("@MGRSSN", oDepartments.mgr_ssn);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }



        public void Update(Departments oDepartments)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("UPDATE_DEPARTMNTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID", oDepartments.Dno);
            com.Parameters.AddWithValue("@p_DEPT_name", oDepartments.Name);
            com.Parameters.AddWithValue("@MGRSSN", oDepartments.mgr_ssn);
            
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Departments oDepartments)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("DELETE_DEPARTMNTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID", oDepartments.Dno);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader getDepartments()
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("GET_DEPARTMNTS", con);
            com.CommandType = CommandType.StoredProcedure;

            con.Open();
            oSqlDataReader= com.ExecuteReader(CommandBehavior.CloseConnection);

            return oSqlDataReader;
        }

    }
}
