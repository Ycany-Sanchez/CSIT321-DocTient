using System.Text.Json.Serialization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace DocTient.Models;

[Table("doctors")]
public class Doctor : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [Column("last_name")]
    public string LastName { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("specialty")]
    public string Specialty { get; set; } = "General Practitioner";

    [Column("hospital_or_clinic")]
    public string HospitalOrClinic { get; set; } = "Makati Med";

    [Column("is_online")]
    public bool IsOnline { get; set; } = true;

    [Column("password")]
    public string Password { get; set; } = string.Empty;

    [Column("last_login_at")]
    public DateTime? LastLoginAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public string FullName => $"{FirstName} {LastName}".Trim();

    [JsonIgnore]
    public string Initials
    {
        get
        {
            var first = string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName[0].ToString().ToUpper();
            var last = string.IsNullOrWhiteSpace(LastName) ? "" : LastName[0].ToString().ToUpper();
            var combined = $"{first}{last}";
            return string.IsNullOrEmpty(combined) ? "DR" : combined;
        }
    }

    [JsonIgnore]
    public List<DoctorReview> Reviews { get; set; } = new();

    [JsonIgnore]
    public double AverageRating => Reviews.Count == 0 ? 0 : Math.Round(Reviews.Average(r => r.Rating), 1);
}
