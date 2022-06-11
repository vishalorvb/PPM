using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMODAL
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
       public  String ProjectName { get; set; }
        public DateTime StartingDate { get; set; }
        
        public DateTime EndingDate { get; set; }

        public List<Employee> Employees { get; set; }
        public Project(int pid, String pname, DateTime sdate, DateTime Edate)
        {

            this.ProjectId = pid;


            this.ProjectName = pname;


            this.StartingDate = sdate;


            this.EndingDate = Edate;

        }
    }
}
