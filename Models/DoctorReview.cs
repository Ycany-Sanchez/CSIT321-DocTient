namespace DocTient.Models;

public class DoctorReview
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string PatientId { get; set; } = string.Empty;
    public string DoctorId { get; set; } = string.Empty;
    public string? AppointmentId { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public string PatientInitials { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
    public string Comment { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public string VisitSummary { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int HelpfulCount { get; set; }
    public bool IsVerifiedVisit { get; set; } = true;

    public void IncrementHelpful() => HelpfulCount++;
}
