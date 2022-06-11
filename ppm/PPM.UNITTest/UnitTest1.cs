using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPMDomain;
using PPMModel;
using System;

namespace PPM.UNITTest
{
    [TestClass]
    public class UnitTest1
    {
        RoleLogic role = new RoleLogic();
        EmployeeLogic employee = new EmployeeLogic();
        ProjectLogic project = new ProjectLogic();
        ProjectEmployeeMapLogic PtoE = new ProjectEmployeeMapLogic();
        [TestMethod]
        public void AddProjectTest()
        {
            DateTime sd = new DateTime(2020, 10, 20);
            DateTime ed = new DateTime(2022, 04, 20);

            Project pro1 = new Project(1,"project1",sd,ed);
            project.AddProject(pro1);
            var result = project.IsExist(1);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void DeleteProjectTest()
        {
            DateTime sd = new DateTime(2020, 10, 20);
            DateTime ed = new DateTime(2022, 04, 20);

            Project pro2 = new Project(5, "project2", sd, ed);
            project.AddProject(pro2);
            project.DeleteProject(5);
            var result2 = project.IsExist(5);
            
            Assert.IsFalse(result2);

        }
        [TestMethod]
        public void AddRoletest()
        {
            Role role1 = new Role(12, "Manager");
            Role role2 = new Role(13, "HR");
            role.AddRole(role1);
            role.AddRole(role2);
            
            Assert.AreEqual("Manager",role1.RoleName);
            Assert.AreEqual("HR", role2.RoleName);

            var result = role.IsExist(12);

            Assert.IsTrue(result);
            Assert.IsTrue(role.IsExist(role2.RoleId));
        }
        [TestMethod]
        public void DeleteRoleTest()
        {
            Role r1 = new Role(10, "Devloper");
            Role r2 = new Role(11, "Testing");

            role.AddRole(r1);
            role.AddRole(r2);

            role.DeleteRole(r1.RoleId);
            Assert.IsTrue(role.IsExist(r2.RoleId));
            Assert.IsFalse(role.IsExist(r1.RoleId));
        }
        [TestMethod]
        public void AddemployeeTest()
        {
            Employee employee1 = new Employee(1,"vishal","kumar",987654123,"kolkata");
            employee.AddEmployee(employee1);
            Role r4 = new Role(2, "manager");
            employee.AddRoleToEmployee(employee1.EmployeeId,r4.RoleId);

            Assert.IsTrue(employee.IsExist(employee1.EmployeeId));
            Assert.AreEqual(r4.RoleId,employee1.RoleId);

        }
        [TestMethod]
        public void DeleteEmployeeTest()
        {
            Employee employee1 = new Employee(2, "MS", "Dhoni", 987654123, "India");
            employee.AddEmployee(employee1);
            Assert.IsTrue(employee.IsExist(employee1.EmployeeId));
            employee.DeleteEmployee(employee1.EmployeeId);
            Assert.IsFalse(employee.IsExist(employee1.EmployeeId));
        }
    }
}
