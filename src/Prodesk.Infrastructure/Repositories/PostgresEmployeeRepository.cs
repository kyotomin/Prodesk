using Prodesk.Core.Repositories;
using Prodesk.Core.Entities;
using Prodesk.Infrastructure;
using System;
using Npgsql;

namespace Prodesk.Infrastructure.Repositories;

public class PostgresEmployeeRepository : IEmployeeRepository
{
    private readonly PostgresConnectionFactory _connectionFactory;

    public Task<IReadOnlyList<Employee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }


    public Task<Employee?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public  Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

}