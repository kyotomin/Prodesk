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