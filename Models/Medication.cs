namespace DocTient.Models;

public class Medication
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Name { get; set; } = string.Empty;
    public string Dose { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public bool Taken { get; set; }
}
