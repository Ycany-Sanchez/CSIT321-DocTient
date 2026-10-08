namespace DocTient.Models;

public class Patient : User
{
    public Patient()
    {
        Role = UserRole.Patient;
    }

    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }
    public string? BloodType { get; set; }
    public string? EmergencyContact { get; set; }
    public List<string> Allergies { get; set; } = new();
    public string? PrimaryDoctorId { get; set; }

    public List<VitalSign> VitalSigns { get; set; } = new();
    public List<HealthRecord> HealthRecords { get; set; } = new();
    public List<Medication> Medications { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();
    public List<DoctorReview> Reviews { get; set; } = new();

    public int? Age => DateOfBirth.HasValue
        ? DateTime.Today.Year - DateOfBirth.Value.Year - (DateTime.Today.DayOfYear < DateOfBirth.Value.DayOfYear ? 1 : 0)
        : null;
}
