using PPMDAL;
using PPMModel;
using PPMUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDomain2
{
    public class ProjectLogic
    {
        ProjectDAL projectdal = new ProjectDAL();
        ProjectUI projectui = new ProjectUI();

        public void AddProject(Project pro)
        {
            int date = DateTime.Compare(pro.StartingDate, pro.EndingDate);
            if (date < 0)
            {
                if (projectdal.IsProjectIdExist(pro.ProjectId)) 
                {
                    projectui.ProjectIDError();
                }
                else
                {
                    projectdal.InsertProject(pro);
                }

            }
            else
            {

                projectui.DateError();
            }
        }
        public void DeleteProject(int PID)
        {
            projectdal.DeleteProject(PID);
        }
        public void ViewProject()
        {
             projectui.ViewProject(projectdal.ViewProject());
        }
    }
}
