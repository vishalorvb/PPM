using PPMDAL;
using PPMModel;
using PPMUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDomain2
{
    public class EmployeeLogic
    {
        EmployeeDAL employeedal = new EmployeeDAL();
        EmployeeUI employeeui = new EmployeeUI();
        public void AddEmployee(Employee Emp)
        {
            if (employeedal.IsEmployeeIdExist(Emp.EmployeeId))
            {
                employeeui.EmployeeIDError();
            }
            if (employeedal.IsEmployeeMobileExist(Emp.mobile))
            {
                employeeui.EmployeePhoneError();
            }
            if (employeedal.IsEmployeeEmailExist(Emp.Email))
            {
                employeeui.EmployeeEmailError();
            }
            else
            {
                employeedal.InsertEmployee(Emp);
            }
        }
        public void DeleteEmployee(int EID)
        {
            if (employeedal.IsEmployeeIdExist(EID))
            {
                employeedal.DeleteEmployee(EID);
            }
            else
            {
                employeeui.EmployeeIDError();
            }
        }
        public void ViewEmployee()
        {
            employeeui.ViewEmployee(employeedal.ViewEmployee());
        }
        public void AddRoleToEmployee(int EID ,int RID)
        {
            if (employeedal.IsEmployeeIdExist(EID) )
            {
                employeedal.AddRoleToEmployee(EID, RID);
            }
            else
            {
                employeeui.EmployeeIDError();
            }
        }
        public void DeleteAllRole(int RID)
        {
            employeedal.DeleteAllRole(RID);
        }
    }
}
