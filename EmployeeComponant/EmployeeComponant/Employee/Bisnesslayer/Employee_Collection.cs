using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EmployeeComponant
{
  public  class Employee_Collection:List<Employee>
    {

     public   Employee_Collection()
        {
            Emploee_DAL oEmploee_DAL = new Emploee_DAL();
            fillList(oEmploee_DAL.getEmployess());
        }
        private void fillList(SqlDataReader oSqlDataReader)
        {
            
            if (oSqlDataReader.HasRows)
            {
                while (oSqlDataReader.Read())
                {

                    Employee oEmployee = new Employee();

                    oEmployee.Ssn =Convert.ToInt32( oSqlDataReader["SSN"]);
                    oEmployee.Name = Convert.ToString(oSqlDataReader["NAME"]);
                    oEmployee.UserName = Convert.ToString(oSqlDataReader["USERNAME"]);
                    oEmployee.Password = Convert.ToString(oSqlDataReader["PASSWORD"]);
                    oEmployee.Salary = Convert.ToInt32(oSqlDataReader["SALARY"]);
                    oEmployee.Dno = Convert.ToInt32(oSqlDataReader["DNO"]);

                    this.Add(oEmployee);
                }
            }

            oSqlDataReader.Close();
        }
    }
}
