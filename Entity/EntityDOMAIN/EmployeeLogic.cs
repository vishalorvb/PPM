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
    public class EmployeeLogic
    {
        EmployeeDAL Employeedal = new EmployeeDAL();
        RoleDAL RoleDAL = new RoleDAL();
        EmployeeUI Employeeui = new EmployeeUI();
        public void AddEmployee(Employee employee)
        {
            if (Employeedal.IsEmployeeIDExist(employee.EmployeeId)) { Employeeui.EmployeeIDError(); }
            if (Employeedal.IsEmployeeMobileExist(employee.Mobile)) { Employeeui.EmployeeIDError(); }
            if (Employeedal.IsEmployeeEmailExist(employee.Email)) { Employeeui.EmployeeIDError(); }
            else { Employeedal.AddEmployee(employee); }
        }
        public void DeleteEmployee(int EID) 
        {
            
            List<Employee> employess = Employeedal.ViewEmployee();
            foreach (Employee employee in employess)
            {
                if (employee.EmployeeId == EID)
                {
                    Employeedal.DeleteEmployee(employee);
                }
            }

            
        } 


        public void ViewEmployee()
        {
            Employeeui.PrintEmployee(Employeedal.ViewEmployee());
        }
        public void AddRoleToEmployee(int EmpID,Role role)
        {
            if (Employeedal.IsEmployeeIDExist(EmpID)) {
                Employeedal.AddRoleToEmploye(EmpID, role);
             }
        }
        public void DeleteRoleFromEmployee( int RID)
        {
            List <Role> Roles =RoleDAL.ViewRole();
            foreach (Role role in Roles)
            {
                if (role.RoleId == RID)
                {
                    Employeedal.DeleteRoleFromEmploye(role);
                }
            }
        }
    }
}
