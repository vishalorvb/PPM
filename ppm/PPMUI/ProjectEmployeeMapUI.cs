using PPMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPMUI
{
    public class ProjectEmployeeMapUI
    {
        public void AllDetails(List<Project> projects, List<Employee>
            Employess, List<ProjectEmployeeMap> maps)
        {
            foreach (Project project in projects)
            {
                Console.WriteLine("ProjectID  ProjectName");
                Console.WriteLine(project.ProjectId + project.ProjectName);
                int PID = project.ProjectId;
                foreach (ProjectEmployeeMap map in maps)
                {
                    if (map.ProID == PID)
                    {
                        int EID = map.EmpID;
                        foreach (Employee E in Employess)
                        {
                            Console.WriteLine("EmployeeID EmpFirtName EmpLastName EmpRoleID");
                            Console.WriteLine(E.EmployeeId + E.FirstName + E.LastName + E.RoleId);
                        }
                    }
                }
            }
        }
    }
}
