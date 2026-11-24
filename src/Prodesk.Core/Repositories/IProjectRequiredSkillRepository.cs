using Prodesk.Core.Entities;

namespace Prodesk.Core.Repositories;

public interface IProjectRequiredSkillRepository
{
	Task<IReadOnlyList<ProjectRequiredSkill>> GetByProjectIdAsync(Guid projectId);

	Task AddAsync(ProjectRequiredSkill requirement);

	Task UpdateMinLevelAsync(Guid projectId, Guid skillId, int minLevel);

	Task DeleteAsync(Guid projectId, Guid skillId);
}