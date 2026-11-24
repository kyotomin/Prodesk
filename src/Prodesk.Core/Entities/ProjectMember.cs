namespace Prodesk.Core.Entities;

public sealed class ProjectMember
{
    public Guid ProjectId { get; init; }
    public Guid EmployeeId { get; init; }
    public string? Role { get; set; }
    public DateTime AssignedAt { get; init; }
}