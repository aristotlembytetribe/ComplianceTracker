using System;
using System.Data.Entity.Migrations;

public partial class InitialCreate : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.ClientMeetings",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    MeetingType = c.String(),
                    NextAppointment = c.DateTime(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
            .Index(t => t.ClientId);
        
        CreateTable(
            "dbo.Clients",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    HandlerId = c.Int(nullable: false),
                    VATPeriodType = c.String(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Users", t => t.HandlerId, cascadeDelete: true)
            .Index(t => t.HandlerId);
        
        CreateTable(
            "dbo.EMP501Submission",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    Period = c.String(),
                    Status = c.String(),
                    SubmittedDate = c.DateTime(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
            .Index(t => t.ClientId);
        
        CreateTable(
            "dbo.Users",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Role = c.String(),
                })
            .PrimaryKey(t => t.Id);
        
        CreateTable(
            "dbo.ProvisionalTaxes",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    DueDate = c.DateTime(nullable: false),
                    Notes = c.String(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
            .Index(t => t.ClientId);
        
        CreateTable(
            "dbo.VATSubmissions",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ClientId = c.Int(nullable: false),
                    Month = c.Int(nullable: false),
                    Year = c.Int(nullable: false),
                    Status = c.String(),
                })
            .PrimaryKey(t => t.Id)
            .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
            .Index(t => t.ClientId);
        
    }
    
    public override void Down()
    {
        DropForeignKey("dbo.VATSubmissions", "ClientId", "dbo.Clients");
        DropForeignKey("dbo.ProvisionalTaxes", "ClientId", "dbo.Clients");
        DropForeignKey("dbo.Clients", "HandlerId", "dbo.Users");
        DropForeignKey("dbo.EMP501Submission", "ClientId", "dbo.Clients");
        DropForeignKey("dbo.ClientMeetings", "ClientId", "dbo.Clients");
        DropIndex("dbo.VATSubmissions", new[] { "ClientId" });
        DropIndex("dbo.ProvisionalTaxes", new[] { "ClientId" });
        DropIndex("dbo.EMP501Submission", new[] { "ClientId" });
        DropIndex("dbo.Clients", new[] { "HandlerId" });
        DropIndex("dbo.ClientMeetings", new[] { "ClientId" });
        DropTable("dbo.VATSubmissions");
        DropTable("dbo.ProvisionalTaxes");
        DropTable("dbo.Users");
        DropTable("dbo.EMP501Submission");
        DropTable("dbo.Clients");
        DropTable("dbo.ClientMeetings");
    }
}
