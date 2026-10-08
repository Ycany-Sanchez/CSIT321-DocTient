namespace DocTient.Models;

public class Patient : User
{
    public Patient()
    {
        Role = UserRole.Patient;
    }

    public List<VitalSign> VitalSigns { get; set; } = new();
    public List<Medication> Medications { get; set; } = new();
    public List<DoctorReview> Reviews { get; set; } = new();
}
