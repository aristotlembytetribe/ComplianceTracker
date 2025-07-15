//using ComplianceTracker.Models;
//using System.Data.Entity.Migrations;

//namespace ComplianceTracker.Migrations
//{
//    public class Configuration
//    {
//    }
//}
using ComplianceTracker.Models;
using System.Data.Entity.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false; // Set to true if you want EF to auto-apply schema changes
    }

    protected override void Seed(AppDbContext context)
    {
        // This method will run after migrating to the latest version.

        // Example:
        // context.Users.AddOrUpdate(u => u.Name,
        //     new User { Name = "Admin", Role = "Admin" }
        // );
    }
}
