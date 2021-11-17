using System.ComponentModel.DataAnnotations;

namespace UCC_ERP.Domain.Entities;

public class College: AuditableEntity, IHasDomainEvent
{
   
    public int Id { get; set; }
    
    public Guid Uuid { get; set; }
    [StringLength(50, MinimumLength = 3)]
    
    public string Name { get; set; }
    public ICollection<Faculty> Faculties { get; set; }

    public List<DomainEvent> DomainEvents { get; set; }
}