using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMModel
{
    public class Project
    {
        public int ProjectId;
        public string ProjectName;
        public DateTime StartingDate;
        public DateTime EndingDate;


        public Project(int pid, String pname, DateTime sdate, DateTime Edate)
        {

            this.ProjectId = pid;


            this.ProjectName = pname;


            this.StartingDate = sdate;


            this.EndingDate = Edate;

        }
        public Project()
        {

        }
    }
}
