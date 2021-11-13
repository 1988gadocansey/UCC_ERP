using System.ComponentModel.DataAnnotations;

namespace UCC_ERP.Domain.Entities;

public class CourseAssignment : AuditableEntity, IHasDomainEvent
{
    
  
    public int Id { get; set; }
    public Guid Uuid { get; }
    public int InstructorId { get; set; }
    public int CourseId { get; set; }
    public Staff Instructor { get; set; }
    public Course Course { get; set; }
    public List<DomainEvent> DomainEvents { get; set; }
}