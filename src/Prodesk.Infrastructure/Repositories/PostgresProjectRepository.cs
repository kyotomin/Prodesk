using Prodesk.Core.Repositories;
using Prodesk.Infrastructure;
using Prodesk.Core.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresProjectRepository : IProjectRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresProjectRepository(PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task AddAsync(Project project)
    {
        await using var connection = 
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO projects (title, description, project_status)
            VALUES (@title, @description, @project_status);
            """;

        await using var command  = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("title", project.Title);
        command.Parameters.AddWithValue(
            "description",
            (object?)project.Description ?? DBNull.Value
            );
         command.Parameters.AddWithValue("project_status", project.Status switch
         {
             ProjectStatus.Planned => "planned",
             ProjectStatus.InProgress => "in_progress",
             ProjectStatus.Finished => "finished",
             _ => throw new ArgumentOutOfRangeException(nameof(project.Status))
         }    
        );
        
        await command.ExecuteNonQueryAsync();

    }

    public async Task UpdateAsync(Project project)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            UPDATE projects
            SET title = @title,
                description = @description,
                project_status = @status,
                updated_at = now()
            WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", project.Id);
        command.Parameters.AddWithValue("title", project.Title);
        command.Parameters.AddWithValue(
            "description",
            (object?)project.Description ?? DBNull.Value
        );
        command.Parameters.AddWithValue("status", project.Status switch
        {
            ProjectStatus.Planned => "planned",
            ProjectStatus.InProgress => "in_progress",
            ProjectStatus.Finished => "finished",
            _ => throw new ArgumentOutOfRangeException(nameof(project.Status))
        });

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await using var connection = 
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            DELETE FROM projects
            WHERE id = @id
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await command.ExecuteNonQueryAsync();
    }

    public async Task<IReadOnlyList<Project>> GetAllAsync()
    {
        var projects = new List<Project>();

        await using var connection = 
            await _connectionFactory.CreateConnectionAsync();

        var sql = """ 
               SELECT id, title, description, project_status::text,
               created_at, updated_at
               FROM projects;
            """;

        await using var command = new NpgsqlCommand(sql, connection);

        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            var project = new Project
            {
                Id = reader.GetGuid(0),
                Title = reader.GetString(1),
                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                Status = ResolveProjectStatus(reader.GetString(3)),
                CreatedAt = reader.GetDateTime(4),
                UpdatedAt = reader.GetDateTime(5)
            };

            projects.Add(project);
        }
        return projects;
    }

    public async Task<Project?> GetByIdAsync(Guid id)
    {
        await using var connection = 
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
               SELECT id, title, description, project_status::text,
               created_at, updated_at
               FROM projects
               WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await using var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return null;
        };


        var project = new Project
        {
            Id = reader.GetGuid(0),
            Title = reader.GetString(1),
            Description = reader.IsDBNull(2) ? null : reader.GetString(2),
            Status = ResolveProjectStatus(reader.GetString(3)),
            CreatedAt = reader.GetDateTime(4),
            UpdatedAt = reader.GetDateTime(5)
        };

        return project;
    }

    private static ProjectStatus ResolveProjectStatus(string status)
    {
        return status switch {
            "planned" => ProjectStatus.Planned,
            "in_progress" => ProjectStatus.InProgress,
            "finished" => ProjectStatus.Finished,
            _ => throw new InvalidOperationException(
            $"Unknown project status: {status}"
        )
        };

    }
}