using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCC_ERP.Domain.Entities;
public enum Grade
{
    A, B, C, D, F
}

public class Enrollment:  AuditableEntity, IHasDomainEvent
{
    
    public int Id { get; set; }
    public Guid Uuid { get; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public int CalenderId { get; set; }
    [DisplayFormat(NullDisplayText = "No grade")]
    public Grade? Grade { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
    public Calender Calender { get; set; }

    public List<DomainEvent> DomainEvents { get; set; }
}