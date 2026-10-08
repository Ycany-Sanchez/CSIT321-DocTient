namespace DocTient.Models;

public class HealthRecord
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string PatientId { get; set; } = string.Empty;
    public string? DoctorId { get; set; }
    public HealthRecordType RecordType { get; set; } = HealthRecordType.ConsultationNote;
    public string Type { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Status { get; set; } = "Normal";
    public DateTime RecordedDate { get; set; } = DateTime.UtcNow;
    public string? Summary { get; set; }
    public string? DoctorNotes { get; set; }
    public string? AttachmentUrl { get; set; }

    public string BadgeClass => Status switch
    {
        "Normal" => "bg-emerald-500/20 text-emerald-300 border border-emerald-500/30",
        "Monitor" => "bg-amber-500/20 text-amber-300 border border-amber-500/30",
        "Critical" => "bg-rose-500/20 text-rose-300 border border-rose-500/30",
        _ => "bg-white/10 text-white/70 border border-white/20"
    };
}
