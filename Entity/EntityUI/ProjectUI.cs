using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUI
{
    public class ProjectUI
    {
        public void DateError()
        {
            Console.WriteLine("Enter valid date");
        }
        public void IDError()
        {
            Console.WriteLine("Enter valid projectID");
        }
        public void NameError()
        {
            Console.WriteLine("Project name already exist");
        }
        public void PrintProject(List<Project> projects)
        {
            foreach(var project in projects)
            {
                Console.WriteLine(project.ProjectId + project.ProjectName);
            }
        }
        public Project CreateProject()
        {
            Console.WriteLine("Enter Project Name");
            String proname = Console.ReadLine();
            Console.WriteLine("Enter ProjectID");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter starting date dd/mm/yyyy");
            DateTime Sd = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter end date dd/mm/yyyy");
            DateTime Ed = Convert.ToDateTime(Console.ReadLine());
            Project p = new Project(pid, proname, Sd, Ed);
            return p;
        }
    }
}
