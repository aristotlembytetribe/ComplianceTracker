namespace ComplianceTracker.Models
{
    public class VATSubmission
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }

        public virtual Client Client { get; set; }
    }
}

