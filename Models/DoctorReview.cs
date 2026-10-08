namespace DocTient.Models;

public class DoctorReview
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Name { get; set; } = string.Empty;
    public string Initials { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
    public string Comment { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public string Visit { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public int Helpful { get; set; }
    public bool Mine { get; set; }
}
