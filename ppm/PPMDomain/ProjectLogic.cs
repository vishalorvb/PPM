using PPMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMUI;
using System.Xml.Serialization;
using System.IO;

namespace PPMDomain
{
    public class ProjectLogic : IProjectOprations
    {
        public List<Project> Projectlist = new List<Project>();
        ProjectUI PUI = new ProjectUI();


        public void AddProject(Project pro)
        {
            int date = DateTime.Compare(pro.StartingDate,pro.EndingDate);
            if(date < 0)
            {
                Projectlist.Add(pro);
              
            }
            else
            {
                
                PUI.DateError();
            }
        }

        public void DeleteProject(int PID)
        {
            foreach(Project pro in Projectlist.ToList())
            {
                if (pro.ProjectId == PID)
                {
                    Projectlist.Remove(pro);
                }
            }
        }
        public bool IsExist(int PID)
        {
            foreach (Project p in Projectlist)
            {
                if (p.ProjectId == PID)
                {
                    return true;
                }
            }
            return false;
        }
        public void SaveProjectToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Project>));
            using (TextWriter writer = new StreamWriter("C:\\Users\\VISHAL\\source\\repos\\Project.xml"))
            {
                xmlSerializer.Serialize(writer, Projectlist);
                Console.WriteLine("Data Saved ");
            }
        }

    }
}
