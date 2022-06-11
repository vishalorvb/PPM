using PPMDAL;
using PPMModel;
using PPMUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDomain2
{
    public class RoleLogic
    {
        RoleDAL Roledal = new RoleDAL();
        RoleUI Roleui = new RoleUI();
        public void AddRole(Role role)
        {
           if (Roledal.IsRoleIDExist(role.RoleId))
            {
                Roleui.RoleExistError();
            }
            else
            {
                Roledal.InsertRole(role);
            }
        }
        public void DeleteRole(Role role)
        {
            if (Roledal.IsRoleIDExist(role.RoleId))
            {
                Roleui.RoleExistError();
            }
            else
            {
                Roledal.DeleteRole(role.RoleId);
            }
        }
        public void ViewRole()
        {
            SqlDataReader DR = Roledal.ViewRole();
            Roleui.ViewRole(DR);
        }
    }
}
