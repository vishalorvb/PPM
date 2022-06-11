using PPMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDomain
{
    interface IRoleOprations
    {
        void AddRole(Role role);
        void DeleteRole(int RID);
        bool IsExist(int RID);
    }
    interface IEmployeeOprations
    {
        void AddEmployee(Employee emp);
        void DeleteEmployee(int EID);
        void AddRoleToEmployee(int eid, int Rid);
        
    }
    interface IProjectOprations
    {
        void AddProject(Project pro);
        void DeleteProject(int PID);
        bool IsExist(int PID);
    }
    interface IProjectEmployeeMap
    {
        void AddEmpToPro(ProjectEmployeeMap PEM);
        void DeleteEmpFromPro(int EID);

    }
}
