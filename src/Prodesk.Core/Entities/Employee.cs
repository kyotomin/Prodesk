namespace Prodesk.Core.Entities;

// Сотрудники
public sealed class Employee
{
    public Guid Id { get; init; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;

    public int ExperienceYears { get; set; }

    public DateTime CreatedAt { get; init; }
}