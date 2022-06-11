using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMModel
{
    public class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Email;
        public int mobile;
        public string address;
        public int RoleId =0;

        public Employee(int Eid, String Fname, String Lname,String Email, int Mno, String Add)
        {

            this.EmployeeId = Eid;
            this.FirstName = Fname;
            this.LastName = Lname;
            this.mobile = Mno;
            this.address = Add;
            this.Email = Email;

        }
        public Employee()
        {

        }
    }
}
