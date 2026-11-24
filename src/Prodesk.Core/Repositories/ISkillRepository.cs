using Prodesk.Core.Entities;

namespace Prodesk.Core.Repositories;

public interface ISkillRepository
{
    Task<IReadOnlyList<Skill>> GetAllAsync();
    Task<Skill?> GetByIdAsync(Guid id);
    Task AddAsync(Skill skill);
    Task UpdateAsync(Skill skill);
    Task DeleteAsync(Guid id);
}
