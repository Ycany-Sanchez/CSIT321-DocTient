namespace DocTient.Models;

public class Appointment
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string PatientId { get; set; } = string.Empty;
    public string DoctorId { get; set; } = string.Empty;
    public DateTime ScheduledDate { get; set; }
    public int DurationMinutes { get; set; } = 30;
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    public string ReasonForVisit { get; set; } = string.Empty;
    public string? Diagnosis { get; set; }
    public string? DoctorNotes { get; set; }
    public bool FollowUpRequired { get; set; }
    public DateTime? FollowUpDate { get; set; }
}
