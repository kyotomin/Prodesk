using Prodesk.Core.Entities;

namespace Prodesk.Core.Repositories;

public interface IProjectMemberRepository
{
    Task<IReadOnlyList<ProjectMember>> GetByProjectIdAsync(Guid projectId);

    Task AddAsync(ProjectMember member);

    Task DeleteAsync(Guid projectId, Guid employeeId);
}