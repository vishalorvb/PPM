using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMODAL
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public String Email { get; set; }
        public int Mobile { get; set; }
        public String Address { get; set; }

        public Role Role = null;
        public Employee(int Eid, String Fname, String Lname, String Email, int Mno, String Add)
        {

            this.EmployeeId = Eid;
            this.FirstName = Fname;
            this.LastName = Lname;
            this.Mobile = Mno;
            this.Address = Add;
            this.Email = Email;

        }
    }
}
