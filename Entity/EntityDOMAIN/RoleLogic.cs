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
    public class RoleLogic
    {
        RoleDAL RoleDal = new RoleDAL();
        RoleUI roleUI = new RoleUI();

        public void AddRole(Role Role)
        {
           
            if (RoleDal.IsRoleIDExist(Role.RoleId))
            {
                roleUI.RoleIDExistError();

            }
            else
            {
                RoleDal.AddRole(Role);
            }
        }
        public void DeleteRole(int RID)
        {
            
            List<Role> Roles = RoleDal.ViewRole();
            if (RoleDal.IsRoleIDExist(RID))
            {
               
                foreach (Role Role in Roles)
                {
                    if(Role.RoleId == RID)
                    {
                        RoleDal.DeleteRole(Role);
                    }
                }
               ;
              
            }
            else
            {
                roleUI.RoleIDExistError();

            }
        }
        public void ViewRole()
        {
            roleUI.PrintRole(RoleDal.ViewRole());
           
        }

    }
}
