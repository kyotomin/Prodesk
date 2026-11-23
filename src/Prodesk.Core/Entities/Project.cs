namespace Prodesk.Core.Entities;

public sealed class Project
{
    public Guid Id { get; init; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ProjectStatus Status { get; set; }

    public DateTime CreatedAt { get; init; }

    public DateTime UpdatedAt { get; set; }
}

public sealed class Employee
{
    public Guid Id { get; init; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public int ExperienceYears { get; set; }
    public DateTime CreatedAt { get; init; }
}
