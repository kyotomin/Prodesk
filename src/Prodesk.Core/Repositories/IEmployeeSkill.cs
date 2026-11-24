using Prodesk.Core.Entities;

namespace Prodesk.Core.Repositories;

public interface IEmployeeSkillRepository
{
    Task<IReadOnlyList<EmployeeSkill>> GetByEmployeeIdAsync(Guid employeeId);

    Task AddAsync(EmployeeSkill employeeSkill);

    Task UpdateLevelAsync(Guid employeeId, Guid skillId, int level);

    Task DeleteAsync(Guid employeeId, Guid skillId);

    Task<IReadOnlyList<EmployeeSkillInfo>> GetDetailsByEmployeeIdAsync(Guid employeeId);
}