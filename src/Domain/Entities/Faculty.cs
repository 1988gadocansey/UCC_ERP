using System.ComponentModel.DataAnnotations;

namespace UCC_ERP.Domain.Entities;

public class Faculty: AuditableEntity, IHasDomainEvent
{
   
    public int Id { get; set; }
   
    public Guid Uuid { get; }
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }
    public int CollegeId { get; set; }
    public College College { get; set; }
    public ICollection<Department> Departments { get; set; }
    public List<DomainEvent> DomainEvents { get; set; }
}