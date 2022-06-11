using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMModel
{
    public class ProjectEmployeeMap
    {
        public int ProID;
        public int EmpID;

        public ProjectEmployeeMap(int Pid, int Eid)
        {
            this.ProID = Pid;
            this.EmpID = Eid;
        }
        public ProjectEmployeeMap()
        {

        }
    }
}
