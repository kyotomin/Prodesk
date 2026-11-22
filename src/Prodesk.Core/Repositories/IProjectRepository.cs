using Prodesk.Core.Entities;

namespace Prodesk.Core.Repositories;

public interface IProjectRepository
{
    Task<IReadOnlyList<Project>> GetAllAsync();

    Task<Project?> GetByIdAsync(Guid id);

    Task AddAsync(Project project);

    Task UpdateAsync(Project project);

    Task DeleteAsync(Guid id);
}