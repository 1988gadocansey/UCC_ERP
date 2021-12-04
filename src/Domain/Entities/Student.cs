using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UCC_ERP.Domain.Entities;

public class Student : AuditableEntity, IHasDomainEvent
{
   
    public int Id { get; set; }
    public Guid Uuid { get; set; }
    [Required] public string Title { get; set; }

    [Required]
    [Column("LastName")]
    [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
    public string LastName { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
    [Column("FirstName")]
    public string FirstName { get; set; }
    [Column("MiddleName")] public string? MiddleName { get; set; }
    public string PreviousName { set; get; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string FullName => LastName + ", " + FirstName + ", " + MiddleName;
    [Required] public string Phone { get; set; }
    public string? AltPhone { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string Address { get; set; }
    public string PostGPRS { get; set; }
    [Required] public string EmergencyContact { get; set; }
    [Required] public string Hometown { get; set; }
    private bool Register;
    private bool Alumni;
    public string? NationalIDType { get; set; }
    public string? NationalIDNo { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; } = new List<Enrollment>();
    public Programme Programme;
    public bool OnCompleted
    {
        get => Alumni;
        set
        {
            if (value == true && Alumni == false)
            {
                DomainEvents.Add(new StudentCompletedEvent(this));
            }

            Alumni = value;
        }
    }
    public bool OnRegister
    {
        get => Register;
        set
        {
            if (value == true && Register == false)
            {
                DomainEvents.Add(new StudentRegisteredEvent(this));
            }

            Register = value;
        }
    }
    public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
}