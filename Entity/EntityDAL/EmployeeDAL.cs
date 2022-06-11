using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class EmployeeDAL
    {
        EntityDbcontext context = new EntityDbcontext();
        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
        public bool IsEmployeeIDExist(int EID)
        {
            List <Employee> employees = context.Employees.ToList();
            foreach (Employee employee in employees)
            {
                if(employee.EmployeeId == EID) { return true; }
            }
            return false;
        }
        public bool IsEmployeeEmailExist(String Email)
        {
            List<Employee> employees = context.Employees.ToList();
            foreach (Employee employee in employees)
            {
                if (employee.Email == Email) { return true; }
            }
            return false;
        }
        public bool IsEmployeeMobileExist(int M)
        {
            List<Employee> employees = context.Employees.ToList();
            foreach (Employee employee in employees)
            {
                if (employee.Mobile == M) { return true; }
            }
            return false;
        }
        public List <Employee> ViewEmployee()
        {
            List<Employee> employees = context.Employees.ToList();
            return employees;
        }
        public void AddRoleToEmploye(int EmpID,Role role)
        {
            Employee Emp = context.Employees.Find(EmpID);
            Emp.Role = role;
            context.Entry(Emp).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteRoleFromEmploye( Role role)
        {
            List<Employee> employees = context.Employees.ToList();
            foreach(Employee employee in employees)
            {
                if (employee.Role == role)
                {
                    Employee Emp = context.Employees.Find(employee.EmployeeId);
                    Emp.Role = null;
                    context.Entry(Emp).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
           
        }
    }
}
