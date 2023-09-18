using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
    public class Projcts_Collection : List<Projcts>
    {
        public Projcts_Collection()
        {
            Projcts_DAL oProjcts_DAL = new Projcts_DAL();
            fillList(oProjcts_DAL.getProjcts());
        }
        private void fillList(SqlDataReader oSqlDataReader)
        {

            if (oSqlDataReader.HasRows)
            {
                while (oSqlDataReader.Read())
                {
                    Projcts oProjcts = new Projcts();
                    oProjcts.PNO = Convert.ToInt32(oSqlDataReader["PNO"]);
                    oProjcts.LOCATION = Convert.ToString(oSqlDataReader["LOCATION"]);
                    oProjcts.PROJ_NAME = Convert.ToString(oSqlDataReader["PROJ_NAME"]);
                    this.Add(oProjcts);
                }
            }

            oSqlDataReader.Close();
        }


    }
}
