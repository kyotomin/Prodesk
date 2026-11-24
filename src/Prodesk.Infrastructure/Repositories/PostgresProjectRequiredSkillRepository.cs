using Prodesk.Core.Entities;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresProjectRequiredSkillRepository : IProjectRequiredSkillRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresProjectRequiredSkillRepository(
        PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<ProjectRequiredSkill>> GetByProjectIdAsync(
        Guid projectId)
    {
        var requirements = new List<ProjectRequiredSkill>();

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT project_id, skill_id, min_level
            FROM project_required_skills
            WHERE project_id = @projectId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("projectId", projectId);

        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            requirements.Add(new ProjectRequiredSkill
            {
                ProjectId = reader.GetGuid(0),
                SkillId = reader.GetGuid(1),
                MinLevel = reader.GetInt16(2)
            });
        }

        return requirements;
    }

    public async Task AddAsync(ProjectRequiredSkill requirement)
    {
        ValidateLevel(requirement.MinLevel);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO project_required_skills
                (project_id, skill_id, min_level)
            VALUES
                (@projectId, @skillId, @minLevel);
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("projectId", requirement.ProjectId);
        command.Parameters.AddWithValue("skillId", requirement.SkillId);
        command.Parameters.AddWithValue("minLevel", (short)requirement.MinLevel);

        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateMinLevelAsync(
        Guid projectId,
        Guid skillId,
        int minLevel)
    {
        ValidateLevel(minLevel);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            UPDATE project_required_skills
            SET min_level = @minLevel
            WHERE project_id = @projectId
              AND skill_id = @skillId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("projectId", projectId);
        command.Parameters.AddWithValue("skillId", skillId);
        command.Parameters.AddWithValue("minLevel", (short)minLevel);

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid projectId, Guid skillId)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            DELETE FROM project_required_skills
            WHERE project_id = @projectId
              AND skill_id = @skillId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("projectId", projectId);
        command.Parameters.AddWithValue("skillId", skillId);

        await command.ExecuteNonQueryAsync();
    }

    private static void ValidateLevel(int level)
    {
        if (level < 1 || level > 5)
            throw new ArgumentOutOfRangeException(
                nameof(level),
                "Минимальный уровень навыка должен быть от 1 до 5"
            );
    }
}