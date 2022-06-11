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
   public  class ProjectEmployeeMapLogic : IProjectEmployeeMap
    {
        public List<ProjectEmployeeMap> ProjectEmployeelist = new List<ProjectEmployeeMap>();

        public void AddEmpToPro(ProjectEmployeeMap PEM)
        {
            ProjectEmployeelist.Add(PEM);
        }
        public void DeleteEmpFromPro(int EID)
        {
            foreach (ProjectEmployeeMap PEM in ProjectEmployeelist)
            {
                if(PEM.EmpID == EID)
                {
                    ProjectEmployeelist.Remove(PEM);
                }
            }
        }
        public void SaveMAPToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ProjectEmployeeMap>));
            using (TextWriter writer = new StreamWriter("C:\\Users\\VISHAL\\source\\repos\\MAP.xml"))
            {
                xmlSerializer.Serialize(writer, ProjectEmployeelist);
                Console.WriteLine("Data Saved ");
            }
        }
    }
}
