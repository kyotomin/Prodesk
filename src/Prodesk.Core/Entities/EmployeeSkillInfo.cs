namespace Prodesk.Core.Entities;

public sealed class EmployeeSkillInfo
{
    public Guid SkillId { get; init; }

    public string SkillName { get; init; } = string.Empty;

    public int Level { get; init; }
}
