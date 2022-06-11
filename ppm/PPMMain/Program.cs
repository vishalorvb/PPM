using PPMDAL;
using PPMDomain;
using PPMModel;
using PPMUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMMain
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            RoleLogic role = new RoleLogic();
            EmployeeLogic employee = new EmployeeLogic();
            ProjectLogic project = new ProjectLogic();
            ProjectEmployeeMapLogic PtoE = new ProjectEmployeeMapLogic(); 
            RoleUI rUI = new RoleUI();
            EmployeeUI eUI = new EmployeeUI();
            ProjectUI pUI = new ProjectUI();
            ProjectEmployeeMapUI mapUI = new ProjectEmployeeMapUI();
            
            int i = 0;
            while (i != 4)
            {

                Console.WriteLine("Choose Below Options ");
                Console.WriteLine("1. Project Module");
                Console.WriteLine("2. Employee Module");
                Console.WriteLine("3. Role Module");
                Console.WriteLine("4. Quit");

                i = Convert.ToInt32(Console.ReadLine());


                switch (i)
                {
                    case 1:
                        int j = 0;
                        while (j != 5)
                        {
                            Console.WriteLine("Project Module ");
                            Console.WriteLine("1. Add");
                            Console.WriteLine("2. List All");
                            Console.WriteLine("3. List ById");
                            Console.WriteLine("4. Delete");
                            Console.WriteLine("5. Retun to main menu");
                            j = Convert.ToInt32(Console.ReadLine());


                            if (j == 1)
                            {
                                Project TempProject = pUI.CreateProject();
                                if (project.IsExist(TempProject.ProjectId))
                                {
                                    Console.WriteLine("ProjectID already Exist");
                                    break;
                                }
                                project.AddProject(TempProject);
                                Console.WriteLine("Select EmpID to add in this project");
                                eUI.PrintEmployee(employee.Employeelist);
                                int eid = Convert.ToInt32(Console.ReadLine());
                                if (employee.IsExistID(eid))
                                {
                                    ProjectEmployeeMap pem = new ProjectEmployeeMap(TempProject.ProjectId, eid);
                                    PtoE.AddEmpToPro(pem);
                                }
                                else
                                {
                                    Console.WriteLine("Select valid EmpID");
                                }
                                Console.WriteLine();
                            }
                            if (j == 2)
                            {
                                pUI.PrintProject(project.Projectlist);
                                Console.WriteLine();
                            }
                            if (j == 3)
                            {
                                Console.WriteLine("Enter ProjectID");
                                int pid = Convert.ToInt32(Console.ReadLine());
                                pUI.ListProjectByID(project.Projectlist, pid);
                            }
                            if (j == 4)
                            {
                                Console.WriteLine("Select ProjectID to be Delete");
                                pUI.PrintProject(project.Projectlist);
                                int PID = Convert.ToInt32(Console.ReadLine());
                                if (project.IsExist(PID))
                                {
                                    
                                    project.DeleteProject(PID);
                                }
                            }
                        }
                        break;

                    case 2:
                        int k = 0;
                        while (k != 5)
                        {
                            Console.WriteLine(" Employee Module");
                            Console.WriteLine("1. Add");
                            Console.WriteLine("2. List All");
                            Console.WriteLine("3. List ById");
                            Console.WriteLine("4. Delete");
                            Console.WriteLine("5. Retun to main menu");
                            k = Convert.ToInt32(Console.ReadLine());


                            if (k == 1)
                            {
                                Employee Temp = eUI.CreateEmployee();
                                if (employee.IsExist(Temp.EmployeeId,Temp.Email,Temp.mobile))
                                {
                                    Console.WriteLine("EmployeeID already Exist");
                                    break;
                                }
                                employee.AddEmployee(Temp);
                                Console.WriteLine();
                            }
                            if (k == 2)
                            {
                                eUI.PrintEmployee(employee.Employeelist);
                                Console.WriteLine();
                            }
                            if (k == 3)
                            {
                                continue;
                            }
                            if (k == 4)
                            {
                                Console.WriteLine("Select EmployeeID to Delete");
                                eUI.PrintEmployee(employee.Employeelist);
                                int EID = Convert.ToInt32(Console.ReadLine());
                                if (employee.IsExistID(EID))
                                {
                                    PtoE.DeleteEmpFromPro(EID);
                                    employee.DeleteEmployee(EID);
                                }
                                else
                                {
                                    Console.WriteLine("Eneter valid EmployeeID");
                                }

                            }
                        }
                        break;

                    case 3:
                        int l = 0;
                        while (l != 5)
                        {
                            Console.WriteLine(" Role Module");
                            Console.WriteLine("1. Add");
                            Console.WriteLine("2. List All");
                            Console.WriteLine("3. List ById");
                            Console.WriteLine("4. Delete");
                            Console.WriteLine("5. Retun to main menu");
                            l = Convert.ToInt32(Console.ReadLine());


                            if (l == 1)
                            {
                                Role TempR = rUI.CreateRole();
                                if (role.IsExist(TempR.RoleId))
                                {
                                    Console.WriteLine("RoleID already exist");
                                    break;
                                }
                                role.AddRole(TempR);
                                Console.WriteLine();
                            }
                            if (l == 2)
                            {
                                rUI.PrintRoles(role.Rolelist);
                                Console.WriteLine();
                            }
                            if (l == 3)
                            {
                                continue;
                            }
                            if (l == 4)
                            {
                                Console.WriteLine("Select Role to Delete");
                                rUI.PrintRoles(role.Rolelist);
                                int RID = Convert.ToInt32(Console.ReadLine());
                                if (role.IsExist(RID))
                                {
                                   
                                    role.DeleteRole(RID);
                                    employee.DeleteAllRole(RID);
                                }

                            }
                        }
                        break;

                    default:
                        break;


                }

            }
            role.SaveRoleToXml();
            employee.SaveEmployeeToXml();
            PtoE.SaveMAPToXml();
            project.SaveProjectToXml();


        }
    }
}
