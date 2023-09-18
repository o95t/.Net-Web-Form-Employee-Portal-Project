using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
 public   class DepartmentsCollection:List<Departments>
    {
     public   DepartmentsCollection()
        {
            Departmentscs_DAL oDepartmentscs_DAL = new Departmentscs_DAL();
            fillList(oDepartmentscs_DAL.getDepartments());
        }
        private void fillList(SqlDataReader oSqlDataReader)
        {

            if (oSqlDataReader.HasRows)
            {
                while (oSqlDataReader.Read())
                {
                    Departments oDepartments = new Departments();
                    oDepartments.Dno = Convert.ToInt32(oSqlDataReader["DNO"]);
                    oDepartments.Name = Convert.ToString(oSqlDataReader["DEPT_NAME"]);
                    oDepartments.mgr_ssn = Convert.ToInt32(oSqlDataReader["MGR_SSN"]);
                    this.Add(oDepartments);
                }
            }

            oSqlDataReader.Close();
        }

    }
}
