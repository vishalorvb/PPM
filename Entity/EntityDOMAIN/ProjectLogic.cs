using EntityDAL;
using EntityMODAL;
using EntityUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDOMAIN
{
    public class ProjectLogic
    {
        ProjectUI projectui = new ProjectUI();
        ProjectDAL projectdal = new ProjectDAL();

        public void AddProject(Project pro)
        {
            int date = DateTime.Compare(pro.StartingDate, pro.EndingDate);
            if (date < 0)
            {
                if (projectdal.IsProjectIDExist(pro.ProjectId)) { projectui.IDError(); }
               else if (projectdal.IsProjectNameExist(pro.ProjectName)) { projectui.NameError(); }
                else { projectdal.AddProject(pro); }
                

            }
            else
            {

                projectui.DateError();
            }

        }
        public void DeleteProject(int pro)
        {
            List<Project> projects = projectdal.ViewProjects();
            
            foreach (Project p in projects)
            {
                if (p.ProjectId == pro)
                {
                    projectdal.DeleteProject(p);
                }
            }
           
        }
        public void AddEmployeeToProject(int ProjectID,Employee emp)
        {
            if (projectdal.IsProjectIDExist(ProjectID))
            {
                projectdal.AddEmployeeToProject(ProjectID, emp);
            }
            else
            {
                projectui.IDError();
            }
        }
        public void ViewProject()
        {
            projectui.PrintProject(projectdal.ViewProjects());
        }
    }
}
