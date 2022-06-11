using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMModel
{
    public class Role
    {
        public string RoleName;
        public int RoleId;
        public Role(int id, String name)
        {

            this.RoleName = name;

            this.RoleId = id;
        }
        public Role()
        {

        }
    }
}
