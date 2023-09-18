using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponant
{
    public class Projcts
    {
        public int PNO { set; get; }
        public string LOCATION { set; get; }
        public string PROJ_NAME{ set; get; }


        public void insert()
        {
            Projcts_DAL oProjcts_DAL = new Projcts_DAL();
            oProjcts_DAL.insert(this);
        }



        public void Update()
        {
            Projcts_DAL oProjcts_DAL = new Projcts_DAL();
            oProjcts_DAL.Update(this);
        }

        public void Delete()
        {
            Projcts_DAL oProjcts_DAL = new Projcts_DAL();
            oProjcts_DAL.Delete(this);
        }

    }
}
