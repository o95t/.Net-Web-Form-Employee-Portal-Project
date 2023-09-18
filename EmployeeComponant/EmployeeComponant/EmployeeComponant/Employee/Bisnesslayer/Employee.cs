using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{ 
   public class Employee
    {
        public int Ssn { set; get; }
        public string Name { set; get; }
        public string UserName { set; get; }
        public string  Password { set; get; }
        public int Salary { set; get; }
        public int  Dno { set; get; }


    public void insert()
    {
            Emploee_DAL oEmploee_DAL = new Emploee_DAL();
            oEmploee_DAL.insert(this);
    }



    public void Update()
    {
            Emploee_DAL oEmploee_DAL = new Emploee_DAL();
            oEmploee_DAL.Update(this);
   }

    public void Delete()
    {
            Emploee_DAL oEmploee_DAL = new Emploee_DAL();
            oEmploee_DAL.Delete(this);

    }
}






}
