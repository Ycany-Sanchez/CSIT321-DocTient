namespace DocTient.Models;

public class Doctor : User
{
    public Doctor()
    {
        Role = UserRole.Doctor;
    }

    public string Specialty { get; set; } = "General Practitioner";
    public string HospitalOrClinic { get; set; } = "Makati Med";
    public bool IsOnline { get; set; } = true;

    public List<DoctorReview> Reviews { get; set; } = new();

    public double AverageRating => Reviews.Count == 0 ? 0 : Math.Round(Reviews.Average(r => r.Rating), 1);
}
