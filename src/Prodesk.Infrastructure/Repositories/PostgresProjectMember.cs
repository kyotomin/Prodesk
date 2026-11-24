
using Prodesk.Core.Entities;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresProjectMemberRepository : IProjectMemberRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresProjectMemberRepository(
        PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<ProjectMember>> GetByProjectIdAsync(
        Guid projectId)
    {
        var members = new List<ProjectMember>();

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT project_id, employee_id, role, assigned_at
            FROM project_members
            WHERE project_id = @projectId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("projectId", projectId);

        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            members.Add(new ProjectMember
            {
                ProjectId = reader.GetGuid(0),
                EmployeeId = reader.GetGuid(1),
                Role = reader.IsDBNull(2) ? null : reader.GetString(2),
                AssignedAt = reader.GetDateTime(3)
            });
        }

        return members;
    }

    public async Task AddAsync(ProjectMember member)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO project_members
                (project_id, employee_id, role)
            VALUES
                (@projectId, @employeeId, @role);
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("projectId", member.ProjectId);
        command.Parameters.AddWithValue("employeeId", member.EmployeeId);
        command.Parameters.AddWithValue(
            "role",
            (object?)member.Role ?? DBNull.Value
        );

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid projectId, Guid employeeId)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            DELETE FROM project_members
            WHERE project_id = @projectId
              AND employee_id = @employeeId;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("projectId", projectId);
        command.Parameters.AddWithValue("employeeId", employeeId);

        await command.ExecuteNonQueryAsync();
    }
}
