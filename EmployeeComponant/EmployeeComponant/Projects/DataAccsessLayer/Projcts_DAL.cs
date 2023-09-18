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
    public class Projcts_DAL
    {


        #region  Propritis
        string scon = ConfigurationManager.ConnectionStrings["TASKEntities"].ConnectionString;
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader oSqlDataReader;

        #endregion


        public void insert(Projcts oProjcts)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("insert_PROJECTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LOCATION", oProjcts.LOCATION);
            com.Parameters.AddWithValue("@PROJECNAME", oProjcts.PROJ_NAME);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }



        public void Update(Projcts oProjcts)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("UPDATE_PROJECTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID", oProjcts.PNO);
            com.Parameters.AddWithValue("@P_LOCATION", oProjcts.LOCATION);
            com.Parameters.AddWithValue("@P_PROJ_NAME", oProjcts.PROJ_NAME);
            
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Projcts oProjcts)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("DELETE_PROJECTS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID", oProjcts.PNO);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader getProjcts()
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("GET_PROJECTS", con);
            com.CommandType = CommandType.StoredProcedure;

            con.Open();
            oSqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection);

            return oSqlDataReader;
        }

    }
}
