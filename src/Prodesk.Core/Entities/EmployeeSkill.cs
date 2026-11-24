namespace Prodesk.Core.Entities;

public sealed class EmployeeSkill
{
    public Guid EmployeeId { get; init; }
    public Guid SkillId { get; init; }
    public int Level { get; set; }
}