
namespace ComplianceTracker.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HandlerId { get; set; }
        public string VATPeriodType { get; set; }

        public virtual User Handler { get; set; }
        public virtual ICollection<VATSubmission> VATSubmissions { get; set; }
        public virtual ICollection<ProvisionalTax> ProvisionalTaxes { get; set; }
        public virtual ICollection<EMP501Submission> EMP501Submissions { get; set; }
        public virtual ICollection<ClientMeeting> ClientMeetings { get; set; }
    }
}
