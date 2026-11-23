using Prodesk.Core.Repositories;
using Prodesk.Core.Entities;
using Prodesk.Infrastructure;
using System;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresEmployeeRepository : IEmployeeRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public PostgresEmployeeRepository(PostgresConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IReadOnlyList<Employee>> GetAllAsync()
    {
        await using var connection = 
            await _connectionFactory.CreateConnectionAsync();

        var employees = new List<Employee>();

        var sql = """
           SELECT id, full_name, email, position, experience_years, created_at
           FROM employees;
           """;

        await using var command = new NpgsqlCommand(sql, connection);

        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync()) {
            var employee = new Employee
            {
                Id = reader.GetGuid(0),
                FullName = reader.GetString(1),
                Email = reader.GetString(2),
                Position = reader.GetString(3),
                ExperienceYears = reader.GetInt16(4),
                CreatedAt = reader.GetDateTime(5),
            };

            employees.Add(employee);
        }

        return employees;
    }

    public async Task<Employee?> GetByIdAsync(Guid id)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            SELECT id, full_name, email, position, experience_years, created_at
            FROM employees
            WHERE id = @id;
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await using var reader = await command.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
        {
            return null;
        };

        var employee = new Employee
        {
            Id = reader.GetGuid(0),
            FullName = reader.GetString(1),
            Email = reader.GetString(2),
            Position = reader.GetString(3),
            ExperienceYears = reader.GetInt16(4),
            CreatedAt = reader.GetDateTime(5),
        };

        return employee;
    }

    public async Task AddAsync(Employee employee) // Может кинуть ex
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
            INSERT INTO employees (full_name, email, position, experience_years)
            VALUES (@full_name, @email, @position, @experience_years)
            """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("full_name", employee.FullName);
        command.Parameters.AddWithValue("email", employee.Email);
        command.Parameters.AddWithValue("position", employee.Position);
        command.Parameters.AddWithValue("experience_years", employee.ExperienceYears);

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
        DELETE FROM employees
        WHERE id = @id;
        """;

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("id", id);

        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Employee employee)
    {
        ValidateEmployee(employee);

        await using var connection =
            await _connectionFactory.CreateConnectionAsync();

        var sql = """
        UPDATE employees
        SET full_name = @full_name,
            email = @email,
            position = @position,
            experience_years = @experience_years
        WHERE id = @id;
        """;

        await using var command = new NpgsqlCommand(sql, connection);

        command.Parameters.AddWithValue("id", employee.Id);
        command.Parameters.AddWithValue("full_name", employee.FullName);
        command.Parameters.AddWithValue("email", employee.Email);
        command.Parameters.AddWithValue("position", employee.Position);
        command.Parameters.AddWithValue("experience_years", employee.ExperienceYears);

        await command.ExecuteNonQueryAsync();
    }

    private static void ValidateEmployee(Employee employee)
    {
        if (string.IsNullOrWhiteSpace(employee.FullName))
        {
            throw new ArgumentException("Имя не может быть пустым полем");
        }

        if (string.IsNullOrWhiteSpace(employee.Email))
        {
            throw new ArgumentException("Почта не может быть пустым полем");
        }

        if (string.IsNullOrWhiteSpace(employee.Position))
        {
            throw new ArgumentException("Позиция не может быть пустым полем");
        }

        if (employee.ExperienceYears < 0)
        {
            throw new ArgumentException("Опыт работы не может быть отрицательным");
        }
    }

}