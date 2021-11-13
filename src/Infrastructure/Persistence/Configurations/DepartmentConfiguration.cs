using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class DepartmentConfiguration:IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Ignore(e => e.DomainEvents);

       
    }

     
}