using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
    public   class Departments
    {
        public int Dno { set; get; }
        public string Name { set; get; }
        public int  mgr_ssn { set; get; }


        public void insert()
        {
            Departmentscs_DAL oDepartmentscs_DAL = new Departmentscs_DAL();
            oDepartmentscs_DAL.insert(this);
        }



        public void Update()
        {
            Departmentscs_DAL oDepartmentscs_DAL = new Departmentscs_DAL();
            oDepartmentscs_DAL.Update(this);
        }

        public void Delete()
        {
            Departmentscs_DAL oDepartmentscs_DAL = new Departmentscs_DAL();
            oDepartmentscs_DAL.Delete(this);
        }

    }
}
