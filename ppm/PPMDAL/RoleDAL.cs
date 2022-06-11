using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//VISHAL-PC\SQLEXPRESS

namespace PPMDAL
{
    public class RoleDAL
    {
        public void InsertRole(Role role)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
          
               
                String Query = "insert into Role (RoleName,RoleId) VALUES('" + role.RoleName + "'," + role.RoleId + ")";

                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            
            con.Close();

        }
        public void DeleteRole(int RID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Delete from Role where RoleId='"+RID+"'";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public bool IsRoleIDExist(int RID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Select * from Role where RoleId ='"+RID+"' ";
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
        public SqlDataReader  ViewRole()
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Select * from Role";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader DR = cmd.ExecuteReader();
           
            con.Close();
            return DR;
        }
    }
    
}
