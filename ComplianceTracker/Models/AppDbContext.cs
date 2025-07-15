using System.Data.Entity;
namespace ComplianceTracker.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VATSubmission> VATSubmissions { get; set; }
        public DbSet<ProvisionalTax> ProvisionalTaxes { get; set; }
        public DbSet<EMP501Submission> EMP501Submissions { get; set; }
        public DbSet<ClientMeeting> ClientMeetings { get; set; }

        public AppDbContext() : base("DefaultComplianceConnection") { }
    }
}
