
using Prodesk.Core.Entities;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresEmployeeSkillRepository : IEmployeeSkillRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresEmployeeSkillRepository(
        PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<EmployeeSkill>> GetByEmployeeIdAsync(
        Guid employeeId)
    {
        var employeeSkills = new List<EmployeeSkill>();

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT employee_id, skill_id, level
            FROM employee_skills
            WHERE employee_id = @employeeId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("employeeId", employeeId);

        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            employeeSkills.Add(new EmployeeSkill
            {
                EmployeeId = reader.GetGuid(0),
                SkillId = reader.GetGuid(1),
                Level = reader.GetInt32(2)
            });
        }

        return employeeSkills;
    }

    public async Task AddAsync(EmployeeSkill employeeSkill)
    {
        ValidateLevel(employeeSkill.Level);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO employee_skills
                (employee_id, skill_id, level)
            VALUES
                (@employeeId, @skillId, @level);
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("employeeId", employeeSkill.EmployeeId);
        command.Parameters.AddWithValue("skillId", employeeSkill.SkillId);
        command.Parameters.AddWithValue("level", employeeSkill.Level);

        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateLevelAsync(
        Guid employeeId,
        Guid skillId,
        int level)
    {
        ValidateLevel(level);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            UPDATE employee_skills
            SET level = @level
            WHERE employee_id = @employeeId
              AND skill_id = @skillId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("employeeId", employeeId);
        command.Parameters.AddWithValue("skillId", skillId);
        command.Parameters.AddWithValue("level", level);

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid employeeId, Guid skillId)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            DELETE FROM employee_skills
            WHERE employee_id = @employeeId
              AND skill_id = @skillId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("employeeId", employeeId);
        command.Parameters.AddWithValue("skillId", skillId);

        await command.ExecuteNonQueryAsync();
    }

    private static void ValidateLevel(int level)
    {
        if (level < 1 || level > 5)
        {
            throw new ArgumentOutOfRangeException(
                nameof(level),
                "Уровень навыка должен быть от 1 до 5"
            );
        }
    }
}
