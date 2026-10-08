namespace DocTient.Models;

public class VitalSign
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string PatientId { get; set; } = string.Empty;
    public VitalType Type { get; set; }
    public string Value { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public double? NumericValue { get; set; }
    public int? Systolic { get; set; }
    public int? Diastolic { get; set; }
    public VitalStatus Status { get; set; } = VitalStatus.Normal;
    public DateTime RecordedAt { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }

    public string BadgeClass => Status switch
    {
        VitalStatus.Normal => "bg-emerald-500/20 text-emerald-300 border border-emerald-500/30",
        VitalStatus.Monitor => "bg-amber-500/20 text-amber-300 border border-amber-500/30",
        VitalStatus.Critical => "bg-rose-500/20 text-rose-300 border border-rose-500/30",
        _ => "bg-white/10 text-white/70 border border-white/20"
    };

    public string Icon => Type switch
    {
        VitalType.BloodPressure => "❤️",
        VitalType.HeartRate => "💓",
        VitalType.Temperature => "🌡️",
        VitalType.BloodOxygen => "🫁",
        VitalType.Weight => "⚖️",
        VitalType.BloodGlucose => "🩸",
        _ => "📊"
    };
}
