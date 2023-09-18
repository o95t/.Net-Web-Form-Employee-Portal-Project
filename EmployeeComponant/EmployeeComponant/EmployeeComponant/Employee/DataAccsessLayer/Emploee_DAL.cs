using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace EmployeeComponant
{
   public class Emploee_DAL
    {


        #region  Propritis
        string scon = ConfigurationManager.ConnectionStrings["TASKEntities"].ConnectionString;
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader oSqlDataReader;

        #endregion


        public void insert(Employee oEmployee)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("insert_employee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@p_name", oEmployee.Name);
            com.Parameters.AddWithValue("@usernaem", oEmployee.UserName);
            com.Parameters.AddWithValue("@p_Password", oEmployee.Password);
            com.Parameters.AddWithValue("@p_salary", oEmployee.Salary);
            com.Parameters.AddWithValue("@p_Dno", oEmployee.Dno);


            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }



        public void Update(Employee oEmployee)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("Update_employee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@P_SSN", oEmployee.Ssn);
            com.Parameters.AddWithValue("@p_name", oEmployee.Name);
            com.Parameters.AddWithValue("@usernaem", oEmployee.UserName);
            com.Parameters.AddWithValue("@p_Password", oEmployee.Password);
            com.Parameters.AddWithValue("@p_salary", oEmployee.Salary);
            com.Parameters.AddWithValue("@p_Dno", oEmployee.Dno);


            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Employee oEmployee)
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("DELETE_employee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@P_SSN", oEmployee.Ssn);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader getEmployess()
        {
            con = new SqlConnection(scon);
            com = new SqlCommand("GET_employee", con);
            com.CommandType = CommandType.StoredProcedure;
            //  SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter("GET_employee", con);
            con.Open();
            //oSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            oSqlDataReader = com.ExecuteReader(CommandBehavior.CloseConnection);
            
            return oSqlDataReader;
        }
    }


}

