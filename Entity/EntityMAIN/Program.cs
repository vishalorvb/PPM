using EntityDOMAIN;
using EntityMODAL;
using EntityUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMAIN
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            RoleLogic role = new RoleLogic();
            EmployeeLogic employee = new EmployeeLogic();
            ProjectLogic project = new ProjectLogic();

            RoleUI rUI = new RoleUI();
            EmployeeUI eUI = new EmployeeUI();
            ProjectUI pUI = new ProjectUI();


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

                                project.AddProject(TempProject);
                                Console.WriteLine("Select EmpID to add in this project");
                                employee.ViewEmployee();

                                Console.WriteLine();
                            }
                            if (j == 2)
                            {
                                project.ViewProject();
                                Console.WriteLine();
                            }
                            if (j == 3)
                            {
                                Console.WriteLine("Enter ProjectID");
                                int pid = Convert.ToInt32(Console.ReadLine());

                            }
                            if (j == 4)
                            {
                                project.ViewProject();
                                Console.WriteLine("Enter ProjectID");
                                int PID = Convert.ToInt32(Console.ReadLine());

                                project.DeleteProject(PID);
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
                                employee.AddEmployee(Temp);
                                Console.WriteLine();
                            }
                            if (k == 2)
                            {
                                employee.ViewEmployee();
                                Console.WriteLine();
                            }
                            if (k == 3)
                            {
                                continue;
                            }
                            if (k == 4)
                            {
                                employee.ViewEmployee();
                                Console.WriteLine("Enter EmployeeID");
                                int EID = Convert.ToInt32(Console.ReadLine());
                                employee.DeleteEmployee(EID);
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

                                role.AddRole(TempR);
                                Console.WriteLine();
                            }
                            if (l == 2)
                            {
                                role.ViewRole();
                                Console.WriteLine();
                            }
                            if (l == 3)
                            {
                                continue;
                            }
                            if (l == 4)
                            {
                                Console.WriteLine("Select Role to Delete");
                                role.ViewRole();
                                int RID = Convert.ToInt32(Console.ReadLine());
                                role.DeleteRole(RID);
                                employee.DeleteRoleFromEmployee(RID);

                            }
                        }
                        break;

                    default:
                        break;


                }

            }
        }
    }
}
