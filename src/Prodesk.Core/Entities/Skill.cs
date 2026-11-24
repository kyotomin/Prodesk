namespace Prodesk.Core.Entities;

// Навыки
public sealed class Skill
{
    public Guid Id { get; init; }

    public string Name { get; set; }

    public DateTime CreatedAt { get; init; }
}