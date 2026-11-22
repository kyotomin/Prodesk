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

    public Task AddAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
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
            ProjectStatus status;

            switch (reader.GetString(3))
            {
                case "planned":
                    status = ProjectStatus.Planned;
                    break;

                case "in_progress":
                    status = ProjectStatus.InProgress;
                    break;

                case "finished":
                    status = ProjectStatus.Finished;
                    break;

                default:
                    throw new InvalidOperationException("Unknown project status");
            }

            var project = new Project
            {
                Id = reader.GetGuid(0),
                Title = reader.GetString(1),
                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                Status = status,
                CreatedAt = reader.GetDateTime(4),
                UpdatedAt = reader.GetDateTime(5)
            };

            projects.Add(project);

        }
        return projects;
    }

    public Task<Project?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}