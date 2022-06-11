using EntityMODAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityUI
{
    public class RoleUI
    {
        public void RoleIDExistError()
        {
            Console.WriteLine("RoleID ALready Exist");
        }
        public void PrintRole(List <Role> Roles)
        {
            Console.WriteLine("RoleID  RoleName");
           foreach (Role role in Roles)
            {
                Console.WriteLine(role.RoleId + role.RoleName);
            }
        }
        public Role CreateRole()
        {
            Console.WriteLine("Enter RoleId");
            int rid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter role Name");
            String roleName = Console.ReadLine();
            Role Nrole = new Role(rid, roleName);

            return Nrole;
        }
    }
}
