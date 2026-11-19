using System.Text.Json.Serialization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace DocTient.Models;

[Table("medications")]
public class Medication : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("patient_email")]
    public string PatientEmail { get; set; } = string.Empty;

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("dose")]
    public string Dose { get; set; } = string.Empty;

    [Column("time")]
    public string Time { get; set; } = string.Empty;

    [Column("taken")]
    public bool Taken { get; set; }

    [Column("taken_at")]
    public DateTime? TakenAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
