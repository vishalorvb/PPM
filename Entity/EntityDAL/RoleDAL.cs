using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class RoleDAL
    {
        EntityDbcontext context = new EntityDbcontext();
        public void AddRole(Role Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
        }
        public void DeleteRole(Role Role)
        {
            context.Roles.Remove(Role);
            context.SaveChanges();
        }
        public bool IsRoleIDExist(int RID)
        {
            List<Role> roles = context.Roles.ToList();
            foreach (Role role in roles)
            {
                if(role.RoleId == RID) { return true; }
            }
            return false;
        }
        public List <Role> ViewRole()
        {
            List<Role> roles = context.Roles.ToList();
            return roles;
        }
    }
}
