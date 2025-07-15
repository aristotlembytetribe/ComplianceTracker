namespace ComplianceTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}

