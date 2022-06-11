using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUI
{
    public class EmployeeUI
    {
        public void EmployeeIDError()
        {
            Console.WriteLine("EmployeeID already exist");
        }
        public void PrintEmployee(List <Employee> employess)
        {
            foreach (Employee employee in employess)
            {
                Console.WriteLine(employee.EmployeeId + employee.FirstName + employee.Email + employee.Mobile);
            }
        }
        public Employee CreateEmployee()
        {
            Console.WriteLine("Enter Employee FirstName");
            String Fname = Console.ReadLine();


            Console.WriteLine("Enter last Name");
            String lName = Console.ReadLine();

            Console.WriteLine("Enter EmpID");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Address");
            String add = Console.ReadLine();

            Console.WriteLine("Enter Email");
            String email = Console.ReadLine();

            Console.WriteLine("Enter Phone number");
            int pn = Convert.ToInt32(Console.ReadLine());

            Employee E = new Employee(EmpID, Fname, lName, email, pn, add);
            return E;

        }
    }
}
