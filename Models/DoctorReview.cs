using System.Text.Json.Serialization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace DocTient.Models;

[Table("doctor_reviews")]
public class DoctorReview : BaseModel
{
    [PrimaryKey("id", false)]
    public long Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = "";

    [Column("initials")]
    public string Initials { get; set; } = "";

    [Column("rating")]
    public int Rating { get; set; } = 5;

    [Column("comment")]
    public string Comment { get; set; } = "";

    [Column("tags")]
    public string Tags { get; set; } = "";

    [Column("visit")]
    public string Visit { get; set; } = "";

    [Column("helpful")]
    public int Helpful { get; set; }

    [Column("is_mine")]
    public bool Mine { get; set; } = true;

    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }

    // Helper for UI tag pills (ignored by Postgrest serializers)
    [JsonIgnore]
    public List<string> TagList => string.IsNullOrWhiteSpace(Tags)
        ? new List<string>()
        : Tags.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
}
