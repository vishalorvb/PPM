using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMUI
{
    public class EmployeeUI
    {
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

            Employee E = new Employee(EmpID, Fname, lName,email, pn, add);
            return E;

        }

        public void PrintEmployee(List<Employee> emp)
        {
            Console.WriteLine("EmpID == EmpFirstName == EmpLastName == RoleID");
            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmployeeId + "==" + e.FirstName + "==" + e.LastName + "==" + e.RoleId);
            }
        }
       
        public void ListEmployeeByID(List<Employee> employees, int EID)
        {
            foreach (Employee e in employees)
            {
                if (e.EmployeeId == EID)
                {
                    Console.WriteLine("EmpID FirstName LastName");
                    Console.WriteLine(e.EmployeeId + e.FirstName + e.LastName);
                }
            }
        }
        public void EmployeeIDError()
        {
            Console.WriteLine("EmplyeeID Already exists, Enter valid ID");
        }
        public void EmployeeEmailError()
        {
            Console.WriteLine("Emplyee  Email Already exists, Enter valid Email");
        }
        public void EmployeePhoneError()
        {
            Console.WriteLine("Phone number Already exists, Enter valid One");
        }
        public void ViewEmployee(SqlDataReader DR)
        {
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    Console.WriteLine("{0}   {1}", DR["EmployeeId"], DR["EmployeeName"]);
                }
            }
        }
    }
}
