namespace DocTient.Models;

public class Medication
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string PatientId { get; set; } = string.Empty;
    public string? PrescribedByDoctorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Dosage { get; set; } = string.Empty;
    public MedicationFrequency Frequency { get; set; } = MedicationFrequency.OnceDaily;
    public string ScheduledTime { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime? EndDate { get; set; }
    public bool IsTaken { get; set; }
    public DateTime? LastTakenAt { get; set; }
    public string? Instructions { get; set; }

    public void MarkAsTaken()
    {
        IsTaken = true;
        LastTakenAt = DateTime.UtcNow;
    }

    public void ResetStatus()
    {
        IsTaken = false;
    }
}
