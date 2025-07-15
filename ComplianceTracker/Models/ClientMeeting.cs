namespace ComplianceTracker.Models
{
    public class ClientMeeting
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string MeetingType { get; set; }
        public DateTime? NextAppointment { get; set; }

        public virtual Client Client { get; set; }
    }
}

