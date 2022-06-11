using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDAL
{
    public class EmployeeDAL
    {
        public void InsertEmployee(Employee employee)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

           


                String Query = "insert into Employee VALUES('" + employee.EmployeeId + "','" + employee.FirstName + "','" + employee.LastName + "','" + employee.Email + "','" +employee.mobile+ "','" + employee.address + "','" + employee.RoleId + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            
            con.Close();
        }
        public void DeleteEmployee(int EID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Delete from employee where EmployeeId='" + EID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteRoleFromEmployee(int EID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "UPDATE Employee SET RoleID = 0 where EmployeeId='" + EID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool IsEmployeeIdExist(int EID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from employee where EmployeeId='" + EID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
             SqlDataReader DR =  cmd.ExecuteReader();
            if (DR.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmployeeMobileExist(int EID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from employee where mobile='" + EID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmployeeEmailExist(String Email)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from employee where Email='" + Email + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public SqlDataReader ViewEmployee()
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from employee ";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader DR = cmd.ExecuteReader();
            
            con.Close();
            return DR;
        }
        public void AddRoleToEmployee(int EID , int RID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "UPDATE Employee SET RoleID = '"+RID+"' where EmployeeId='" + EID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAllRole(int RID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "UPDATE Employee SET RoleID = 0 where EmployeeId='" + RID + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
