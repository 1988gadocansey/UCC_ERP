using System.ComponentModel.DataAnnotations;

namespace UCC_ERP.Domain.Entities;

public class Programme: AuditableEntity, IHasDomainEvent
{
  
    public int Id { set; get; }
    public Guid Uuid { get; }
    public string Name { set; get; }
    public string Code { set; get; }
    public string LevelAdmitted { set; get; }
    public bool Running { set; get; }
    public bool ShowOnPortal { set; get; }
    public string Type { set; get; }
    public int Duration { set; get; }
    public int DepartmentId { set; get; }
    public Department Department { get; set; }
    public virtual ICollection<Student> Students { get; set; }


    public List<DomainEvent> DomainEvents { get; set; }
}