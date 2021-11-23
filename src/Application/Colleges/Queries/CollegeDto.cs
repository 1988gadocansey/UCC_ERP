using UCC_ERP.Application.Common.Mappings;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Application.Colleges.Queries;

public class CollegeDto:IMapFrom<College>
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Guid Uuid { get; set; }

   
}