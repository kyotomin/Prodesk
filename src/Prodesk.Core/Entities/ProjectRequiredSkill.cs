namespace Prodesk.Core.Entities;

public sealed class ProjectRequiredSkill
{
	public Guid ProjectId { get; init; }

	public Guid SkillId { get; init; }

	public int MinLevel { get; set; } = 1;
}