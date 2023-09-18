using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
    public class HoursCollection:List<HoursLog>
    { 

    public    HoursCollection()
            {
            Hours_DAL oHours_DAL = new Hours_DAL();
                fillList(oHours_DAL.GET_HOURS());
            }

            private void fillList(SqlDataReader oSqlDataReader)
            {

                if (oSqlDataReader.HasRows)
                {
                    while (oSqlDataReader.Read())
                    {
                    HoursLog oHours = new HoursLog();
                    oHours.SSN = Convert.ToInt32(oSqlDataReader["SSN"]);
                    oHours.PNO = Convert.ToInt32(oSqlDataReader["PNO"]);
                    oHours.HOURS = Convert.ToInt32(oSqlDataReader["HOURS"]);
                    oHours.EmpNAME = Convert.ToString(oSqlDataReader["NAME"]);
                    oHours.PROJ_NAME = Convert.ToString(oSqlDataReader["PROJ_NAME"]);
                    this.Add(oHours);
                    }
                }

                oSqlDataReader.Close();
            }


        }
    }
