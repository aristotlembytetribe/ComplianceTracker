namespace ComplianceTracker.Models
{
    public class ProvisionalTax
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; }

        public virtual Client Client { get; set; }
    }
}

