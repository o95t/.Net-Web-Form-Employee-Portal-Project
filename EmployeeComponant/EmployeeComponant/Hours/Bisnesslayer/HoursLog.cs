using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
    public class HoursLog
    {
        public int SSN { set; get; }
        public int PNO { set; get; }
        public int HOURS { set; get; }

        public String EmpNAME { set; get; }
        public String PROJ_NAME { set; get; }

        public void insert()
        {
            Hours_DAL oHours_DAL = new Hours_DAL();
            oHours_DAL.insert(this);
        }



        public void Update()
        {
            Hours_DAL oHours_DAL = new Hours_DAL();
            oHours_DAL.Update(this);
        }

        public void Delete()
        {
            Hours_DAL oHours_DAL = new Hours_DAL();
            oHours_DAL.Delete(this);
        }

    }
}
