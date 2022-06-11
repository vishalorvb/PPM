using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMUI
{
    public class ProjectUI
    {
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

        public void PrintProject(List<Project> projects)
        {
            foreach (Project p in projects)
            {
                Console.WriteLine(p.ProjectId + "====>" + p.ProjectName);
            }
        }
       
        public void ListProjectByID(List<Project> projects, int PID)
        {
            foreach (Project p in projects)
            {
                if (p.ProjectId == PID)
                {
                    Console.WriteLine("projectid  ProjectName");
                    Console.WriteLine(p.ProjectId + p.ProjectName);
                }
            }
        }
        public  void DateError()
        {
            Console.WriteLine("Enter valid Date");
        }
        public void ProjectIDError()
        {
            Console.WriteLine("Projectid already exist");
        }
        public void ViewProject(SqlDataReader DR)
        {
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    Console.WriteLine("{0}   {1}", DR["projectId"], DR["ProjectName"]);
                }
            }
        }
    }
}
