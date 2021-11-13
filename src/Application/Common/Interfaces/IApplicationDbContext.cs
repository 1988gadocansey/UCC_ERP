using UCC_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace UCC_ERP.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }
    DbSet<Student> Students { get; }
    DbSet<Programme> Programmes { get; }
    DbSet<Department> Departments { get; }
    DbSet<Faculty> Faculties { get; }
    DbSet<College> Colleges { get; }
    DbSet<Course> Courses { get; }
    DbSet<Staff> Staff { get; }
    DbSet<CourseAssignment> CourseAssignment { get; }
    DbSet<Enrollment> Enrollment { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
