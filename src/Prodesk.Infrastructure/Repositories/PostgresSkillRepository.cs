using Prodesk.Core.Entities;
using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

// Реализация репозитория навыков для PostgreSQL.
public class PostgresSkillRepository : ISkillRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresSkillRepository(PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<Skill>> GetAllAsync()
    {
        var skills = new List<Skill>();

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT id, name, created_at
            FROM skills;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            var skill = new Skill
            {
                Id = reader.GetGuid(0),
                Name = reader.GetString(1),
                CreatedAt = reader.GetDateTime(2)
            };

            skills.Add(skill);
        }

        return skills;
    }

    public async Task<Skill?> GetByIdAsync(Guid id)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT id, name, created_at
            FROM skills
            WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return null;

        return new Skill
        {
            Id = reader.GetGuid(0),
            Name = reader.GetString(1),
            CreatedAt = reader.GetDateTime(2)
        };
    }

    public async Task AddAsync(Skill skill)
    {
        ValidateSkill(skill);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO skills (name)
            VALUES (@name);
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("name", skill.Name);

        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Skill skill)
    {
        ValidateSkill(skill);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            UPDATE skills
            SET name = @name
            WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", skill.Id);
        command.Parameters.AddWithValue("name", skill.Name);

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            DELETE FROM skills
            WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await command.ExecuteNonQueryAsync();
    }

    private static void ValidateSkill(Skill skill)
    {
        if (string.IsNullOrWhiteSpace(skill.Name))
            throw new ArgumentException("Название навыка не может быть пустым");
    }
}