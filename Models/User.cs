namespace DocTient.Models;

public abstract class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginAt { get; set; }

    public string FullName => $"{FirstName} {LastName}".Trim();

    public string Initials
    {
        get
        {
            var first = string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName[0].ToString().ToUpper();
            var last = string.IsNullOrWhiteSpace(LastName) ? "" : LastName[0].ToString().ToUpper();
            var combined = $"{first}{last}";
            return string.IsNullOrEmpty(combined) ? "U" : combined;
        }
    }
}
