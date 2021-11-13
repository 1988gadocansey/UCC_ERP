using System.ComponentModel.DataAnnotations;

namespace UCC_ERP.Domain.Common;

public abstract class AuditableEntity
{
  
    [DataType(DataType.DateTime)]
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
