using PPMModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMDAL
{
    public class ProjectDAL
    {
        public void InsertProject(Project project)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
           

                String Query = "insert into Project VALUES('" + project.ProjectId + "','" + project.ProjectName + "','" + project.StartingDate + "','"+ project.EndingDate+"')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            
            con.Close();
        }
        public void DeleteProject(int PID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "Delete from project where ProjectId='"+PID+"' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }
        public bool IsProjectIdExist(int PID)
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from project where ProjectId='" + PID + "' ";
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
        public SqlDataReader ViewProject()
        {
            String ConnectionString = "Data Source=VISHAL-PC\\SQLEXPRESS;Initial Catalog=PPM;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Query = "select * from project";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader DR = cmd.ExecuteReader();
          
           con.Close();
            return DR;
        }

    }
}
