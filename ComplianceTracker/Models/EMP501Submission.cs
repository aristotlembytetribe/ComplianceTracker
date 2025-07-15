namespace ComplianceTracker.Models
{
    public class EMP501Submission
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Period { get; set; }
        public string Status { get; set; }
        public DateTime? SubmittedDate { get; set; }

        public virtual Client Client { get; set; }
    }
}

