namespace EntityDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Mobile = c.Int(nullable: false),
                        Address = c.String(),
                        Role_RoleId = c.Int(),
                        Project_ProjecteId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjecteId)
                .Index(t => t.Role_RoleId)
                .Index(t => t.Project_ProjecteId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjecteId = c.Int(nullable: false, identity: true),
                        StartingDate = c.DateTime(nullable: false),
                        EndingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProjecteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Project_ProjecteId", "dbo.Projects");
            DropForeignKey("dbo.Employees", "Role_RoleId", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "Project_ProjecteId" });
            DropIndex("dbo.Employees", new[] { "Role_RoleId" });
            DropTable("dbo.Projects");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
        }
    }
}
