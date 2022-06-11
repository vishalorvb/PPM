using PPMModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PPMDomain
{
    public class RoleLogic : IRoleOprations
    {
        public List<Role> Rolelist = new List<Role>();

        public void AddRole(Role role)
        {
            Rolelist.Add(role);
        }
        public void DeleteRole(int RID)
        {
           foreach (Role role in Rolelist.ToList())
            {
                if (role.RoleId == RID)
                {
                    Rolelist.Remove(role);
                }
            }
        }
        public bool IsExist(int RID)
        {
            foreach (Role role in Rolelist)
            {
                if (role.RoleId == RID)
                {
                    return true;
                }
            }
            return false;
        }
        public void SaveRoleToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Role>));
            using (TextWriter writer = new StreamWriter("C:\\Users\\VISHAL\\source\\repos\\Role.xml"))
            {
                xmlSerializer.Serialize(writer, Rolelist);
                Console.WriteLine("Data Saved ");
            }
        }
    }
}
