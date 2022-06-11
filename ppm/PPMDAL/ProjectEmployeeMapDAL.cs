using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDAL
{
    public class ProjectEmployeeMapDAL
    {
        public void InsertProjectEmployeeMap(ProjectEmployeeMap Maps)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

                String Query = "insert into ProjectEmployeeMap VALUES('" + Maps.ProID + "','" + Maps.EmpID + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            
            con.Close();
        }
        public void DeleteEmployeeFromProject(int EID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Delete From ProjectEmployeeMap where EmployeeId = '"+EID+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
