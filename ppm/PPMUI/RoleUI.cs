using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMUI
{
    public class RoleUI
    {
        public Role CreateRole()
        {
            Console.WriteLine("Enter RoleId");
            int rid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter role Name");
            String roleName = Console.ReadLine();
            Role Nrole = new Role(rid, roleName);

            return Nrole;
        }
        public void PrintRoles(List<Role> Rolelist)
        {
            foreach (Role role in Rolelist)
            {
                Console.WriteLine(role.RoleId);
                Console.WriteLine(role.RoleName);
            }
        }
       
        public void ListRoleByID(List<Role> roles, int Rid)
        {
            foreach (Role role in roles)
            {
                if (role.RoleId == Rid)
                {
                    Console.WriteLine("RoleID RoleName");
                    Console.WriteLine(role.RoleId + role.RoleName);
                }
            }
        }
        public void RoleExistError()
        {
            Console.WriteLine("RoleId Already Exist ");
        }
        public void ViewRole(SqlDataReader DR)
        {
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    Console.WriteLine("{0}   {1}", DR["RoleId"], DR["RoleName"]);
                }
            }
           
        }
    }
}
