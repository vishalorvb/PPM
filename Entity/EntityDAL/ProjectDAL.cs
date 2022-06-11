using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class ProjectDAL
    {
        EntityDbcontext context = new EntityDbcontext();
        
        public void AddProject(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
        }
        public void DeleteProject(Project project)
        {
            context.Projects.Remove(project);
            context.SaveChanges();
        }
        public bool IsProjectIDExist(int PID)
        {
           List <Project> projects=context.Projects.ToList();

            foreach (Project project in projects)
            {
                if (project.ProjectId == PID) { return true; }
            }
            return false;
        }
        public bool IsProjectNameExist(String name)
        {
            List<Project> projects = context.Projects.ToList();

            foreach (Project project in projects)
            {
                if (project.ProjectName == name) { return true; }
            }
            return false;
        }
        public List <Project> ViewProjects()
        {
            List<Project> projects = context.Projects.ToList();
            return projects;
        }
        public void AddEmployeeToProject(int projectID,Employee Emp)
        {
            Project project = context.Projects.Find(projectID);
            project.Employees.Add(Emp);
            context.Entry(project).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
