using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCC_ERP.Domain.Entities;

public class Course: AuditableEntity, IHasDomainEvent
{ 
 
    public int Id { get; set; }

    public Guid Uuid { get; }
    [StringLength(50, MinimumLength = 3)]
    public string Title { get; set; }

    [Range(0, 5)]
    public int Credits { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
    public ICollection<CourseAssignment> CourseAssignments { get; set; }

    public List<DomainEvent> DomainEvents { get; set; }
}