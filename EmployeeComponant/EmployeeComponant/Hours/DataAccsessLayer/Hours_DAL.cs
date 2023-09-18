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
    class Hours_DAL
    {

        #region  Propritis
        string scon = ConfigurationManager.ConnectionStrings["TASKEntities"].ConnectionString;
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader oSqlDataReader;

        #endregion


        public void insert(HoursLog oHours)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("insert_HOURS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SSN", oHours.SSN);
            com.Parameters.AddWithValue("@PNO", oHours.PNO);
            com.Parameters.AddWithValue("@HOURS", oHours.HOURS);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }



        public void Update(HoursLog oHours)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("UPDATE_HOURS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SSN", oHours.SSN);
            com.Parameters.AddWithValue("@PNO", oHours.PNO);
            com.Parameters.AddWithValue("@HOURS", oHours.HOURS);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(HoursLog oHours)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("DELETE_HOURS", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SSN", oHours.SSN);
            com.Parameters.AddWithValue("@PNO", oHours.PNO);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader GET_HOURS()
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("GET_HOURS", con);
            com.CommandType = CommandType.StoredProcedure;

            con.Open();
            oSqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection);

            return oSqlDataReader;
        }





    }
}
