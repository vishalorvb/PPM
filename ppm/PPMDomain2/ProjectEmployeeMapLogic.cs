using PPMDAL;
using PPMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDomain2
{
    public class ProjectEmployeeMapLogic
    {
        ProjectEmployeeMapDAL projectdal = new ProjectEmployeeMapDAL();
        public void AddEmployeeToProject(ProjectEmployeeMap Maps)
        {
            projectdal.InsertProjectEmployeeMap(Maps);
        }
        public void DeleteEmployeeFromProject(int EID)
        {
            projectdal.DeleteEmployeeFromProject(EID);
        }
    }
}
