using PPMModel;
using PPMUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PPMDomain
{
    public class EmployeeLogic : IEmployeeOprations
    {
        EmployeeUI EmpUI = new EmployeeUI();

        public List<Employee> Employeelist = new List<Employee>();
        public void AddEmployee(Employee emp)
        {
            Employeelist.Add(emp);

        }
        public void DeleteEmployee(int EID)
        {
           foreach (Employee emp in Employeelist.ToList())
            {
                if (emp.EmployeeId == EID)
                {
                    Employeelist.Remove(emp);
                }
            }
        }
        public void AddRoleToEmployee(int eid, int Rid)
        {
            foreach (Employee emp in Employeelist)
            {
                if (emp.EmployeeId == eid)
                {
                    emp.RoleId = Rid;
                }
            }
        }
        public void DeleteRoleFromEmployee(int eid)
        {
            foreach (Employee emp in Employeelist)
            {
                if (emp.EmployeeId == eid)
                {
                    emp.RoleId = 0;
                }
            }
        }

        public bool IsExist(int EID, String Email,int pn)
        {
            foreach (Employee emp in Employeelist)
            {
                if (emp.EmployeeId == EID)
                {
                    EmpUI.EmployeeIDError();
                    return true;
                }
                if (emp.Email == Email)
                {
                    EmpUI.EmployeeEmailError();
                    return true;
                }
                if (emp.mobile == pn)
                {
                    EmpUI.EmployeePhoneError();
                    return true;
                }
            }
            return false;
        }

        public bool IsExistID(int EID)
        {
            foreach (Employee emp in Employeelist)
            {
                if (emp.EmployeeId == EID)
                {
                    EmpUI.EmployeeIDError();
                    return true;
                }
                
            }
            return false;
        }
        public void DeleteAllRole(int RID)
        {
            foreach (Employee emp in Employeelist)
            {
                if(emp.RoleId == RID)
                {
                    emp.RoleId = 0;
                }
            }
        }
        public void SaveEmployeeToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            using (TextWriter writer = new StreamWriter("C:\\Users\\VISHAL\\source\\repos\\Employee.xml"))
            {
                xmlSerializer.Serialize(writer, Employeelist);
                
            }
        }

    }
}
