namespace UCC_ERP.Domain.Entities;

public class Calender:  AuditableEntity, IHasDomainEvent
{
 
    public int Id { get; set; }
    public Guid Uuid { get; }
    public int ListId { get; set; }

    public string? Title { get; set; }

    public string? Note { get; set; }
    public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();

}