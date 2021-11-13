using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCC_ERP.Domain.Entities;

public class Department: AuditableEntity, IHasDomainEvent
{
    
    public int Id { get; set; }
    public Guid Uuid { get; }
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "money")]
    public decimal Budget { get; set; }
    public int? FacultyId { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; }

    public int? StaffId { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
    
    public Staff Staff { get; set; }
    public Faculty Faculty { get; set; }
    public ICollection<Programme> Programmes { get; set; }

    public List<DomainEvent> DomainEvents { get; set; }
}