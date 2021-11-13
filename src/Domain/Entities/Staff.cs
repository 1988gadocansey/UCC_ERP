using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCC_ERP.Domain.Entities;

public class Staff: AuditableEntity, IHasDomainEvent
{
   
    public int Id { get; set; }
    public Guid Uuid { get; }
    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [Column("FirstName")]
    [StringLength(50)]
    public string FirstMidName { get; set; }

    [DataType(DataType.Date)]
    public DateTime HireDate { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string FullName => LastName + ", " + FirstMidName;


    public List<DomainEvent> DomainEvents { get; set; }
}